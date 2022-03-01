if (window.matchMedia("(max-width: 1024px)").matches) {
  $(document).on("ready", function () {
    $(".out-team-carusel").slick({
      dots: true,
      infinite: true,
      slidesToShow: 1,
      slidesToScroll: 1,
      arrows: false,
    });
  });
} else if (window.matchMedia("(min-width: 1385px)").matches) {
  $(document).on("ready", function () {
    $(".out-team-carusel").slick({
      dots: true,
      infinite: true,
      slidesToShow: 4,
      slidesToScroll: 4,
      arrows: true,
    });
  });
} else if (window.matchMedia("(max-width: 1385px)").matches) {
  $(document).on("ready", function () {
    $(".out-team-carusel").slick({
      dots: true,
      infinite: true,
      slidesToShow: 4,
      slidesToScroll: 4,
      arrows: false,
    });
  });
}
