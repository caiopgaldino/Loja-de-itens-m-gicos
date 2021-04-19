using System;
using System.Collections.Generic;
namespace Loja_de_Itens_Mágicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancia da loja;
            Loja loja = new Loja();
            //A lista Catalogo adicionando os itens criados
            loja.Catalogo=Item.Criacao();
            int alt;
            Console.WriteLine("Entre com o nome do seu personagem"); 
            Person Pessoa = new Person(Console.ReadLine());
            Pessoa.Arsenal();
            Pessoa.ImprimirPessoa();
            Console.WriteLine("Agora a última etapa antes de jogarmos, compre itens, prepare-se antes sua primeira missão!!");
            do
            {

                Console.WriteLine("1: Comprar");
                Console.WriteLine("Qualquer outro número: Sair");
                alt = Convert.ToInt32(Console.ReadLine());
                if (alt == 1)
                {
                    int[] dupla;
                    dupla=Pessoa.Comprar(loja);
                    loja.Vender(dupla,Pessoa.Dindin);
                    
                }
                if (alt == 2)
                {
                    
                    
                }

            } while (alt == 1);
            Console.WriteLine("Você saiu da loja, começe sua jornada");
        }

    }
}
