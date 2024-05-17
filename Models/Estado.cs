using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_D_Milhas.Models
{
    [Table("estados")]
    public class Estado
    {
        [Key]
        public int id {get; private set;}
        public string nome {get; private set;}
        public string sigla {get; private set;}

        public Estado(string nome, string sigla){
            this.nome = nome;
            this.sigla = sigla;
        }
    }
}