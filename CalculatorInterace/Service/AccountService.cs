using CalculatorInterace.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterace.Service
{
    internal class AccountService:IAccountService
    {
         
        public string name;
        public string password;


        void IAccountService.AccountService(string name,string password)
        {
            {
                this.name = name;
                this.password = password;
            }


        }

        void IAccountService.Sign(string name,string password)
        {
            if (name == "Shaiq111" && password == "Shaiq1997")
            {
                Console.WriteLine("Ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password yanlisdir");
            }
        }
    }
}
 
