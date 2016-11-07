<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="utf-8" />
        
        <webopt:bundlereference runat="server" path="~/Content/css" />
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    </head>

    <body>

        <form runat="server">
            <asp:ScriptManager runat="server">
                <Services>
                    <asp:ServiceReference Path="~/AJAX.asmx" />
                </Services>
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

                <div class="col-xs-5">
                    <asp:Label ID="Label4" runat="server" Text="Find Date By Name"></asp:Label>
                </div>

            </div>
         
            <div class="row">
                <div class ="col-xs-1">
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    
            
                </div>
                <div class ="col-xs-3">
                    
                    <asp:TextBox CssClass="form-control" ID="inputName" runat="server" />
            
                </div>
                
                <div class ="col-xs-1">
                    <asp:Button Text="GetDate" Type="button" runat="server" ID="getDate" CssClass="btn btn-default" />
        
                    
                </div>

                <div class="col-xs-1">
           
                    <asp:Label ID="Label2" runat="server" Text="Date"></asp:Label>
            
                </div>
                
                <div class="col-xs-3">
           
                    <asp:TextBox CssClass="form-control" ID="outputDate" runat="server" />
            
                </div>

            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-xs-5">
                    <asp:Label ID="Label3" runat="server" Text="Find Name By Date"></asp:Label>
                </div>
            </div>
            
            
            <div class="row">
                <div class="col-xs-1">
                    <asp:Label ID="Label5" runat="server" Text="Mon : "></asp:Label>

                </div>
                <div class="col-xs-1">
                     <asp:TextBox CssClass="form-control" ID="mon" runat="server" />

                </div>
                <div class="col-xs-1">
                    <asp:Label ID="Label6" runat="server" Text="Day : "></asp:Label>

                </div>
                <div class="col-xs-1">
                     <asp:TextBox CssClass="form-control" ID="day" runat="server" />

                </div>
                <div class="col-xs-1">
                    <asp:Button Text="GetName" Type="button" runat="server" ID="getName" CssClass="btn btn-default" />

                </div>
                <div class="col-xs-1">
                    <asp:Label ID="Label7" runat="server" Text="Name : "></asp:Label>

                </div>
                <div class="col-xs-3">
                     <asp:TextBox CssClass="form-control" ID="outputName" runat="server" />

                </div>

            </div>
            <br />
            <br />
            <div class="row">

                <div class="col-xs-2">
            
                    <asp:DropDownList CssClass="form-control" ID="option" runat="server">
             
                        <asp:ListItem runat="server" Value="Brisbane" Text="Brisbane"></asp:ListItem>
                        <asp:ListItem runat="server" Value="New Farm" Text="New Farm"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Bowen Hills" Text="Bowen Hills"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Hamilton" Text="Hamilton"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Eagle Farm" Text="Eagle Farm"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Albion Bc" Text="Albion Bc"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Clayfield" Text="Clayfield"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Lutwyche" Text="Lutwyche"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Alderley" Text="Alderley"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Kelvin Grove" Text="Kelvin Grove"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Ashgrove" Text="Ashgrove"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Milton" Text="Milton"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Bardom" Text="Bardon"></asp:ListItem>
                        <asp:ListItem runat="server" Value="St Lucia" Text="St Lucia"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Uni of Queensland" Text="Uni of Queensland"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Highgate Hill" Text="Highgate Hill"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Dutton Park" Text="Dutton Park"></asp:ListItem>
                        <asp:ListItem runat="server" Value="East Brisbane" Text="East Brisbane"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Cannon Hill" Text="Cannon Hill"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Balmoral" Text="Balmoral"></asp:ListItem>
                        <asp:ListItem runat="server" Value="Murarrie" Text="Murarrie"></asp:ListItem>
                        

                    </asp:DropDownList>

                </div>

                <div class="col-xs-2">
                    <button type="button" onclick="onClick()" runat="server" id="Button1" class="btn btn-default" >ShowPostCode</button>

                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="postCode" runat="server" Text="Post Code"></asp:Label>
            
            <br />
            <br />
            <asp:Label ID="time" runat="server" Text="Label"></asp:Label>
            
            
        </form>
        <script type="text/javascript" src="JavaScript.js"></script>
        
    </body>

</html>
    


