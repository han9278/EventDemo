﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventDemoClient.ServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventType", Namespace="http://schemas.datacontract.org/2004/07/EventDemoService")]
    public enum EventType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Type1 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Type2 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Type3 = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AllEvents = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ISubscriptionContract", CallbackContract=typeof(EventDemoClient.ServiceReference.ISubscriptionContractCallback))]
    public interface ISubscriptionContract {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISubscriptionContract/FiringEvents")]
        void FiringEvents(EventDemoClient.ServiceReference.EventType events);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISubscriptionContract/FiringEvents")]
        System.Threading.Tasks.Task FiringEventsAsync(EventDemoClient.ServiceReference.EventType events);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionContract/Subscribe", ReplyAction="http://tempuri.org/ISubscriptionContract/SubscribeResponse")]
        void Subscribe(EventDemoClient.ServiceReference.EventType type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionContract/Subscribe", ReplyAction="http://tempuri.org/ISubscriptionContract/SubscribeResponse")]
        System.Threading.Tasks.Task SubscribeAsync(EventDemoClient.ServiceReference.EventType type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionContract/UnSubsctibe", ReplyAction="http://tempuri.org/ISubscriptionContract/UnSubsctibeResponse")]
        void UnSubsctibe(EventDemoClient.ServiceReference.EventType type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionContract/UnSubsctibe", ReplyAction="http://tempuri.org/ISubscriptionContract/UnSubsctibeResponse")]
        System.Threading.Tasks.Task UnSubsctibeAsync(EventDemoClient.ServiceReference.EventType type);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISubscriptionContractCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISubscriptionContract/Event1")]
        void Event1();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISubscriptionContract/Event2")]
        void Event2(int num);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISubscriptionContract/Event3")]
        void Event3(int num, string text);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISubscriptionContractChannel : EventDemoClient.ServiceReference.ISubscriptionContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubscriptionContractClient : System.ServiceModel.DuplexClientBase<EventDemoClient.ServiceReference.ISubscriptionContract>, EventDemoClient.ServiceReference.ISubscriptionContract {
        public SubscriptionContractClient(object callbackInstance) :
            base(callbackInstance)
        {
        } 
        public SubscriptionContractClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public SubscriptionContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public SubscriptionContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public SubscriptionContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public SubscriptionContractClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void FiringEvents(EventDemoClient.ServiceReference.EventType events) {
            base.Channel.FiringEvents(events);
        }
        
        public System.Threading.Tasks.Task FiringEventsAsync(EventDemoClient.ServiceReference.EventType events) {
            return base.Channel.FiringEventsAsync(events);
        }
        
        public void Subscribe(EventDemoClient.ServiceReference.EventType type) {
            base.Channel.Subscribe(type);
        }
        
        public System.Threading.Tasks.Task SubscribeAsync(EventDemoClient.ServiceReference.EventType type) {
            return base.Channel.SubscribeAsync(type);
        }
        
        public void UnSubsctibe(EventDemoClient.ServiceReference.EventType type) {
            base.Channel.UnSubsctibe(type);
        }
        
        public System.Threading.Tasks.Task UnSubsctibeAsync(EventDemoClient.ServiceReference.EventType type) {
            return base.Channel.UnSubsctibeAsync(type);
        }
    }
}
