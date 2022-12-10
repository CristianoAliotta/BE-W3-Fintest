<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="BE_W3_Fintest.Detail" %>
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
    <div class="d-flex justify-content-center container-fluid pb-4 ">
    <div class="container detail d-flex rounded-3 mt-4">
        <div>
            <img id="ImgProd" runat="server" />
        </div>
        <div class="d-flex flex-column justify-content-around">
            <div class="px-4">
                <h1 id="ArtName" class="detailName" runat="server"></h1>
                <p id="ArtPrice" runat="server"></p>
                <asp:Button ID="AddItem" CssClass="detailBtn prime" runat="server" Text="Add to cart" OnClick="AddToCart" />
                
            </div>
            <div class="px-4">
                <p id="ArtDesc" runat="server"></p>
            </div>
        </div>
    </div>
    </div>
</div>
</asp:Content>
