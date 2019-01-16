<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookAnOrder.aspx.cs" Inherits="PicnicRUS.BookAnOrder" %>
    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <form id="form1" >
        <div>
            <br />
            <br />
        </div>
        <asp:Label ID="lblFirstName" runat="server" Text="FirstName"></asp:Label>
        :
        <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstname" ErrorMessage="Please Enter the First Name"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblLastname" runat="server" Text="LastName"></asp:Label>
        :&nbsp;
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Please Enter the Last Name"></asp:RequiredFieldValidator>
        <br />
        <br />
        ContactNumber:
        <asp:TextBox ID="TxtContactNumber" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularContactNumber" runat="server" ControlToValidate="TxtContactNumber" ErrorMessage="Please Enter Valid Phone Number" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Customer Type"></asp:Label>
&nbsp;
        <asp:DropDownList ID="ddlCustomerType" runat="server">
            <asp:ListItem>Regular</asp:ListItem>
            <asp:ListItem>Cooperate</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="LblAddress" runat="server" Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCreateCustomer" runat="server" OnClick="Button1_Click" Text="Create Customer" />
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Update Customer" OnClick="Button2_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCustomerCreation" runat="server" Text="Message" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Calendar ID="CalDate" runat="server" OnSelectionChanged="CalDate_SelectionChanged" Visible="False"></asp:Calendar>
        <br />
        Picnic Date :<asp:Button ID="BtnDate" runat="server" OnClick="BtnDate_Click" Text="Choose " />
        <asp:TextBox ID="TxtDate" runat="server" OnTextChanged="TxtDate_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEmployeeAssigned" runat="server" Text="Employee Assigned"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlemployeename" runat="server" DataSourceID="SqlDataSource1" DataTextField="Employee_Name" DataValueField="Employee_Name" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PicnicRUSConnectionString2 %>" SelectCommand="SELECT [Employee_Name] FROM [Employee]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="btnAvailability" runat="server" OnClick="btnAvailability_Click" Text="Check Availability" />
&nbsp;&nbsp;
        <asp:Label ID="lblEmpAvailbility" runat="server" Text="Message Employee Availbility" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        <br />
        <br />
    </form>
        </asp:Content>