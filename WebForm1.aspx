<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Examen2VanessaAlvaradoSarmiento.WebForm1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/Principal.css">


</head>
<body>
 <form id="form2" runat="server">
        <div style="height: 339px">
            <h1 style="font-family: 'Bahnschrift Light'">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PAGO DE SERVICIOS</h1>
            <asp:Panel ID="Panel1" runat="server" Height="226px" Width="662px">
                &nbsp;&nbsp;
                <br />
                &nbsp;
                <asp:Label ID="lCed" runat="server" Text="Cedula:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tCed1" runat="server" OnTextChanged="tCed1_TextChanged"></asp:TextBox>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="lNom" runat="server" Text="Nombre:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tNom1" runat="server" OnTextChanged="tNom1_TextChanged"></asp:TextBox>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="lDireccion" runat="server" Text="Direccion:"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tDireccion1" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="lTel" runat="server" Text="Telefono"></asp:Label>
                :&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tTel1" runat="server"></asp:TextBox>
                <br />
                &nbsp;</asp:Panel>
            <br />
            <asp:ImageButton ID="ImageButton1" href="FacturacionAgua" runat="server"  Height="155px" ImageUrl="~/imagenes/agua.jpg" Width="225px" OnClick="ImageButton1_Click"/>
            <asp:ImageButton ID="ImageButton2" runat="server" Height="155px" ImageUrl="~/imagenes/luz.png" Width="225px" OnClick="ImageButton2_Click" />
            <asp:ImageButton ID="ImageButton3" runat="server" Height="155px" ImageUrl="~/imagenes/cable.jpg" Width="225px" OnClick="ImageButton3_Click" />
            <asp:ImageButton ID="ImageButton4" runat="server" Height="155px" ImageUrl="~/imagenes/icono-del-teléfono-en-blanco-y-negro-símbolo-ilustración-vector-132741772.jpg" Width="225px" OnClick="ImageButton4_Click" />
            <br />
        </div>
        </form>
    </body>
</html>