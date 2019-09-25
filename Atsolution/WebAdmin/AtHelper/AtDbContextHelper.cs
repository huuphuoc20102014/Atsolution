using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AtHelper
{
    public class AtDbContextHelper
    {
        public static string PrintTest()
        {
            return "Print test";
        }

        public static readonly List<AtMapSqlToNetType> MAP_SQL_TO_NET_TYPE;

        static AtDbContextHelper()
        {
            var fileMapResource = typeof(AtDbContextHelper).Assembly.GetManifestResourceStream("AtHelper.MapSqlToNetType.csv");

            using (var reader = new StreamReader(fileMapResource))
            using (var csv = new CsvReader(reader))
            {
                MAP_SQL_TO_NET_TYPE = csv.GetRecords<AtMapSqlToNetType>().ToList();
            }
        }

        public static List<AtMappingColumn> ReadMetaDbContext(string fullDbContextName, string entityName, IEnumerable<PropertyMetadata> prosMeta = null, IEnumerable<NavigationMetadata>  navsMeta = null)
        {
            var wrkProsMeta = new List<PropertyMetadata>();
            if (prosMeta != null)
            {
                wrkProsMeta = prosMeta.ToList();
            }
            var wrkNavsMeta = new List<NavigationMetadata>();
            if (navsMeta != null)
            {
                wrkNavsMeta = navsMeta.ToList();
            }

            var location = System.IO.Path.GetDirectoryName(typeof(AtHelper.AtDbContextHelper).Assembly.Location);
            string dllDbContextFileName;
            if (string.IsNullOrWhiteSpace(fullDbContextName))
            {
                dllDbContextFileName = System.IO.Path.Combine(location, entityName.Substring(0, entityName.IndexOf(".") + 1)) + "dll";
            }
            else
            {
                dllDbContextFileName = System.IO.Path.Combine(location, fullDbContextName.Substring(0, fullDbContextName.IndexOf(".") + 1)) + "dll";
            }
            var dbContextAsembly = System.Reflection.Assembly.LoadFile(dllDbContextFileName);

            if (string.IsNullOrWhiteSpace(fullDbContextName))
            {
                var entityNameInstance = dbContextAsembly.CreateInstance(entityName);
                fullDbContextName = (string)entityNameInstance.GetType()
                    .GetField(
                        "FULL_DB_CONTEXT_NAME",
                        BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy
                    ).GetValue(entityNameInstance);

                entityName = entityName.Substring(entityName.LastIndexOf(".") + 1);
            }
           

            var context = (DbContext)dbContextAsembly.CreateInstance(fullDbContextName);

            var itemEntityType = context.Model.GetEntityTypes().FirstOrDefault(h => h.ClrType.Name == entityName);
            var listProperty = itemEntityType.GetProperties().ToList();
            var listMapping = new List<AtMappingColumn>(listProperty.Count);

            foreach (var itemProperty in listProperty)
            {
                var relational = itemProperty.Relational();
                var columnType = relational.ColumnType.ToLowerInvariant();

                var mapping = new AtMappingColumn();
                mapping.SqlName = relational.ColumnName;
                mapping.NetName = itemProperty.Name;
                mapping.AllowNull = itemProperty.IsNullable;

                // Tim map item tu sql type name
                var columTypeRemoveLength = relational.ColumnType;
                // Tim index cua dau bat dau maxlength cua kieu string hoac so ki tu hien thi cua kieu so
                var indexOpenBrace = relational.ColumnType.IndexOf('(');
                var maxLength = -1;
                if (indexOpenBrace > 0)
                {
                    columTypeRemoveLength = columTypeRemoveLength.Substring(0, indexOpenBrace);
                    var indexCloseBrace = relational.ColumnType.IndexOf(')');
                    var strMaxLength = relational.ColumnType.Substring(indexOpenBrace + 1, indexCloseBrace - indexOpenBrace - 1);
                    if (strMaxLength.ToLower() == "max")
                    {
                        maxLength = 4000;
                    }
                    else
                    {
                        if (int.TryParse(strMaxLength, out int outMaxLength))
                        {
                            maxLength = outMaxLength;
                        }
                    }
                }
                var mapSqlToNet = MAP_SQL_TO_NET_TYPE.FirstOrDefault(h => h.SqlType == columTypeRemoveLength);
                mapping.MapSqlToNetType = mapSqlToNet;
                mapping.MaxLength = maxLength;

                mapping.DisplayType = mapping.MapSqlToNetType.NetType;
                if (mapping.AllowNull)
                {
                    if (mapping.MapSqlToNetType.IsValueType)
                    {
                        mapping.DisplayType = mapping.MapSqlToNetType.NetType + "?";
                    }
                }

                if (mapping.SqlName.EndsWith("_ReadOnly"))
                {
                    mapping.IsReadOnly = true;
                }

                listMapping.Add(mapping);

                var itemForeign = wrkProsMeta.FirstOrDefault(h => h.IsForeignKey && h.PropertyName == mapping.NetName);
                if (itemForeign != null)
                {
                    mapping.IsForeignKey = true;
                    var itemNavigation = wrkNavsMeta.FirstOrDefault(h => h.ForeignKeyPropertyNames != null && h.ForeignKeyPropertyNames.Contains(mapping.NetName));
                    if (itemNavigation != null)
                    {
                        mapping.NetNavigationPropertyName = itemNavigation.AssociationPropertyName;
                    }
                }

                var itemPrimary = wrkProsMeta.FirstOrDefault(h => h.IsPrimaryKey && h.PropertyName == mapping.NetName);
            }

            


            return listMapping;
        }

        private void A(IEntityType itemEntityType, IEnumerable<PropertyMetadata> prosMeta = null, IEnumerable<NavigationMetadata> navsMeta = null)
        {
            var wrkProsMeta = new List<PropertyMetadata>();
            if (prosMeta != null)
            {
                wrkProsMeta = prosMeta.ToList();
            }
            var wrkNavsMeta = new List<NavigationMetadata>();
            if (navsMeta != null)
            {
                wrkNavsMeta = navsMeta.ToList();
            }

            var listProperty = itemEntityType.GetProperties().ToList();
            var listMapping = new List<AtMappingColumn>(listProperty.Count);

            foreach (var itemProperty in listProperty)
            {
                var relational = itemProperty.Relational();
                var columnType = relational.ColumnType.ToLowerInvariant();

                var mapping = new AtMappingColumn();
                mapping.SqlName = relational.ColumnName;
                mapping.NetName = itemProperty.Name;
                mapping.AllowNull = itemProperty.IsNullable;

                // Tim map item tu sql type name
                var columTypeRemoveLength = relational.ColumnType;
                // Tim index cua dau bat dau maxlength cua kieu string hoac so ki tu hien thi cua kieu so
                var indexOpenBrace = relational.ColumnType.IndexOf('(');
                var maxLength = -1;
                if (indexOpenBrace > 0)
                {
                    columTypeRemoveLength = columTypeRemoveLength.Substring(0, indexOpenBrace);
                    var indexCloseBrace = relational.ColumnType.IndexOf(')');
                    var strMaxLength = relational.ColumnType.Substring(indexOpenBrace + 1, indexCloseBrace - indexOpenBrace - 1);
                    if (strMaxLength.ToLower() == "max")
                    {
                        maxLength = 4000;
                    }
                    else
                    {
                        if (int.TryParse(strMaxLength, out int outMaxLength))
                        {
                            maxLength = outMaxLength;
                        }
                    }
                }
                var mapSqlToNet = MAP_SQL_TO_NET_TYPE.FirstOrDefault(h => h.SqlType == columTypeRemoveLength);
                mapping.MapSqlToNetType = mapSqlToNet;
                mapping.MaxLength = maxLength;

                mapping.DisplayType = mapping.MapSqlToNetType.NetType;
                if (mapping.AllowNull)
                {
                    if (mapping.MapSqlToNetType.IsValueType)
                    {
                        mapping.DisplayType = mapping.MapSqlToNetType.NetType + "?";
                    }
                }

                if (mapping.SqlName.EndsWith("_ReadOnly"))
                {
                    mapping.IsReadOnly = true;
                }

                listMapping.Add(mapping);

                var itemForeign = wrkProsMeta.FirstOrDefault(h => h.IsForeignKey && h.PropertyName == mapping.NetName);
                if (itemForeign != null)
                {
                    mapping.IsForeignKey = true;
                    var itemNavigation = wrkNavsMeta.FirstOrDefault(h => h.ForeignKeyPropertyNames != null && h.ForeignKeyPropertyNames.Contains(mapping.NetName));
                    if (itemNavigation != null)
                    {
                        mapping.NetNavigationPropertyName = itemNavigation.AssociationPropertyName;
                    }
                }

                var itemPrimary = wrkProsMeta.FirstOrDefault(h => h.IsPrimaryKey && h.PropertyName == mapping.NetName);
            }

        }


        public static string GetSlugProperty(List<string> listPropertyName)
        {
            foreach (var property in listPropertyName)
            {
                if (property.StartsWith("Slug_"))
                {
                    return property;
                }
            }

            return "";
        }

        public static string GetProperyNameOfSlug(string slugProperty)
        {
            var indexUndercore = slugProperty.IndexOf("_");
            return slugProperty.Substring(indexUndercore + 1);
        }

        public static string GetShortName(string fullName)
        {
            var indexDot = fullName.LastIndexOf(".");
            if (indexDot >= 0)
            {
                return fullName.Substring(indexDot + 1);
            }

            return fullName;
        }
    }

    public class AtMappingColumn
    {
        //public string Name { get; set; }

        //public string DataType { get; set; }








        public string SqlName { get; set; } = "";
        public string NetName { get; set; } = "";

        public bool AllowNull { get; set; }
        public int MaxLength { get; set; }

        public AtMapSqlToNetType MapSqlToNetType { get; set; } = new AtMapSqlToNetType();

        public string DisplayType { get; set; } = "";
        public bool IsReadOnly { get; set; }

        public bool IsPrimaryKey { get; set; }
        public bool IsForeignKey { get; set; }

        public string NetNavigationPropertyName { get; set; } = "";
    }

    public class AtMapSqlToNetType
    {
        public string SqlType { get; set; } = "";
        public string NetType { get; set; } = "";
        public string NetFullType { get; set; }
        public bool IsValueType { get; set; }
        public bool IsNumeric { get; set; }
        public bool IsInteger { get; set; }
        public bool IsDecimal { get; set; }
        public bool IsDate { get; set; }
        public bool IsTime { get; set; }
        public bool IsDateTime { get; set; }
        public bool IsBool { get; set; }
        public bool IsString { get; set; }
        public bool IsArray { get; set; }
    }
}
