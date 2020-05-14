using Models.Processes.Methods;
using SqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModels.Processes.Methods
{
    public static class EsterilizacionManager
    {
        public static List<Esterilizacion> Esterilizacion_Select_List(Esterilizacion esterilizacion)
        {
            return MainSqlEngine.IsSelectList(esterilizacion);
        }

        public static Esterilizacion Esterilizacion_Select(Esterilizacion esterilizacion)
        {
            return MainSqlEngine.IsSelect(esterilizacion);
        }

        public static string Esterilizacion_Insert(Esterilizacion esterilizacion)
        {
            return MainSqlEngine.IsInsert(esterilizacion);
        }

        public static string Esterilizacion_Update(Esterilizacion esterilizacion)
        {
            return MainSqlEngine.IsUpdate(esterilizacion);
        }
    }
}
