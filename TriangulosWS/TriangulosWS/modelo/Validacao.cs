using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangulosWS.modelo
{
    public class Validacao
    {
        public int l1;
        public int l2;
        public int l3;
        public String mensagem;

        public void validar(String lado1, String lado2, String lado3)
        {
            this.mensagem = "";
            try
            {
                this.l1 = Convert.ToInt32(lado1);
                this.l2 = Convert.ToInt32(lado2);
                this.l3 = Convert.ToInt32(lado3);
                if (l1 + l2 <= l3 ||
                    l1 + l3 <= l2 ||
                    l2 + l3 <= l1)
                {
                    this.mensagem = "Não é um triângulo";
                }
            }
            catch (Exception e)
            {
                this.mensagem = "Valores inválidos";
            }
        }
    }
}