﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldWebServiceLibrary
{
    [DataContract]
    public class Name
    {
        [DataMember]
        public string First;

        [DataMember]
        public string Last;
    }

    [ServiceContract]
    public interface IHelloWorld
    {
        [OperationContract]
        string SayHello(Name person);
    }

    class HelloWorldService : IHelloWorld
    {
        public string SayHello(Name person)
        {
            return string.Format("Hello {0} {1}",
                person.First, person.Last);
        }
    }
}
