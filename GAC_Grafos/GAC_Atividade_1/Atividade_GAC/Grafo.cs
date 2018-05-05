using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_GAC
{
    public class Grafo
    {

        int qtd_aresta = 0;

        private int qtdVertices;
        private Dictionary<int, List<int>> Vertice = new Dictionary<int, List<int>>();

        public int QtdVertices { get => qtdVertices; set => qtdVertices = value; }

        public Grafo(int qtdVertices)
        {
            this.QtdVertices = qtdVertices;

            for (int i = 1; i < (qtdVertices + 1); i++)
            {
                Vertice.Add(i, new List<int>());
            }
        }

        // Imprime o grafo (Vértice e arestas)
        public void ImprimeGrafo()
        {
            foreach (KeyValuePair<int, List<int>> i in Vertice)
            {
                Console.Write("\nVértice: " + i.Key + "\tArestas: ");

                foreach (int j in (i.Value as List<int>))
                {
                    Console.Write(j + "\t");
                }
            }
        }

        // Insere uma aresta no grafo. O procedimento recebe os vértices(v1, v2).
        public void InsereAresta(int V1, int V2)
        {
            string pesquisa = "\nUm dos vértices informados não exite. ";

            foreach (KeyValuePair<int, List<int>> i in Vertice)
            {
                if (Vertice.ContainsKey(V1) && Vertice.ContainsKey(V2))
                {
                    pesquisa = "";

                    if (V1.Equals(i.Key))
                    {
                        if (i.Value.Contains(V2))
                        {
                            Console.Write("\nEssa aresta já foi incluída. ");
                        }
                        else
                        {
                            i.Value.Add(V2);
                            Console.Write("\nAresta inserida com sucesso. ");
                        }
                    }
                }
            }
            Console.Write(pesquisa);
        }

        // Verifica se existe uma determinada aresta. A função retorna true se a aresta (v1, v2) está presente no grafo, senão retorna false.
        public bool Adjacentes(int V1, int V2)
        {
            bool pesquisa = false;

            foreach (KeyValuePair<int, List<int>> i in Vertice)
            {
                if (Vertice.ContainsKey(V1))
                {
                    foreach (int j in (i.Value as List<int>))
                    {
                        if (j.Equals(V2))
                        {
                            pesquisa = true;
                        }
                    }
                }
            }
            return pesquisa;
        }

        // Retira uma aresta do grafo. O procedimento retira a aresta(v1, v2) do grafo.
        public void retiraAresta(int V1, int V2)
        {
            bool pesquisa = false;

            if (Adjacentes(V1, V2))
            {
                foreach (KeyValuePair<int, List<int>> i in Vertice)
                {
                    if (V1.Equals(i.Key))
                    {
                        foreach (int j in (i.Value as List<int>))
                        {
                            if (j.Equals(V2))
                            {
                                pesquisa = true;
                            }
                        }
                    }

                    if (pesquisa)
                    {
                        (i.Value as List<int>).Remove(V2);
                        Console.Write("\nAresta removida com sucesso. ");
                    }
                }
            }
        }

        // Insere o vértice v no grafo.
        public void InsereVertice()
        {
            int aux = Vertice.Keys.Max();
            Vertice.Add((aux + 1), new List<int>());
            Console.Write("\nVértice " + (aux + 1) + " inserido com sucesso. ");
        }

        // Retira o vértice v do grafo.
        public void RetiraVertice(int v)
        {
            for (int i = 0; i < Vertice.Count; i++)
            {
                retiraAresta(i, v);
            }

            Vertice.Remove(v);

            Console.Write("\nVértice " + v + " removido com sucesso. ");
        }

        // Obtém a lista de vértices adjacentes ao vértice v
        public void ListaDeAdjacente(int chave)
        {


            string pesquisa = "Não encontrado.";

            foreach (KeyValuePair<int, List<int>> i in Vertice)
            {
                if (chave.Equals(i.Key))
                {
                    pesquisa = "";

                    Console.Write("\nVértice: " + i.Key + "\t");

                    Console.WriteLine();

                    foreach (int j in (i.Value as List<int>))
                    {
                        Console.Write("\n " + i.Key + "-" + j + "\t");
                        qtd_aresta = i.Key + j;
                    }
                }
            }


            Console.WriteLine(pesquisa);

        }

        public bool par(int v)
        {
            if((v) % 2 == 0 && (v) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool impar(int v)
        {
            if ((v) % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        //Ordem do vértice

        public void Exibe_Ordem(int qtd_vertice)
        {
            Console.WriteLine("A ordem do vértice é: " + qtdVertices);
        }

        public void Completo()
        {

            if (qtd_aresta < (qtdVertices * (qtdVertices - 1) / 2))
            {
                Console.Write("O grafo não é completo! \n");
            }
            else
            {
                if (qtd_aresta < qtdVertices * (qtdVertices - 1) / 2)
                {
                    Console.WriteLine("O grafo é completo! \n\n");
                }
            }

        }

        public bool Regular()
        {
            List<int> sequenciaG = new List<int>();

            foreach (KeyValuePair<int, List<int>> i in Vertice)
            {
                sequenciaG.Add((i.Key));
            }

            int grau = sequenciaG[0];

            foreach (int i in sequenciaG)
            {
                if (grau != i) ;
                return false;
            }

            return true;
        }

        public void Grau(int chave)
        {
            string pesquisa = "Não encontrado.";

            int count = 0;

            foreach (KeyValuePair<int, List<int>> i in Vertice)
            {
                if (chave.Equals(i.Key))
                {
                    pesquisa = "";

                    Console.Write("\nVértice: " + i.Key + "\t");

                    Console.WriteLine();

                    foreach (int j in (i.Value as List<int>))
                    {
                        Console.Write("\n " + i.Key + "-" + j + "\t\n");
                        count = i.Key + j;

                    }
                }
            }

            Console.WriteLine("\n O Grau do vértice é: " + count);
        }

        public void sequenciaG()
        {
            List<int> sequenciaGrau = new List<int>();
            foreach (KeyValuePair<int, List<int>> i  in Vertice)
            {
                sequenciaGrau.Add((i.Key));
                sequenciaGrau.Sort();
            }

            foreach (int grau in sequenciaGrau)
            {
                Console.WriteLine(" " + grau);
            }
        }
    }
}
