using System;
using System.Collections.Generic;

namespace Loja_de_Itens_Mágicos
{
    public class Item
    {
        public String Nome;
        public Int32 Preco;
        public Int32 Quantidade;
        public String Descricao;
        public String Categoria;
        //definição de itens
        public Item(String Nome, int valor, int quantidade,string descricao,string categoria)
        {
            this.Nome = Nome;
            this.Preco = valor;
            this.Quantidade = quantidade;
            this.Descricao = descricao;
            this.Categoria = categoria;
        }
        // cria itens, a lista com esses itens é recebida pelo catálogo da loja
        public static List<Item> Criacao()
        {
            List<Item> Itens = new List<Item>();
            Item Palheta = new Item("Palheta do Dragão Vermelho",2000,1, "Um mítico item mágico, de poder imensurável","Mítco");
            Itens.Add(Palheta);

            Item Espadao = new Item("Espada matadora de Demônios",2000,100,"Só pode ser usado por nobres guerreiros","Épica");
            Itens.Add(Espadao);

            Item escudo = new Item("Escudo de matéria vermelha",500,100,"Defende tudo, mas causa dano ao usuário...","Lendário");
            Itens.Add(escudo);

            Item CapuzRabadon = new Item("Capuz de Rabadon",1500,100,"Provê habilidade mágica incomensurável ao usuário","Mítico");
            Itens.Add(CapuzRabadon);
            return Itens;
        }
    }
}