using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICAH
{
    static class GlobalVar
    {
        public static string cnx;

        public static void Inicializar()
        {
            cnx = "Server=localhost; Port= 5432; Database=clinica; User Id=postgres; Password=Salmos665;";
        }
    }
}
