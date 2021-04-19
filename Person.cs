using System;
using System.Collections.Generic;
namespace Loja_de_Itens_Mágicos
{
    public class Person
    {
        public String Nome;
        public Double Dindin = 20000;
        public List<Item> Build = new List<Item>();
        public Person(String Name)
        { this.Nome = Name; }
        //cria um item inicial para o personagem
        public void Arsenal()
        {
            Item sword = new Item("Espada velha", 1500,1,"É velha mas ainda serve","Comum");
            Build.Add(sword);
        }
        //mostra os itens do funcionário
        public void ImprimirItens()
        {
            Console.WriteLine("Seus itens:");
            foreach(var item in this.Build)
            {
                Console.WriteLine("Nome: {0} Quantidade:{1} Categoria: {2}",item.Nome,item.Quantidade,item.Categoria);
            }
        }
        public void ImprimirPessoa()
        {
            string s;
            s=String.Format("Nome: {0}\n",this.Nome);
            s += String.Format("Moedas: {0}", this.Dindin);
            Console.WriteLine(s);
            ImprimirItens();
        }
        // função que permite o personagem comprar itens
        public int[] Comprar(Loja loja)
        {
            int alternativa;
            int posicao;
            int quant;
            loja.Mostruario();
            Console.WriteLine("Entre com a posição do item que você deseja comprar:");
            posicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com a quantidade que você deseja comprar:");
            quant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Comfirma que irá comprar {0}",loja.Catalogo[posicao].Nome);
            Console.WriteLine("Sim: 1");
            Console.WriteLine("Não: 2");
            alternativa = Convert.ToInt32(Console.ReadLine());
            if(alternativa==1)
            {
              if (this.Dindin>= quant*loja.Catalogo[posicao].Preco)
              {
                    if (loja.Catalogo[posicao].Quantidade >= quant)
                    {
                      this.Dindin -=loja.Catalogo[posicao].Preco;
                      Build.Add(loja.Catalogo[posicao]);
                      Build[Build.Count - 1].Quantidade = quant;
                      Console.WriteLine("Você adquiriu {0}x{1}!",quant, loja.Catalogo[posicao].Nome);
                      Console.WriteLine("Este é o seu novo saldo: {0}", this.Dindin);
                      Console.WriteLine("Esse é seu arsenal atual");
                      for (int i = 0; i < Build.Count; i++)
                      {   
                       Console.WriteLine("{0}   quantidade:{1}", Build[i].Nome, Build[i].Quantidade);
                       Console.WriteLine("========================================");
                      }
                    }
                    else
                    {
                     Console.WriteLine("Não é possível comprar essa quantidade, você pode comprar no máximo: {0}",loja.Catalogo[posicao].Quantidade);
                    }
              }
            else
            {
                Console.WriteLine("Você não tem dinheiro suficiente, faça missões para ganhar dinheiro");
            }
            }
            int [] tripla = new int[3] { posicao, alternativa,quant };
            return tripla ;
        }
    }
}