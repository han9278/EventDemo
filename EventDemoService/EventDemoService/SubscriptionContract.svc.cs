using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EventDemoService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
    public class SubscriptionContract : ISubscriptionContract
    {
        static Action m_Event1 = delegate { };
        static Action<int> m_Event2 = delegate { };
        static Action<int, string> m_Event3 = delegate { };

        public void FiringEvents(EventType type)
        {
            if ((type & EventType.Type1) == EventType.Type1)
            {
                m_Event1();
            }
            if ((type & EventType.Type2) == EventType.Type2)
            {
                m_Event2(3);
            }
            if ((type & EventType.Type3) == EventType.Type3)
            {
                m_Event3(3,"jjjj");
            }
        }

        public void Subscribe(EventType type)
        {
            IEvent subscribe = OperationContext.Current.GetCallbackChannel<IEvent>();
            if ((type & EventType.Type1) == EventType.Type1)
            {
                m_Event1 += subscribe.Event1;
            }
            if ((type & EventType.Type2) == EventType.Type2)
            {
                m_Event2 += subscribe.Event2;
            }
            if ((type & EventType.Type3) == EventType.Type3)
            {
                m_Event3 += subscribe.Event3;
            }
        }

        public void UnSubsctibe(EventType type)
        {
            IEvent subscribe = OperationContext.Current.GetCallbackChannel<IEvent>();
            if ((type & EventType.Type1) == EventType.Type1)
            {
                m_Event1 -= subscribe.Event1;
            }
            if ((type & EventType.Type2) == EventType.Type2)
            {
                m_Event2 -= subscribe.Event2;
            }
            if ((type & EventType.Type3) == EventType.Type3)
            {
                m_Event3 -= subscribe.Event3;
            }
        }
    }
}
