using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplicationHenriqueOliveira
{
    class Funcionario
    {
        public Endereco endereco = new Endereco();
        private string nome;
        private string CPF;
        private string dataNasc;
        private string telefone;

        #region métodos Get
        public string getNome()
        {
            return nome;
        }
        public string getCPF()
        {
            return CPF;
        }
        public string getDataNasc()
        {
            return dataNasc;
        }
        public string getTelefone()
        {
            return telefone;
        }
        #endregion

        #region métodos Set
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }

        public void setDataNasc(string dataNasc)
        {
            this.dataNasc = dataNasc;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        #endregion
    }
}
