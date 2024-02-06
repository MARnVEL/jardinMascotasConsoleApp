
using System;
using System.IO;

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
            especiesDeAnimal = "perro";
            animalID = "p1";
            edadAnimal = "2";
            descripcionFisicaAnimal = "Tamaño medio. Color crema. Golden retriever hembra. Peso: aproximadamente 30kg. Domesticada.";
            descripcionPersonalidadAnimal = "Le encanta que le froten la barriga y le gusta perseguir su cola. da muchos besos.";
            nombreAnimal = "Lola";
            break;
        case 1:
            especiesDeAnimal = "perro";
            animalID = "p2";
            edadAnimal = "9";
            descripcionFisicaAnimal = "Golden retriever grande. Macho de color marrón rojizo que pesa alrededor de 40kg. domesticado.";
            descripcionPersonalidadAnimal = "¡Le encanta que le froten las orejas cuando te saluda en la puerta o en cualquier momento! Le encanta inclinarse y dar abrazos de perrito.";
            nombreAnimal = "Loki";
            break;
        case 2:
            especiesDeAnimal = "gato";
            animalID = "g3";
            edadAnimal = "1";
            descripcionFisicaAnimal = "Pequeña hembra blanca que pesa alrededor de kg. Entrenada para usar caja de arena.";
            descripcionPersonalidadAnimal = "Amigable";
            nombreAnimal = "Perona";
            break;
        case 3:
            especiesDeAnimal = "gato";
            animalID = "g4";
            edadAnimal = "?";
            descripcionFisicaAnimal = "";
            descripcionPersonalidadAnimal = "";
            nombreAnimal = "";
            break;
        default:
            especiesDeAnimal = "";
            animalID = "";
            edadAnimal = "";
            descripcionFisicaAnimal = "";
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
    // Para limpiar la consola. Importantísimo.
    Console.Clear();

    Console.WriteLine("Bienvenidos a la aplicación \"Mascotas Felices\". Tus opciones son:");
    Console.WriteLine(" 1. Mostrar información de todas nuestras mascotas actuales.");
    Console.WriteLine(" 2. Añadir un nuevo amigo animal al array nuestrosAnimales.");
    Console.WriteLine(" 3. Asegurarse que las edades y las descripciones físicas estén completas.");
    Console.WriteLine(" 4. Asegurarse que los nombres y las descripciones de las personalidades estén completas.");
    Console.WriteLine(" 5. Editar la edad de un animal");
    Console.WriteLine(" 6. Editar la descripción de personalidad de un animal");
    Console.WriteLine(" 7. Mostrar todos los gatos con un característica especificada");
    Console.WriteLine(" 8. Mostrar todos los perros con un característica especificada");
    Console.WriteLine();
    Console.WriteLine("Ingresa el número que seleccionaste (o escribe Salir para salir del programa.)");

    leerResultado = Console.ReadLine();
    if (leerResultado != null)
    {
        seleccionDelMenu = leerResultado.ToLower();
    }

    // Utilizamos el switch-case la opción del menú seleccionada
    switch (seleccionDelMenu)
    {
        case "1":
            // Listar información de todas nuestras mascotas actuales
            for (int i = 0; i < cantidadMaximaMascotas; i++)
            {
                if (nuestrosAnimales[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(nuestrosAnimales[i, j].ToString());
                    }
                }
            }
            Console.WriteLine("\n\rPresiona la tecla Enter para continuar.");
            leerResultado = Console.ReadLine();
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            break;
        case "8":
            break;

        default:
            break;
    }


} while ( seleccionDelMenu != "salir" );

