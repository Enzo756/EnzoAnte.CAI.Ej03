using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnzoAnte.CAI.Ej03
{
    internal class Ejercicio03Model
    {
        public string PaísIngresado { get; set; }
        public string ProvinciaIngresada { get; set; }
        public string LocalidadIngresada { get; set; }
        public string CalleIngresada { get; set; }
        public string NúmeroIngresado { get; set; }
        public string PisoIngresado { get; set; }
        public string DepartamentoIngresado { get; set; }

        public string Validar()
        {
            return "Ok";
        }


    }
}
