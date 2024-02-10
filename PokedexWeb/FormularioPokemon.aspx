<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FormularioPokemon.aspx.cs" Inherits="PokedexWeb.FormularioPokemon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:textbox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre:</label>
                <asp:textbox runat="server" ID="TextNombre" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNumero" class="form-label">Número:</label>
                <asp:textbox runat="server" ID="TexNumero" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripción:</label>
                <asp:textbox runat="server" TextMode="Multiline" ID="TextDescripcion" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="ddlTipo" class="form-label">Tipo:</label>
                <asp:textbox runat="server" ID="ddlTipo" CssClass="form-select" />
            </div>
            <div class="mb-3">
                <label for="ddlDebilidad" class="form-label">Debilidad:</label>
                <asp:textbox runat="server" ID="ddlDebilidad" CssClass="form-select" />
            </div>

            <%--falta el evento onclick--%>
            <div class="mb-3">
                <asp:button text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" runat="server" />
                <a href="PokemonLista.aspx">Cancelar</a>
            </div>

        </div>
    </div>

</asp:Content>
