<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addb.aspx.cs" Inherits="BookStoreClient.Addb" %>

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
        .tbox{
            width:250px;
        }
        </style>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</head>
<body class="bgg">
    <form id="form1" runat="server">
        <center>
        <div><br/>
            <p class="h3">
            Enter details of new book below.
            <br/>
            
        </p>
            <br/>
        </div>
        <p class="h4">
            NAME:
        
            <asp:TextBox CssClass="tbox" ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p class="h4">AUTHOR:
            <asp:TextBox CssClass="tbox" ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p class="h4">PRICE:
        <asp:TextBox CssClass="tbox" ID="TextBox4" runat="server"  ></asp:TextBox></p>
        <br/>
        
        <asp:Button class="btn btn-dark" ID="Button1" runat="server" Text="ADD BOOK" OnClick="Button1_Click"/>
        <br /></center>
    </form>
</body>
</html>
