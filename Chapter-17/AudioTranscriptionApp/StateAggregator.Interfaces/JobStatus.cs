﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StateAggregator.Interfaces
{
    [DataContract]
    public class JobStatus
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Url { get; set; }
        [DataMember]
        public int Precent { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}
