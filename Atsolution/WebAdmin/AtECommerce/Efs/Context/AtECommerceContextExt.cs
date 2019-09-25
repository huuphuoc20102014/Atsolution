using System;
using AtECommerce.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AtECommerce.Efs.Entities
{
    public partial class WebAtSolutionContext : DbContext
    {
        internal string LoginUserId { get; set; }

        public WebAtSolutionContext() : base()
        {
        }
    }

    public class AtBaseECommerceEntity
    {
        public const string FULL_DB_CONTEXT_NAME = "AtECommerce.Efs.Entities.WebAtSolutionContext";
    }

    public class AtRegisterValidatorModel { }
    public class AtRegisterValidator : AtBaseValidator<AtRegisterValidatorModel> { }

}
