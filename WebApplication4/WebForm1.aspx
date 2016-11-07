<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title></title>
    <script type="text/javascript" src="JavaScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
            
            
    <div>
        <asp:Table ID="Table1" runat="server" BorderWidth="5px" CellSpacing="10">
            

            
            
        </asp:Table>
        <br /><br />
        

        <div class="row">
            
            
            
            <asp:Button runat="server" Text="Add Book" ID="addBook" />

            <asp:Label ID="Label1" runat="server" Text="  ID: "></asp:Label>
            <asp:TextBox ID="inputID" runat="server"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="inputName" runat="server"></asp:TextBox>

            <asp:Label ID="Label3" runat="server" Text="Author: "></asp:Label>
            <asp:TextBox ID="inputAuthor" runat="server"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Year: "></asp:Label>
            <asp:TextBox ID="inputYear" runat="server"></asp:TextBox>

            <asp:Label ID="Label5" runat="server" Text="Price: "></asp:Label>
            <asp:TextBox ID="inputPrice" runat="server"></asp:TextBox>

            <asp:Label ID="Label6" runat="server" Text="Stock: "></asp:Label>
            <asp:TextBox ID="inputStock" runat="server"></asp:TextBox>
            <asp:Label ID="value" runat="server" Text="result"></asp:Label>
            
            
        </div>
        
        <div class="row">
            <asp:Button runat="server" Text="Delete Book" ID="deleteBook" />
            <asp:DropDownList ID="option" runat="server">
                <asp:ListItem Selected="True" Value="Num"> Num </asp:ListItem>
                  <asp:ListItem Value="ID"> ID </asp:ListItem>
                  <asp:ListItem Value="Year"> Year </asp:ListItem>
                  
            </asp:DropDownList>
            <asp:TextBox ID="inputDelete" runat="server"></asp:TextBox>
            <asp:Label ID="value2" runat="server" Text="result"></asp:Label>
        </div>
        <div class="row">
            <asp:Button runat="server" Text="Search Book" ID="searchBook" />
            <asp:DropDownList ID="option2" runat="server">
                <asp:ListItem Selected="True" Value="ID"> ID </asp:ListItem>
                  <asp:ListItem Value="Name"> Name </asp:ListItem>
                  <asp:ListItem Value="Author"> Author </asp:ListItem>
                  <asp:ListItem Value="Year"> Year </asp:ListItem>
                  
            </asp:DropDownList>
            <asp:TextBox ID="inputSearch" runat="server"></asp:TextBox>
            <asp:Label ID="value3" runat="server" Text="result"></asp:Label>
        </div>
        <asp:Table ID="Table2" runat="server" BorderWidth="5px" CellSpacing="10">
           
        </asp:Table>
        <br /> <br />
        <asp:Label ID="Label7" runat="server" Text="Purchase Books"></asp:Label>

        <div class="row">
             <asp:Label ID="Label8" runat="server" Text="Total Budget"></asp:Label>
            
            <asp:TextBox ID="budget" runat="server"></asp:TextBox>
           
        </div>

        

        <div class="row">
            <div class="col">
                <asp:Label ID="Label11" runat="server" Text="test"></asp:Label>
                <asp:Label ID="Label10" runat="server" Text="test"></asp:Label>
                <asp:Label ID="Label9" runat="server" Text="test"></asp:Label>
                <asp:Table ID="Table3" runat="server">
                    
           
                </asp:Table>
                <asp:Button runat="server" Text="more" ID="moreBook" />
                
                
            </div>
            <div class="col" runat="server" id="listBooks">

            </div>
            
            
        </div>
        
        
        
        

        <div class="row">
            <asp:Button runat="server" Text="Purchase" ID="Purchase" />
            <asp:TextBox ID="outputPurchase" runat="server"></asp:TextBox>
           
        </div>


        
    </div>
        
    </form>
</body>
</html>
