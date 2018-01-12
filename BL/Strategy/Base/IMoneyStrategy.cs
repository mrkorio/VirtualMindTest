using BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Strategy.Base
{
    public interface IMoneyStrategy
    {

        Money GetQuotation();

    }
}
