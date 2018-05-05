using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_GAC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            bool testeOpcao = true;

            Console.WriteLine("\n######## GAC - Grafos ########");

            int qtdVertice = 0;
            bool testeQtdVertice = true;

            Console.Write("\nDigite o número de vértices: ");
            testeQtdVertice = int.TryParse(Console.ReadLine(), out qtdVertice);

            while (!testeQtdVertice)
            {
                Console.WriteLine("NÚMERO INVÁLIDO. Digite a quantidade de vértices: ");
                testeQtdVertice = int.TryParse(Console.ReadLine(), out qtdVertice);
            }

            Grafos Grafos = new Grafos(qtdVertice);

            do
            {
                Console.Clear();
                Console.WriteLine("\n######## GRAFOS ########n");
                Console.WriteLine("[1] Inserir aresta");
                Console.WriteLine("[2] Pesquisar aresta");
                Console.WriteLine("[3] Excluir aresta");
                Console.WriteLine("[4] Inserir vértice");
                Console.WriteLine("[5] Excluir vértice");
                Console.WriteLine("[6] Imprimir Grafos");
                Console.WriteLine("[7] Lista vértices adjacentes");
                Console.WriteLine("[8] Ordem do vértice");
                Console.WriteLine("[9] Completo");
                //Console.WriteLine("[9] Regular");
                //Console.WriteLine("[9] Par");
                //Console.WriteLine("[9] Impar");
                Console.WriteLine("[10] Grau");
                //Console.WriteLine("[9] Sequencia de Grau");
                Console.WriteLine("[0] Sair\n");

                Console.Write("\nDigite a opção desejada: ");
                testeOpcao = int.TryParse(Console.ReadLine(), out opcao);

                while (opcao < 0 || opcao > 15 || testeOpcao == false)
                {
                    Console.Write("\nOPÇÃO INVÁLIDA. Digite a opção desejada: ");
                    testeOpcao = int.TryParse(Console.ReadLine(), out opcao);
                }

                switch (opcao)
                {
                    case (1):

                        Console.Clear();
                        Console.WriteLine("\n********************** INSERIR ARESTA **********************");

                        int V1 = 0, V2 = 0;
                        bool testeAresta = true;

                        Console.Write("\nDigite o primeiro vértice: ");
                        testeAresta = int.TryParse(Console.ReadLine(), out V1);

                        while (!testeAresta || V1 > qtdVertice)
                        {
                            Console.Write("\nVALOR INVÁLIDO. Digite o primeiro vértice: ");
                            testeAresta = int.TryParse(Console.ReadLine(), out V1);
                        }

                        testeAresta = true;
                        Console.Write("\nDigite o segundo vértice: ");
                        testeAresta = int.TryParse(Console.ReadLine(), out V2);

                        while (!testeAresta || V2 > qtdVertice)
                        {
                            Console.Write("\nVALOR INVÁLIDO. Digite o segundo vértice: ");
                            testeAresta = int.TryParse(Console.ReadLine(), out V2);
                        }

                        Grafos.InsereAresta(V1, V2);
                        Console.ReadKey(true);

                        break;

                    case (2):

                        Console.Clear();
                        Console.WriteLine("\n********************** PESQUISAR ARESTA ********************");

                        V1 = 0;
                        V2 = 0;
                        testeAresta = true;

                        Console.Write("\nDigite o primeiro vértice: ");
                        testeAresta = int.TryParse(Console.ReadLine(), out V1);

                        while (!testeAresta || V1 > qtdVertice)
                        {
                            Console.Write("\nVALOR INVÁLIDO. Digite o primeiro vértice: ");
                            testeAresta = int.TryParse(Console.ReadLine(), out V1);
                        }

                        testeAresta = true;
                        Console.Write("\nDigite o segundo vértice: ");
                        testeAresta = int.TryParse(Console.ReadLine(), out V2);

                        while (!testeAresta || V2 > qtdVertice)
                        {
                            Console.Write("\nVALOR INVÁLIDO. Digite o segundo vértice: ");
                            testeAresta = int.TryParse(Console.ReadLine(), out V2);
                        }

                        if (Grafos.Adjacentes(V1, V2)) Console.WriteLine("\nA aresta existe. ");
                        else Console.WriteLine("\nA aresta não existe. ");

                        Console.ReadKey(true);

                        break;

                    case (3):

                        Console.Clear();
                        Console.WriteLine("\n********************** EXCLUIR ARESTA **********************");

                        V1 = 0;
                        V2 = 0;
                        testeAresta = true;

                        Console.Write("\nDigite o primeiro vértice: ");
                        testeAresta = int.TryParse(Console.ReadLine(), out V1);

                        while (!testeAresta || V1 > qtdVertice)
                        {
                            Console.Write("\nVALOR INVÁLIDO. Digite o primeiro vértice: ");
                            testeAresta = int.TryParse(Console.ReadLine(), out V1);
                        }

                        testeAresta = true;
                        Console.Write("\nDigite o segundo vértice: ");
                        testeAresta = int.TryParse(Console.ReadLine(), out V2);

                        while (!testeAresta || V2 > qtdVertice)
                        {
                            Console.Write("\nVALOR INVÁLIDO. Digite o segundo vértice: ");
                            testeAresta = int.TryParse(Console.ReadLine(), out V2);
                        }

                        Grafos.retiraAresta(V1, V2);
                        Console.ReadKey(true);

                        break;

                    case (4):

                        Console.Clear();
                        Console.WriteLine("\n********************** INSERIR VÉRTICE *********************");

                        qtdVertice++;
                        Grafos.InsereVertice();

                        Console.ReadKey(true);

                        break;

                    case (5):

                        Console.Clear();
                        Console.WriteLine("\n********************** EXCLUIR VÉRTICE *********************");

                        int vertice;
                        bool testeVertice = true;

                        Console.Write("\nDigite o número do vértice que deseja retirar: ");
                        testeVertice = int.TryParse(Console.ReadLine(), out vertice);

                        while (!testeVertice)
                        {
                            Console.Write("\nVALOR INVÁLIDO. Digite o número do vértice que deseja retirar: ");
                            testeVertice = int.TryParse(Console.ReadLine(), out vertice);
                        }

                        qtdVertice--;
                        Grafos.RetiraVertice(vertice);

                        Console.ReadKey(true);

                        break;

                    case (6):

                        Console.Clear();
                        Console.WriteLine("\n********************** IMPRIME GRAFO ***********************");

                        Grafos.ImprimeGrafo();

                        Console.ReadKey(true);

                        break;

                    case (7):

                        Console.Clear();
                        Console.WriteLine("\n********************** LISTA VÉRTICES ADJACENTES ***********");

                        int v = 0;
                        testeVertice = true;

                        Console.Write("\nDigite o vértice para listar as adjacências: ");
                        testeVertice = int.TryParse(Console.ReadLine(), out v);

                        while (!testeVertice)
                        {
                            Console.Write("\nVALOR INVÁLIDO. Digite o vértice para listar as adjacências: ");
                            testeVertice = int.TryParse(Console.ReadLine(), out v);
                        }

                        Grafos.ListaDeAdjacente(v);

                        Console.ReadKey(true);

                        break;

                    case (8):

                        Console.Clear();

                        Console.WriteLine("\n");
                        Console.Write("######## ORDEM DO VÉRTICE: ########");
                        Console.WriteLine("\n\n");

                        Grafos.Exibe_Ordem(qtdVertice);

                        Console.ReadKey(true);

                        break;

                    case (9):

                        Console.Clear();

                        Console.WriteLine("\n");
                        Console.Write("######## GRAFO COMPLETO ########");
                        Console.WriteLine("\n\n");

                        Grafos.Completo();

                        Console.ReadKey(true);

                        break;

                    case (10):

                        Console.Clear();

                        Console.WriteLine("\n");
                        Console.Write("######## GRAFO COMPLETO ########");
                        Console.WriteLine("\n\n");

                        int g = 0;
                        testeVertice = true;

                        Console.Write("\nDigite o vértice para listar as adjacências: ");
                        testeVertice = int.TryParse(Console.ReadLine(), out g);

                        while (!testeVertice)
                        {
                            Console.Write("\nVALOR INVÁLIDO. Digite o vértice para listar as adjacências: ");
                            testeVertice = int.TryParse(Console.ReadLine(), out g);
                        }

                        Grafos.Grau(g);

                        Console.ReadKey(true);

                        break;

                    case (0):

                        break;

                    default:

                        Console.Write("\nOPÇÃO INVÁLIDA!");
                        break;
                }

            } while (opcao != 0);

            Console.Write("\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
    }
