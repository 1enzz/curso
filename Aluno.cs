using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso {
    class Aluno {
        public string Nome;
        public double N1, N2, N3;
        public double Media = 60.00;

        public double CalculaMediaAluno() {
            double media = (N1 + N2 + N3);

            return media;
        }

        public string VerificaSituacao(double mediaCalculada) {
            double pontosFaltantes;
            pontosFaltantes = Media - mediaCalculada;
            if (mediaCalculada >= Media) {
                return "\nNOTA FINAL  = " + mediaCalculada.ToString("F2", CultureInfo.InvariantCulture) + "\nAPROVADO";
            } else {
                return "\nNOTA FINAL = " + mediaCalculada.ToString("F2", CultureInfo.InvariantCulture)
                    + "\nREPROVADO " 
                    +"\nFALTARAM " + pontosFaltantes.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }



    }
}
