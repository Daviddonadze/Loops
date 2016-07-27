<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CheckBoxDwopdownWithJquery._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


     <asp ID="Label1" runat="server" Text="Use this AMS"></asp>
    <input type="checkbox" runat ="server" ID="chkPhoneSMS" onclick="chkChanged()" />
    &nbsp &nbsp 
    <asp:Label ID="lblServiceProvider" runat="server" Text="Service Provider"></asp:Label>
    <asp:DropDownList ID="ddlServiceProvider" runat="server">
        <asp:ListItem Text="-----Select---" Value="0"></asp:ListItem>
        <asp:ListItem Text="ATT" Value="1"></asp:ListItem>
        <asp:ListItem Text="Verizon" Value="2"></asp:ListItem>
        <asp:ListItem Text="Sprint" Value="3"></asp:ListItem>
        <asp:ListItem Text="TMoble" Value="4"></asp:ListItem>

    </asp:DropDownList>
    
    <ul>
        
        <li>Ira</li>
        <li>Ira1</li>

    </ul>
    
    <input type="image" id="btnHelpWindow"  src="Images/HelpIcon.jpg"  onclick="howToBid();" style="width: 20px;" />
    
     <div  id ="dvhowToBid" class = "MyClass" style="display: none">
        
            Ira will find a job
            Yuri will find a job
            Vlad will find a job
            David will find a job
            Allya will find a job
            Anu Raj will find a job

   </div>
    

    <script type="text/javascript">
    $(document).ready(function () {
        $('#<%= ddlServiceProvider.ClientID %>').attr("disabled", "true");
       

    });

        function howToBid() {
            var el = $('.MyClass')[0].innerHTML;
            alert(el);

        }

        function chkChanged() {
        if ($('#<%= chkPhoneSMS.ClientID %>').is(':checked')) {
        $('#<%= ddlServiceProvider.ClientID %>').removeAttr("disabled");
        }
        else {
        $('#<%= ddlServiceProvider.ClientID %>').attr("disabled", "true");
            }
        }
        </script>
</asp:Content>
