using Comex.Modelos.Modelos;

namespace Comex.Testes
{
    public class ItemDePedidoTeste
    {
        [Fact]
        public void TestaCalculaSubtotal()
        {
            Cliente cliente = new ("Cliente 1");
            Produto produto = new ("Produto 1", 5, 10);
            ItemDePedido itemDePedido = new (produto, produto.Quantidade, produto.Preco);

            var validacao = itemDePedido.CalculaSubtotal();

            Assert.Equal(50, validacao);
        }
    }
}