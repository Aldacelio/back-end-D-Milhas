using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_D_Milhas.Models
{
    [Table("companhias")]
    public class Companhia
    {

        [Key]
        public int id { get; private set; }
        public  string nome { get; private set; }

        public Companhia(string nome){
            this.id = id;
            this.nome = nome;
        }
        
    }
}