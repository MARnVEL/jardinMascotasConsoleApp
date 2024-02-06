
using System;
using IO;

// El array nuestros animales almacenará lo siguiente:
string especiesDeAnimal = "";
string animalID = "";
string edadAnimal = "";
string descripcionFisicaAnimal = "";
string descripcionPersonalidadAnimal = "";
string nombreAnimal = "";

// Variables que soportan datos de entrada:
int cantidadMaximaMascotas = 8;
string? leerResultado;
string seleccionDelMenu = "";
int contadorMascotas = 0;
string otraMascota = "y";
bool entradaValida = false;
int edadMascota = 0;

// Array utilizado para almacenar datos en tiempo de ejecución. No hay persistencia de datos
string[,] nuestrosAnimales = new string[cantidadMaximaMascotas, 6];

// Creamos algunos datos iniciales para el array nuestrosAnimales
for (int i = 0; i < cantidadMaximaMascotas; i++)
{
    switch (i)
    {
        case 0:
            especiesDeAnimal = "dog";
            animalID = "d1";
            edadAnimal = "2";
            descipcionFisicaAnimal = "Tamaño medio. Color crema. Golden retriever hembra. Peso: aproximadamente 30kg. Domesticada.";
            descripcionPersonalidadAnimal = "Le encanta que le froten la barriga y le gusta perseguir su cola. da muchos besos.";
            nombreAnimal = "Lola";
            break;
        case 1:
            especiesDeAnimal = "dog";
            animalID = "d2";
            edadAnimal = "9";
            descipcionFisicaAnimal = "Golden retriever grande. Macho de color marrón rojizo que pesa alrededor de 40kg. domesticado.";
            descripcionPersonalidadAnimal = "¡Le encanta que le froten las orejas cuando te saluda en la puerta o en cualquier momento! Le encanta inclinarse y dar abrazos de perrito.";
            nombreAnimal = "Loki";
            break;
        case 2:
            especiesDeAnimal = "cat";
            animalID = "c3";
            edadAnimal = "1";
            descipcionFisicaAnimal = "Pequeña hembra blanca que pesa alrededor de kg. Entrenada para usar caja de arena.";
            descripcionPersonalidadAnimal = "Amigable";
            nombreAnimal = "Perona";
            break;
        case 3:
            especiesDeAnimal = "cat";
            animalID = "c4";
            edadAnimal = "?";
            descipcionFisicaAnimal = "";
            descripcionPersonalidadAnimal = "";
            nombreAnimal = "";
            break;
        default:
            especiesDeAnimal = "";
            animalID = "";
            edadAnimal = "";
            descipcionFisicaAnimal = "";
            descripcionPersonalidadAnimal = "";
            nombreAnimal = "";
            break;
    }

    /* En el array `nuestrosAnimales` no se guardan los datos tal cual los ingresa
    el usuario, sino que se le agregan string descriptivos de los datos
    delante de los datos en sí. 
    */
    nuestrosAnimales[i, 0] = "ID #: " + animalID;
    nuestrosAnimales[i, 1] = "Especies: " + especiesDeAnimal;
    nuestrosAnimales[i, 2] = "Edad: " + edadAnimal;
    nuestrosAnimales[i, 3] = "Nombre: " + nombreAnimal;
    nuestrosAnimales[i, 4] = "Descripción física: " + descripcionFisicaAnimal;
    nuestrosAnimales[i, 5] = "Personalidad: " + descripcionPersonalidadAnimal;
}

// Muestre el menú de opciones superior:
do
{
    
} while ( seleccionDelMenu != "salir" );

