﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientAsync.ServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRef.ILiczbyPierwsze")]
    public interface ILiczbyPierwsze {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILiczbyPierwsze/GetPierwsze", ReplyAction="http://tempuri.org/ILiczbyPierwsze/GetPierwszeResponse")]
        int[] GetPierwsze(int rangeA, int rangeB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILiczbyPierwsze/GetPierwsze", ReplyAction="http://tempuri.org/ILiczbyPierwsze/GetPierwszeResponse")]
        System.Threading.Tasks.Task<int[]> GetPierwszeAsync(int rangeA, int rangeB);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILiczbyPierwszeChannel : ClientAsync.ServiceRef.ILiczbyPierwsze, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LiczbyPierwszeClient : System.ServiceModel.ClientBase<ClientAsync.ServiceRef.ILiczbyPierwsze>, ClientAsync.ServiceRef.ILiczbyPierwsze {
        
        public LiczbyPierwszeClient() {
        }
        
        public LiczbyPierwszeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LiczbyPierwszeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LiczbyPierwszeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LiczbyPierwszeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int[] GetPierwsze(int rangeA, int rangeB) {
            return base.Channel.GetPierwsze(rangeA, rangeB);
        }
        
        public System.Threading.Tasks.Task<int[]> GetPierwszeAsync(int rangeA, int rangeB) {
            return base.Channel.GetPierwszeAsync(rangeA, rangeB);
        }
    }
}
