using System;
using System.Collections.Generic;
namespace Loja_de_Itens_Mágicos
{
    public class Loja
    {
        public List<Item> Catalogo = new List<Item>();
        //função da loja que atualiza o estoque de acordo com a compra
        public void Vender(int[]tripla, Double dindin)
        {
           
            if(tripla[1]==1 && tripla[2]<=Catalogo[tripla[0]].Quantidade && dindin>= tripla[2]*Catalogo[tripla[0]].Preco)
            {
                if(Catalogo[tripla[0]].Quantidade - tripla[2] ==0)
                {
                 Catalogo.Remove(Catalogo[tripla[0]]);
                }
               else
               {  
                Catalogo[tripla[0]].Quantidade -= tripla[2] ; 
               }
            }    
        }
        //mostra os itens ao usuário
        public void Mostruario()
        {
            Console.WriteLine("========================================");
            for (int i = 0; i < Catalogo.Count; i++)
            {
                Console.WriteLine("Nome: {0} Posição: {1}\r",Catalogo[i].Nome,i);
                Console.WriteLine("Descrição: {0}\r", Catalogo[i].Descricao);
                Console.WriteLine("Quantidade: {0}\r", Catalogo[i].Quantidade);
                Console.WriteLine("Categoria: {0}\r", Catalogo[i].Categoria);
                Console.WriteLine("Preço: {0} moedas\r", Catalogo[i].Preco);
                Console.WriteLine("========================================");
                Console.WriteLine("\r");
                
            }
            
        }
    }
}