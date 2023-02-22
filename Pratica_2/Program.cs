using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dona Tita";
            int codigo = 1;
            string valor = "";

            Fila pedido = new Fila(100);
            Fila pagamento = new Fila(100);
            Fila encomenda = new Fila(100);

            Console.WriteLine("Selecione uma opção: \n1 - Inserção de cliente na fila de pedidos\n2 - Remoção de cliente da fila de pedidos\n3 - Remoção de cliente da fila de pagamentos\n4 - Remoção de cliente da fila de encomendas\n5 - Sair");
            valor = Console.ReadLine();

            while (valor != "5")
            {
                int cliente = 0;
                switch (valor)
                {

                    case "1":
                        if (!pedido.cheia())
                        {
                            Console.WriteLine("Novo cliente de código: " + (codigo) + " adicionado à fila de pedidos!!");
                            pedido.enfileirar(codigo);
                            codigo++;
                        }
                        else
                        {
                            Console.WriteLine("Fila de pedidos cheia!!");
                        }
                        break;
                    case "2":
                        if (pedido.vazia())
                        {
                            Console.WriteLine("A fila de pedidos já está vazia");
                        }
                        else
                        {
                            cliente = pedido.desenfileirar();
                            Console.WriteLine("Cliente de código: " + (cliente) + " removido com sucesso da fila de pedidos!\n Cliente" + cliente + " adicionado na fila de pagamento");
                            pagamento.enfileirar(cliente);
                        }
                        break;
                    case "3":
                        if (pagamento.vazia())
                        {
                            Console.WriteLine("A fila de pagamentos já está vazia");
                        }
                        else
                        {
                            cliente = pagamento.desenfileirar();
                            Console.WriteLine("Cliente de código: " + (cliente) + " removido com sucesso da fila de pagamentos!\n Cliente" + cliente + " adicionado na fila de encomenda");
                            encomenda.enfileirar(cliente);
                        }

                        break;

                    case "4":
                        if (encomenda.vazia())
                        {
                            Console.WriteLine("A fila de encomendas já está vazia");
                        }
                        else
                        {

                            cliente = encomenda.desenfileirar();
                            Console.WriteLine("Cliente de código: " + (cliente) + " removido com sucesso da fila de encomendas e foi embora!");
                        }
                        break;
                }
                valor = Console.ReadLine();
            }
            Console.WriteLine("Volte Sempre!!");
            Console.ReadKey();
        }
    }
}
