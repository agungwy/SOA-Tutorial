using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for AJAX
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class AJAX : System.Web.Services.WebService
{

    //public AJAX()
    //{

    //    //Uncomment the following line if using designed components 
    //    //InitializeComponent(); 
    //}

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public string GetPostCode(string suburb)
    {
        
        string lines;
        Dictionary<string, string> dict = new Dictionary<string, string>();

        // Read the file and display it line by line.
        System.IO.StreamReader file =
        new System.IO.StreamReader(@"c:\Users\agung\Documents\My Web Sites\Assgin2\Postcodes.txt");
        while ((lines = file.ReadLine()) != null)
        {
            System.Console.WriteLine(lines);
            string[] line = lines.Split(',');
            dict.Add(line[0], line[1]);
            System.Console.WriteLine(line);
            
            
        }
        file.Close();
        return dict[suburb];
        

        
    }

}
