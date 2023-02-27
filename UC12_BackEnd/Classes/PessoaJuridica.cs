using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

            //76773415000160 (14 dígitos)
            //76.773.415/0001-60 (18 dígitos)
        {
                                                    //está sendo comparado através do método Regex o valor informado do cnpj com o 
                                                    //padrão Regex, \d{14} informar a quantidade de digitos, no caso 14 dígitos
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2}) $");

            if (retornoCnpjValido) //ou podemos apagar o "== true" pois o comando já valida
            {   
                                            //Substring lê a parte interna do código
                string subStringCnpj14 = cnpj.Substring(8, 4); 
                                            //vai pular 8 digitos do cnpj e irá ler 4 digitos, no caso o 0001
                if (subStringCnpj14 == "0001")
                {
                    return true;
                }else return false;
            } 

            string subStringCnpj18 = cnpj.Substring(11, 4);

                if (subStringCnpj18 == "0001")
                {
                    return true;
                }

        return false;                           
        }
    }
}