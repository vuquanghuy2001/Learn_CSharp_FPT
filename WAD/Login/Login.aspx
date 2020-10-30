<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        UserName:<asp:TextBox ID="TextBox1" runat="server" Width="243px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            Password:<asp:TextBox ID="TextBox2" runat="server" Width="243px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </form>
</body>
</html>
