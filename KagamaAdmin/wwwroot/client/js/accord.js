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
    let updateResultEl = $(".main-calculator .result tbody");
    const calcButtonsEl = $(".main-calculator .service .bottom .text");

    setCalculatorPosition();

    let clicked = false;

    for (let i = 0; i < calcButtonsEl.length; i++) {
        calcButtonsEl.eq(i).click(function () {
            if (!clicked) {
                resultEl.slideDown();
            }

            updateResultEl.fadeOut();

            // changeResults();

            updateResultEl.fadeIn();
            clicked = true;
        });
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