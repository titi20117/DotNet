// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let modalUser = document.getElementById("newUserModal");
let modalAward = document.getElementById("newAwardModal");
let btnAddUser = document.getElementById("btnNewUser");
let btnsClose = document.querySelectorAll(".close");

let Modals = [ modalUser, modalAward ];
let showModal = (btnEvent, modal) => {
    btnEvent.addEventListener("click", () => {
        modal.classList.remove("d-none");
        modal.classList.add("d-block");
    })
}

window.addEventListener("click", (event) => {
    for (let modal of Modals) {
        if (event.target == modal) {
            modal.classList.remove("d-block");
            modal.classList.add("d-none");
        }
    }
})

let closeModal = (btnEvent, modal) => {
    for (var el of btnEvent) {
        el.addEventListener("click", (event) => {
            modal.classList.remove("d-block");
            modal.classList.add("d-none");
        });
    }
}

//User 
showModal(btnAddUser, modalUser);
closeModal(btnsClose, modalUser);