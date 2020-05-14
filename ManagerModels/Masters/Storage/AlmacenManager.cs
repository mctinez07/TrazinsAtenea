using Models.Masters.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlEngine;

namespace ManagerModels.Masters.Storage
{
    public static class AlmacenManager
    {
        public static List<Almacen> Almacen_Select_List(Almacen almacen)
        {
            return MainSqlEngine.IsSelectList(almacen);
        }

        public static Almacen Almacen_Select(Almacen almacen)
        {
            return MainSqlEngine.IsSelect(almacen);
        }

        public static string Almacen_Insert(Almacen almacen)
        {
            return MainSqlEngine.IsInsert(almacen);
        }

        public static string Almacen_Update(Almacen almacen)
        {
            return MainSqlEngine.IsUpdate(almacen);
        }
    }
}
