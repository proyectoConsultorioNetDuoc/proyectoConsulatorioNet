﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="consultorioWeb.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
 <title>Acceso Plataforma Virtual <3</title>
        <link href="CSS/estilo.css" rel="stylesheet" type="text/css" />
        <style type="text/css">
            .style1 {
                height: 182px;
            }

            .style3 {
                height: 182px;
                width: 38px;
            }

            .style4 {
                width: 24px;
            }

            .style5 {
                width: 174px;
            }

            .style6 {
                width: 301px;
            }

            .style7 {
                height: 182px;
                width: 301px;
            }

            .style8 {
                width: 253px;
            }

            .style9 {
                width: 187px;
            }

            .style10 {
                width: 38px;
            }
        </style>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                <table style="width:100%;">
                    <tr>
                        <td class="style10">
                            <br /><br /> &nbsp;
                        </td>
                        <td class="style6">
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style10">
                            <img alt="ministerio de la salud" src="Imagen/LogoGobierno.png" /> </td>
                        <td class="style6">
                            <center>
                                <asp:Label ID="Label4" runat="server" Text="ACCESO PLATAFORMA VIRTUAL CONSULTORIO"></asp:Label>
                            </center>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                        </td>
                        <td class="style7">
                            <table style="width: 96%; height: 173px;">
                                <tr>
                                    <td class="style4">
                                        &nbsp;</td>
                                    <td class="style5">
                                        &nbsp;</td>

                                </tr>
                                <tr>
                                    <td class="style4">
                                        <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>
                                    </td>
                                    <td class="style5">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                        ControlToValidate="txtUsuario" ForeColor="Red" 
                                            ErrorMessage="Ingrese Usuario"></asp:RequiredFieldValidator>
                                        <asp:TextBox ID="txtUsuario" runat="server" Width="139px" ></asp:TextBox>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="style4">
                                        <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
                                    </td>
                                    <td class="style5">
                                        <asp:TextBox ID="txtPass" TextMode="Password" runat="server" Width="137px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ForeColor="Red"
                                            ErrorMessage="Ingrese Contraseña"></asp:RequiredFieldValidator>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="style4">
                                        &nbsp;</td>
                                    <td class="style5">
                                        &nbsp;
                                        </td>

                                </tr>
                            </table>
                        </td>
                        <td class="style1">
                        </td>
                    </tr>
                </table>
                <table style="width: 100%;">
                    <tr>
                        <td class="style8">
                            &nbsp;
                            </td>
                        <td class="style9">
                            &nbsp;
                            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Height="71px" 
                                Width="160px" onclick="btnIngresar_Click" />
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">                           
                           
                        </td>
                        <td class="style9">
                            &nbsp;
                            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" Text=""></asp:Label>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                            &nbsp;
                        </td>
                        <td class="style9">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </div>
        </form>
        <div class="footer">
       <center>
                <asp:Label ID="Label1" runat="server" Text="@ConsultorioWebNet"></asp:Label>
            </center>
        </div>
    </body>
</html>
