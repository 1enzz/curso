using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso {
    public static class ConversorDeMoeda {
        public static double Cotacao, Dolares, IOF = 6;

        public static double Converter() {
            double valorConversao,valorEmReal;

            valorConversao = Dolares * Cotacao;

            valorEmReal = valorConversao += valorConversao * (IOF / 100);
            return valorEmReal;
        }
    }
}
