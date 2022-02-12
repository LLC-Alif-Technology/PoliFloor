// $(() => {
// -----Accordeon-----

const accordItems = $(".main-qna .accord .item");

for (let i = 0; i < accordItems.length; i++) {
  accordItems.eq(i).click(function () {
    closeAll($(this));

    $(this).find(".answer").slideToggle(500);
    $(this).find(".arrow").toggleClass("rotate");
  });
}

// ........end........

// -----Calculator-----

let resultEl = $(".main-calculator .result");

let updateResultEl = $(".main-calculator .result tbody"),
  calcButtonsEl = $(".main-calculator .service .bottom .text");

setCalculatorPosition();

let clicked = false;

for (let i = 0; i < calcButtonsEl.length; i++) {
  calcButtonsEl.eq(i).click(function () {
    if (!clicked) {
      resultEl.slideDown();
    }

    const dataThick = $(this).parent().parent().attr("data-thick");
    $("#thickVal").html(`<option>${dataThick}</option>`);

    updateResultEl.fadeOut();

    $.ajax(
      `calculat?id=${$(this).parent().parent().attr("data-id")}&area=${$(
        "#area"
      ).val()}&thick=${dataThick}&varnish=Матовый`
    ).then((res) => {
      console.log(res);

      let result = "";

      let totalSumPerSquare = 0;

      let area = +$("#area").val();

      for (let i = 0; i < res.calcProducts.length; i++) {
        const product = res.calcProducts[i];

        const pricePerSquare =
          (product.kg / 1000) * (product.prPriceKg * res.eur);

        result += `<tr>
            <td>${product.prTitle}</td>
            <td>${intShortener(product.kg / 1000)}</td>
            <td>${intShortener((product.kg / 1000) * area)}</td>
            <td>${intShortener(pricePerSquare)}</td>
            <td>${intShortener(
              (product.kg / 1000) * area * (product.prPriceKg * res.eur)
            )}</td>
          </tr>`;
      }

      $("#tbody").html(result);

      updateResultEl.fadeIn();

      $(".main-calculator #totalPricePSEl").text(
        intShortener(res.totalSum_1m2)
      );
      $(".main-calculator #totalSum").text(intShortener(res.totalSum));
      $(".main-calculator #totalCount").text(area);
      $(".main-calculator .price-page").fadeIn();

      clicked = true;
    });
  });
}

function intShortener(num) {
  const result = num % 2 !== 0 ? num.toFixed(2) : num;
  return result;
  //   if (`${parseInt(result)}`.length < 4) {
  //     return result;
  //   }

  //   let str = `${result}`;
  //   const afterDot = str.slice(str.indexOf("."));
  //   const start = str.slice(0, str.length % 3);

  //   str = str.replace(afterDot, "");
  //   let newStr = "";

  //   for (let i = str.length % 3; i < str.length; i++) {
  //     newStr += str[i];
  //     if ((i - (str.length % 3) + 1) % 3 === 0) {
  //       newStr += " ";
  //     }
  //   }

  //   return start + " " + newStr + afterDot;
}

console.log(calcButtonsEl);

// ....................

function setCalculatorPosition() {
  if ($(window).innerWidth() <= 620) {
    resultEl = $(".main-calculator .result-table");
    updateResultEl = $(".main-calculator .result-table");
  } else {
    resultEl = $(".main-calculator .result");
    updateResultEl = $(".main-calculator .result tbody");
  }
}

function closeAll(self) {
  for (let i = 0; i < accordItems.length; i++) {
    accordItems.eq(i).not(self).find(".answer").slideUp(500);
    accordItems.eq(i).not(self).find(".arrow").removeClass("rotate");
  }
}
// });

// -------- main-projects counter --------

$(".main-projects #total").text($(".main-projects .card").length);

getLink();

$(".main-projects .prev, .main-projects .next").on("click", () => {
  const current =
    $(".main-projects .card").index($(".main-projects .slick-current")) === -1
      ? $(".main-projects .card").not(".slick-cloned").length
      : $(".main-projects .card").index($(".main-projects .slick-current")) + 1;

  $(".main-projects #current").text(current);

  getLink();
});

function getLink() {
  $(".last-el a").attr(
    "href",
    $(".main-projects .card")
      .eq($(".main-projects .card").index($(".slick-current")) + 1)
      .attr("data-alias")
  );
}
// ----------------------------------------
