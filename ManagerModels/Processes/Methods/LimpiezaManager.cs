using Models.Processes.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlEngine;

namespace ManagerModels.Processes.Methods
{
    public static class LimpiezaManager
    {
        public static List<Limpieza> Limpieza_Select_List(Limpieza limpieza)
        {
            return MainSqlEngine.IsSelectList(limpieza);
        }

        public static Limpieza Limpieza_Select(Limpieza limpieza)
        {
            return MainSqlEngine.IsSelect(limpieza);
        }

        public static Limpieza Limpieza_Insert(Limpieza limpieza)
        {
            return MainSqlEngine.IsInsert(limpieza);
        }

        public static Limpieza Limpieza_Update(Limpieza limpieza)
        {
            return MainSqlEngine.IsUpdate(limpieza);
        }
    }
}
