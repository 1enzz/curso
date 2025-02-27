using System;
using System.Globalization;

namespace curso {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += SalarioBruto * (porcentagem / 100);

        }

        public override string ToString() {
            return Nome + ", $" + SalarioLiquido();
        }
    }
}
