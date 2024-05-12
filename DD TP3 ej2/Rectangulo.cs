using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_TP3_ej2
{
    internal class Rectangulo: Figura
    {
        #region Atributos
        private double basee;
        private double altura;
        #endregion

        #region Constructores
        public Rectangulo(double basee, double altura)
        {
            this.basee = (basee > 0) ? basee : 0;
            this.altura = (altura> 0) ? altura : 0;
        }
        #endregion

        #region Property
        public double Basee
        {
            get { return basee; }
            set { basee = (value > 0) ? value : 0; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = (value > 0) ? value : 0; }
        }
        #endregion

        #region consultas
        public override double area()
        {
            return basee * altura;
        }

        public override double perimetro()
        {
            return altura * 2 + basee * 2;
        }

        public string mostrar() //Cambiar a ToString
        {
            return $"Base: {basee} Altura: {altura}";
        }
        #endregion
    }
}
