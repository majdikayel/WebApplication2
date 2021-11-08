<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Nom</td>
                    <td><asp:TextBox ID="Nom" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>Prénom</td>
                    <td><asp:TextBox ID="Prenom" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>City</td>
                    <td><asp:TextBox ID="City" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btn1" runat="server" Text="Insert" OnClick="btn1_Click" />
                        <asp:Button ID="btn2" runat="server" Text="Delete" OnClick="btn2_Click" />
                        <asp:Button ID="btn3" runat="server" Text="Update" OnClick="btn3_Click" />
                        <asp:Button ID="btn4" runat="server" Text="View" OnClick="btn4_Click" />
                    </td>
                </tr>

                <tr>
                    <td>Enter ID for update</td>
                    <td><asp:TextBox ID="oldid" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
