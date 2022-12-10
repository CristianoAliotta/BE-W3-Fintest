<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BE_W3_Fintest.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="d-flex">
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
     
<div class="mainPage d-flex flex-wrap pb-4">
     <div class="p-5 mb-4 rounded-3 mt-5 jumbo "id="hero">
      <div   >
        <div id="heroTxt" class="p-4  rounded-3">
        <h1 class="display-5 fw-bold text-warning">HOLIDAY SALES</h1>
        <p class="col-md-8 fs-4 text-white">SAVE UP TO 50% ON VAPES AND CBD</p>
        <button class="btn btn-sm fs-4 prime" type="button">View Products</button>
        </div>
      </div>
    </div>
 <asp:Repeater ID="RepeaterVape" runat="server" ItemType="BE_W3_Fintest.Articolo">
    <ItemTemplate>
        <div class="" id="art">
            <asp:Image ID="ImgProd" runat="server" ImageUrl="<%# Item.Img %>" CssClass="artImg" />
            <div class="card-body mx-auto">
            <h5 class="card-title "><%# Item.Name %></h5>
            <p class="card-text"><%# Item.Price %>$</p>
            </div>
            <div id="btnDiv">
            <button id="artBtn"><a href="Detail.aspx?Id=<%# Item.Id %>">More info</a></button>
            </div>
        </div>
   </ItemTemplate>
 </asp:Repeater>
</div>
</div>
</asp:Content>

