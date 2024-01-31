using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class ListaDeLivros
    {
        List<Livros> LivrosLista;

        public ListaDeLivros()
        {
            LivrosLista = new List<Livros> ();
        }

        public void CadastraLivro(Livros livro)
        {
            LivrosLista.Add(livro);
        }

        public List<Livros> Lista() {
            return LivrosLista;
        }

        public List<Livros> GetLivros()
        {
            return LivrosLista;
        }
    }
}
