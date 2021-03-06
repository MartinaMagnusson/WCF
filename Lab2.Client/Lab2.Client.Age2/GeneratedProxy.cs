﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:4.0.30319.42000
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://Lab2.Service.Age", ConfigurationName="IDays")]
public interface IDays
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Lab2.Service.Age/IDays/GetAge", ReplyAction="http://Lab2.Service.Age/IDays/GetAgeResponse")]
    string GetAge(System.DateTime birthday);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Lab2.Service.Age/IDays/GetAge", ReplyAction="http://Lab2.Service.Age/IDays/GetAgeResponse")]
    System.Threading.Tasks.Task<string> GetAgeAsync(System.DateTime birthday);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IDaysChannel : IDays, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class DaysClient : System.ServiceModel.ClientBase<IDays>, IDays
{
    
    public DaysClient()
    {
    }
    
    public DaysClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public DaysClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public DaysClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public DaysClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string GetAge(System.DateTime birthday)
    {
        return base.Channel.GetAge(birthday);
    }
    
    public System.Threading.Tasks.Task<string> GetAgeAsync(System.DateTime birthday)
    {
        return base.Channel.GetAgeAsync(birthday);
    }
}
