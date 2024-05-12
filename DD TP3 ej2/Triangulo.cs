using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_TP3_ej2
{
    internal class Triangulo : Figura
    {
        #region Atributos
        private double baseTriangulo;
        private double altura;
        private double lado1;
        private double lado2;
        #endregion

        #region Constructores
        public Triangulo(double baseTriangulo, double lado1, double lado2)
        {
            bool esValido = trianguloValido(baseTriangulo, lado1, lado2);
            this.baseTriangulo= esValido ? baseTriangulo : 0;
            this.lado1= esValido ? lado1 : 0;
            this.lado2= esValido ? lado2 : 0;
            altura = calcularAltura();
        }
        #endregion

        #region Utilidades
        private double calcularAltura()
        {
            double semiperimetro = (lado1 + lado2 + baseTriangulo) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - baseTriangulo));
            return Math.Round(baseTriangulo != 0 ? ((2 * area) / baseTriangulo) : 0 , 3);
        }
        #endregion

        #region Property
        public double BaseTriangulo
        {
            get { return baseTriangulo; }
            set { baseTriangulo = trianguloValido(value, lado1, lado2) ? value : baseTriangulo; }
        }
        public double Lado1
        {
            get { return lado1; }
            set { lado1 = trianguloValido(baseTriangulo, value, lado2) ? value : lado1; }
        }
        public double Lado2
        {
            get { return lado2; }
            set { lado2 = trianguloValido(baseTriangulo, lado1, value) ? value : lado2; }
        }

        //Considerar agregar un Property para altura, en ese caso considerar agregar tambipen un constructor que use base y altura o algo similar //

        #endregion

        #region Static
        public static bool trianguloValido(double baseTriangulo, double lado1, double lado2)
        {            
            return (baseTriangulo + lado1 > lado2) && (baseTriangulo + lado2 > lado1) && (lado1 + lado2 > baseTriangulo);
        }
        #endregion

        #region Consultas
        public override double perimetro()
        {
            return baseTriangulo + lado1 + lado2;
        }

        public override double area()
        {
            return (baseTriangulo * altura) / 2;
        }
        public string mostrar() //Cambiar a ToString
        {
            return $"Base: {baseTriangulo} Altura: {altura} lado1: {lado1} lado2: {lado2}";
        }
        #endregion
    }
}
