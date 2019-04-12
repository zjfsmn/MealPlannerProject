<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PhysicalProfile.aspx.cs" Inherits="MealPlanner.Web.PhysicalProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainPlaceholder" runat="server">

    <fieldset>
        <div class="form-group row">
            <label class="col-12 col-sm-4  col-form-label btn btn-info">What do you want?</label>
            <div class="col-12 col-sm-8">
              
                    <asp:RadioButton ID="RadioButtonLoseWeight" runat="server" Text="Lose Weight" CssClass="col-sm-2" GroupName="GoalGroup" Checked="true" />
                    <asp:RadioButton ID="RadioButtonMaintain" runat="server" Text="Maintain" CssClass="col-sm-2" GroupName="GoalGroup" />
             
            </div>
        </div>

        <div class="form-group row">
            <label class="col-12 col-sm-4  col-form-label btn btn-info">Gender</label>
            <div class="col-12 col-sm-8">
                <asp:RadioButton ID="RadioButtonMale" runat="server" Text="Male" CssClass="col-sm-2" GroupName="GenderGroup" Checked="true" />
                <asp:RadioButton ID="RadioButtonFemale" runat="server" Text="Female" CssClass="col-sm-2" GroupName="GenderGroup" />
            </div>
        </div>

        <div class="form-group row">
            <label for="height-inputs" class="col-12 col-sm-4 col-form-label btn btn-info">Height</label>

            <div class="inline_block col-12 col-sm-8" id="height-inputs">
                    <asp:TextBox ID="txbheightfeet" runat="server" CssClass="col-sm-2 d-inline-block"></asp:TextBox>
                        <label for="txbheightfeet" >ft</label>                                          
                    <asp:TextBox ID="txbheightinch" runat="server" CssClass="col-sm-2 d-inline-block"></asp:TextBox>
                        <label for="txbheightinch">in</label>             
            </div>
        </div>

         <div class="form-group row">
                <label for="weight-input" class="col-12 col-sm-4 col-form-label btn btn-info">Weight</label>

                <div class="inline_block col-12 col-sm-8" id="weight-input">
                   
                    <asp:TextBox ID="txbWeight" runat="server" CssClass="col-sm-2 d-inline-block"></asp:TextBox>
                    <label for="txbWeight" >lbs</label>
                    
                </div>
            </div>

         <div class="form-group row">
                <label for="age-input" class="col-12 col-sm-4 col-form-label btn btn-info">Age</label>

                <div class="inline_block col-12 col-sm-8" id="age-input">
                   
                    <asp:TextBox ID="txbAge" runat="server" CssClass="col-sm-2 d-inline-block"></asp:TextBox>
                    <label for="txbAge" >years</label>
                    
                </div>
            </div>

        <div class="form-group row">
                <label for="DDLExercise" class="col-12 col-sm-4 col-form-label btn btn-info">Activity level</label>

                <div class="col-12 col-sm-8">
                  

                    <asp:DropDownList ID="DDLExercise" runat="server">
                        <asp:ListItem Value="sedentary"> sedentary  (little or no exercise)</asp:ListItem>
                        <asp:ListItem Value="lightlyActive" Selected="True"> lightly active  (light exercise/sports 1-3 days/week)</asp:ListItem>
                        <asp:ListItem Value="moderatelyActive">moderately active  (moderate exercise/sports 3-5 days/week)</asp:ListItem>
                        <asp:ListItem Value="veryActive">very active  (hard exercise/sports 6-7 days a week)</asp:ListItem>
                        <asp:ListItem Value="extraActive">extra active  (very hard exercise/sports &amp; physical job or 2x training) </asp:ListItem>
                    </asp:DropDownList>
            </div>
            </div>

           


                 <div class="form-group row">
                <label for="goalWeight-input" class="col-12 col-sm-4 col-form-label btn btn-info">What's your goal weight?</label>

                <div class="inline_block col-12 col-sm-8" id="goalWeight-input">
                   
                    <asp:TextBox ID="tbxGoalWeight" runat="server" CssClass="col-sm-2 d-inline-block"></asp:TextBox>
                    <label for="tbxGoalWeight" >lbs</label>
                    
                </div>
            </div>

        
                 <div class="form-group row">
                <label for="daysToGo-input" class="col-12 col-sm-4 col-form-label btn btn-info">How Many days to reach your goal?</label>

                <div class="inline_block col-12 col-sm-8" id="daysToGo-input">
                   
                    <asp:TextBox ID="tbxDaysToGo" runat="server" CssClass="col-sm-2 d-inline-block"></asp:TextBox>
                    <label for="tbxDaysToGo" >days</label>


                   
                    
                </div>
            </div>

        <div class="row">
            <div class="form-group row col-sm-9">

                <div class="offset-sm-2  col-sm-4 top_spacer bottom_spacer">

                    <asp:Button ID="calculate_button" runat="server" Text="Calculate" CssClass="btn btn-lg btn-block btn-danger" OnClick="calculate_button_Click" />
                    <br />

                    <asp:Label ID="validationLabel" runat="server" Text="" Visible="false" CssClass="btn-primary"></asp:Label>

                    <table class="table">
                        <thead>
                            <tr>
                                <th><strong>BMI</strong></th>
                                <th><strong>Suggested Calories</strong></th>

                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <asp:Label ID="LabelMBI" runat="server" Text=""></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="LabelSuggestCalories" runat="server" Text=""></asp:Label></td>
                            </tr>
                        </tbody>
                    </table>

                </div>
            </div>
            <div class="col-sm-3">
                <asp:Button ID="BtnNextStep" runat="server" Text="Next Step" PostBackUrl="~/DietProfile.aspx" />
            </div>

        </div>

    </fieldset>

</asp:Content>
