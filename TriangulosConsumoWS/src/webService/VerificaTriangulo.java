/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package webService;

/**
 *
 * @author Rever
 */
public class VerificaTriangulo
{

    public static String verificaTriangulo(java.lang.String lado1, java.lang.String lado2, java.lang.String lado3)
    {
        org.tempuri.Service1 service = new org.tempuri.Service1();
        org.tempuri.IService1 port = service.getBasicHttpBindingIService1();
        return port.verificaTriangulo(lado1, lado2, lado3);
    }
    
}
