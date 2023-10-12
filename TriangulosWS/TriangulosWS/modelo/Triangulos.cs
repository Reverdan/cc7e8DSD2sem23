using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangulosWS.modelo
{
    public class Triangulos
    {
        public String verificarTriângulo(int l1, int l2, int l3)
        {
            String resposta = "";
            if (l1 == l2 && l2 == l3)
                resposta = "Triângulo equilátero";
            else
            {
                if (l1 != l2 && l2 != l3 && l1 != l3)
                    resposta = "Triângulo escaleno";
                else
                    resposta = "Triângulo isósceles";
            }
            return resposta;  
        }
    }
}