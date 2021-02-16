using Models.Masters;
using SqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModels.Masters
{
    public static class EspecialidadManager
    {
        public static List<Especialidad> Especialidad_Select_List(Especialidad especialidad)
        {
            return MainSqlEngine.IsSelectList(especialidad);
        }

        public static Especialidad Especialidad_Select(Especialidad especialidad)
        {
            return MainSqlEngine.IsSelect(especialidad);
        }

        public static Especialidad Especialidad_Insert(Especialidad especialidad)
        {
            return MainSqlEngine.IsInsert(especialidad);
        }

        public static Especialidad Especialidad_Update(Especialidad especialidad)
        {
            return MainSqlEngine.IsUpdate(especialidad);
        }

    }
}
