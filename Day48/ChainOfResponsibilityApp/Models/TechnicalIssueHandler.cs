using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityApp.Models
{
    public class TechnicalIssueHandler : SupportTicketHandler
    {
        protected override bool CanHandle(TicketType ticketType)
        {
            return ticketType == TicketType.TechnicalIssue;
        }

        protected override void ProcessTicket(string message, Action<string> logAction)
        {
            logAction("Processing Technical Issue: " + message);
        }
    }
}
