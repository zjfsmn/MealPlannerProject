<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewAccount.aspx.cs" Inherits="MealPlanner.Web.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainPlaceholder" runat="server">
    
          <div class="col-12 text-center">
                 <h1>Create your account</h1>
            <p>We need a little information to get started</p>
            </div>
            
  
        
     <br />
         <br />
       
    

          <div class="form-group row align-content-center">

                <label class="col-sm-6">UserName:</label>
             <div class="col-sm-6">
                 <asp:TextBox ID="UserNameTextBox" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
              </div>
                      </div>
               
             <div class="form-group row">
                <label class="col-sm-6">Email:</label>
              <div class="col-sm-6">
               <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Invalid Email" ForeColor="Red" ControlToValidate="EmailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
              </div>
                 </div>
                
                
              <div class="form-group row">
                <label class="col-sm-6">Password:</label>
              <div class="col-sm-6">
                 <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"  CssClass="form-control"></asp:TextBox>
              </div>
                
          </div>

           <br />
    
      
    <div class="row justify-content-center">
         <div class="form-group">
             <div class="col-sm-6">
                    <asp:Button ID="CreateAccountButton" runat="server" Text="Create Your Account" CssClass="btn btn-lg btn-primary" OnClick="CreateAccountButton_Click"/>  </div>
             <div class="col-sm-6">
                 <asp:Label ID="validationLabel" Text="" Visible="false" runat="server" CssClass="bg-danger"></asp:Label>
           
             </div>
         
                
  

                 <br />
             <div class="row">
                 <div class="col-sm-12">
                     <asp:Button ID="LoginButton" runat="server" Text="Already a member? Sign in." PostBackUrl="~/SignIn.aspx" />
                 </div>
                 <asp:Button ID="NextStepButton" runat="server" Text="Next Step" PostBackUrl="~/PhysicalProfile.aspx" />
             </div>



         </div>
  
    </div>
        

   
           


</asp:Content>
