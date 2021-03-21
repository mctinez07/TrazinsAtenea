using Models.Masters;
using SqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModels.Masters
{
    public static class CentroCosteManager
    {
        public static List<CentroCoste> CentroCoste_Select_List(CentroCoste centrocoste)
        {
            return MainSqlEngine.IsSelectList(centrocoste);
        }

        public static CentroCoste CentroCoste_Select(CentroCoste centrocoste)
        {
            return MainSqlEngine.IsSelect(centrocoste);
        }

        public static CentroCoste CentroCoste_Insert(CentroCoste centrocoste)
        {
            return MainSqlEngine.IsInsert(centrocoste);
        }

        public static CentroCoste CentroCoste_Update(CentroCoste centrocoste)
        {
            return MainSqlEngine.IsUpdate(centrocoste);
        }
    }
}
