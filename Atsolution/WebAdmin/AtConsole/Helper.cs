using AtConsole.Efs.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtConsole
{
    public class Helper
    {
        public static List<AtMappingColumn> ReadEntityMeta(string entityName)
        {
            var context = new AtECommerceContext();
            var itemEntityType = context.Model.GetEntityTypes().FirstOrDefault(h => h.ClrType.Name == entityName);
            var listProperty = itemEntityType.GetProperties().ToList();
            var listMapping = new List<AtMappingColumn>(listProperty.Count);

            foreach (var itemProperty in listProperty)
            {
                var relational = itemProperty.Relational();
                var columnType = relational.ColumnType.ToLowerInvariant();

                var mapping = new AtMappingColumn();
                mapping.Name = itemProperty.Name;
                mapping.AllowNull = itemProperty.IsNullable;

                var dataType = itemProperty.ClrType.Name;
                if (itemProperty.ClrType.Name.StartsWith("Nullable"))
                {
                    dataType = itemProperty.ClrType.GenericTypeArguments[0].Name;
                }
                dataType = dataType.ToLowerInvariant();

                if (dataType == "boolean")
                {
                    mapping.DataType = "bool";
                }
                else if (dataType == "string")
                {
                    mapping.DataType = "string";

                    if (columnType.Contains("max"))
                    {
                        mapping.MaxLength = 4000;
                    }
                    else if (columnType.Contains("("))
                    {
                        var indexOpen = columnType.IndexOf("(");
                        var indexClose = columnType.IndexOf(")");
                        mapping.MaxLength = int.Parse(columnType.Substring(indexOpen + 1, indexClose - indexOpen - 1));
                    }
                }
                else if (dataType == "datetime" || dataType == "datetimeoffset")
                {
                    if (columnType == "date")
                    {
                        mapping.DataType = "date";
                    }
                    else
                    {
                        mapping.DataType = "datetime";
                    }
                }
                else if (dataType == "int32")
                {
                    mapping.DataType = "int";
                }
                else if (dataType == "int64")
                {
                    mapping.DataType = "long";
                }
                else if (dataType == "double")
                {
                    mapping.DataType = "double";
                }
                else if (dataType == "decimal")
                {
                    mapping.DataType = "decimal";
                }

                listMapping.Add(mapping);
            }

            return listMapping;
        }
    }

    public class AtMappingColumn
    {
        public string Name { get; set; }
        public bool AllowNull { get; set; }
        public string DataType { get; set; }
        public int MaxLength { get; set; }
    }
}
