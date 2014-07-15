using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//resource -> http://blog.equametrics.com/2013/06/return-to-the-simple-an-algorithmic-trading-strategy-inspired-by-missing-a-trade
namespace Stuff.Algore
{
    public class Fidget
    {
        DataClasses1DataContext _db;
        const double m = 0.609384;  //1 day holding pattern for em5
        //also try 1.5 EM5 where sharpe ratio = 0.90755

        public Fidget()
        {
            _db = new DataClasses1DataContext();
        }

        //columnmize into the db
        public void GetAverageTrueRange(DateTime relativeDate, int period)
        { 
            
        }

        //Rles:
        //Gap up today
        //Yesterday had a big selloff
        //Today’s Open > Yesterday’s Open
        //Today’s Low > Yesterday’s High 
        public void SpotTheEM5()
        {
            var b = _db.END_OF_DAYs.ToArray<END_OF_DAY>();
            Debug.Write(b[3].Date);
        }

        public void IsBigSellOf()
        {
            //Yesterday’s True Range > m * Yesterday’s Average True Range
        }

        //The true range indicator is the greatest of the following: 
        //-current high less the current low. 
        //-the absolute value of the current high less the previous close. 
        //-the absolute value of the current low less the previous close. 
        public void AverageTrueRange(DateTime dateOfTrade)
        {
            var dayTrade = GetTrade(dateOfTrade);
            var diffCurrentHighLessCurrentLow = dayTrade.HighPrice - dayTrade.LowPrice;

        }

        public END_OF_DAY GetTrade(DateTime dayTrade)
        {
            return _db.END_OF_DAYs.Where(x => x.Date == dayTrade).FirstOrDefault();
        }

        public END_OF_DAY GetPreviousTrade(DateTime currentDay)
        {
            return null;
        }

        public void GetRSIValue()
        {

        }
    }
}
