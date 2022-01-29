const modal = document.getElementById("main-qna-modal");
const modalButton = document.getElementById("qna-modal-button");
const blackFon = document.getElementById("main-qna-modal-black-fon");
const closeModal = document.getElementById("main-qna-modal-close");

function closeModulevent(evt) {
  if (evt.key === "Escape" || evt.code === "Escape") {
    modal.style.display = "none";
    document.children[0].style.overflow = "auto";
    document.removeEventListener("keydown", closeModulevent, false);
  }
}

modalButton.onclick = () => {
  modal.style.display = "flex";
  document.children[0].style.overflow = "hidden";
  document.addEventListener("keydown", closeModulevent, false);
};

blackFon.onclick = (evt) => {
  modal.style.display = "none";
  document.children[0].style.overflow = "auto";
  document.removeEventListener("keydown", closeModulevent, false);
};

closeModal.onclick = (evt) => {
  modal.style.display = "none";
  document.children[0].style.overflow = "auto";
  document.removeEventListener("keydown", closeModulevent, false);
};
