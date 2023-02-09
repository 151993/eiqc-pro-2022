using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using QSS.eIQC.DataAccess.DataContext;
using System;

namespace QSS.eIQC.UnitTests.Core
{
    public class QSSDataFixture : IDisposable
    {
        public QSSContext qssContext { get; private set; }
        public DbContextOptions<QSSContext> qssContextOptions { get; private set; }
        private const string Database = "eIQCInMemoryDatabase";


        public QSSDataFixture()
        {

            qssContextOptions = new DbContextOptionsBuilder<QSSContext>()
                .UseInMemoryDatabase(Database + DateTime.Now.ToFileTimeUtc())
             // don't raise the error warning us that the in memory db doesn't support transactions
             .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
             .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
             .EnableSensitiveDataLogging(true)
                .Options;

            
            qssContext = new QSSContext(qssContextOptions, MoqUserIdentity.GetUserIdentity().Object);
            qssContext.Database.EnsureDeleted();
            qssContext.Database.EnsureCreated();


        }

        public void Dispose()
        {
            qssContext.Database.EnsureDeleted();
            qssContext.Dispose();
        }
    }
}
