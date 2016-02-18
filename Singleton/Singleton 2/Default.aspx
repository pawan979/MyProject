<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 213px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblText" runat="server"></asp:Label>
    
    </div>
        <p>
            <asp:TextBox ID="txtText" runat="server" OnTextChanged="txtText_TextChanged"></asp:TextBox>  
             </p>
        <p style="width: 805px">
            <asp:Label ID="lblLatestUpdate" runat="server" Text="Latest Update"></asp:Label> 
            &nbsp;&nbsp;&nbsp;    
            <asp:Label ID="lblUpdatedText" runat="server" Text=""></asp:Label>
        </p>
        
    </form>
</body>
</html>
