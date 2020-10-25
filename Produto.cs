using System.Globalization;
namespace Course {
    class Produto {
        //ATRIBUTOS PRIVADOS
        private string _nome;
        //PROPRIEDADES AUTO IMPLEMENTADAS
        public double Preco { get; private set; }//auto propertiy = eu já defino que o preço não pode ser alterado
        public int Quantidade { get; private set; }//auto propertie - somente leitura, não pode alterar a quantidade
        //MÉTODO CONSTRUTOR
        public Produto() {
        }
        //SOBRECARGA = OUTRO CONSTRUTOR
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //PROPRIEDADES CUSTOMIZADAS
        //PROPERTY = como  o nome possui uma lógica cutomizada, ele não recebe a autopropertie
        public string Nome {
            //se o nome tiver menos que duas letras não haverá como alterálo, ele ira exibir o nome anterior
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
       //OUTROS MÉTODOS
        public double ValorTotalEmEstoque {//Calcula o valor total do estoque
            get { return Preco * Quantidade; }
        }
        public void AdicionarProdutos(int quantidade) {// adiciona um produto  
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {// remove o produto
            Quantidade -= quantidade;
        }
        public override string ToString() {//retorna a quantidade e nome separada por virgula e o valor com duas casas decimais e separados por virgula
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

