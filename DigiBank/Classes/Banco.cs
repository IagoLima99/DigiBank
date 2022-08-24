using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public abstract class Banco
    {
        public Banco()
        {
            this.NomeDoBanco = "DigiBank";
            this.CodigoDoBanco = "0127";
        }

        public string NomeDoBanco { get; set; }
        public string CodigoDoBanco { get; private set; }


    }
}
