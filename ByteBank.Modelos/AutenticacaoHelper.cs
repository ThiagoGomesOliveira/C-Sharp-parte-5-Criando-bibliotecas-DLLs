using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
   class AutenticacaoHelper
    {

        public bool CompararSenha(string pSenhaVerdadeira, string pSenhaAlternativa)
        {
            return pSenhaAlternativa == pSenhaVerdadeira;
        }

    }
}
