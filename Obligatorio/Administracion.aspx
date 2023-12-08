<%@ Page Title="Administración" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="Obligatorio.Administracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Administración</h3>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnUsuarios" runat="server" CssClass="btn btn-primary" Text="Ir a usuarios" OnClick="btnUsuarios_Click" />
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnVerVentas" runat="server" CssClass="btn btn-primary" Text="Ver listado de ventas" OnClick="btnVerVentas_Click" />
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnVerAlquileres" runat="server" CssClass="btn btn-primary" Text="Ver listado de Alquileres" OnClick="btnVerAlquileres_Click" />
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            <asp:Button ID="btnVV" runat="server" CssClass="btn btn-primary" Text="Ver ventas por vendedor" OnClick="btnVV_Click" />
        </div>
    </div>

    <br />
    <br />
    <div class=" row">
        <div class="col-lg-6">
            <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" Visible="false" placeholder="Buscar" OnTextChanged="txtBuscar_TextChanged"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-4">
            <button id="btnBuscar" runat="server" cssclass="btn btn-primary" visible="false" onclick="btnBuscar_Click">Buscar</button>
        </div>
    </div>
    <div class=" row">
        <div class="col-lg-8">
            Vendedores
         <asp:ListBox ID="lstUsuarios" runat="server" Visible="false" CssClass="form-control" OnSelectedIndexChanged="lstUsuarios_SelectedIndexChanged"></asp:ListBox>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-8">
            <asp:Label ID="lblMessage" Visible="false" runat="server" ForeColor="red" />
        </div>
    </div>

    <div class=" row">
        <div class="col-lg-8">
            <asp:GridView ID="gvVV" runat="server" Height="171px" Visible="false"
                Width="676px" DataKeyNames="DocumentoEmpleado" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="FechaVenta">
                        <ItemTemplate>
                            <asp:Label ID="lblFechaVenta" runat="server" Text='<%# Bind("FechaVenta") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFechaVentaGrid" runat="server" Text='<%# Bind("FechaVenta") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="DocumentoCliente">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# Bind("DocumentoCliente") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lbl2" runat="server" Text='<%# Bind("DocumentoCliente") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Matricula">
                        <ItemTemplate>
                            <asp:Label ID="lblMatricula" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtMatriculaGrid" runat="server" Text='<%# Bind("Matricula") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio Venta">
                        <ItemTemplate>
                            <asp:Label ID="lblPrecio" runat="server" Text='<%# Bind("Precio") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioGrid" runat="server" Text='<%# Bind("Precio") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Link" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>
    </div>


</asp:Content>
