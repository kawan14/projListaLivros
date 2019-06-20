  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Livro
    {
        #region atributos
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;
        #endregion

        #region propriedades
        public List<Exemplar> Exemplares { get { return this.exemplares; } }
        public int Isbn { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        #endregion

        #region construtores
        public Livro(int i) { this.Isbn = i; }

        public Livro(int i, string t, string a, string e)
        {
            this.Isbn = i;
            this.Titulo = t;
            this.Autor = a;
            this.Editora = e;
            this.exemplares = new List<Exemplar>();
        }
        #endregion

        #region metodos
        public void adicionarExemplar(Exemplar exemplar)
        {
            foreach (Exemplar exemp in this.exemplares)
                if (exemp.Equals(exemplar)) throw new Exception("Já existe um exemplar com este tombo.");
            this.exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
            return this.exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int disponiveis = 0;
            this.exemplares.ForEach(item => { if (item.disponivel()) disponiveis++; });
            return disponiveis;
        }

        public int qtdeEmprestimos()
        {
            int emprestados = 0;
            this.exemplares.ForEach(item => emprestados += item.qtdeEmprestimos());
            return emprestados;
        }

        public double percDisponibilidade()
        {
            double exemp = this.qtdeExemplares();
            double disp = this.qtdeDisponiveis();
            return (exemp == 0 || disp == 0) ? 0 : (disp / exemp) * 100;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
                return this.Isbn.Equals(((Livro)obj).Isbn);
            return false;
        }
        #endregion
    }
}
