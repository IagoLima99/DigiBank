using DigiBank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public abstract class Conta : Banco, IConta
    {

        public Conta()
        {

        }

        public double Saldo { get; protected set; }
        public string NumeroAgencia { get; private set; }
        public string CodigoBanco { get; private set; }

        public double ConsultaSaldo()
        {
            return this.Saldo;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > this.Saldo)
                return false;

            this.Saldo -= valor;
            return true;
        }

        public string GetCodigoDoBanco()
        {
            throw new NotImplementedException();
        }

        public string GetNumeroDaAgenncia()
        {
            throw new NotImplementedException();
        }

        public string GetNumeroDaConta()
        {
            throw new NotImplementedException();
        }

        
    }
}
