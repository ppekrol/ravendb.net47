using System;
using Raven.Client.Document;

namespace RavenDB.NetStandard
{
    public static class GetStats
    {
        public static void DoWork()
        {
            using (var store = new DocumentStore())
            {
                store.Url = "http://live-test.ravendb.net";
                store.DefaultDatabase = "Test";

                store.Initialize(ensureDatabaseExists: true);

                var stats = store.DatabaseCommands.GetStatistics();

                Console.WriteLine($"Number of documents: {stats.CountOfDocuments}");
            }
        }
    }
}