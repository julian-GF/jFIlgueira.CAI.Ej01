using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jFIlgueira.CAI.Ej01
{
    internal class FormularioPersonasModel
    {
        public string DocumentoIngresado { get; set; }
        public string NombreIngresado { get; set; }
        public string ApellidoIngresado { get; set; }
        public string FechaNacimiento { get; set; }


        public string validar()
        {
            return "OK";
        }

    }
}
