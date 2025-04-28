document.addEventListener("DOMContentLoaded", function () {
    const button = document.querySelector(".btn-outline-info");
    const inputField = document.querySelector("#userInput");

    button.addEventListener("click", function () {
        const inputValue = inputField.value || "vacío";
        alert(`Mi nombre es Santiago Pilamunga, mi hobbie es jugar videojuegos y el valor del campo de texto es: ${ inputValue }`);
    });
});
