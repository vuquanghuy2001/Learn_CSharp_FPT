<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="helloWorld.aspx.cs" Inherits="WebApplication2.helloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Username:<asp:TextBox ID="txtUsername" runat="server" OnTextChanged="txtUsername_TextChanged"></asp:TextBox>
        </p>
        <p>
            Password:<asp:TextBox ID="txtPassword" runat="server" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="BtnLogin" runat="server" OnClick="BtnLogin_Click" Text="login" />
        <p>
            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
