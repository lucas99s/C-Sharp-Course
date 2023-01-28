using System;
using System.Collections.Generic;
using System.Text;

namespace _1_TiposReferenciaETtiposValor
{
    struct Ponto //Usando struct ao invés de apontar um endereço de memória, eles mesmos armazenarão os valores.
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return $"({x},{y})";
        }
    }

    //Class as variáveis são armazenadas por ponteiros de memória, já struct é com caixas.
}
