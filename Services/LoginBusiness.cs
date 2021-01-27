using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCategory.Models;
using ProductCategory.Data;

namespace ProductCategory.Services
{
    public class LoginBusiness
    {

        public bool loginControl(string username,string password)
        {
            var user = "admin";
            var pass = "1234";
            if (username == user && password ==pass)
            {
                return true;
            }
                return false;
        }
    }
}
