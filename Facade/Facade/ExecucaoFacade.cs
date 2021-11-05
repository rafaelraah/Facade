using DesignPatterns;
using System;
using System.Collections.Generic;

namespace Facade
{
    public class ExecucaoFacade
    {
        public static void Executar()
        {
            var produtos = new List<Produto>
            {
                new Produto{Nome = "Tenis Nike", Valor = new Random().Next(1000)},
                new Produto{Nome = "Calça Adiddas", Valor = new Random().Next(1000)},
                new Produto{Nome = "Bola de Basquete", Valor = new Random().Next(1000)}
            };

            var pedido = new Pedido
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var pagamento = new Pagamento
            {
                CartaoCredito = "1111 2222 3333 4444"
            };

            // Resolver com DI
            var pagamentoService = new PagamentoCartaoCreditoService(new PagamentoCartaoCreditoFacade(new PayPalGateway(), new ConfigurationManager()));

            var pagamentoResult = pagamentoService.RealizarPagamento(pedido, pagamento);

            Console.WriteLine(pagamentoResult.Status);

            Console.ReadKey();

        }
    }
}
