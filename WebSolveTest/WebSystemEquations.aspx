<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebSystemEquations.aspx.cs" Inherits="WebSolveTest.WebSystemEquations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            x1 +
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            x2 +
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            x3 =
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            x1 +
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            x2 +
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            x3 =
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            x1 +
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            x2 +
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            x3 =
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </asp:Panel>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Solve" />
    
        <br />
        <br />
        <asp:Panel ID="form2" runat="server">

        </asp:Panel>
    </div>
    </form>
</body>
</html>
