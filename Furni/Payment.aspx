<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Furni.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 208px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            width: 693px;
        }
        .auto-style7 {
            width: 105%
        }
        .auto-style8 {
            margin-left: 15px;
        }
        .auto-style10 {
            width: 445px;
        }
        .auto-style11 {
            width: 62px;
        }
        .auto-style12 {
            width: 99%
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style7">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#3333FF" Text="Payments"></asp:Label>
            </td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Account Number"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">Balance Amount to be paid</td>
            <td class="auto-style6">
                &nbsp;&nbsp;&nbsp;<asp:Label ID="Label10" runat="server" Text="₹"></asp:Label>
            &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label9" runat="server" Text="Balance in account"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label8" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/photo1/pay.jpg" Width="72px" OnClick="ImageButton1_Click" />
            </td>
            <td class="auto-style6">
                <asp:Panel ID="Panel1" runat="server" Visible="False" Width="429px">
                    <table class="auto-style12">
                        <tr>
                            <td class="auto-style10">
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td class="auto-style10">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style11">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update new balance" />
                            </td>
                            <td class="auto-style10">₹
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style8" Height="25px" Width="116px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style11">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                &nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="auto-style11">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">&nbsp;</td>
                            <td class="auto-style10">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style11">&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td class="auto-style6">
            </td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style6">
                                <asp:Label ID="Label7" runat="server" Text="Balance Updated" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">
                                <asp:ImageButton ID="ImageButton2" runat="server" CssClass="auto-style5" Height="99px" ImageUrl="~/photo1/continue shop.jpg" PostBackUrl="~/userdetails.aspx" Visible="False" Width="127px" />
                            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
