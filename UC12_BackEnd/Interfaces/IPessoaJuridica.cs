using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC12_BackEnd.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string cnpj);
    }
}