﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Calculadora_w.ServidorCalculadoraW {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Servicio/", ConfigurationName="ServidorCalculadoraW.WS_Test")]
    public interface WS_Test {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://Servicio/).
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/WS_Test/divideRequest", ReplyAction="http://Servicio/WS_Test/divideResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Calculadora_w.ServidorCalculadoraW.divideResponse divide(Calculadora_w.ServidorCalculadoraW.divideRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/WS_Test/divideRequest", ReplyAction="http://Servicio/WS_Test/divideResponse")]
        System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.divideResponse> divideAsync(Calculadora_w.ServidorCalculadoraW.divideRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://Servicio/).
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/WS_Test/restaRequest", ReplyAction="http://Servicio/WS_Test/restaResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Calculadora_w.ServidorCalculadoraW.restaResponse resta(Calculadora_w.ServidorCalculadoraW.restaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/WS_Test/restaRequest", ReplyAction="http://Servicio/WS_Test/restaResponse")]
        System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.restaResponse> restaAsync(Calculadora_w.ServidorCalculadoraW.restaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://Servicio/).
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/WS_Test/multiplicaRequest", ReplyAction="http://Servicio/WS_Test/multiplicaResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Calculadora_w.ServidorCalculadoraW.multiplicaResponse multiplica(Calculadora_w.ServidorCalculadoraW.multiplicaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/WS_Test/multiplicaRequest", ReplyAction="http://Servicio/WS_Test/multiplicaResponse")]
        System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.multiplicaResponse> multiplicaAsync(Calculadora_w.ServidorCalculadoraW.multiplicaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://Servicio/).
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/WS_Test/sumaRequest", ReplyAction="http://Servicio/WS_Test/sumaResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Calculadora_w.ServidorCalculadoraW.sumaResponse suma(Calculadora_w.ServidorCalculadoraW.sumaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/WS_Test/sumaRequest", ReplyAction="http://Servicio/WS_Test/sumaResponse")]
        System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.sumaResponse> sumaAsync(Calculadora_w.ServidorCalculadoraW.sumaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="divide", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class divideRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public float num1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public float num2;
        
        public divideRequest() {
        }
        
        public divideRequest(float num1, float num2) {
            this.num1 = num1;
            this.num2 = num2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="divideResponse", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class divideResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public float @return;
        
        public divideResponse() {
        }
        
        public divideResponse(float @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="resta", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class restaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int num1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public int num2;
        
        public restaRequest() {
        }
        
        public restaRequest(int num1, int num2) {
            this.num1 = num1;
            this.num2 = num2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="restaResponse", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class restaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int @return;
        
        public restaResponse() {
        }
        
        public restaResponse(int @return) {
            this.@return = @return;
        }

        public static implicit operator restaResponse(sumaRequest v)
        {
            throw new NotImplementedException();
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="multiplica", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class multiplicaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public float num1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public float num2;
        
        public multiplicaRequest() {
        }
        
        public multiplicaRequest(float num1, float num2) {
            this.num1 = num1;
            this.num2 = num2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="multiplicaResponse", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class multiplicaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public float @return;
        
        public multiplicaResponse() {
        }
        
        public multiplicaResponse(float @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="suma", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class sumaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int num1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public int num2;
        
        public sumaRequest() {
        }
        
        public sumaRequest(int num1, int num2) {
            this.num1 = num1;
            this.num2 = num2;
        }

        internal int suma(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public static implicit operator sumaRequest(sumaResponse v)
        {
            throw new NotImplementedException();
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sumaResponse", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class sumaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int @return;
        
        public sumaResponse() {
        }
        
        public sumaResponse(int @return) {
            this.@return = @return;
        }

        public static implicit operator sumaResponse(sumaRequest v)
        {
            throw new NotImplementedException();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WS_TestChannel : Calculadora_w.ServidorCalculadoraW.WS_Test, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WS_TestClient : System.ServiceModel.ClientBase<Calculadora_w.ServidorCalculadoraW.WS_Test>, Calculadora_w.ServidorCalculadoraW.WS_Test {
        
        public WS_TestClient() {
        }
        
        public WS_TestClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WS_TestClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_TestClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_TestClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Calculadora_w.ServidorCalculadoraW.divideResponse Calculadora_w.ServidorCalculadoraW.WS_Test.divide(Calculadora_w.ServidorCalculadoraW.divideRequest request) {
            return base.Channel.divide(request);
        }
        
        public float divide(float num1, float num2) {
            Calculadora_w.ServidorCalculadoraW.divideRequest inValue = new Calculadora_w.ServidorCalculadoraW.divideRequest();
            inValue.num1 = num1;
            inValue.num2 = num2;
            Calculadora_w.ServidorCalculadoraW.divideResponse retVal = ((Calculadora_w.ServidorCalculadoraW.WS_Test)(this)).divide(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.divideResponse> Calculadora_w.ServidorCalculadoraW.WS_Test.divideAsync(Calculadora_w.ServidorCalculadoraW.divideRequest request) {
            return base.Channel.divideAsync(request);
        }
        
        public System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.divideResponse> divideAsync(float num1, float num2) {
            Calculadora_w.ServidorCalculadoraW.divideRequest inValue = new Calculadora_w.ServidorCalculadoraW.divideRequest();
            inValue.num1 = num1;
            inValue.num2 = num2;
            return ((Calculadora_w.ServidorCalculadoraW.WS_Test)(this)).divideAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Calculadora_w.ServidorCalculadoraW.restaResponse Calculadora_w.ServidorCalculadoraW.WS_Test.resta(Calculadora_w.ServidorCalculadoraW.restaRequest request) {
            return base.Channel.resta(request);
        }
        
        public int resta(int num1, int num2) {
            Calculadora_w.ServidorCalculadoraW.restaRequest inValue = new Calculadora_w.ServidorCalculadoraW.restaRequest();
            inValue.num1 = num1;
            inValue.num2 = num2;
            Calculadora_w.ServidorCalculadoraW.restaResponse retVal = ((Calculadora_w.ServidorCalculadoraW.WS_Test)(this)).resta(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.restaResponse> Calculadora_w.ServidorCalculadoraW.WS_Test.restaAsync(Calculadora_w.ServidorCalculadoraW.restaRequest request) {
            return base.Channel.restaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.restaResponse> restaAsync(int num1, int num2) {
            Calculadora_w.ServidorCalculadoraW.restaRequest inValue = new Calculadora_w.ServidorCalculadoraW.restaRequest();
            inValue.num1 = num1;
            inValue.num2 = num2;
            return ((Calculadora_w.ServidorCalculadoraW.WS_Test)(this)).restaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Calculadora_w.ServidorCalculadoraW.multiplicaResponse Calculadora_w.ServidorCalculadoraW.WS_Test.multiplica(Calculadora_w.ServidorCalculadoraW.multiplicaRequest request) {
            return base.Channel.multiplica(request);
        }
        
        public float multiplica(float num1, float num2) {
            Calculadora_w.ServidorCalculadoraW.multiplicaRequest inValue = new Calculadora_w.ServidorCalculadoraW.multiplicaRequest();
            inValue.num1 = num1;
            inValue.num2 = num2;
            Calculadora_w.ServidorCalculadoraW.multiplicaResponse retVal = ((Calculadora_w.ServidorCalculadoraW.WS_Test)(this)).multiplica(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.multiplicaResponse> Calculadora_w.ServidorCalculadoraW.WS_Test.multiplicaAsync(Calculadora_w.ServidorCalculadoraW.multiplicaRequest request) {
            return base.Channel.multiplicaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.multiplicaResponse> multiplicaAsync(float num1, float num2) {
            Calculadora_w.ServidorCalculadoraW.multiplicaRequest inValue = new Calculadora_w.ServidorCalculadoraW.multiplicaRequest();
            inValue.num1 = num1;
            inValue.num2 = num2;
            return ((Calculadora_w.ServidorCalculadoraW.WS_Test)(this)).multiplicaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Calculadora_w.ServidorCalculadoraW.sumaResponse Calculadora_w.ServidorCalculadoraW.WS_Test.suma(Calculadora_w.ServidorCalculadoraW.sumaRequest request) {
            return base.Channel.suma(request);
        }
        
        public int suma(int num1, int num2) {
            Calculadora_w.ServidorCalculadoraW.sumaRequest inValue = new Calculadora_w.ServidorCalculadoraW.sumaRequest();
            inValue.num1 = num1;
            inValue.num2 = num2;
            Calculadora_w.ServidorCalculadoraW.sumaResponse retVal = ((Calculadora_w.ServidorCalculadoraW.WS_Test)(this)).suma(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.sumaResponse> Calculadora_w.ServidorCalculadoraW.WS_Test.sumaAsync(Calculadora_w.ServidorCalculadoraW.sumaRequest request) {
            return base.Channel.sumaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Calculadora_w.ServidorCalculadoraW.sumaResponse> sumaAsync(int num1, int num2) {
            Calculadora_w.ServidorCalculadoraW.sumaRequest inValue = new Calculadora_w.ServidorCalculadoraW.sumaRequest();
            inValue.num1 = num1;
            inValue.num2 = num2;
            return ((Calculadora_w.ServidorCalculadoraW.WS_Test)(this)).sumaAsync(inValue);
        }
    }
}