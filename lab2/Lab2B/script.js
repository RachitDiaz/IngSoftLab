
var fondo = true;

function cambiarFondo(){
    if(fondo){
        document.body.style.backgroundColor = "black";
        document.body.style.color = "white";
        fondo = false;
    }else{
        document.body.style.backgroundColor = "white";
        document.body.style.color = "black";
        fondo = true;
    }

}

const agregar = ()=>{
    const lista = document.getElementById("lista");
    const cantidadIndices = lista.getElementsByTagName("li").length;
    const nuevoElemento = document.createElement("li");

    nuevoElemento.textContent = `Elemento ${cantidadIndices + 1}`;
    lista.appendChild(nuevoElemento);
}   


const borrar = ()=>{
    const lista = document.getElementById("lista");
    const elementos = lista.getElementsByTagName("li");

    if (elementos.length > 0) {
        lista.removeChild(elementos[elementos.length - 1]);
    }
}   
