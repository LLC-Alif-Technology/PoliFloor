
function change(el,revId) {
  $.ajax({
    url: "/cp/Review/UpdateTitle?id="+el.value+"&reviewId="+revId,
    method : "GET",
    success: function (data) {
      console.log(data);
    }
  })
}

