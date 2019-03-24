<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginWithGoogle.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Google login" />
            <asp:Panel runat="server" ID="pnlProfile" Visible="false">
                <hr />
                <table>
                    <tr>
                        <td rowspan="5" valign="top">
                            <asp:Image ID="ProfileImage" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>ID:
                        <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Nome:
                        <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Email:
                        <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Sexo:
                        <asp:Label ID="lblSexo" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Tipo:
                        <asp:Label ID="lblTipo" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear" />
                        </td>
                    </tr>

                </table>

            </asp:Panel>
        </div>
    </form>
</body>
</html>
