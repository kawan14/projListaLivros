using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Livros
    {
        #region atributos
        private List<Livro> acervo;
        #endregion

        #region propriedades
        public List<Livro> Acervo { get { return this.acervo; } }
        #endregion

        #region construtores

        public Livros()
        {
            this.acervo = new List<Livro>();
        }
        #endregion

        #region metodos
        public void adicionar(Livro livro)
        {
            if (this.pesquisar(livro) != null) throw new Exception("Já existe um livro com esse ISBN.");
            this.acervo.Add(livro);
        }

        public Livro pesquisar(Livro livro)
        {
            return this.acervo.FirstOrDefault(item => item.Equals(livro));
        }
        #endregion
    }
}
