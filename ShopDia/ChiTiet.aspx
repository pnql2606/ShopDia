<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChiTiet.aspx.cs" Inherits="ShopDia.ChiTiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div>
    <asp:FormView ID="ChiTiet" runat="server" ItemType="ShopDia.Models.Album" SelectMethod ="GetDetails" RenderOuterTable="false">
 <ItemTemplate >
 <div >
 <h1><%#:Item.TenDia %></h1>
 </div>
 <br />
 <table>
 <tr>
 <td>
 <img src="/Images/<%#:Item.HinhAnh %>"
 style="border:solid; height:225px" alt="<%#:Item.TenDia %>"/>
 </td>
 <td>&nbsp;</td>
 <td style="vertical-align: top; text-align:left;">
 <b>Mô tả sách:</b><br /><%#:Item.MoTa %>
 <br />
 <span><b>Giá:</b>&nbsp;<%#: String.Format("{0:c}",Item.Gia)%></span>
 <br />
 <span><b>Mã sách:</b>&nbsp;<%#:Item.MaDia %></span>
 <br />
 <br />
 </td>
 </tr>
 </table>
 </ItemTemplate>
 </asp:FormView>
     </div>
</asp:Content>
