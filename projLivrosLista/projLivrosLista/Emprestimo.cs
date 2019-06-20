using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Emprestimo
    {
        #region atributos
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;
        #endregion

        #region propriedades
        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
        #endregion

        #region construtores
        public Emprestimo(DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            this.DtEmprestimo = dataEmprestimo;
            this.DtDevolucao = dataDevolucao;
        }
        #endregion
    }
}
