using Models.Masters;
using SqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModels.Masters
{
    public static class EmbalajeManager
    {
        public static List<Embalaje> Embalaje_Select_List(Embalaje embalaje)
        {
            return MainSqlEngine.IsSelectList(embalaje);
        }

        public static Embalaje Embalaje_Select(Embalaje embalaje)
        {
            return MainSqlEngine.IsSelect(embalaje);
        }

        public static string Embalaje_Insert(Embalaje embalaje)
        {
            return MainSqlEngine.IsInsert(embalaje);
        }

        public static string Embalaje_Update(Embalaje embalaje)
        {
            return MainSqlEngine.IsUpdate(embalaje);
        }
    }
}
