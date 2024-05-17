using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_D_Milhas.Models
{
    [Table("promocoes")]
    public class Promocao
    {
        [Key]
        public int id { get; private set; }
        public string destino { get; private set; }
        public string imagem { get; private set; }
        public double preco { get; private set; }

        public Promocao(string destino, string imagem, double preco){
            this.destino = destino;
            this.imagem = imagem;
            this.preco = preco;
        }

    }
}