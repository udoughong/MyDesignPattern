<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesDashboard.aspx.cs" Inherits="SDP_ObserverPattern_AspNet.SalesDashboard" %>

<%@ Register src="SalesReport1.ascx" tagname="SalesReport1" tagprefix="uc1" %>
<%@ Register src="SalesReport2.ascx" tagname="SalesReport2" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Product:<br />
                <asp:DropDownList ID="DropDownList1" runat="server"
                    Width="215px">
                </asp:DropDownList><br />
                Date:<br />
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
                <br />
                <uc1:SalesReport1 ID="SalesReport11" runat="server" />
                <uc2:SalesReport2 ID="SalesReport21" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
