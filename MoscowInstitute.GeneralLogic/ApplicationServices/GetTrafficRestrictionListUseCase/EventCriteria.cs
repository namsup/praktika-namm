using MoscowTrafficRestriction.DomainObjects;
using MoscowTrafficRestriction.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MoscowTrafficRestriction.ApplicationServices.GetTrafficRestrictionListUseCase
{
    public class EventCriteria : ICriteria<TrafficRestriction>
    {
        public string INN { get; }

        public EventCriteria(string NameWinter)
            => this.INN = INN;

        public Expression<Func<TrafficRestriction, bool>> Filter
            => (tr => tr.INN == INN);
    }
}
