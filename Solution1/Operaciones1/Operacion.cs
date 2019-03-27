﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operaciones;

namespace Operaciones
{
    public class Operacion
    {
        private double v1, v2, resultado;

        public double V2
        {
            get { return v2; }
            set { v2 = value; }
        }

        public double V1
        {
            get { return v1; }
            set { v1 = value; }
        }

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public Operacion()
        {
            this.v1 = 0;
            this.v2 = 0;
        }
        public double CalcularS()
        {
            resultado = v1 + v2;
            return resultado;
        }
        public double CalcularR()
        {
            resultado = v1 - v2;
            return resultado;
        }
        public double CalcularM()
        {
            resultado = v1 * v2;
            return resultado;
        }
        public double CalcularD()
        {
            resultado = v1 / v2;
            return resultado;
        }
    }
}