package webService;

import br.com.correios.bsb.sigep.master.bean.cliente.EnderecoERP;
import br.com.correios.bsb.sigep.master.bean.cliente.SQLException_Exception;
import br.com.correios.bsb.sigep.master.bean.cliente.SigepClienteException;
import java.util.logging.Level;
import java.util.logging.Logger;
import modelo.Endereco;

public class webServiceCorreios
{
    public String mensagem;
    public Endereco consultarCEP(String cep)
    {
        this.mensagem = "";
        Endereco endereco = new Endereco();
        try
        {
            EnderecoERP end = consultaCEP(cep);
            endereco.logradouro = end.getEnd();
            endereco.bairro = end.getBairro();
            endereco.cidade = end.getCidade();
        }
        catch (SigepClienteException ex)
        {
            this.mensagem = "CEP inválido";
        }
        catch (SQLException_Exception ex)
        {
            this.mensagem = "Erro de conexão";
        }
        return endereco;
    }
    
    
    private static EnderecoERP consultaCEP(java.lang.String cep) throws SigepClienteException, SQLException_Exception
    {
        br.com.correios.bsb.sigep.master.bean.cliente.AtendeClienteService service = new br.com.correios.bsb.sigep.master.bean.cliente.AtendeClienteService();
        br.com.correios.bsb.sigep.master.bean.cliente.AtendeCliente port = service.getAtendeClientePort();
        return port.consultaCEP(cep);
    }
    
}
