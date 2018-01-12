using BE.Models;
using BL.Strategy;
using BL.Strategy.Base;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace BL.Helpers
{
    public class CommonHelper
    {

        private const string PESOS = "PESOS";
        private const string REAL = "REAL";
        private const string DOLAR = "DOLAR";

        private const string END_POINT = "https://www.bancoprovincia.com.ar/principal/dolar";

        public static IMoneyStrategy GetMoneyStrategy(string money)
        {
            IMoneyStrategy moneyStrategy = null;

            switch (money.ToUpper())
            {
                case PESOS:
                    moneyStrategy = new PesosStrategy();
                    break;
                case REAL:
                    moneyStrategy = new RealStrategy();
                    break;
                case DOLAR:
                    moneyStrategy = new DolarStrategy();
                    break;
                default:
                    moneyStrategy = new DefaultStrategy();
                    break;
            }
            return moneyStrategy;
        }



        public static Money GetDolarStatus()
        {
            Money result = new Money();

            var req = WebRequest.Create(END_POINT);
            req.Method = "POST";
            req.ContentType = "application/json";
         
       
            using (var stream = req.GetRequestStream())
            {
                
            }

            using (var resp = req.GetResponse())
            {
                var results = new StreamReader(resp.GetResponseStream()).ReadToEnd();

                //JObject.Parse(results);
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                var jsonObject = serializer.Deserialize<string[]>(results);

                result = new Money(double.Parse(jsonObject[0]), double.Parse(jsonObject[1]), jsonObject[2]);


            }

            return result;
        }


    }
}
