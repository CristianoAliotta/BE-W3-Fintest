<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="BE_W3_Fintest.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="d-flex">
<div>
     <div class="h-100">
     <div class="d-flex flex-column flex-shrink-0  aside" style="width: 4.5rem;">
    
    <ul class="nav nav-pills nav-flush flex-column mb-auto text-center">
      <li class="nav-item mt-5">
        <a href="Default.aspx" class="nav-link py-3  rounded-0" aria-current="page" title="Home" data-bs-toggle="tooltip" data-bs-placement="right">
          <i class="fa-solid fa-house text-white fs-2  "></i>
        </a>
      </li>
      <li class="nav-item">
        <a href="Cart.aspx" class="nav-link py-3  rounded-0" aria-current="page" title="Home" data-bs-toggle="tooltip" data-bs-placement="right">
          <i class="fa-solid fa-cart-shopping text-white fs-2  "></i>
        </a>
      </li>
      
    </ul>
 
  </div>
</div>

</div>
<div class="d-flex justify-content-center container-fluid pb-4">
    <div class="container cart rounded-3 mt-5 d-flex flex-column align-content-start p-4 " id="GridContainer" runat="server" visible="false">
        <asp:GridView ID="CartGrid" runat="server" AutoGenerateColumns="false" ItemType="BE_W3_Fintest.Articolo" CssClass="table table-borderless text-white">
            <Columns>
                <asp:TemplateField HeaderText="Product Name">
                    <ItemTemplate>
                        <asp:Label CssClass="CartTitle" ID="ArtName" runat="server" Text="<%# Item.Name %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <asp:Label ID="ArtPrice" runat="server" Text="<%# Item.Price %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Label ID="ArtsSum" CssClass="CartTot" runat="server" Text=""></asp:Label> <br />
        <div class="d-flex justify-content-center">
        <asp:Button ID="Delete" runat="server" Text="Delete Cart" CssClass="btn btn-danger CartBtn mx-2" OnClick="DeleteCart" />
        <asp:Button ID="Button1" runat="server" Text="Checkout" CssClass="btn  CartBtn mx-2"  />
        </div>

    </div>
    <asp:Label ID="Empty" runat="server" Text="" Visible="true" CssClass="CartTot mt-5"></asp:Label>
</div>
</div>
</asp:Content>
