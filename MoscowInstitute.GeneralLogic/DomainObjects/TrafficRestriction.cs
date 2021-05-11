using System;
using System.Collections.Generic;
using System.Text;

namespace MoscowTrafficRestriction.DomainObjects
{
    public class TrafficRestriction : DomainObject 
    {

        public string NameOfManagingOrg { get; set; }
        public string Year { get; set; }

        public string INN { get; set; }

        public string IssuedPrescriptions { get; set; }

        public string ViolationsAmount { get; set; }

        public string ProtocolsComposed { get; set; }

        public string EventsExecuted { get; set; }

        public string EventsNotExecutedInTime { get; set; }

        public string ProtocolsComposedForFailure { get; set; }

        public string SumOfFine { get; set; }

        public string global_id { get; set; }








    }
}
