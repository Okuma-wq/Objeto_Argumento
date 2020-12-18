using System;
using System.Collections.Generic;

namespace ObjetoArgumento.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto _produto){
            carrinho.Add(_produto);
        }

        public void MostrarProduto(){
            if(carrinho != null){
                foreach (Produto item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }

        public void RemoverProduto(Produto _produto){
            carrinho.Remove(_produto);
        }
        
        public void MostrarTotal(){
            ValorTotal = 0;
            if (carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    ValorTotal += item.Preco;
                }
                Console.WriteLine($"O total do carrinho é: {ValorTotal.ToString("C")}");
            } else{
                Console.WriteLine("Seu carrinho está vazio!");
            }
        }

        public void AlterarItem(int _codigo_procurado, Produto _novoProduto){
            carrinho.Find(produto => produto.Codigo == _codigo_procurado).Nome = _novoProduto.Nome;
            carrinho.Find(produto => produto.Codigo == _codigo_procurado).Preco = _novoProduto.Preco;
        }
        
    }
}