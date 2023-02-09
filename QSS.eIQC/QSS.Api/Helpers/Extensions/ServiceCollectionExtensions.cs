using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using QSS.eIQC.DataAccess.DataContext;

namespace QSS.eIQC.Api.Helpers.Extensions
{
    /// <summary>
    /// The Service Collection Extensions
    /// </summary>
    /// <seealso cref="IServiceCollection"/>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Extension to use a single transaction per HTTP request
        /// </summary>
        /// <param name="serviceCollection">the <see cref="IServiceCollection"/></param>
        /// <param name="level">The <see cref="IsolationLevel"/> for the transaction</param>
        public static void UseSingleTransactionPerRequest(this IServiceCollection serviceCollection, IsolationLevel level = IsolationLevel.Snapshot)
        {
            serviceCollection.AddScoped(serviceProvider =>
            {
                var context = serviceProvider.GetService(typeof(IQSSContext)) as QSSContext;
                
                return context?.Database.BeginTransaction(level);
            });
        }

        /// <summary>
        /// Set up the Service PostgreSQL DB Context
        /// </summary>
        /// <param name="serviceCollection">The <see cref="IServiceCollection"/></param>
        /// <param name="applicationConfigurationConnectionString">The data migration connection string</param>
        public static void UsePostgreSqlServer(this IServiceCollection serviceCollection, string applicationConfigurationConnectionString)
        {
            // https://www.npgsql.org/efcore/api/Microsoft.Extensions.DependencyInjection.NpgsqlServiceCollectionExtensions.html#Microsoft_Extensions_DependencyInjection_NpgsqlServiceCollectionExtensions_AddEntityFrameworkNpgsql_IServiceCollection_
            // https://www.npgsql.org/efcore/index.html#additional-configuration-for-aspnet-core-applications
            serviceCollection.AddDbContext<QSSContext>(options =>
                options.UseNpgsql(applicationConfigurationConnectionString,
                x => x.MigrationsAssembly(typeof(QSSContext).Assembly.GetName().Name)));
        }

        /// <summary>
        /// Set up the Service InMemory PostgreSQL DB Context
        /// </summary>
        /// <param name="serviceCollection">The <see cref="IServiceCollection"/></param>
        /// <param name="database">InMemory database name.</param>
        public static void UseInMemoryPostgreSqlServer(this IServiceCollection serviceCollection, string database)
        {
            // Replace default database connection with In-Memory database
            serviceCollection.AddDbContext<QSSContext>(options =>
                options.UseInMemoryDatabase(database)
             // don't raise the error warning us that the in memory db doesn't support transactions
             .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
             .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
             .EnableSensitiveDataLogging(true));
        }

    }
}
