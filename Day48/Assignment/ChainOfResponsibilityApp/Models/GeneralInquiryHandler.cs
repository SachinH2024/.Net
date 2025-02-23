using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityApp.Models
{
    public class GeneralInquiryHandler : SupportTicketHandler
    {
        protected override bool CanHandle(TicketType ticketType)
        {
            return ticketType == TicketType.GeneralInquiry;
        }

        protected override void ProcessTicket(string message, Action<string> logAction)
        {
            logAction("Processing General Inquiry: " + message);
        }
    }
}