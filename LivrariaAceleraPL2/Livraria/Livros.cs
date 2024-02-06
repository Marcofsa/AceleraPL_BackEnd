using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Livraria
{
    [Table("Livro")]
    public class Livros
    {
        /// <summary>
        /// Nome do Livro
        /// </summary>
        public string Livro { get; set; }
        /// <summary>
        /// Quantidade de Páginas
        /// </summary>
        [Column("PG")]
        public int Paginas { get; set; }

        /// <summary>
        /// CODIGO ISBN (International Standard Book Number)
        /// </summary>
        [Key]
        [Column("COD")]
        public int Codigo { get; set; }
        /// <summary>
        /// Valor do Livro em Reais (BRL)
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Construtor para Livro padrão 
        /// </summary>
        /// <param name="livro">Nome do Livro</param>
        /// <param name="paginas">Numero de Paginas</param>
        /// <param name="codigo">Código ISBN</param>
        /// <param name="valor"> Preço (BRL)</param>
        public Livros(string livro, int paginas, int codigo, decimal valor)
        {
            Livro = livro;
               
            Paginas = paginas;

            Codigo = codigo;

            Valor = valor;
        }

        public override string ToString()
        {
            return Livro;
        }

        public static Livros LivroFromCsv(string csvLine)
        {
            string[] campos = csvLine.Split(' ');
            if (campos.Length <= 1 )
            {
                throw new Exception("O arquivo não contém campos suficientes");
            }
            Livros livrosCSV = new Livros(campos[0], int.Parse(campos[1]), int.Parse(campos[2]), int.Parse(campos[3]));
            return livrosCSV;
        }

    }
}
