using System;
using System.Globalization;
namespace curso {
    class Retangulo {
        public double Largura, Altura;

        public double Area() {
           double area =  Largura * Altura;
            return area;
        }

        public double Perimetro() {
            double perimeto = (Largura * 2) + (Altura * 2);
            return perimeto;
        }

        public double Diagonal(){
            double diagonal = Math.Sqrt(Math.Pow(Altura,2) +Math.Pow(Largura,2) );

            return diagonal;
        }

        public override string ToString() {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) 
                + "\n PERÍMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) 
                + "\n DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
