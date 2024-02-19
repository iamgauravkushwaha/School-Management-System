<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ahome.aspx.cs" Inherits="schoolmanage.Ahome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style5 {
            height: 430px;
            width: 287px;
        }
        .auto-style4 {
            font-weight: bold;
            font-size: medium;
        }
        .auto-style2 {
            height: 430px;
            width: 1132px;
        }
        .auto-style6 {
            text-align: center;
            margin-top: 0px;
        }
        .auto-style7 {
            width: 751px;
            height: 516px;
            float: left;
            margin-right: 0px;
            margin-left: 0px;
        }
        .auto-style8 {
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #6699FF">
        <div>
            <br />
            <asp:Panel ID="Panel5" runat="server" BackColor="#000099" Height="38px">
                <h2 class="auto-style1"><strong>
                    <asp:Label ID="Label1" runat="server" ForeColor="White" Text="SCHOOL MANAGEMENT SYSTEM"></asp:Label>
                    </strong></h2>
            </asp:Panel>
        </div>
        <table class="auto-style6">
            <tr>
                <td class="auto-style5">
                    <asp:Panel ID="Panel4" runat="server" BackColor="#FF3300" Height="523px" Width="170px" CssClass="auto-style8">
                        <br />
                        <strong>
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" BackColor="White" CssClass="auto-style4" OnClick="Button1_Click" Text="Student" Width="124px" />
                        </strong>
                        <br />
                        <br />
                        <br />
                        <em><strong>
                        <asp:Button ID="Button2" runat="server" BackColor="White" CssClass="auto-style4" Text="Subject" Width="124px" OnClick="Button2_Click" />
                        </strong></em>
                        <br />
                        <br />
                        <br />
                        <strong>
                        <asp:Button ID="Button3" runat="server" CssClass="auto-style4" Text="Teacher" Width="124px" OnClick="Button3_Click" />
                        </strong>
                        <br />
                        <br />
                        <br />
                        <strong>
                        <asp:Button ID="Button4" runat="server" CssClass="auto-style4" Text="Section" Width="124px" OnClick="Button4_Click" />
                        </strong>
                        <br />
                        <br />
                        <br />
                        <strong>
                        <asp:Button ID="Button6" runat="server" CssClass="auto-style4" Text="Dashbord" Width="124px" OnClick="Button6_Click" />
                        </strong>
                        <br />
                        <br />
                        <br />
                        <br />
                    </asp:Panel>
                </td>
                <td class="auto-style2">
                    <img class="auto-style7" src="img/myclassr.jpg" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
