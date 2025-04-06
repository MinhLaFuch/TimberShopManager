using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.objects
{
    internal class Account
    {
        private string employeeId, username, password;

        public Account(string employeeId, string username, string password)
        {
            this.employeeId = employeeId;
            this.username = username;
            this.password = password;
        }
    }
}
