using ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreiosWSDL.modelo
{
    public class Controle
    {
        public String mensagem;

        public Endereco pesquisarEndereco(String cep)
        {
            this.mensagem = "";
            AtendeClienteClient atendeCliente = new();
            Endereco endereco = new();
            try
            {
                Task<consultaCEPResponse> address = atendeCliente.consultaCEPAsync(cep);
                endereco.logradouro = address.Result.@return.end;
                endereco.bairro = address.Result.@return.bairro;
                endereco.cidade = address.Result.@return.cidade;
            }
            catch (System.Exception e)
            {
                this.mensagem = "CEP inválido";
            }
            return endereco;
        }
    }
}
