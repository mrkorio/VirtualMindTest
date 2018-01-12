using BL.Strategy.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Models;
using BL.Helpers;

namespace BL.Strategy
{
    public class DolarStrategy : IMoneyStrategy
    {
        public  Money GetQuotation()
        {
            return CommonHelper.GetDolarStatus();
        }
    }
}
