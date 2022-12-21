using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterace.Service.Interface
{
    internal interface IAccountService
    {
        void AccountService(string name, string password);
        void Sign(string name,string password);
    }
}
