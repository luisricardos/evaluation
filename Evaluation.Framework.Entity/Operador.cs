using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluation.Framework.Entity
{
    public class Operador : IdentificadorBase
    {
        public bool Ativo { get; set; }

        public Decimal Percentual { get; set; }

        public Decimal Limite { get; set; }

        public string Praca { get; set; }
    }
}