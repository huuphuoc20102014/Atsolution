using System;
using AtECommerce.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GenEf.Efs.Entities
{
    public partial class WebGoldenSeaContext : DbContext
    {
        internal string LoginUserId { get; set; }

        public WebGoldenSeaContext() : base()
        {
        }
    }

    public class AtBaseECommerceEntity
    {
        public const string FULL_DB_CONTEXT_NAME = "AtECommerce.Efs.Entities.WebGoldenSeaContext";
    }

    public class AtRegisterValidatorModel { }
    public class AtRegisterValidator : AtBaseValidator<AtRegisterValidatorModel> { }

}
