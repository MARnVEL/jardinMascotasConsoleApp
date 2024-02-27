# Aplicación de consola para administrar las mascotas abandonadas

> Este proyecto se trata de una simple aplicación de consola creada con el framework dotNET.
>
> El objetivo de este proyecto es realizar prácticas para aprender **C#** y el marco de
> trabajo **.NET-CORE**.

## Sobre la APP

> Esta es una aplicación que ayuda a ubicar mascotas en nuevos hogares. Las características de la aplicación son:
>
> - Aplicación de consola de C#.
> - Los datos de la aplicación están almacenados en un array de string multidimensional llamado `nuestrosAnimales`.
> - El array `nuestrosAnimales` incluye las siguientes "características de mascotas" para cada animal:
>   - Número de ID de la mascota.
>   - Especies de animal (gato o perro).
>   - Edad de la mascota (años).
>   - Una descripción de las características/condiciones físicas de la mascota.
>   - Una descripción de la personalidad de la mascota.
>   - El nombre de la mascota.
>   - Un monto de donación sugerida para el cuidado de una mascota en específico.
> - Existe un conjunto de datos de ejemplo que representa perros y gatos que están actualmente en nuestro cuidado.
> - Mostrar un menú de opciones para acceder a las funcionalidades principales de la aplicación.
> - Las funcionalidades principales permiten realizar las siguientes tareas:
>   - Listar la información de mascotas para todos los animales en el array `nuestrosAnimales`.
>   - Agregar nuevos animales el array `nuestrosAnimales`. Se apican las siguientes condiciones:
>     - Las especies de las mascotas (perro o gato) se ingresan cuando una nuevo animal se agrega al array `nuestrosAnimales`.
>     - Un ID de mascota se genera automáticamente cuando un nuevo animal se agrega al array `nuestrosAnimales`.
>     - Algunas características físicas para una mascota podrían ser desconocidas hasta el exámen de la veterinaria. Por ejemplo: edad, raza, estado (castrado/esterilizado), etc.
>     - El nombre y la personalidad de un animal podrían ser desconocidos cuando una mascota ingresa por primera vez.
>   - Asegurarse que la edad y las decripciones físicas del animal estén completas. Esto podría ser requerido después de la revisión en la veterinaria.
>   - Asegurarse que el nombre y las descripciones de personalidad de los animales estén completas (esta acción puede suceder después de que el equipo llegue a conocer a la mascota).
>   - Editar la edad de un animal (si la fecha de cumpleaños se conoce y la mascota cumple años mientras está bajo nuestro cuidado).
>   - Editar la descripción de personalidad de la mascota (una mascota podría comportarse diferente después de pasar algún tiempo bajo nuestro cuidado).
>   - Mostrar todos los gatos que coincidan con una característica física especificada por el usuario.
>   - Mostrar todos los perros que coincidan con una característica física especificada por el usuario.

## About the APP

> This is an application that helps place pets in new homes. The application's features are:
>
> - C# console application.
> - The application data is stored in a multidimensional string array named `nuestrosAnimales`.
> - The `nuestrosAnimales` array includes the following "pet characteristics" for each animal:
>   - Pet ID #.
>   - Pet species (cat or dog).
>   - Pet age (years).
>   - A description of the pet's physical condition/characteristics.
>   - A description of the pet's personality.
>   - The pet's nickname.
> - There is  a sample dataset that represents dogs and cats currently in our care.
> - Display menu options to access the main features of the application.
> - The main features enable the following tasks:
>   - List the pet information for all animals in the `nuestrosAnimales` array.
>   - Add new animals to the `nuestrosAnimales` array. The following conditions apply:
>     - The pet species (dog or cat) are entered when a new animal is added to the `nuestrosAnimales` array.
>     - A pet ID is programmatically generated when a new animal is added to the `nuestrosAnimales` array.
>     - Some physical characteristics for a pet may be unknown until a veterinarian's examination. For example: age, breed, and neutered/spayed status.
>     - An animal's nickname and personality may be unknown when a pet first arrives.
>   - Ensure animal ages and physical descriptions are complete. This may be required after a veterinarian's examination.
>   - Ensure animal nicknames and personality descriptions are complete (this action can occur after the team gets to know a pet).
>   - Edit an animal’s age (if a pet's birth date is known and the pet has a birthday while in our care).
>   - Edit an animal’s personality description (a pet may behave differently after spending more time in our care).
>   - Display all cats that meet user specified physical characteristics.
>   - Display all dogs that meet user specified physical characteristics.

## Tecnologías utilizadas:
<div align="center" style="display: flex">
      <span>
         <a href="https://learn.microsoft.com/en-us/dotnet/csharp/" target="_blank">
               <img width="100" style="margin: 10" title='cSharp' src='https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png'>
         </a>
      </span>
      <span>
         <a href="https://learn.microsoft.com/en-us/dotnet/" target="_blank" title='dotNET'>
               <img width="100" style="margin: 10" title='dotNET' src='https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg'>
         </a>
      </span>
</div>

## Requerimientos

- Tener intalado el sdk **dotNET 8** (<https://dotnet.microsoft.com/en-us/download>).
- Tener instalado git.

## Usos

### Para ejecutar o utilizar el proyecto debes clonar este repositorio en un directorio de tu sistema. Abre una terminal y ejecuta el siguiente comando

```bash
git clone https://github.com/MARnVEL/jardinMascotasConsoleApp.git
```

### Con una terminal localizarse en el directorio del proyecto y ejecutar

```bash
dotnet build
```

### Para ejecutar el proyecto

```bash
dotnet run
```

Ref: <https://github.com/tutosYTBandCourses/Challenge-project-branching-looping-CSharp-main.git>
