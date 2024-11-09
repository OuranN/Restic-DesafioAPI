using System.ComponentModel.DataAnnotations;

namespace MinhaApi.model
{
    public class Produto
    {
        [Key]
        public int ID_Produto { get; private set; }
        public string Nome { get; private set; }
        public string Tipo { get; private set; }
        public decimal Valor { get; private set; }

        public Produto(string nome, string tipo, decimal valor)
        {
            Nome = nome;
            Tipo = tipo;
            Valor = valor;
        }

        public void Update(string nome, string tipo, decimal valor)
        {
            Nome = nome;
            Tipo = tipo;
            Valor = valor;
        }
    }
}
