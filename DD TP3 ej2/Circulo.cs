using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_TP3_ej2
{
    internal class Circulo : Figura
    {
        #region Atributos
        private double radio;
        #endregion

        #region Constructores
        public Circulo(double radio)
        {
            this.radio = (radio > 0) ? radio : 0;
        }
        #endregion

        #region Property
        public double Radio
        {
            get { return radio; }
            set { radio = (value > 0) ? value : 0; }
        }
        #endregion

        #region Consultas
        public override double area()
        {
            return Math.PI * Math.Pow(radio , 2);
        }

        public override double perimetro()
        {
            return 2 * Math.PI * radio;
        }

        public override string ToString() 
        {
            return $"Radio: {radio}";
        }
        #endregion
    }
}
