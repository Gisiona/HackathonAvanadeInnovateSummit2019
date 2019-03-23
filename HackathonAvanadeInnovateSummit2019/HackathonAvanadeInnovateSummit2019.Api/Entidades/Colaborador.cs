using System;

namespace HackathonAvanadeInnovateSummit2019.Api.Entidades
{
    public class Colaborador: Base
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime DataContratacao { get; private set; }
        public virtual Projeto Projeto { get; set; }
        public virtual Empresa Empresa { get; set; }

    }
}
