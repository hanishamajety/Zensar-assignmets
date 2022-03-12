<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ListItems.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; List Of Products<br />
            <br />
        </div>
        Select any Item: <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="126px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem></asp:ListItem>
        
        </asp:DropDownList>
        <br />   
        
        <asp:Image ID="Image1" runat="server" Height="553px" Width="496px" />
        <br />
        <%--<asp:Button ID="Button1" runat="server" Text="Click to Check the Price" />--%>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Price Label"></asp:Label>
    </form>
</body>
</html>
