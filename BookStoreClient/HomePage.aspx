<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="BookStoreClient.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .bgg{
            background-image: linear-gradient(to left, #40bf7d , #00b3b3);
        }

        gridcenter {
            margin-left:auto;
            margin-right:auto;
        }
        </style>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</head>
<body class="bgg">
    <form id="form1" runat="server">
        <h1 class="row justify-content-center mt-4 mb-3">WELCOME TO OUR BOOK STORE!!</h1><br />
            <div class="h3 row justify-content-center mb-3"><asp:Label  ID="Label1" runat="server" Text="Label"></asp:Label></div><br />
        <div class="h5 row justify-content-center text-center ">
        
        <asp:GridView CssClass="gridcenter " ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
            OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit"
    OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="Id" Height="212px" Width="555px" >
            <Columns>
    <asp:CommandField HeaderText="Operations" ShowEditButton="true" ShowCancelButton="true" ShowDeleteButton="true" ShowHeader="True" />
    
</Columns>
            <AlternatingRowStyle BackColor="#c1d0f0" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#d6e0f5"  />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        </div>
        <p>
            &nbsp;</p>
        <div class="text-center">
            <asp:Button Class="btn btn-dark" ID="Button1" runat="server" Height="47px" OnClick="Button1_Click" Text="ADD BOOK" Width="130px" />
        </div>
    </form>
</body>
</html>
