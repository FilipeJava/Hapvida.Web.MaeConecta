namespace Hapvida.Web.MaeConecta.Models
{
    public class Procedimentos
    {
        public int IdProcedimentos { get; set; }

        public Tipo Tipo { get; set; }

        public DateTime Data { get; set; }

        public Especialidade Especialidade { get; set; }


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
