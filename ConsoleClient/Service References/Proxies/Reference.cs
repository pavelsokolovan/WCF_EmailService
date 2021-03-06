﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleClient.Proxies {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Proxies.IEmailValidator")]
    public interface IEmailValidator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailValidator/ValiddateAdress", ReplyAction="http://tempuri.org/IEmailValidator/ValiddateAdressResponse")]
        bool ValiddateAdress(string emailAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailValidator/ValiddateAdress", ReplyAction="http://tempuri.org/IEmailValidator/ValiddateAdressResponse")]
        System.Threading.Tasks.Task<bool> ValiddateAdressAsync(string emailAddress);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmailValidatorChannel : ConsoleClient.Proxies.IEmailValidator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmailValidatorClient : System.ServiceModel.ClientBase<ConsoleClient.Proxies.IEmailValidator>, ConsoleClient.Proxies.IEmailValidator {
        
        public EmailValidatorClient() {
        }
        
        public EmailValidatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmailValidatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailValidatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailValidatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ValiddateAdress(string emailAddress) {
            return base.Channel.ValiddateAdress(emailAddress);
        }
        
        public System.Threading.Tasks.Task<bool> ValiddateAdressAsync(string emailAddress) {
            return base.Channel.ValiddateAdressAsync(emailAddress);
        }
    }
}
