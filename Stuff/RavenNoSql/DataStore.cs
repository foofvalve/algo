using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client.Document;
using Raven.Client.Linq;
using Raven.Client;


namespace Stuff.RavenNoSql
{
    public class DataStore
    {
        static IDocumentStore _documentStore;
        IDocumentSession _session;

        public DataStore()
        {
            _documentStore =
                new DocumentStore { Url = "http://localhost:8080", DefaultDatabase = "ALGO2" };
            _documentStore.Initialize();            
            //_documentStore.RegisterListener(new UniqueConstraintsStoreListener());            
        }


        public void AddPrice(DailyPrice priceEntry)
        {
            _session = _documentStore.OpenSession();
            _session.Store(priceEntry);
            _session.SaveChanges();
        }

        //public void AddPrice(DailyPrice priceEntry)
        //{
        //    _session = _documentStore.OpenSession();
           

        //    var checkResult = _session.CheckForUniqueConstraints(priceEntry);

        //    if (checkResult.ConstraintsAreFree())
        //    {
        //        _session.Store(priceEntry);
        //        _session.SaveChanges();
        //    }
        //    else
        //    {
        //        System.Diagnostics.Debug.Write("Existing price entry found");
        //        //var existingUser = checkResult.DocumentForProperty(x => x.Email);
        //    }
        //}

        public void GetAllPrices(string id)
        {
            _session = _documentStore.OpenSession();
            var prices = _session.Load<DailyPrice>(id);
            System.Diagnostics.Debug.Write(prices.transactionDate.ToString());            
        }
    }
}
