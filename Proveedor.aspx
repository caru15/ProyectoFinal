<%@ Page Title="Proveedores" Language="C#"  MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Proveedor.aspx.cs" Inherits="Proveedor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <!-- <h2><%: Title %>.</h2>-->
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Crear Nuevo Proveedor.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Prov" CssClass="col-md-2 control-label">Proveedor Nombre</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Prov" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Prov"
                    CssClass="text-danger" ErrorMessage="Se requiere el nombre de proveedor." />
            </div>
        </div>   
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Cuenta" CssClass="col-md-2 control-label">Número de cuenta</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Cuenta" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Cuenta"
                    CssClass="text-danger" ErrorMessage="Se requiere el número de cuenta" />
            </div>
        </div>   
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Dom" CssClass="col-md-2 control-label">Domicilio</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Dom" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Dom"
                    CssClass="text-danger" ErrorMessage="Se requiere domicilio" />
            </div>
        </div>  
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Mail" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Mail" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Mail"
                    CssClass="text-danger" ErrorMessage="Se requiere un email válido." />
            </div>
        </div> 
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateProveedor_Click" Text="Registrar" CssClass="btn btn-small btn-success" />
            </div>
        </div>
    </div>
</asp:Content>