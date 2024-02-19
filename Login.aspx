<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="schoolmanage.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
            color: #FFFFFF;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            height: 224px;
        }
        .auto-style6 {
            height: 224px;
            width: 226px;
            text-align: center;
        }
        .auto-style7 {
            width: 226px;
        }
        .auto-style9 {
            font-weight: bold;
        }
        .auto-style10 {
            text-align: center;
        }
        .auto-style11 {
            width: 158px;
            height: 167px;
            margin-right: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="Black" Height="50px">
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" ForeColor="White" Text="Admin Login "></asp:Label>
        </asp:Panel>
        <table class="auto-style4">
            <tr>
                <td class="auto-style6">
                    <img alt="" class="auto-style11" src="login-icon-3060.png" /></td>
                <td class="auto-style5"><strong>UserName</strong>&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <strong>Password</strong>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style9" ForeColor="Black" Height="30px" OnClick="Button1_Click" Text="Login" Width="128px" />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="Label2" runat="server" Text=" invalid user" Visible="False"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp; &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
