using System;

namespace Aula27CriarExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo = 1;
            p.Nome = "Audi";
            p.Preco = 199.000f;

            p.Inserir(p);
        }
    }
}
