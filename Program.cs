
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
            /*
            Añadir un nuevo amigo animal al array nuestrosAnimales
            El array nuestrosAnimales contiene:
                1. La especie (perro o gato). Campo requerido.
                2. El número de ID. Por ejemplo, C17.
                3. La edad de la mascota. Puede estar en blanco al ingresar por primera vez
                4. El nombre de la mascota. Puede estar en blanco.
                5. Una descripción de la apariencia física de la mascota. Puede estar en blanco.
                6. Una descripción de la personalidad de la mascota. Puede estar en blanco.
            */
            otraMascota = "y";
            contadorMascotas = 0;
            for (int i = 0; i < cantidadMaximaMascotas; i++)
            {
                if (nuestrosAnimales[i, 0] != "ID #: ")
                {
                    contadorMascotas += 1;
                }
            }

            if ( contadorMascotas < cantidadMaximaMascotas )
            {
                Console.WriteLine($"Actualmente tenemos {contadorMascotas} mascotas que necesitan hogar. Podemos manejar {(cantidadMaximaMascotas - contadorMascotas)} mascotas más.");
            }

            while ( otraMascota == "y" && contadorMascotas < cantidadMaximaMascotas )
            {
                // Obtenemos las especies (gato o perro). El string especiesDeAnimal es un campo requerido.
                do
                {
                    Console.WriteLine("\n\rIngresa 'perro' o 'gato' para empezar un nuevo ingreso:");
                    leerResultado = Console.ReadLine();
                    if (leerResultado != null)
                    {
                        especiesDeAnimal = leerResultado.ToLower();
                        if (especiesDeAnimal != "perro" && especiesDeAnimal != "gato")
                        {
                            entradaValida = false;
                        }
                        else
                        {
                            entradaValida = true;
                        }
                    }
                } while ( entradaValida == false );

                // construimos el número de ID del animal. Por ejemplo G1, G2, G3 (para Gato 1, Gato 2, Gato 3)
                animalID = especiesDeAnimal.Substring(0, 1) + (contadorMascotas + 1).ToString();

                // Obtenemos la edad de la mascota. Puede ser ? la primera vez que se ingresan los datos.
                do
                {
                    Console.WriteLine("Ingrese la edad de la mascota, o ingrese ? si es desconocida. ");
                    leerResultado = Console.ReadLine();
                    if ( leerResultado != null )
                    {
                        edadAnimal = leerResultado;
                        if (edadAnimal != "?")
                        {
                            entradaValida = int.TryParse(edadAnimal, out edadMascota);
                        }
                        else
                        {
                            entradaValida = true;
                        }
                    }
                } while ( entradaValida == false );

                // Obtenemos una descripción de la apariencia física de la mascota. `descripcionFisicaAnimal` puede estar en blanco.
                do
                {
                    Console.WriteLine("Ingrese una descripción física de la mascota (tamaño, color, género, peso, abandonada)");
                    leerResultado = Console.ReadLine();
                    if (leerResultado != null)
                    {
                        descripcionFisicaAnimal = leerResultado.ToLower();
                        if (descripcionFisicaAnimal == "")
                        {
                            descripcionFisicaAnimal = "tbd";
                        }
                    }
                } while ( entradaValida == false );

                // Obtenemos una descripción de la personalidad. `descripcionPersonalidadAnimal` puede estar en blanco.
                do
                {
                    Console.WriteLine("Ingrese una descripción de la personalidad de la mascota (gustos o disgustos, trucos, nivel de energía, etc.)");
                    leerResultado = Console.ReadLine();
                    if (leerResultado != null)
                    {
                        descripcionPersonalidadAnimal = leerResultado.ToLower();
                        if (descripcionPersonalidadAnimal == "")
                        {
                            descripcionPersonalidadAnimal = "tbd";
                        }
                    }
                } while ( entradaValida == false );

                // Obtenemos el nombre de la mascota. `nombreAnimal`. Puede estar en blanco.
                do
                {
                    Console.WriteLine("Ingrese un nombre para la mascota.");
                    leerResultado = Console.ReadLine();
                    if (leerResultado != null)
                    {
                        nombreAnimal = leerResultado.ToLower();
                        if (nombreAnimal == "")
                        {
                            nombreAnimal = "tbd";
                        }
                    }
                } while ( entradaValida == false );

                // Almacenamos la información de la mascota en el array `nuestrosAnimales`.
                nuestrosAnimales[contadorMascotas, 0] = "ID #: " + animalID;
                nuestrosAnimales[contadorMascotas, 1] = "Especies: " + especiesDeAnimal;
                nuestrosAnimales[contadorMascotas, 2] = "Edad: " + edadAnimal;
                nuestrosAnimales[contadorMascotas, 3] = "Nombre: " + nombreAnimal;
                nuestrosAnimales[contadorMascotas, 4] = "Descripción física: " + descripcionFisicaAnimal;
                nuestrosAnimales[contadorMascotas, 5] = "Personalidad: " + descripcionPersonalidadAnimal;

                // Incrementamos contadorMascotas (el array tiene base-cero, así que incrementamos el contador después de agregar al array).
                contadorMascotas = contadorMascotas + 1;

                // verificamos el límite `cantidadMaximaMascotas`.
                if (contadorMascotas < cantidadMaximaMascotas)
                {
                    // ¿Otra mascota?
                    Console.WriteLine("¿Desea ingresar información para otra mascota? (y/n)");
                    do
                    {
                        leerResultado = Console.ReadLine();
                        if (leerResultado != null)
                        {
                            otraMascota = leerResultado.ToLower();
                        }

                    } while ( otraMascota != "y" && otraMascota != "n" );
                }

                // NOTA: El valor de `otraMascota` ("y" o "n") se evalúa en la expresión de la sentencia `while` en al principio del bucle `while`.
            }
            
            if (contadorMascotas >= cantidadMaximaMascotas)
            {
                Console.WriteLine("Hemos alcanzado nuestro límite para la cantidad de mascotas que podemos cuidar.");
                Console.WriteLine("Presiona la tecla Enter para continuar.");
                leerResultado = Console.ReadLine();
            }

            break;
        case "3":
            // Asegurarse de que la edad y las descripciones físicas están completas.
            for (int i = 0; i < cantidadMaximaMascotas; i++)
            {
                // Si tiene un id asignado pero no tiene edad es porque la mascota existe pero tiene los datos (en este caso la edad) incompletos.
                if ( nuestrosAnimales[i, 2]  == "Edad: ?" && nuestrosAnimales[i, 0] != "ID #: " )
                {
                    bool edadValida = false;
                    do
                    {
                        Console.WriteLine($"\n\rIngrese una edad para {nuestrosAnimales[i, 0]}");
                        leerResultado = Console.ReadLine();

                        if ( leerResultado != null )
                        {
                            edadAnimal = leerResultado;
                            if (edadAnimal != "")
                            {
                                edadValida = int.TryParse(edadAnimal, out edadMascota);
                                nuestrosAnimales[i, 2] = "Edad: " + edadMascota.ToString();
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un número válido!");
                                edadValida = false;
                            }

                        }
                    } while (edadValida == false);

                }
                // Si tiene un id asignado pero no tiene descipción física es porque la mascota existe pero tiene los datos (en este caso la descripción física) incompletos.

                
                if (
                    (
                        nuestrosAnimales[i, 4]  == "Descripción física: tbd" ||
                        nuestrosAnimales[i, 4]  == "Descripción física: "
                    ) &&
                    nuestrosAnimales[i, 0] != "ID #: "
                )
                {

                    do
                    {
                        Console.WriteLine($"\n\rIngrese una 'Descripción física' para {nuestrosAnimales[i, 0]} (tamaño, color, peso, abandonada, etc.)");
                        leerResultado = Console.ReadLine();

                        if ( leerResultado != null )
                        {
                            descripcionFisicaAnimal = leerResultado.ToLower();
                            if ( descripcionFisicaAnimal != "" && descripcionFisicaAnimal != "tbd" )
                            {
                                nuestrosAnimales[i, 4] = "Descripcion física: " + descripcionFisicaAnimal;
                                entradaValida = true;
                            }
                            else
                            {
                                Console.WriteLine($"\n\rIngrese una 'Descripción física' válida para {nuestrosAnimales[i, 0]} (tamaño, color, peso, abandonada, etc.)");
                                entradaValida = false;
                            }

                        }
                    } while ( entradaValida == false );

                }

            }
            Console.WriteLine("Los campos para la edad y la descripcion física est+an completos para todos nuestros amigos.");
            Console.WriteLine("Presiona la tecla Enter para continuar.");
            leerResultado = Console.ReadLine();
            break;

        case "4":
            // Asegurarse que el nombre y las descripociones de personalidad de las mascotas estén compoletas.
            for (int i = 0; i < cantidadMaximaMascotas; i++)
            {
                // Si tiene un id asignado pero no tiene nombre es porque la mascota existe pero tiene los datos (en este caso el nombre) incompletos.
                if ( nuestrosAnimales[i, 3]  == "Nombre: " && nuestrosAnimales[i, 0] != "ID #: " )
                {
                    bool nombreValido = false;
                    do
                    {
                        Console.WriteLine($"\n\rIngrese un nombre para {nuestrosAnimales[i, 0]}");
                        leerResultado = Console.ReadLine();

                        if ( leerResultado != null )
                        {
                            nombreAnimal = leerResultado.ToLower();
                            if ( nombreAnimal != "" && nombreAnimal != "tbd" )
                            {
                                nuestrosAnimales[i, 3] = "Nombre: " + nombreAnimal;
                                nombreValido = true;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un nombre válido para la mascota!");
                                nombreValido = false;
                            }

                        }
                    } while (nombreValido == false);

                // Si tiene un id asignado pero no tiene descipción física es porque la mascota existe pero tiene los datos (en este caso la descripción física) incompletos.
                }
                
                if (
                    (
                        nuestrosAnimales[i, 5]  == "Personalidad: tbd" ||
                        nuestrosAnimales[i, 5]  == "Personalidad: "
                    ) &&
                    nuestrosAnimales[i, 0] != "ID #: "
                )
                {

                    do
                    {
                        Console.WriteLine($"\n\rIngrese una 'Descripción de personalidad' para {nuestrosAnimales[i, 0]} (gustos o cosas que no le gustan, trucos, nivel de energía, etc.)");
                        leerResultado = Console.ReadLine();

                        if ( leerResultado != null )
                        {
                            descripcionPersonalidadAnimal = leerResultado.ToLower();
                            if (descripcionPersonalidadAnimal != "" && descripcionPersonalidadAnimal != "tbd")
                            {
                                nuestrosAnimales[i, 5] = "Personalidad: " + descripcionPersonalidadAnimal;
                                entradaValida = true;
                            }
                            else
                            {
                                Console.WriteLine("Ups... Parece que hay un error. Ingrese una 'Descripción de personalidad' para {nuestrosAnimales[i, 0]} (gustos o cosas que no le gustan, trucos, nivel de energía, etc.)");
                                entradaValida = false;
                            }

                        }
                    } while (entradaValida == false);

                }

            }
            Console.WriteLine("Los campos para el nombre y la descripción física de todos nuestros animales están completos.");
            Console.WriteLine("Presione la tecla Enter para continuar.");
            leerResultado = Console.ReadLine();
            break;
        case "5":
            Console.WriteLine("En construcción - Por favor, regresa el mes siguiente para ver progresos.");
            Console.WriteLine("Presiona la tecla Enter para continuar.");
            leerResultado = Console.ReadLine();
            break;
        case "6":
            Console.WriteLine("En construcción - Por favor, regresa el mes siguiente para ver progresos.");
            Console.WriteLine("Presiona la tecla Enter para continuar.");
            leerResultado = Console.ReadLine();
            break;
        case "7":
            Console.WriteLine("En construcción - Por favor, regresa el mes siguiente para ver progresos.");
            Console.WriteLine("Presiona la tecla Enter para continuar.");
            leerResultado = Console.ReadLine();
            break;
        case "8":
            // Muestra todos los perros con una característica especificada.
            Console.WriteLine("En construcción - Por favor, regresa el mes siguiente para ver progresos.");
            Console.WriteLine("Presiona la tecla Enter para continuar.");
            leerResultado = Console.ReadLine();
            break;

        default:
            break;
    }


} while ( seleccionDelMenu != "salir" );

