using System;

namespace HackathonAvanadeInnovateSummit2019.Api.Entidades
{
    public abstract class Base
    {
        public Guid Id { get; private set; }
        public DateTime Date { get; private set; }

        public Base()
        {
            Id = Guid.NewGuid();
            Date = new DateTime();
        }
    }
}
