﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://microsoft.wcf.documentation", ConfigurationName="IStatefulService", SessionMode=System.ServiceModel.SessionMode.Required)]
public interface IStatefulService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.wcf.documentation/IStatefulService/GetSessionID", ReplyAction="http://microsoft.wcf.documentation/IStatefulService/GetSessionIDResponse")]
    string GetSessionID();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IStatefulServiceChannel : IStatefulService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class StatefulServiceClient : System.ServiceModel.ClientBase<IStatefulService>, IStatefulService
{
    
    public StatefulServiceClient()
    {
    }
    
    public StatefulServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public StatefulServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public StatefulServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public StatefulServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string GetSessionID()
    {
        return base.Channel.GetSessionID();
    }
}
