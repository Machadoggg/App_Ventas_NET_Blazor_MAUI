//alert("Hola Mundo con JS");

//document.write("hola desde fichero externo de consola");

//console.log("Muestra esto en pantalla en consola");
//console.log(88+4);
'use strict'

//////////////////////////Estructura de control SWITCH/////////////////////
//console.log("switch");
var edad = 22;
var imprime = "";

switch (edad)
{
    case 18:
        imprime = "Tienes: "+edad+", Acabas de cumplir la mayoría de edad";
        break;
    case 25:
        imprime = "Tienes: " + edad +", Ya eres un adulto";
        break;
    case 40:
        imprime = "Tienes: " + edad +", Crisis de los 40";
        break;
    case 75:
        imprime = "Tienes: " + edad +", Eres ya un anciano";
        break;
    default: 
        imprime = "Tienes: " + edad +", Tu edad es neutra";
        break;
}
document.write(imprime);
//////////////////////////////////////////////////////////////////////////

//////////////////////////  Ciclo FOR   /////////////////////
var numero = 100;

for (var i = 0; i < numero; i++) {
    console.log("Vamos por el número: " + i);
    debugger;
}
//////////////////////////////////////////////////////////////////////////


//////////////////////////  Plantillas HTML en JS   /////////////////////
//var nombre = prompt("Ingresa un nombre");
//var apellidos = prompt("Ingresa tus apellidos");

//var texto = `
//    <h1>Hola que tal</h1>
//    <h1>Mi nombre es: ${nombre}</h1>
//    <h1>Mis apellidos son: ${apellidos}</h1>
//`;
//document.write(texto);
//////////////////////////////////////////////////////////////////////////


//////////////////////////  ARRAYS en JS   /////////////////////

var nombre = "Jorge";

//array secillo
var nombres = ["Jorge Humberto", "Juan Lopez", "..."]

//array objeto
var lenguajes = new Array("java", "C#", "Phyton");

console.log(lenguajes);

//acceder al indice
console.log(lenguajes[1]);


//////////////////////////////////////////////////////////////////////////


//////////////////////////  ARRAYS avanzados en JS   /////////////////////

var lenguajes2 = new Array("php", "C++", "go");

document.write("<ul>");
    for (var i = 0; i < lenguajes2.length; i++) {
        document.write("<li>"+lenguajes[i]+"</li>")
    }
document.write("<ul>")

//////////////////////////////////////////////////////////////////////////


//////////////////////////  FOREACH en JS   /////////////////////

var lenguajes3 = new Array("F#", "java", "pascal");

document.write("<ul>");
    lenguajes3.forEach((elemento, index, data) => {
        document.write("<li>" + elemento + "</li>")
    });
document.write("<ul>")


var lenguajes4 = new Array("F#", "java", "pascal");

document.write("<ul>");
lenguajes4.forEach((elemento, indice, data) => {
    document.write("<li>" + indice+ " - " + elemento + "</li>")
});
document.write("<ul>")

//////////////////////////////////////////////////////////////////////////


/////////////////////////////Array multidimensional//////////////////////////////////

var categorias = ['accion', 'terror', 'comedia'];
var peliculas = ['La vida', 'rápido', 'shrek'];

var cine = [categorias, peliculas]

console.log(cine[0][2]);//comedia
console.log(cine[1][2]);//shrek


//////////////////////////////////////////////////////////////////////////


/////////////////////////////operaciones con arrays//////////////////////////////////

var categorias2 = ['accion', 'terror', 'comedia'];
var peliculas2 = ['La vida', 'rápido', 'shrek'];

//agregar elemento  al array
peliculas2.push("batman");
console.log(peliculas2);

//////////////////////////////////////////////////////////////////////////


/////////////////////////////operaciones con arrays//////////////////////////////////



//////////////////////////////////////////////////////////////////////////