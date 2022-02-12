const rewardOutside = $("#main-reward-outside");
const rewardImage = $("#main-reward-outside-img");
const closeReward = $("#main-reward-outside-close");

function closeRewardImg(evt) {
  if (evt.code === "Escape" || evt.key === "Escape") {
    rewardOutside[0].style.display = "none";
    document.removeEventListener(closeRewardImg);
  }
}

function clickReward(el) {
  rewardImage[0].src = el.children[0].src;
  rewardOutside[0].style.display = "flex";
  document.addEventListener("keydown", closeRewardImg);
}

closeReward[0].onclick = () => {
  rewardOutside[0].style.display = "none";
  document.removeEventListener(closeRewardImg);
};
