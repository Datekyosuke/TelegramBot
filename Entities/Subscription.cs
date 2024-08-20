using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Entities
{
    public class Subscription
    {
        public string ServiceName { get; set; }
        public string Period { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public SubscriptionStatus Status { get; set; }
    }
}
