package Servicio;

import static java.lang.Double.NaN;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Unicomfacauca
 */
@WebService(serviceName = "WS_Test")
public class WS_Test {

    /**
     * This is a sample web service operation
     */
        
    @WebMethod(operationName = "suma")
    public int suma(@WebParam(name = "num1") int num1,@WebParam(name = "num2") int num2) {
    int resultado = num1 + num2;
    return  resultado;
    }
    
    @WebMethod(operationName = "resta")
    public int resta(@WebParam(name = "num1") int num1,@WebParam(name = "num2") int num2) {
    int resultado = num1 - num2;
    return  resultado;
    }
    
    @WebMethod(operationName = "multiplica")
    public float multiplica(@WebParam(name = "num1") float num1,@WebParam(name = "num2") float num2) {
    float resultado = num1 * num2;
    return  resultado;
    }
    
    @WebMethod(operationName = "divide")
    public float divide(@WebParam(name = "num1") float num1,@WebParam(name = "num2") float num2) {
     

    if(num2==0)
    return (float) NaN;
    
        float resultado = num1 / num2;
        return resultado;
     
    }
        
    
      
}
 