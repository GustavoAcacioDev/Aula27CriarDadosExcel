using System.IO;

namespace Aula27CriarExcel
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";

        /// <summary>
        /// Abre e fecha o Produto.csv
        /// </summary>
        public Produto()
        {

            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }
        
        /// <summary>
        /// Insere a linha que foi preparada no CSV
        /// </summary>
        /// <param name="p"></param>
        public void Inserir(Produto p){

            var linha = new string[] { p.PrepararLinhaCSV(p) };
            File.AppendAllLines(PATH, linha);
        }
        /// <summary>
        /// Prepara a linha a ser introduzida no arquivo CSV
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>Linha</returns>
        private string PrepararLinhaCSV(Produto produto){

            return $"codigo={produto.Codigo};nome={produto.Nome};preco={produto.Preco};";
        }
    }
}