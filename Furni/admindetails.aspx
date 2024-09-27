<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admindetails.aspx.cs" Inherits="Furni.admindetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 271px;
        }
        .auto-style2 {
            width: 53px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    </p>
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" BackColor="#99CCFF" Font-Size="Large" Text="Welcome ...admin                                "></asp:Label>
                <asp:Label ID="Label6" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Italic="True" Font-Size="Large" ForeColor="#3399FF" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                <asp:ImageButton ID="ImageButton1" runat="server" BorderStyle="Solid" Height="156px" ImageUrl="~/ph/istockphoto-966443884-612x612.jpg" OnClick="ImageButton1_Click" Width="147px" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:ImageButton ID="ImageButton3" runat="server" BorderColor="#FF66CC" BorderStyle="Solid" Height="156px" ImageUrl="~/ph/istockphoto-966443884-612x612.jpg" OnClick="ImageButton3_Click" Width="147px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" BackColor="#FFFF99" Text="Click button to Add Category"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server" BackColor="#FFFF99" Text="Click button to Add Product"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                <asp:ImageButton ID="ImageButton2" runat="server" BackColor="#FFCCCC" BorderColor="#996633" BorderStyle="Dashed" ForeColor="#996633" Height="156px" ImageUrl="~/photo2/istockphoto-1256772810-612x612.jpg" OnClick="ImageButton2_Click" Width="147px" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:ImageButton ID="ImageButton4" runat="server" BorderColor="#FF99CC" BorderStyle="Dashed" Height="156px" ImageUrl="~/photo2/istockphoto-1256772810-612x612.jpg" OnClick="ImageButton4_Click" Width="147px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" BackColor="#66FF33" Text="Click button to Edit Category details"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label4" runat="server" BackColor="Lime" Text="Click button to Edit product details"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
