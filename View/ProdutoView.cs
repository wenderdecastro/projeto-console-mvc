using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_console_mvc.Model;

namespace projeto_console_mvc.View
{
    public class ProdutoView
    {
        //metodo para exibir os dados da lista de produtos
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}\nNome: {item.Nome}\nPreço: {item.Preco:C}");
            }
        }
        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Informe o nome");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preço");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
        }
    }
}