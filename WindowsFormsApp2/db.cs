using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace WindowsFormsApp2
{
    public class db
    {
        private MongoClient client;

        public db()
        {
            // Sets the connection URI
            const string connectionUri = "mongodb://localhost:27017";
            // Creates a new client and connects to the server
            client = new MongoClient(connectionUri);
        }
        public IMongoDatabase GetDatabase()
        {
            return client.GetDatabase("Duombaze");
        }

        public void Transaction(Action<IClientSession> onTransaction)
        {
            using (var session = client.StartSession())
            {
                try
                {
                    onTransaction.Invoke(session);
                    session.CommitTransaction();
                }
                catch (Exception ex)
                {
                    // Display the error however you please
                    return;
                }
                // Display that the transaction was completed successuflly(optional)
            }

        }
    }
}
