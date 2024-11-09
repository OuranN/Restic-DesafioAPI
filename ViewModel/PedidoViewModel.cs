namespace MinhaApi.ViewModel
{
    public class PedidoViewModel
    {
        public string StatusPedido { get; set; }
        public int FK_Cliente { get; set; } // Relacionamento com Cliente é feito pelo ID do Cliente no banco
    }
}
