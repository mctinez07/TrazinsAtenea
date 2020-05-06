using Models.Messages;
using SqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModels.Messages
{
    public static class MensajesManager
    {
        public static Mensaje Mensaje_Select(Mensaje mensaje)
        {
            return MainSqlEngine.IsSelect(mensaje);
        }
    }
}
