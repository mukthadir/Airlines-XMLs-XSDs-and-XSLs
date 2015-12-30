<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AirlinesTryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2> Mukthadir H Choudhury &nbsp &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp Assignment 4 Part 1 </h2>

        Please Enter the url of the Airlines.xml file:
        <asp:TextBox ID="TextBox1" runat="server" Width="800px"></asp:TextBox><br />
        url where I have saved my airlines.xml -> http://www.public.asu.edu/~mhchoudh/Airlines.xml <br />
        please copy paste the above url and put it in the textbox.
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" style = "LEFT: 700px; POSITION: absolute;" />
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"  Height="600px" Width="1200px" Wrap="True"></asp:TextBox>
    </div>
</asp:Content>
