using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UC12_BackEnd.Interfaces;

namespace UC12_BackEnd.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf {get;set;}

        public DateTime dataNasc {get;set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}