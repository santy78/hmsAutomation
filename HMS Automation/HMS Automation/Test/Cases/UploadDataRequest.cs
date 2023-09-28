using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Test.Cases
{
    public class UploadDataRequest
    {
        public string GroupID { get; set; }

        [JsonProperty("PatientIdentifier")]
        public string PatientId { get; set; }

        public string RecID { get; set; }


        //public List<MeasureData> MeasureData { get; set; }

        public string CustomField1 { get; set; }

        public string CustomField2 { get; set; }

    }
}
