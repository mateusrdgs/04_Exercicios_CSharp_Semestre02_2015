using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplicationHenriqueOliveira
{
    class Endereco
    {
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;

        #region métodos Get
        public string getRua()
        {
            return rua;
        }
        public string getNumero()
        {
            return numero;
        }
        public string getBairro()
        {
            return bairro;
        }
        public string getCidade()
        {
            return cidade;
        }
        public string getEstado()
        {
            return estado;
        }
        #endregion

        #region métodos Set
        public void setRua(string rua)
        {
            this.rua = rua;
        }
        public void setNumero(string numero)
        {
            this.numero = numero;
        }
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }
        #endregion
    }
}
