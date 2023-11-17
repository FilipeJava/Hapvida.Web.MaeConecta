using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Hapvida.Web.MaeConecta.Models
{
    [Table("Tbl_usuario")]
    public class Usuario
    {
        [Column("id"),HiddenInput]
        public int UsuarioId { get; set; }

        [Required,MaxLength(100)]
        public string? Nome { get; set; }
        [Required]
        public int Idade { get; set;}

        [Required]
        public int SemanaGestacao { get; set;}
        [Required, EmailAddress]
        public string? Email { get; set;}
        [Required]
        public string? Senha { get; set; }
        [Column("Tp_Sangue"),Required,Display(Name ="Tipo Sanguineo")]
        public TipoSanguineo TipoSanguineo { get; set; }
        [Column("Dt_Cadastro"),Display(Name ="Data de Cadastro"), DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; }


        //1:1
        public Endereco Endereco { get; set; }

        public int EnderecoId { get; set; }

        //1:N

        public IList<Ocorrencias> Ocorrencias { get; set;}

        public IList<Contatos> Contatos { get; set; }



    }

    public enum TipoSanguineo
    {
        APositivo, ANegativo,
        BPositivo, BNegativo,
        OPositivo, ONegativo,
        ABPositivo, ABNegativo
    }
}
