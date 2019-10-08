<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="FizzBuzz.Web.Page1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="labelnumero">
                Numero:
            </td>
            <td class ="CeldaNumeros">
                <input id="textonumeros" type="text" class="form-control" style="width:350px;" maxlength="2" />
            </td>
            <td class ="BotonNumeros">
                <button id="botonFizzBuzz" type="button" class="btn btn-sm" title="¿FizzBuzz?">Ingresar Numero</button>
            </td>
        </tr>
    </table>
</asp:Content>
