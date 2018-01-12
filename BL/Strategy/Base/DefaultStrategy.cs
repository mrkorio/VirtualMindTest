using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Models;
using System.ServiceModel.Web;

namespace BL.Strategy.Base
{
    public class DefaultStrategy : IMoneyStrategy
    {
        public Money GetQuotation()
        {
            throw new WebFaultException(System.Net.HttpStatusCode.Unauthorized);
        }
    }
}
