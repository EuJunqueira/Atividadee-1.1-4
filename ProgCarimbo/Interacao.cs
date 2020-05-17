using System;
using System.Collections.Generic;
using System.Text;

namespace ProgCarimbo
{
    interface Interacao
    {
        void usar();
        void carregar(string Pcor, int Pcarga);
        void trocarCor(string Pcor);
        void trocarTexto(string Ptexto);
    }
}
