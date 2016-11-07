using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Text;

namespace WebApplication4
{
    public class BookPurchaseResponse
    {
        [MessageHeader]
        public string responseData;
        public Boolean resultData;

        [MessageBodyMember]
        public Boolean result
        {
            set { resultData = value; }
            get { return resultData; }
        }

        [MessageBodyMember]
        public string response
        {
            set { responseData = value; }
            get { return responseData; }
        }
    }
}