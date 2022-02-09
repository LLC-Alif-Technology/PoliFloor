const Slider = document.getElementById("tvScrollLists");
const buttonNext = document.getElementById("sliderListsNext");
const buttonPrev = document.getElementById("sliderListsPrev");
const UnListsTv = document.getElementById("UnListsTv");
const sliderSelectCard = document.getElementById("sliderSelectCard");
const cards = [...sliderSelectCard.children];

let { children } = UnListsTv;
let index = 0;

buttonNext.onclick = (evt) => {
  evt.preventDefault();

  let defaultscroll = children[children.length - 1].offsetLeft;

  if (index > children.length) {
    return;
  }

  index++;

  Slider.scrollLeft = children[index]?.offsetLeft || defaultscroll;
};

buttonPrev.onclick = (evt) => {
  evt.preventDefault();

  let defaultscroll = 0;

  if (index <= 0) {
    return;
  }

  index--;

  Slider.scrollLeft = children[index]?.offsetLeft || defaultscroll;
};

cards.forEach((o, i) => {
  o.onclick = () => {
    Slider.scrollLeft = children[i]?.offsetLeft;
    
  };
});
