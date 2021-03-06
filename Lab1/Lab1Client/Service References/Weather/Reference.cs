﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab1Client.Weather {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Weather.Lab1WebServiceSoap")]
    public interface Lab1WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name WeatherResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Weather", ReplyAction="*")]
        Lab1Client.Weather.WeatherResponse Weather(Lab1Client.Weather.WeatherRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Weather", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab1Client.Weather.WeatherResponse> WeatherAsync(Lab1Client.Weather.WeatherRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WeatherRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Weather", Namespace="http://tempuri.org/", Order=0)]
        public Lab1Client.Weather.WeatherRequestBody Body;
        
        public WeatherRequest() {
        }
        
        public WeatherRequest(Lab1Client.Weather.WeatherRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class WeatherRequestBody {
        
        public WeatherRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WeatherResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WeatherResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab1Client.Weather.WeatherResponseBody Body;
        
        public WeatherResponse() {
        }
        
        public WeatherResponse(Lab1Client.Weather.WeatherResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WeatherResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string WeatherResult;
        
        public WeatherResponseBody() {
        }
        
        public WeatherResponseBody(string WeatherResult) {
            this.WeatherResult = WeatherResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Lab1WebServiceSoapChannel : Lab1Client.Weather.Lab1WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Lab1WebServiceSoapClient : System.ServiceModel.ClientBase<Lab1Client.Weather.Lab1WebServiceSoap>, Lab1Client.Weather.Lab1WebServiceSoap {
        
        public Lab1WebServiceSoapClient() {
        }
        
        public Lab1WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Lab1WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Lab1WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Lab1WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab1Client.Weather.WeatherResponse Lab1Client.Weather.Lab1WebServiceSoap.Weather(Lab1Client.Weather.WeatherRequest request) {
            return base.Channel.Weather(request);
        }
        
        public string Weather() {
            Lab1Client.Weather.WeatherRequest inValue = new Lab1Client.Weather.WeatherRequest();
            inValue.Body = new Lab1Client.Weather.WeatherRequestBody();
            Lab1Client.Weather.WeatherResponse retVal = ((Lab1Client.Weather.Lab1WebServiceSoap)(this)).Weather(inValue);
            return retVal.Body.WeatherResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab1Client.Weather.WeatherResponse> Lab1Client.Weather.Lab1WebServiceSoap.WeatherAsync(Lab1Client.Weather.WeatherRequest request) {
            return base.Channel.WeatherAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab1Client.Weather.WeatherResponse> WeatherAsync() {
            Lab1Client.Weather.WeatherRequest inValue = new Lab1Client.Weather.WeatherRequest();
            inValue.Body = new Lab1Client.Weather.WeatherRequestBody();
            return ((Lab1Client.Weather.Lab1WebServiceSoap)(this)).WeatherAsync(inValue);
        }
    }
}
