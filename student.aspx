<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="schoolmanage.student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            width: 415px;
        }
        .auto-style5 {
            width: 245px;
            text-align: center;
        }
        .auto-style6 {
            width: 245px;
        }
        .auto-style7 {
            font-weight: bold;
        }
        .auto-style8 {
            width: 245px;
            text-align: center;
            height: 30px;
        }
        .auto-style9 {
            width: 415px;
            height: 30px;
        }
        .auto-style11 {
            width: 245px;
            text-align: center;
            height: 23px;
        }
        .auto-style12 {
            width: 415px;
            height: 23px;
        }
        .auto-style13 {
            width: 478px;
            height: 401px;
            margin-left: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #6699FF">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#003399" Height="38px">
                <h2 class="auto-style1"><strong>
                    <asp:Label ID="Label1" runat="server" ForeColor="White" Text="SCHOOL MANAGEMENT SYSTEM"></asp:Label>
                    </strong></h2>
            </asp:Panel>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ahome.aspx">Home</asp:HyperLink>
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style11">
                    <h4>Student Information</h4>
                </td>
                <td class="auto-style12"></td>
                <td rowspan="7">
                    <img class="auto-style13" src="img/teacher.jpg" /></td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>Student Name</strong></td>
                <td class="auto-style4"><strong>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; </strong>
                    <asp:RequiredFieldValidator ID="v" runat="server" ControlToValidate="TextBox2" ErrorMessage="Emter student name"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>DOB</strong></td>
                <td class="auto-style4"><strong>
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;&nbsp;&nbsp; </strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="enter Date of birth"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>Gender</strong></td>
                <td class="auto-style4"><strong>&nbsp;<asp:RadioButton ID="RadioButton1" runat="server" GroupName="g" Text="male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="g" Text="female" />
&nbsp;&nbsp;&nbsp; </strong></td>
            </tr>
            <tr>
                <td class="auto-style8"><strong>Phone</strong></td>
                <td class="auto-style9"><strong>
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Phone"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="enter phone number"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>Email</strong></td>
                <td class="auto-style4"><strong>
                    <asp:TextBox ID="TextBox6" runat="server" TextMode="Email"></asp:TextBox>
&nbsp;&nbsp;&nbsp; </strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6" ErrorMessage="enter email"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"><strong></strong></td>
                <td class="auto-style4"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style7" OnClick="Button1_Click" Text="Save" />
                    </strong></td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="149px" Width="768px" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="School ID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("sclid") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("sclid") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Student ID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("stdid") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("stdid") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("stdname") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("stdname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Date OF Birth">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("dob") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("dob") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("gender") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Phone">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("phno") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("phno") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("email") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("email") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action" ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" CausesValidation="false" CommandName="cmdedit" CommandArgument="<%#((GridViewRow)Container).RowIndex %>" Text="Edit" />
              </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action" ShowHeader="False">
                    <ItemTemplate>
                       <asp:Button ID="Button2" runat="server" CausesValidation="false" CommandName="cmddelete" CommandArgument="<%#((GridViewRow)Container).RowIndex %>" Text="delete" />

                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </form>
</body>
</html>
