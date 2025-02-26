using System.Globalization;
namespace curso {
    class Produto {

        public string Nome;
        public float Preco;
        public int Quantidade;
       

        public void AdicionarProdutos (int quantidade){
            Quantidade = Quantidade + quantidade;
            

        }

        public void RemoverProdutos(int quantidade) {
            Quantidade = Quantidade - quantidade;
            
           
        }

        public double ValorTotalEmEstoque() {
            var valorTotal = Preco * Quantidade;
            return valorTotal;
        }

        public override string ToString() {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + "unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
