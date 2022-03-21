<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kurs.aspx.cs" Inherits="Kurs.Kurs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Общая информация</title>
    <style type="text/css">
        #form1 {
            background-color: #FF6666;
            background-image:url('http://zabavnik.club/wp-content/uploads/background_html_9_16082057.png');
            font-size: large;
            height: 990px;
            width: 1674px;
        }
        .raz {
            text-align:right;
                            
        }
    </style>
</head>
<body style="font-weight: 700; height: 990px;">
    <form id="form1" runat="server">
        <div class =" raz"> <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Font-Size="Large" Height="29px" Width="97px" style="font-size: medium; float:left;">
            <asp:ListItem Value="0">1 курс</asp:ListItem>
            <asp:ListItem Value="1">2 курс</asp:ListItem>
            <asp:ListItem Value="2">3 курс</asp:ListItem>
            <asp:ListItem Value="3">4 курс</asp:ListItem>
            <asp:ListItem Value="4">все курсы</asp:ListItem>
            
        </asp:DropDownList>
            
            
            <asp:Image ID="Image1" runat="server" Height="120px"  ImageUrl="https://priem.mirea.ru/olymp-2019/images/mirea.jpg?v2" Width="200px" />
            </div>
        <div style="font-size: large; height: 700px; width: 1650px;"> 
            
            
            <br />
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Groups.aspx?id=1&kurs=1" runat="server">ИКБО-01-20</asp:HyperLink><br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Groups.aspx?id=2&kurs=1" runat="server">ИКБО-02-20</asp:HyperLink><br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink3" NavigateUrl="~/Groups.aspx?id=3&kurs=1" runat="server">ИКБО-03-20</asp:HyperLink><br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink4" NavigateUrl="~/Groups.aspx?id=4&kurs=1" runat="server">Все студенты 1 курса</asp:HyperLink><br /><br />

            </asp:View>
            <asp:View ID="View2" runat="server">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink5" NavigateUrl="~/Groups.aspx?id=1&kurs=2" runat="server">ИКБО-01-19</asp:HyperLink><br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink6" NavigateUrl="~/Groups.aspx?id=2&kurs=2" runat="server">ИКБО-02-19</asp:HyperLink><br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink7" NavigateUrl="~/Groups.aspx?id=3&kurs=2" runat="server">ИКБО-03-19</asp:HyperLink><br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink8" NavigateUrl="~/Groups.aspx?id=4&kurs=2" runat="server">Все студенты 2 курса</asp:HyperLink><br /><br />             
            </asp:View>
                <asp:View ID="View3" runat="server">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink9" NavigateUrl="~/Groups.aspx?id=1&kurs=3" runat="server">ИКБО-01-18</asp:HyperLink><br /><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink10" NavigateUrl="~/Groups.aspx?id=2&kurs=3" runat="server">ИКБО-02-18</asp:HyperLink><br /><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink11" NavigateUrl="~/Groups.aspx?id=3&kurs=3" runat="server">ИКБО-03-18</asp:HyperLink><br /><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink12" NavigateUrl="~/Groups.aspx?id=4&kurs=3" runat="server">Все студенты 3 курса</asp:HyperLink><br /><br />
                </asp:View>
                <asp:View ID="View4" runat="server">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink13" NavigateUrl="~/Groups.aspx?id=1&kurs=4" runat="server">ИКБО-01-17</asp:HyperLink><br /><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink14" NavigateUrl="~/Groups.aspx?id=2&kurs=4" runat="server">ИКБО-02-17</asp:HyperLink><br /><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink15" NavigateUrl="~/Groups.aspx?id=3&kurs=4" runat="server">ИКБО-03-17</asp:HyperLink><br /><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink16" NavigateUrl="~/Groups.aspx?id=4&kurs=4" runat="server">Все студенты 4 курса</asp:HyperLink><br /><br />
                </asp:View>
                <asp:View ID="View5" runat="server">
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </asp:View>
        </asp:MultiView>
                 
            <br />
            <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Text="Label" Visible="False"></asp:Label>
            <br />
                 
        <br />
&nbsp;При изменении данных о студенте, введите его ID и нажмите &quot;Подтвердить&quot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Panel ID="Panel1" runat="server" Height="117px" Width="1647px">
                <asp:Button ID="Button3" runat="server" Text="Изменить данные о Студенте" OnClick="Button3_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" Text="Подтвердить" OnClick="Button4_Click" />
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Удалить Студента" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="ID Студента:"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="55px"></asp:TextBox>
            </asp:Panel>
        <p style="font-size: large">
&nbsp;&nbsp;
            </p>
            <asp:Panel ID="Panel2" runat="server">
                <asp:Button ID="Button1" runat="server" Text="Добавить Студента" OnClick="Button1_Click" />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="ФИО:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="393px"></asp:TextBox>
            </asp:Panel>
            <p style="font-size: large">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            </p>
        <asp:Label ID="Label3" runat="server" Text="Курс:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" Width="107px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Группа:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>ИКБО-01-20</asp:ListItem>
            <asp:ListItem>ИКБО-02-20</asp:ListItem>
            <asp:ListItem>ИКБО-03-20</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Форма обучения:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem>очная</asp:ListItem>
            <asp:ListItem>очно-заочная</asp:ListItem>
            <asp:ListItem>заочная</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Вид возмещения затрат:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList5" runat="server">
            <asp:ListItem>бюджет</asp:ListItem>
            <asp:ListItem>платник</asp:ListItem>
            <asp:ListItem>контракт</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Студентический билет продлён:"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" Checked="True" />
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Количество долгов:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="44px">0</asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Text="Количество взятых книг из библиотеки:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="37px">0</asp:TextBox>
            <br />
            </div>  
    </form>
</body>
</html>
