using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stuff.RavenNoSql;

namespace Stuff.Tests
{
    [TestClass]
    public class TestDBLayer
    {
        DataStore _dataStore;

        [TestInitialize]
        public void SetUp()
        {
            _dataStore = new DataStore();
        }

        [TestMethod]
        public void TestAddRetrieve()
        {
            _dataStore.AddPrice(new DailyPrice()
                {
                    id = DateTime.Now + "-" + "BHP",
                    transactionDate = DateTime.Now,
                    code = "BHP",
                    priceOpen = 37.96,
                    priceHigh = 38.19,
                    priceLow = 37.84,
                    priceClose = 38.03
                });
            //Assert.IsTrue(id != "", "Id > Expected not blank Actual: " + id);
            //_dataStore.GetAllPrices(id);
        }
    }
}
