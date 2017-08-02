using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    static class VarGlobal
    {
        public static string cnx2;

        public static void Inicializar()
        {
            cnx2 = "Server=localhost; Port= 5432; Database=clinica; User Id=postgres; Password=marathon1;";
        }
    }
}
