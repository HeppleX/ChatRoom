<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chat.aspx.cs" Inherits="Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.5.1.js"></script>
    <script type="text/javascript">
        function refresh() {
            $.ajax({
                url: "Ajax.aspx",
                cache: false,
                success: function (text) {
                    document.getElementById("divMsg").innerHTML = text;
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert("网络连接有问题，请重试！");
                }
            });
            setTimeout("refresh()", 500);
        }
    </script>
</head>
<body onload="refresh()">
    <form id="form1" runat="server">
        <div id="divMsg"></div>
        <div>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="146px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="发送" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
