<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
       

        <asp:PlaceHolder runat="server">
            <%: Scripts.Render("~/bundles/modernizr") %>
        </asp:PlaceHolder>
        <webopt:bundlereference runat="server" path="~/Content/css" />
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    </head>

    <body>

        <form runat="server">
            <asp:ScriptManager runat="server">
                <Scripts>
                    <%--To learn more about bundling scripts in ScriptManager see http://go.microsoft.com/fwlink/?LinkID=301884 --%>
                    <%--Framework Scripts--%>
                    <asp:ScriptReference Name="MsAjaxBundle" />
                    <asp:ScriptReference Name="jquery" />
                    <asp:ScriptReference Name="bootstrap" />
                    <asp:ScriptReference Name="respond" />
                    <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                    <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                    <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                    <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                    <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                    <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                    <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                    <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                    <asp:ScriptReference Name="WebFormsBundle" />
                    <%--Site Scripts--%>
                </Scripts>
            </asp:ScriptManager>
         
            <div class="row">
                <div class ="col-xs-1">
                    <asp:Button Text="Calculate" runat="server" ID="calculate" CssClass="btn btn-default" />
            
                </div>
                <div class ="col-xs-2">
        
                    <asp:TextBox CssClass="form-control" ID="number1" runat="server" />
                </div>
                <div class="col-xs-1">
            
                    <asp:DropDownList CssClass="form-control" id="option" runat="server">
             
                        <asp:ListItem runat="server" Value="add" Text="+"></asp:ListItem>
                        <asp:ListItem runat="server" Value="minus" Text="-"></asp:ListItem>
                        <asp:ListItem runat="server" Value="multiple" Text="*"></asp:ListItem>
                        <asp:ListItem runat="server" Value="divide" Text="/"></asp:ListItem>
                    </asp:DropDownList>

                </div>
                <div class="col-xs-2">
           
                    <asp:TextBox CssClass="form-control" ID="number2" runat="server" />
            
                </div>

        
                <div class="col-xs-1">
                    <label>= Base 10</label>
                </div>
                <div class="col-xs-1">
                    <asp:TextBox ID="Base10" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
        
        
                <div class="col-xs-1">
                    <label>Base 2</label>
                </div>
                <div class="col-xs-1">
                    <asp:TextBox ID="Base2" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
        
            </div>
            <br />
            <br />
            <div class="row">
                <div class ="col-xs-1">
                    <asp:Button Text="Count" runat="server" ID="count" CssClass="btn btn-default" /></asp:Button>
                </div>
                <div class="col-xs-1">
                    <label>Num of 0</label>
                </div>
                <div class="col-xs-2">
                    <asp:TextBox ID="Numof0" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
        
        
                <div class="col-xs-1">
                    <label>Num of 1</label>
                </div>
                <div class="col-xs-2">
                    <asp:TextBox ID="Numof1" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
        
            </div>
        </form>

    </body>

</html>
    


