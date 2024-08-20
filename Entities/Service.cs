using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Entities
{
    public class Service
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<SubscriptionPeriod> SubscriptionPeriods { get; set; }
    }
}
