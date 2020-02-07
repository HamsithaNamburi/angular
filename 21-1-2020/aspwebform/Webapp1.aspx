<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webapp1.aspx.cs" Inherits="aspwebform.Webapp1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 176px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<asp:Label runat="server" Text="Label"> </asp:Label>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            
 Enter Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
       <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
   
            </div>
   
        
    </form>
</body>
</html>
