﻿using MAD.IntegrationFramework.Database;
using MAD.IntegrationFramework.Services.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.IntegrationFramework.Database
{
    internal class MIFDbContextFactory<DbContext> : IMIFDbContextFactory<DbContext> where DbContext : MIFDbContext, new()
    {
        private AutomaticMigrationService AutomaticMigrationService;

        public MIFDbContextFactory(AutomaticMigrationService automaticMigrationService)
        {
            this.AutomaticMigrationService = automaticMigrationService;
        }

        public DbContext Create()
        {
            DbContext dbContext = new DbContext();

            this.AutomaticMigrationService.EnsureDatabaseUpToDate(dbContext);

            return dbContext;
        }
    }
}