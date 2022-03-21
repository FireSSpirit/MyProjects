<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Groups.aspx.cs" Inherits="Kurs.Groups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Информация о выбранной группе</title>
    <style type="text/css">
        #form1 {
            background-color: #FF6666;
            background-image:url('http://zabavnik.club/wp-content/uploads/background_html_9_16082057.png');
            font-size: large;
            height: 990px;
            width: 1674px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700">
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
