<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LinqToSqlTutorials.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtCategoryName" runat="server"></asp:TextBox>
        <asp:Button ID="btnInsert" runat="server" Text="Button" />
        <hr/>
        <asp:GridView ID="CategoryList" runat="server"></asp:GridView>
       
    </div>
    </form>
</body>
</html>
