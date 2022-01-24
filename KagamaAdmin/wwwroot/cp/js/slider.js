window.onload = () => {
  const slider = document.querySelector(".my .slider"),
    next = document.querySelector(".my .next"),
    prev = document.querySelector(".my .prev");

  const slides = document.querySelectorAll(".my .slide");

  let totalSlideWidth = slides[0].offsetWidth * slides.length;
  let sliderWidth = slider.offsetWidth;
  let position = 0;

  next.onclick = () => {
    if (position < totalSlideWidth) {
      position += sliderWidth;
    }

    slider.scrollTo(position, 0);

    next.style.opacity = position >= totalSlideWidth ? 0.3 : 1;
    prev.style.opacity = 1;
  };

  prev.onclick = () => {
    if (position > 0) {
      position -= sliderWidth;
    }

    slider.scrollTo(position, 0);

    prev.style.opacity = position <= 0 ? 0.3 : 1;
    next.style.opacity = 1;
  };


  initializeSwiper();
};

function initializeSwiper() {
  const slider = document.querySelector(".my .gallery-top"),
    slides = document.querySelectorAll(".my .slide"),
    sliderMain = document.querySelector(".my .main-slider");

  if (this.innerWidth <= 1475) {
    slider.classList.remove("slider-container");
    slider.classList.add("swiper-container");

    sliderMain.classList.remove("slider");

    for (let i = 0; i < slides.length; i++) {
      slides[i].classList.add("swiper-slide");
      slides[i].classList.remove("margin");
    }
  } else {
    slider.classList.add("slider-container");
    slider.classList.remove("swiper-container");

    sliderMain.classList.add("slider");

    for (let i = 0; i < slides.length; i++) {
      slides[i].classList.remove("swiper-slide");
      slides[i].classList.add("margin");
    }
  }
}

window.onresize = initializeSwiper;
