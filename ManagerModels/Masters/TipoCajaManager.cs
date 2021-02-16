using Models.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlEngine;

namespace ManagerModels.Masters
{
    public static class TipoCajaManager
    {
        public static List<TipoCaja> TipoCaja_Select_List(TipoCaja tipoCaja)
        {
            return MainSqlEngine.IsSelectList(tipoCaja);
        }

        public static TipoCaja TipoCaja_Select(TipoCaja tipoCaja)
        {
            return MainSqlEngine.IsSelect(tipoCaja);
        }

        public static TipoCaja TipoCaja_Insert(TipoCaja tipoCaja)
        {
            return MainSqlEngine.IsInsert(tipoCaja);
        }

        public static TipoCaja TipoCaja_Update(TipoCaja tipoCaja)
        {
            return MainSqlEngine.IsUpdate(tipoCaja);
        }
    }
}
