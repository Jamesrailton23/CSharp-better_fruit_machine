<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="fruit_machine._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <h2>Fruit Machine</h2>
            <br />
            <br />
            <asp:Image ID="image_1" runat="server" Height="150px" Width="150px" BorderStyle="None" /> &nbsp &nbsp &nbsp &nbsp &nbsp <asp:Image ID="image_2" runat="server" Height="150px" Width="150px" BorderStyle="None" /> &nbsp &nbsp &nbsp &nbsp &nbsp  <asp:Image ID="image_3" runat="server" Height="150px" Width="150px" BorderStyle="None" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="image_button_spin" runat="server" ImageUrl="/images/spin.png" Height="100px" Width="100px" OnClick="image_button_one_Click" /> 
            <br />
            <br />
            <br />
            <asp:TextBox ID="tb_bet" runat="server"></asp:TextBox>
            <br />
            <br />
           <h2>Payout = <asp:Label ID="lable_payout" runat="server"></asp:Label></h2>
             <br />
             <br />
             <br />
             <br />
        </div>
    </form>
</body>
</html>
