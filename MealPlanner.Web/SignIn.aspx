<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="MealPlanner.Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainPlaceholder" runat="server">
    <div class="col-12 text-center">
        <h2>Login In</h2>

    </div>
    <div class="form-group">

        <label>UserName:</label>
        <asp:TextBox ID="UserNameSigninTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <br />
        <label>Password:</label>
        <asp:TextBox ID="PasswordSigninTextBox" runat="server" CssClass="form-control"></asp:TextBox>


    </div>
    <div class="form-group">
        <asp:Button ID="signInButton" runat="server" OnClick="signInButton_Click" Text="Sign In" CssClass="btn btn-lg btn-primary" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" Text="" CssClass="bg-danger"></asp:Label>
        <br />
        <br />

        <br />
        <br />
        <br />
        </div>
        <div class="form-group row">

            <asp:Button ID="forgotpasswordButton" runat="server" Text="Forget your password?" OnClick="forgotpasswordButton_Click" />
            <br />
            <asp:Button ID="createNewAccountButton" runat="server" Text="Create a new Account?" PostBackUrl="~/NewAccount.aspx" CausesValidation="false" CssClass="btn" />
        </div>
    
            
</asp:Content>
