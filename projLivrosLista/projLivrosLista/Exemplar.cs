using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Exemplar
    {
        #region atributos
        private int tombo;
        private List<Emprestimo> emprestimos;
        #endregion

        #region propriedades
        public int Tombo { get => tombo; set => tombo = value; }
        public List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }
        #endregion

        #region construtores
        public Exemplar(int tombo)
        {
            this.Tombo = tombo;
            this.Emprestimos = new List<Emprestimo>();
        }
        #endregion

        #region metodos
        public bool emprestar()
        {
            if (this.disponivel())
            {
                this.Emprestimos.Add(new Emprestimo(DateTime.Now, new DateTime(0)));
                return true;
            }
            return false;
        }

        public bool devolver()
        {
            if (!this.disponivel())
            {
                this.Emprestimos[this.Emprestimos.Count - 1].DtDevolucao = DateTime.Now;
                return true;
            }
            return false;
        }

        public bool disponivel()
        {
            return (!((this.Emprestimos.Count > 0) && (this.Emprestimos[this.Emprestimos.Count - 1].DtDevolucao == DateTime.MinValue)));
        }

        public int qtdeEmprestimos()
        {
            return this.Emprestimos.Count;
        }

        public override bool Equals(Object obj)
        {
            if (obj.GetType() == this.GetType())
                return this.Tombo == ((Exemplar)obj).Tombo;
            return false;
        }
        #endregion
    }
}
