using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2_Personalidade.Models
{
    public class Personalidade
    {
        private long _id;
        private string _nome;
        private DateTime _nascimento;
        private string _sexo;

        /// <summary>
        /// Tipo Long
        /// </summary>
        public long Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public DateTime Nascimento { get => _nascimento; set => _nascimento = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }

        public string AsString()
            => "Personalidade: [Id: " + Id.ToString() + ", Nome: " + Nome + ", Nascimento: " + Nascimento.ToString() + ", Sexo: " + Sexo + "]";
    }
}