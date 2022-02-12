makeGallery($(".main-reviews .slide .image_desc img"));

function makeGallery(elem) {
  const animTransition = 200;

  for (let i = 0; i < elem.length; i++) {
    elem.eq(i).on("click", function () {
      const newImage = $(`<img />`);

      newImage.attr("src", $(this).attr("src")).css({
        width: "auto",
        height: "100%",
        objectFit: "cover",
        border: "4px solid #fff",
      });
      $("body").css("overflow", "hidden");

      $(".img-preview-modal").html("").append(newImage);
      $(".img-preview-modal").fadeIn(animTransition).css("display", "flex");
    });
  }
  $(".img-preview-modal").on("click", function (e) {
    if (e.target.tagName !== "IMG") {
      closeModal();
    }
  });

  function closeModal() {
    $(".img-preview-modal").html("").fadeOut(animTransition);
    $("body").css("overflow", "auto");
  }
}
