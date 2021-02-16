using Models.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlEngine;

namespace ManagerModels.Masters
{
    public static class HospitalManager
    {
        public static List<Hospital> Hospital_Select_List(Hospital hospital)
        {
            return MainSqlEngine.IsSelectList(hospital);
        }

        public static Hospital Hospital_Select(Hospital hospital)
        {
            return MainSqlEngine.IsSelect(hospital);
        }

        public static Hospital Hospital_Insert(Hospital hospital)
        {
            return MainSqlEngine.IsInsert(hospital);
        }

        public static Hospital Hospital_Update(Hospital hospital)
        {
            return MainSqlEngine.IsUpdate(hospital);
        }
    }
}
