using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomaWS.modelo
{
    public class Validacao
    {
        public Double n1;
        public Double n2;
        public String mensagem;

        public void validar(String num1, String num2)
        {
            this.mensagem = "";
            num1 = num1.Replace(".", ",");
            num2 = num2.Replace(".", ",");
            try
            {
                this.n1 = Convert.ToDouble(num1);
                this.n2 = Convert.ToDouble(num2);
            }
            catch (FormatException e)
            {
                this.mensagem = "Números inválidos";
            }
        }
    }
}