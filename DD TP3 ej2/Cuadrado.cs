using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DD_TP3_ej2
{
    internal class Cuadrado: Rectangulo
    {
        #region Atributos
        private double lado;
        #endregion

        #region Constructor
        public Cuadrado(double lado) :base(lado, lado)
        {
            this.lado =(lado > 0) ? lado : 0;
        }
        #endregion

        #region Property
        public double Lado
        {
            get { return lado; }
            set { lado = (lado > 0) ? lado : 0; }
        }
        #endregion

        #region Consultas
        public override double area()
        {
            return lado * lado;
        }

        public override double perimetro()
        {
            return lado * 2 + lado * 2;
        }

        public override string ToString()
        {
            return $"Lado: {lado}";
        }
        #endregion
    }
}
