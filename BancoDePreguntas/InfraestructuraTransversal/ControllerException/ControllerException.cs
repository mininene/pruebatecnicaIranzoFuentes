using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.InfraestructuraTransversal.ControllerException
{
    public class ControllerException:Exception
    {
        public ControllerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}