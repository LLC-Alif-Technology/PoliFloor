window.onload = function () {
  if (this.innerWidth > 620) {
    $(".rewards-wrapper").slick({
      slidesToShow: 3,
      slidesToScroll: 1,
      arrows: true,
    });
    $(".main-reviews .main-slider").slick({
      slidesToShow: 2,
      slidesToScroll: 1,
      arrows: true,
    });

    $(".main-catalog .catalogs").slick({
      slidesToShow: 4,
      slidesToScroll: 1,
      arrows: true,
    });

    $(".main-projects .cards").slick({
      slidesToShow: 1,
      slidesToScroll: 1,
      arrows: true,
      nextArrow: $(".main-projects .next img"),
      prevArrow: $(".main-projects .prev img"),
    });
  } else {
    $(".rewards-wrapper").slick({
      slidesToShow: 1,
      slidesToScroll: 1,
      arrows: false,
      dots: true,
    });

    $(".main-reviews .main-slider").slick({
      slidesToShow: 1,
      slidesToScroll: 1,
      arrows: false,
      dots: true,
    });
    $(".main-catalog .catalogs").slick({
      slidesToShow: 1,
      slidesToScroll: 1,
      arrows: false,
      dots: true,
    });
  }
};

$(() => {
  $(".play-button").click(function () {
    $(this).hide();
  });
});

const rateImages = $("#mainLead .rate img");

for (let i = 0; i < rateImages.length; i++) {
  rateImages.eq(i).on("click", function () {
      fill(i);
      $("#rating").val(i+1)
  });
}

function fill(n) {
  for (let i = 0; i < rateImages.length; i++) {
    if (i <= n) {
      rateImages.eq(i).addClass("filled");
    } else {
      rateImages.eq(i).removeClass("filled");
    }
  }
}

