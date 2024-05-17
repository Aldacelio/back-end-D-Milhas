using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_D_Milhas.Models
{
    [Table("users")]
    public class User
    {
        public int id { get; private set; }
        public string nome { get; private set; }
        public DateTime nascimento { get; private set; }
        public string cpf { get; private set; }
        public string telefone { get; private set; }
        public string email { get; private set; }
        public string senha { get; private set; }
        public string genero { get; private set; }
        public string cidade { get; private set; }

        [ForeignKey("estadoId")]
        public Estado? estado { get; private set; }
        public int estadoId { get; private set; }
        public User(string nome, DateTime nascimento, string cpf, string telefone, string email, string senha, string genero, string cidade, int estadoId){
            this.nome = nome;
            this.nascimento = nascimento;
            this.cpf = cpf;
            this.telefone = telefone;
            this.email = email;
            this.senha = senha;
            this.genero = genero;
            this.cidade = cidade;
            this.estadoId = estadoId;
        }

    }
}