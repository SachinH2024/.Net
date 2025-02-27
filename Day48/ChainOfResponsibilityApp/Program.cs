using ChainOfResponsibilityApp.Models;

namespace ChainOfResponsibilityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SupportTicketHandler generalInquiryHandler = new GeneralInquiryHandler();
            SupportTicketHandler technicalIssueHandler = new TechnicalIssueHandler();
            SupportTicketHandler billingIssueHandler = new BillingIssueHandler();

            generalInquiryHandler.SetNextHandler(technicalIssueHandler);
            technicalIssueHandler.SetNextHandler(billingIssueHandler);

            Action<string> logAction = Console.WriteLine;

            generalInquiryHandler.HandleTicket(TicketType.GeneralInquiry, "I have a question about your product.", logAction);
            generalInquiryHandler.HandleTicket(TicketType.TechnicalIssue, "I am facing an issue with your software.", logAction);
            generalInquiryHandler.HandleTicket(TicketType.BillingIssue, "I have a problem with my bill.", logAction);
        }
    }
}


