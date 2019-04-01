<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblNum1" runat="server" Text="EmployeeId"></asp:Label>
                 </td>
                <td><asp:TextBox ID="eid" runat="server" ></asp:TextBox></td>
                <td>
                    <button id=""></button>
                </td>
                <td >
                    <asp:Button ID="Btn" runat="server" Text="get" OnClick="btnres_Click" />
 </td>
                </tr>
                </table>
        <table id="tid">
           
            <tr>
                 <td>
                    <asp:Label ID="Label1" runat="server" Text="EmployeeName"></asp:Label>
                 </td>
                <td><asp:TextBox ID="ename" runat="server" ></asp:TextBox></td>
            </tr>
            <tr>
                 <td>
                    <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label>
                 </td>
                <td><asp:TextBox ID="egender" runat="server" ></asp:TextBox></td>
            </tr>
     
            </table>
    </div>
    </form>
</body>

</html>
