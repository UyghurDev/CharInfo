<%@ Page Title="ھەرىپ ئۇچۇرىغا ئېرىشىش" Language="C#" MasterPageFile="~/Common/Public.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CharInfo_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="text-align: center">
                <br />
              ھەرىپ ئۇچۇرىغا ئېرىشىش<br />
                <hr class="HorzentalLineHeader" dir="rtl" />
            </td>
        </tr>
        <tr>
            <td>
                <table cellpadding="0" dir="rtl" 
                    style="border-collapse: collapse; width: 600px; border: 1px solid #d5ddf3" align="center">
                    <tr>
                        <td >
                            <asp:Label ID="lblCodeTable" runat="server" Text="تېكىست:"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td dir="ltr">
                            <asp:TextBox ID="txtSource" runat="server" Height="200px" TextMode="MultiLine" 
                                Width="600px" CssClass="TextBox">ئاەبپتجچخدرزژسشغفقكگڭلمنھوۇۆۈۋېڭي</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center">
                            <asp:Button ID="btnGetInfo" runat="server" OnClick="Convert_Click" 
                                Text="ئۇچۇرىنى ئېلىش" />
                            <br />
                            <asp:Panel ID="Panel1" runat="server" Height="400px" ScrollBars="Horizontal" 
                                Width="600px">
                                <asp:GridView ID="dgvResult" 
    runat="server" CellPadding="4" ForeColor="#333333" 
    GridLines="None" Width="100%">
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" 
                                                    ForeColor="White" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" 
                                                    HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" 
                                                    ForeColor="#333333" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" 
                                                    ForeColor="White" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" 
                                                    ForeColor="#284775" />
                                </asp:GridView>
                            </asp:Panel>
                        </td>
                                        </tr>
                                        <tr>
                                        <td>
                                            &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#CCCCFF">
                                                <asp:Literal ID="ltrlConvertedText" runat="server"></asp:Literal>
                                            </td>
                                        </tr>
                                    </table>
               
                <br />
                مۇناسىۋەتلىك ئۇلىنىشلار<hr align="right" class="HorzentalLineLinks" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

