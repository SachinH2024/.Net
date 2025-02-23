using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternApp.Models
{
    public class Notification
    {
        public string SendNotification(string message)
        {
            return $"Notification: {message}";
        }
    }
}