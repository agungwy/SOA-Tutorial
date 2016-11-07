using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        getDate.Click += new EventHandler(this.GetDate);
        getName.Click += new EventHandler(this.GetName);
    }

    protected void GetDate(object sender, EventArgs e)
    {
        WebService ws = new WebService();
        var name = inputName.Text;
        string date = ws.GetDate(name);

        outputDate.Text = date;


    }

    protected void GetName(object sender, EventArgs e)
    {
        WebService3 ws2 = new WebService3();
        int month = Int32.Parse(mon.Text);
        int days = Int32.Parse(day.Text);
        string name = ws2.GetName(month, days);

        outputName.Text = name;


    }
}