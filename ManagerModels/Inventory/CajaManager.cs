using Models.Inventory;
using SqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModels.Inventory
{
    public static class CajaManager
    {
        public static List<Caja> Caja_Select_List(Caja caja)
        {
            return MainSqlEngine.IsSelectList(caja);
        }

        public static Caja Caja_Select(Caja caja)
        {
            return MainSqlEngine.IsSelect(caja);
        }

        public static string Caja_Insert(Caja caja)
        {
            return MainSqlEngine.IsInsert(caja);
        }

        public static string Caja_Update(Caja caja)
        {
            return MainSqlEngine.IsUpdate(caja);
        }
    }
}
