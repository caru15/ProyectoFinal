<%@ Page Title="Notas" Language="C#"  MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Notas.aspx.cs" Inherits="Notas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Crear Nuevo Proveedor.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TipoNota" CssClass="col-md-2 control-label">Tipo Nota</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TipoNota" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TipoNota"
                    CssClass="text-danger" ErrorMessage="Se requiere el nombre de proveedor." />
            </div>
        </div>   
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Monto" CssClass="col-md-2 control-label">Monto</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Monto" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Monto"
                    CssClass="text-danger" ErrorMessage="Se requiere el número de cuenta" />
            </div>
        </div>   
        <!--<div class="form-group">
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
                <asp:Button runat="server"  Text="Registrar" CssClass="btn btn-small btn-success" />
            </div>
        </div>-->
    </div>
</asp:Content>