﻿using Models.Masters.Storage;
using SqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModels.Masters.Storage
{
    public static class AlmacenesUbicacionesManager
    {
        public static List<AlmacenesUbicaciones> AlmacenesUbicaciones_GetStructure(AlmacenesUbicaciones almacenesUbicaciones)
        {
            var procedureName = string.Format("{0}_{1}", almacenesUbicaciones.GetType().Name, "RecuperarEstructura");
            return MainSqlEngine.IsSelectList(almacenesUbicaciones, procedureName);
        }

        public static List<AlmacenesUbicaciones> AlmacenesUbicaciones_Select_List(AlmacenesUbicaciones almacenesUbicaciones)
        {
            return MainSqlEngine.IsSelectList(almacenesUbicaciones);
        }

        public static AlmacenesUbicaciones AlmacenesUbicaciones_Select(AlmacenesUbicaciones almacenesUbicaciones)
        {
            return MainSqlEngine.IsSelect(almacenesUbicaciones);
        }

        public static AlmacenesUbicaciones AlmacenesUbicaciones_Insert(AlmacenesUbicaciones almacenesUbicaciones)
        {
            return MainSqlEngine.IsInsert(almacenesUbicaciones);
        }

        public static AlmacenesUbicaciones AlmacenesUbicaciones_Update(AlmacenesUbicaciones almacenesUbicaciones)
        {
            return MainSqlEngine.IsUpdate(almacenesUbicaciones);
        }
    }
}
