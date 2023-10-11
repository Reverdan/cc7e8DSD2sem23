using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomaWS.modelo
{
    public class Controle
    {
        public String executar(String num1, String num2)
        {
            String resposta = "";
            Validacao validacao = new Validacao();
            validacao.validar(num1, num2);
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                resposta = calculos.somar(validacao.n1, validacao.n2);
            }
            else
            {
                resposta = validacao.mensagem;
            }
            return resposta;
        }
    }
}