<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:button ID="Button" Text="Clique Aqui" ToolTip="É sério" runat="server" onclick="Button_Click" />
        </div>
        <div>
        </div>
        <div>
            <div>
                Número da conta
            </div>
            <asp:textbox Id="NroConta" runat="server" OnTextChanged="NroConta_TextChanged"></asp:textbox>
        </div>
        <div>
            <div>
                Nome do Titular
            </div>
            <asp:textbox Id="NomeTitular" runat="server" OnTextChanged="NomeTitular_TextChanged"></asp:textbox>
        </div>
        <div>
            <div>
                Valor do Saque
            </div>
            <asp:textbox Id="Saque" runat="server"></asp:textbox>
        </div>
        <div>
            <asp:Button ID="Sacar" runat="server" Text="Sacar!" OnClick="Sacar_Click" />
        </div>
    </form>
</body>
</html>

