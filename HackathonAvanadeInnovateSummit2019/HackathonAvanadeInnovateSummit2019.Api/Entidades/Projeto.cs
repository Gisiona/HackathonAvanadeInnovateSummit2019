namespace HackathonAvanadeInnovateSummit2019.Api.Entidades
{
    public class Projeto: Base
    {
        public int IdProjeto { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int CodPostal { get; set; }

    }
}