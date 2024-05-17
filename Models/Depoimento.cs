using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_D_Milhas.Models
{
    [Table("depoimentos")]
    public class Depoimento
    {
        [Key]
        public int id { get; private set; }
        public string texto { get; private set; }
        public string autor {get; private set; }
        public string avatar {get; private set;}

        public Depoimento(string texto, string autor, string avatar){
            this.texto = texto;
            this.autor = autor;
            this.avatar = avatar;
        }
    }
}