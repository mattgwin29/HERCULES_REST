﻿using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using HERCULES.Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HERCULES.Server.Models;

namespace HERCULES.Server.Data
{
    public partial class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("PS4")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            builder.ToUpperCaseTables();
            builder.ToUpperCaseColumns();
            builder.ToUpperCaseForeignKeys();
            builder.ToUpperCaseIndexes();


            // builder.AddFootprintColumns();
            builder.FinalAdjustments();




        }
    }
}