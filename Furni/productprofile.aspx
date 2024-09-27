<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="productprofile.aspx.cs" Inherits="Furni.productprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 205px;
        }
        .auto-style2 {
            margin-left: 120px;
            width: 214px;
        }
        .auto-style3 {
            margin-top: 38px;
        }
        .auto-style4 {
            width: 214px;
        }
        .auto-style5 {
            width: 185px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Image ID="Image1" runat="server" Height="135px" Width="145px" />
            </td>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#993366" Text="Label"></asp:Label>
                <br />
                ₹
                <asp:Label ID="Label2" runat="server" ForeColor="#006666"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" ForeColor="#006666" Text="Label"></asp:Label>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#006666" Text="Quantity"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>Select Quantity</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>₹</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#006666" Text="Total Price"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:Label ID="Label8" runat="server" Text="₹" Visible="False"></asp:Label>
&nbsp;<asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="152px" ImageUrl="~/photo2/addtocart.png" OnClick="ImageButton1_Click" Width="250px" />
            </td>
            <td class="auto-style4">
                <asp:ImageButton ID="ImageButton2" runat="server" CssClass="auto-style3" Height="124px" ImageUrl="~/photo2/continueshopping.jpg" OnClick="ImageButton2_Click" Width="186px" />
            </td>
            <td class="auto-style5">
                <asp:ImageButton ID="ImageButton3" runat="server" Height="94px" ImageUrl="~/photo2/viewcart.jpg" PostBackUrl="~/viewcart.aspx" Width="184px"  />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
