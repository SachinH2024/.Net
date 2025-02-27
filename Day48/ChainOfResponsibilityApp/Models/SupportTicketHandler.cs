using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityApp.Models
{
    public abstract class SupportTicketHandler
    {
        protected SupportTicketHandler _nextHandler;

        public void SetNextHandler(SupportTicketHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void HandleTicket(TicketType ticketType, string message, Action<string> logAction)
        {
            if (CanHandle(ticketType))
            {
                ProcessTicket(message, logAction);
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleTicket(ticketType, message, logAction);
            }
        }

        protected abstract bool CanHandle(TicketType ticketType);
        protected abstract void ProcessTicket(string message, Action<string> logAction);
    }
}
