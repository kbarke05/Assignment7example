﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment7example
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommAsstServices" in both code and config file together.
    [ServiceContract]
    public interface ICommAsstServices
    {
        [OperationContract]
        List<ComService> GetServices();
        
    }

    [DataContract]
    public class ComService
    {
        [DataMember]
        public string ServiceName { get; set; }
        [DataMember]
        public string ServiceDescription { get; set; }
    
    }
}
