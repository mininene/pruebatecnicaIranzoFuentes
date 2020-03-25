using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDePreguntas.Services.LogService
{
    public interface ILog
    {
        void WriteLog(string mensaje);
    }
}
