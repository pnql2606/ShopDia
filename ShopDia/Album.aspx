<%@ Page Title="Album" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Album.aspx.cs" Inherits="ShopDia.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <body> 
      <section style="margin-top:100px">
         <div>
         <hgroup>
         <h2><%: Page.Title %></h2>
         </hgroup>
         <asp:ListView ID="danhsach" runat="server" DataKeyNames="MaDia" GroupItemCount="4" ItemType="ShopDia.Models.Album" SelectMethod="GetAlbums">
         <EmptyDataTemplate>
             <table >
                 <tr>
                     <td>Không thấy dữ liệu</td>
                 </tr>
             </table>
         </EmptyDataTemplate>
         <EmptyItemTemplate>
         <td/>
         </EmptyItemTemplate>
         <GroupTemplate>
             <tr id="itemPlaceholderContainer" runat="server">
             <td id="itemPlaceholder" runat="server"></td>
          </tr>
         </GroupTemplate>
         <ItemTemplate>
              <td id="Td1" runat="server">
                  <table>
                     <tr>
                     <td>
                         <a href="ChiTiet.aspx?bookID=<%#:Item.MaDia%>">
                         <img src ="/Images/<%#:Item.HinhAnh%>" width="150" height="225" style="border:solid" /></a>
                    </td>
                     </tr>
             <tr>
          <td>
         <a href="ChiTiet.aspx?bookID=<%#:Item.MaDia%>">
         <span>
         <%#:Item.TenDia%>
             </span>
             </a>
             <br />
             <span>
         <b>Giá: </b><%#:String.Format("{0:c}",Item.Gia)%>
          </span>

             <br />
              <a href="AddToCart.aspx?bookID=<%#:Item.MaDia%>">
     <span>
         <b>Thêm vào giỏ sách<b>
            </span>
             </a>        
             </td>
             </tr>
            <tr>
         <td>&nbsp;</td>
         </tr>
         </table>
         </p>
         </td>
         </ItemTemplate>
         <LayoutTemplate>
                  <table style="width:100%;">
                  <tbody>
                      <tr>
                      <td>
                          <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                            <tr id="groupPlaceholder"></tr>
                     </table>
              </td>
                 </tr>
                 <tr>
             <td></td>
             </tr>
         <tr></tr>
         </tbody>
         </table>
         </LayoutTemplate>
         </asp:ListView>
         </div>
         </section>
        </body>
</asp:Content>
