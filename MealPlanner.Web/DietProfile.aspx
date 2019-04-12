<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DietProfile.aspx.cs" Inherits="MealPlanner.Web.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainPlaceholder" runat="server">

    <fieldset class="align-content-center">
          <br />
          <br />

        <div class="form-group row">
            <label class="col-12 col-sm-3  col-form-label btn btn-info">Your Diet Choice?</label>
            <div class="col-12 col-sm-9">
              
                    <asp:RadioButton ID="RadioButtonAnything" runat="server" Text="Anything" CssClass="col-sm-2" GroupName="DietChoiceGroup" Checked="true" />
                    <asp:RadioButton ID="RadioButtonVegan" runat="server" Text="Vegan" CssClass="col-sm-2" GroupName="DietChoiceGroup" />
             
            </div>
        </div>
        <br />
       
         <%-- <div class="form-group row">
              
                 <label for="DDLExercise" class="col-12 col-sm-3 col-form-label btn btn-info">Do you have any Allergies?</label>
          
              <%--<div class="col-12 col-sm-9">
                    <asp:CheckBoxList ID="CheckBoxListAllergies" runat="server" RepeatColumns="4">

                        <asp:ListItem Text="Gluten" Value="Gluten" ></asp:ListItem>
                        <asp:ListItem Text="Peanut" Value="Peanut"></asp:ListItem>
                        <asp:ListItem Text="Eggs" Value="Eggs"></asp:ListItem>
                        <asp:ListItem Text="Dairy" Value="Dairy"></asp:ListItem>
                         <asp:ListItem Text="Soy" Value="Soy"></asp:ListItem>
                        <asp:ListItem Text="Onion" Value="Onion"></asp:ListItem>
                        <asp:ListItem Text="Nuts" Value="Nuts"></asp:ListItem>
                        <asp:ListItem Text="Seafood" Value="Seafood"></asp:ListItem>
                    </asp:CheckBoxList>
          
            </div>--%>

              
                

        <div style="font-family: Arial">
            <fieldset style="width: 350px">
                <legend><b>Allergies</b></legend>
                <asp:CheckBox ID="GlutenCheckBox" Checked="true" Text="Gluten" runat="server"  />
                <asp:CheckBox ID="PeanutCheckBox" runat="server" Text="Peanut" />
                <asp:CheckBox ID="EggsCheckBox" Text="Eggs" runat="server" />
                <asp:CheckBox ID="DairyCheckBox" Text="Dairy" runat="server" />
                <asp:CheckBox ID="SoyCheckBox" runat="server" Text="Soy" />
                <asp:CheckBox ID="OnionCheckBox" runat="server" Text="Onion" />
                <asp:CheckBox ID="NutsCheckBox" runat="server" Text="Nuts" />
                <asp:CheckBox ID="SeafoodCheckBox" runat="server" Text="Seafood" />
            </fieldset>
        
    <br />
            <br />
           
        </div>


        <br />
                 <br />
              <div class="form-group offset-sm-2  col-sm-4">
            <asp:Button ID="BtnDietSubmit" runat="server" CssClass="btn btn-lg btn-block btn-danger" Text="Submit My Diet Choice" OnClick="BtnDietSubmit_Click" />

        </div>
        

        
          

    </fieldset>
   




   
</asp:Content>
