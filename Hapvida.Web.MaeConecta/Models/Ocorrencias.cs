using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Hapvida.Web.MaeConecta.Models
{
    [Table("Tbl_ocorrencia")]
    public class Ocorrencias
    {
        [Column("id"), HiddenInput]
        public int OcorrenciasId { get; set; }

        [Required]
        public string? Titulo { get; set; }

        [Column("Dt_ocorrencia"), Display(Name = "Data da Ocorrencia"), DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required]
        public string? Descricao { get; set;}
    }
}
