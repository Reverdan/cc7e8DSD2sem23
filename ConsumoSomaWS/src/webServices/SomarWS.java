/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package webServices;

/**
 *
 * @author Rever
 */
public class SomarWS
{

    public static String somar(java.lang.String num1, java.lang.String num2)
    {
        org.tempuri.Service1 service = new org.tempuri.Service1();
        org.tempuri.IService1 port = service.getBasicHttpBindingIService1();
        return port.somar(num1, num2);
    }
    
}
