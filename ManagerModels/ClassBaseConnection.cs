using SqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModels
{
    public class ClassBaseConnection
    {
        protected string CNX_DB { get; set; }

        public ClassBaseConnection()
        {
            CNX_DB = MainSqlEngine.CNX_DB();
        }
    }
}
