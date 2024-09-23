<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="To_do_List.Categoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="titulo">Categorias </h1>

    <div class="row">
        <asp:Repeater runat="server" ID="RepCat">
            <ItemTemplate>
                <div class="col-md-4 mb-3">
                    <div class="card text-center cat">
                        <div class="card-header">
                            Categorias
                       
                        </div>
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("NombreCategoria") %></h5>
                            <p class="card-text"><%#Eval("Descripcion") %>.</p>
                            <asp:LinkButton runat="server" ID="EliminarBtn" OnClick="EliminarBtn_Click" CommandArgument='<%# Eval("Id_cat") %>' CssClass="btn btn-danger">
                                <i class="fas fa-trash-alt" style="font-size: 20px;"></i>
                            </asp:LinkButton>

                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <section class="card-login">
        <div class="login-container">
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre de la categoria</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control mx-auto" name="txtNombre" />
                <div id="NombreHelp" class="form-text">Ingrese el nombre de la categoria.</div>
                <asp:Label runat="server" ID="lblNombreError" CssClass="text-danger" Visible="false" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control mx-auto" name="txtDescripcion" />
                <div id="DescripcionHelp" class="form-text">Ingrese la descripcion.</div>
                <asp:Label runat="server" ID="lblDescripcionError" CssClass="text-danger" Visible="false" />
            </div>
        </div>
        <div class="mb-3">
            <asp:Button runat="server" ID="btnAgregar" Text="Agregar" CssClass="btn btn-secondary" OnClick="btnAgregar_Click" />
        </div>
    </section>
</asp:Content>
