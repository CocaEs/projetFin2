﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFin
{
    class Clientes
    {
        string nombre;
        string apellido;
        string nit;
        DateTime fecha;
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nit { get => nit; set => nit = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
