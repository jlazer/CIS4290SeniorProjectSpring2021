<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="CIS4290SeniorProjectSpring2021.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringforOnlineStore %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
    </form>
</body>
</html>
