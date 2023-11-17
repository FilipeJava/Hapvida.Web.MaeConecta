using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Hapvida.Web.MaeConecta.Models
{

    [Table("Tbl_procedimento")]
    public class Procedimentos
    {
        [Column("id"), HiddenInput]
        public int ProcedimentosId { get; set; }

        [Column("Ds_tipo"), Required, Display(Name = "Tipo Do Procedimento")]
        public Tipo Tipo { get; set; }

        [Column("Ds_especialidade"), Required, Display(Name = "Especialidade")]
        public Especialidade Especialidade { get; set; }

        [Column("Dt_procedimento"), Display(Name = "Data do Procedimento"), DataType(DataType.DateTime)]
        public DateTime Data { get; set; }

       


    }

    public enum Tipo
    {
        Consulta,Exames
    }

    public enum Especialidade
    {
        Obstetricia, Ginecologia,
        Neonatologia, Perinatologia,
        EndocrinologiaObstetrica,
        CardiologiaObstetrica,
        Ultrassonografia,Sangue,
        Glicose, EstresseFetal,
        Amniocentese, Cardiotocografia,
        Dopplerfluxometria, Ecocardiografia

    }

}
