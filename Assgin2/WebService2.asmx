<%@ WebService Language="C#" Class="WebService2" %>

using System;
using System.Web;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService2  : System.Web.Services.WebService {

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public string getName(int mon, int day)
    {
        if (mon == 3)
        {
            if (day > 20 && day < 32 )
            {
                return "Aries";
            }
            else if (day >0)
            {
                return "Pisces";
            }
            else
            {
                return "Wrong Input Date";
            }
        }
        else if (mon == 4)
        {
            if (day > 20 && day <31)
            {
                return "Taurus";
            }
            else if (day > 0)
            {
                return "Aries";
            }
            else
            {
                return "Wrong Input Date";
            }

        }
        else if (mon == 5)
        {
            if (day > 21 && day <32)
            {
                return "Gemini";
            }
            else if (day>0)
            {
                return "Taurus";
            }
            else
            {
                return "Wrong Input Date";
            }
        }

        else if (mon == 6)
        {
            if (day > 21 && day < 31)
            {
                return "Cancer";
            }
            else if (day >0)
            {
                return "Gemini";
            }
            else
            {
                return "Wrong Input Date";
            }
        }

        else if(mon == 7)
        {
            if (day > 22 && day < 32)
            {
                return "Leo";
            }
            else if(day>0)
            {
                return "Cancer";
            }
            else
            {
                return "Wrong Input Date";
            }
        }

        else if(mon == 8)
        {
            if (day > 22 && day <32)
            {
                return "Virgo";
            }
            else if (day > 0)
            {
                return "Leo";
            }
            else
            {
                return "Wrong Input Date";
            }
        }
        else if(mon == 9)
        {
            if (day > 23 && day < 31)
            {
                return "Libra";
            }
            else if (day > 0)
            {
                return "Virgo";
            }
            else
            {
                return "Wrong Input Date";
            }
        }
        else if (mon == 10)
        {
            if (day > 23 && day < 32)
            {
                return "Scorpio";
            }
            else if (day > 0)
            {
                return "Libra";
            }
            else
            {
                return "Wrong Input Date";
            }

        }
        else if (mon == 11)
        {
            if (day > 22 && day < 31)
            {
                return "Sagittarius";
            }
            else if (day >0){
                return "Scorpio";
            }
            else
            {
                return "Wrong Input Date";
            }
        }

        else if (mon == 12)
        {
            if (day > 21 && day < 32)
            {
                return "Capicorn";
            }
            else if (day > 0)
            {
                return "Sagittarius";
            }
            else
            {
                return "Wrong Input Date";
            }
        }
        else if (mon == 1)
        {
            if (day > 20 && day < 32)
            {
                return "Aquarius";
            }
            else if(day > 0)
            {
                return "Capicorn";
            }
            else
            {
                return "Wrong Input Date";
            }
        }
        else if (mon == 2)
        {
            if (day > 19 && day < 30)
            {
                return "Pisces";
            }
            else if (day > 0)
            {
                return "Aquarius";
            }
            else
            {
                return "Wrong Input Date";
            }
        }
        else
        {
            return "Wrong Input Date";
        }



        

    }

}
    