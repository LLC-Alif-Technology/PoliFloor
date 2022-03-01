const getReviewsByServiceId = (serviceId) => {
    $.ajax({
        url: `Home/GetServicId?id=${serviceId}`,
        method: 'GET',
        success: (data) => {
            const parsed = data.map((review) => {
                const {name, city, rating, creationData, title, img, img2, img3, img4} = review
                return makeDynamicReview(name, city, rating, creationData, title, img, img2, img3,img4)
            })
            $('#reviews').html(parsed.join('\n'))
        }
    })
}

const makeDynamicReview = (name, city, rate, date, title, img, img2, img3, img4) => {
    const parsedDate = new Date(date);
    const day = parsedDate.getDate() > 9 ? parsedDate.getDate() : `0${parsedDate.getDate()}`
    const month = parsedDate.getMonth()+1 > 9 ? parsedDate.getMonth()+1 : `0${parsedDate.getMonth()+1}`
    const year = parsedDate.getFullYear()
    
    return `<div class="slide">
            <div class="info">
                <div class="name">${name}</div>
                <div class="city_name">${city}</div>
            </div>
            <div class="info">
                <div class="rate">
                    ${`<img src="/client/img/fullfilled.png" />\n`.repeat(rate)}
                    ${`<img src="/client/img/empty.png" />\n`.repeat(5 - rate)}
                    ${rate.length === 0 ? `<img src="/client/img/empty.png" />\n`.repeat(5) : ''}
                </div>
                <div class="date">${day} ${month} ${year}</div>
            </div>
            <div class="description">
                ${title}
            </div>
            <div class="image_desc">
                ${img && '<img src=' + img + ' />' || ""}
                ${img2 && '<img src=' + img2 + ' />' || ""}
                ${img3 && '<img src=' + img3 + ' />' || ""}
                ${img4 && '<img src=' + img4 + ' />' || ""}
            </div>
        </div>`
}

$(function () {
    getReviewsByServiceId($('#reviews').attr('data-serviceId'))
})

const rateImages = $("#mainLead2 .rate img");
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



