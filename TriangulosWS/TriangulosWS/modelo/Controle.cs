using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangulosWS.modelo
{
    public class Controle
    {
        public String mensagem;

        public String executar(String lado1, String lado2, String lado3)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.validar(lado1, lado2, lado3);
            if (validacao.mensagem.Equals(""))
            {
                Triangulos triangulos = new Triangulos();
                this.mensagem = triangulos.verificarTriângulo(validacao.l1, validacao.l2, validacao.l3);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return mensagem;
        }
    }
}