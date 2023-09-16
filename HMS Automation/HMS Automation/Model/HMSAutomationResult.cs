using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Model
{
    public class HMSAutomationResult
    {
        public Int64? Id { get; set; }
        public int BatchId { get; set; }
        public string ScreenName { get; set; }
        public string ResponseType { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string Errors { get; set; }
        public string DateTime { get; set; }
      
    }
}
