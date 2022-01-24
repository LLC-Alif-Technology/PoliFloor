const headerLists = document.getElementById("header-lists");
const topBlockMenu = document.getElementById("top-block-menu");
const swiperContainer = document.getElementById("swiper-container");
const HeaderLogo = document.getElementById("logo");

let openCloseMenu = false;
const urlIcomeMunu = "../client/img/top-menu-";

topBlockMenu.onclick = (evt) => {
  evt.preventDefault();

  openCloseMenu = !openCloseMenu;

  let heightLists = window.getComputedStyle(swiperContainer).height;

  headerLists.style.height = heightLists;
  headerLists.style.left = openCloseMenu ? 0 : "-100%";
  HeaderLogo.style.display = openCloseMenu ? "none" : "flex";
  topBlockMenu.children[0].src = openCloseMenu ? `${urlIcomeMunu}close.png` : `${urlIcomeMunu}open.png`;
};