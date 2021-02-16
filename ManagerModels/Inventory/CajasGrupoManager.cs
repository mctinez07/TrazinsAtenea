using Models.Inventory;
using SqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModels.Inventory
{
    public static class CajasGrupoManager
    {
        public static List<CajasGrupo> CajasGrupo_Select_List(CajasGrupo cajasGrupo)
        {
            return MainSqlEngine.IsSelectList(cajasGrupo);
        }

        public static CajasGrupo CajasGrupo_Select(CajasGrupo cajasGrupo)
        {
            return MainSqlEngine.IsSelect(cajasGrupo);
        }

        public static CajasGrupo CajasGrupo_Insert(CajasGrupo cajasGrupo)
        {
            return MainSqlEngine.IsInsert(cajasGrupo);
        }

        public static CajasGrupo CajasGrupo_Update(CajasGrupo cajasGrupo)
        {
            return MainSqlEngine.IsUpdate(cajasGrupo);
        }

        public static CajasGrupo CajasGrupo_Delete(CajasGrupo cajasGrupo)
        {
            return MainSqlEngine.IsDelete(cajasGrupo);
        }
    }
}
