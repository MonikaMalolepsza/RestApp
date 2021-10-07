<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RestApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel panel-default">

        <div class="panel-heading">Properties</div>
        <br />
        <div class="panel-body">
             <div>
                <asp:Button runat="server" Text="Get" CssClass="btn btn-secondary" OnClick="RunGet" />
                <asp:Button runat="server" Text="Put" CssClass="btn btn-secondary" OnClick="RunPut" />
                <asp:Button runat="server" Text="Get By Id" CssClass="btn btn-secondary" OnClick="RunGetById" />
                <asp:Button runat="server" Text="Post" CssClass="btn btn-secondary" OnClick="RunPost" />
                <asp:Button runat="server" Text="Delete" CssClass="btn btn-secondary" OnClick="RunDelete" />
             </div>
            <br />
            <br />
            <label>Entry</label>
            <br />
            <label>GET/PUT/DELETE Id</label>
            <asp:TextBox runat="server" ID="textId" CssClass="form-control" />
            <label for="textEdit">Name</label>
            <asp:TextBox ID="textEdit" runat="server" CssClass="form-control"></asp:TextBox>      
            <label for="textEdit">Status</label>
            <asp:TextBox ID="textIdField" runat="server" Visible="false" ReadOnly="true" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <br />
    <div class="panel panel-default">
        <div class="panel-heading">Data</div>
        <br />
        <div class="panel-body">
            <asp:GridView ID="tbl1" CssClass="table" runat="server">
            </asp:GridView>
            <br />
            <asp:GridView ID="tbl2" CssClass="table" runat="server">
            </asp:GridView>
        </div>
                <asp:Button runat="server" Text="Clear" OnClick="Clear" />
        <br />
    </div>
</asp:Content>
