function Validaciones() {
  let listaErrores = "";
  let dioError = 0;
  let nombre = document.getElementById("nombre");
  let apellido = document.getElementById("apellido");
  let dni = document.getElementById("dni");
  let edad = document.getElementById("edad");

  if (nombre.value == "") {
    listaErrores += "El nombre no debe estar vacío \n";
    dioError = 1;
  }
  if (apellido.value == "") {
    listaErrores += "El apellido no debe estar vacío \n";
    dioError = 1;
  }
  if (dni.value == "") {
    listaErrores += "El dni no debe estar vacío \n";
    dioError = 1;
  }
  if (dni.value == "") {
    listaErrores += "La edad no debe estar vacía \n";
    dioError = 1;
  }

  if (dioError == 1) {
    alert(listaErrores);
    return false;
  } else {
    return true;
  }
}
