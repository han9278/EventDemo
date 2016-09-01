using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EventDemoService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract(CallbackContract=typeof(IEvent))]
    public interface ISubscriptionContract
    {
        [OperationContract(IsOneWay=true)]
        void FiringEvents(EventType events);

        [OperationContract]
        void Subscribe(EventType type);

        [OperationContract]
        void UnSubsctibe(EventType type);
    }

    public enum EventType
    {
        Type1 = 1,
        Type2 = 2,
        Type3 = 3,
        AllEvents = Type1 | Type2 | Type3
    }

    public interface IEvent
    {
        [OperationContract(IsOneWay=true)]
        void Event1();

        [OperationContract(IsOneWay=true)]
        void Event2(int num);

        [OperationContract(IsOneWay=true)]
        void Event3(int num,string text);
    }
}
