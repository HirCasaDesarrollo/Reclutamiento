var cursos = {
    "items": [
        {
            "imagen": "img/mujer.JPG",
            "author": "Dianne Edwards",
            "fondo":"https://m.media-amazon.com/images/I/51vtHjQAXTL._AC_SX425_.jpg",
            "email": "@dianned",
            "minutos": "82 min",
            "descripcion": "Learning how to create simple Swift applications in 8 lessons"
        },
        {
            "imagen": "img/hombre.jpg",
            "author": "Dianne Edwards",
            "fondo":"https://carlosvassan.com/wp-content/uploads/2021/08/Wallpaper-evangelion-v.5-1024x576.jpg",
            "email": "@dianned",
            "minutos": "90 min",
            "descripcion": "Best tips for drawing some good thematic ilustration"
        }
    ]
};



var principal = document.getElementsByClassName("cursos")[0];
var items = cursos.items;
for (var i = 0; i < items.length; i++) {

    //creacion de los divs y asignación de clases
    var divConFondo = document.createElement("div");
    divConFondo.setAttribute("class", "col-lg-5 col-md-10 con-fondo")
    divConFondo.style.setProperty("background-image","url('"+items[i].fondo+"')");

    var divConFondoDatos = document.createElement("div");
    divConFondoDatos.setAttribute("class", "con-fondo-datos")

    var divInstructor = document.createElement("div");
    divInstructor.setAttribute("class", "instructor")

    var divContacto = document.createElement("div");
    divContacto.setAttribute("class", "contacto");

    var divDescripcion = document.createElement("div");
    divDescripcion.setAttribute("class", "descripcion");


    //creación de los elementos de los divs con sus respectivos valores
    var img = document.createElement("img");
    img.setAttribute("src", items[i].imagen);
    divInstructor.appendChild(img)

    var nombre = document.createElement("h5");
    var nombre_text = document.createTextNode(items[i].author);
    nombre.appendChild(nombre_text);

    var email = document.createElement("p");
    var email_text = document.createTextNode(items[i].email);
    email.appendChild(email_text);

    divContacto.appendChild(nombre);
    divContacto.appendChild(email)
    divInstructor.appendChild(divContacto);

    var minutos = document.createElement("span");
    minutos.setAttribute("class", "minutos");
    var minutos_text = document.createTextNode(items[i].minutos);
    minutos.appendChild(minutos_text);

    divConFondoDatos.appendChild(divInstructor);
    divConFondoDatos.appendChild(minutos);

    var descripcion = document.createElement("p");
    var descripcion_text = document.createTextNode(items[i].descripcion);
    descripcion.appendChild(descripcion_text);
    divDescripcion.appendChild(descripcion);

    //añadiendo los divs secundarios al elementos principal
    divConFondo.appendChild(divConFondoDatos);
    divConFondo.appendChild(divDescripcion);

    principal.appendChild(divConFondo);

}

// para el funcionamiento del menu
function init(){
	var home = document.getElementById("home");
    var progress = document.getElementById("progress");
    var messages = document.getElementById("messages");
    var settings=document.getElementById("settings")
    home.style.display = "block";
    progress.style.display = "none";
    messages.style.display = "none";
    settings.style.display="none";  

}
function home() {
	var home = document.getElementById("home");
    var progress = document.getElementById("progress");
    var messages = document.getElementById("messages");
    var settings=document.getElementById("settings")
    if (home.style.display === "none") {
        home.style.display = "block";
        progress.style.display = "none";
        messages.style.display = "none";   
        settings.style.display="none";
    } else {
        progress.style.display = "none";
        messages.style.display = "none";   
        settings.style.display="none";      
    }
    
}

function progress() {
	var home = document.getElementById("home");
    var progress = document.getElementById("progress");
    var messages = document.getElementById("messages");
    var settings=document.getElementById("settings")
    if (progress.style.display === "none") {
        progress.style.display = "block";
        home.style.display = "none";
        messages.style.display = "none";   
        settings.style.display="none";
    } else {
        home.style.display = "none";
        messages.style.display = "none";   
        settings.style.display="none";      
    }
    
}

function messages(){
    var home = document.getElementById("home");
    var progress = document.getElementById("progress");
    var messages = document.getElementById("messages");
    var settings=document.getElementById("settings");
    if(messages.style.display==="none"){
        messages.style.display="block";
        home.style.display = "none";
        progress.style.display = "none";   
        settings.style.display="none";
    }else{
        home.style.display = "none";
        progress.style.display = "none";   
        settings.style.display="none";
    }
}
function settings(){
    var home = document.getElementById("home");
    var progress = document.getElementById("progress");
    var messages = document.getElementById("messages");
    var settings=document.getElementById("settings");
    if(settings.style.display==="none"){
        settings.style.display="block";
        home.style.display = "none";
        progress.style.display = "none";   
        messages.style.display="none";
    }else{
        home.style.display = "none";
        progress.style.display = "none";   
        messages.style.display="none";
    }
}

init();