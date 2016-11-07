using System;
using System.Web;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public string GetDate(String inputName)
    {
        Dictionary<string, string> list = new Dictionary<string, string>();
        list.Add("Aries", "03/21-04/20");
        list.Add("Taurus", "04/21-05/21");
        list.Add("Gemini", "05/22-06/21");
        list.Add("Cancer", "06/22-07/22");
        list.Add("Leo", "07/23-08/22");
        list.Add("Virgo", "08/23-09/23");
        list.Add("Libra", "09/24-10/23");
        list.Add("Scorpio", "10/24-11/22");
        list.Add("Sagittarius", "11/23-12/21");
        list.Add("Capicorn", "12/22-01/20");
        list.Add("Aquarius", "01/21-02/19");
        list.Add("Pisces", "02/20-03/20");

        string name = inputName;

        if (list.ContainsKey(name))
        {
            return list[name];
        }
        else
        {
            return "Not Found";
        }
    }


}