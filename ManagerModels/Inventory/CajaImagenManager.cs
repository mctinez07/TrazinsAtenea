using Models.Inventory;
using SqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModels.Inventory
{
    public static class CajaImagenManager
    {
        public static List<CajaImagen> CajaImagen_Select_List(CajaImagen cajaImagen)
        {
            return MainSqlEngine.IsSelectList(cajaImagen);
        }

        public static CajaImagen CajaImagen_Select(CajaImagen cajaImagen)
        {
            return MainSqlEngine.IsSelect(cajaImagen);
        }

        public static CajaImagen CajaImagen_Insert(CajaImagen cajaImagen)
        {
            return MainSqlEngine.IsInsert(cajaImagen);
        }

        public static CajaImagen CajaImagen_Update(CajaImagen cajaImagen)
        {
            return MainSqlEngine.IsUpdate(cajaImagen);
        }

        public static CajaImagen CajaImagen_Delete(CajaImagen cajaImagen)
        {
            return MainSqlEngine.IsDelete(cajaImagen);
        }
    }
}
