using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace back_end_D_Milhas.Models
{
    [Table("passagens")]
    public class Passagem
    {
        
        [Key]
        public int id { get; private set; }

        public string tipo { get; private set; }

        public int precoIda { get; private set; }

        public int precoVolta { get; private set; }

        public int taxaEmbarque { get; private set; }

        public int conexoes { get; private set; }

        public int tempoVoo { get; private set; }

        [ForeignKey("origemId")]
        public Estado? origem { get; private set; }

        [ForeignKey("destinoId")]
        public Estado? destino { get; private set; }

        [ForeignKey("companhiaId")]
        public Companhia? companhia { get; private set; }

        public int origemId { get; private set; }
        public int destinoId { get; private set; }
        public int companhiaId { get; private set; }

        public Passagem(string tipo, int precoIda, int precoVolta, int taxaEmbarque, int conexoes, int tempoVoo, int origemId, int destinoId, int companhiaId){
            this.tipo = tipo;
            this.precoIda = precoIda;
            this.precoVolta = precoVolta;
            this.taxaEmbarque = taxaEmbarque;
            this.conexoes = conexoes;
            this.tempoVoo = tempoVoo;
            this.origemId = origemId;
            this.destinoId = destinoId;
            this.companhiaId = companhiaId;
        }

    }
}