using System;

namespace curso
{
    class Triangulo
    {
        //de acordo com o padrao do C# na poo nome de atributo sempre começa com letra maiúscula
        public double A;
        public double B;
        public double C;

        //metodos da classe triangulo
        public double Area() {
            double p = (A + B + C) / 2.0;
            
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }

        
    }
}
