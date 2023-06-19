using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09ProdutoSegQua
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> produtos = new List<string> { "Pepse", "Fanta" };
            


            Console.WriteLine("Bem-vindo ao Conradito Store");
            Console.WriteLine("Digite 1 para cadastrar ou 2 para listar");
            string resposta = Console.ReadLine();

            if(resposta == "1")
            {

                Console.WriteLine("Digite o nome do produto");
                
                
                string produto = Console.ReadLine();
                produto = produto.Substring(0, 1).ToUpper();
                


                if(produtos.Contains(produto ) )
                {
                    Console.WriteLine("esse produto já esta na lista...");
                }
                else
                {

                    produtos.Add(produto);
                    Console.WriteLine("Produto adicionado!");
                }

               



            }

            else
            {
                string texto = "";
                int contador = 0;
                while( contador < produtos.Count)
                {

                    texto += produtos[contador] + ",";

                    //

                    contador++;

                }

                string nome = produtos[contador];
                string primeira_letra = nome.Substring(0, 1).ToUpper();
                string resto = nome.Substring(1, nome.Length - 1);
                string nome_tratado = primeira_letra + resto;

                texto.Substring(0, texto.Length - 2);
                



                Console.WriteLine( texto );
            }

           
           

        } 


    }
}
