using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscowTrafficRestriction.WebService.InfrastructureServices.Gateways
{
    public class Cells
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

    public class ResultFromServer
    {
        public int Number { get; set; }
        public Cells Cells { get; set; }
    }
}
