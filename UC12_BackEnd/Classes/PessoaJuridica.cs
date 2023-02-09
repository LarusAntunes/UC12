using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UC12_BackEnd.Interfaces;

namespace UC12_BackEnd.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get;set;}

        public string? razaoSocial {get;set;}

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000 )
            {   
                float resultado = (rendimento/100) * 3;
                //ou 
                //float resultado = rendimento * .03f; (no caso 0.03 seria 3 por cento)
                return resultado;

            }   else if (rendimento > 3000 && rendimento <= 6000 )
            {
                float resultado = (rendimento / 100) * 5;
                return resultado;

            }   else if (rendimento > 6000 && rendimento <= 10000 )
            {
                float resultado = (rendimento / 100) * 7;
                return resultado;  

            }   else
            {
                float resultado = (rendimento / 100) * 9;
                return resultado;
            }
            
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}