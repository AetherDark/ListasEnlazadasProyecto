# Proyecto de Listas Enlazadas en C#

## Descripción

Este proyecto implementa una estructura de datos de lista enlazada en C# con diversas operaciones como inserción, eliminación, búsqueda y visualización de los elementos de la lista.

El programa proporciona un menú interactivo en la consola donde el usuario puede gestionar la lista enlazada de caracteres. Se permite la inserción ordenada de letras, la eliminación de elementos específicos, la búsqueda de caracteres dentro de la lista y la visualización de los elementos almacenados en ella. Además, el usuario puede borrar toda la lista y consultar los créditos del proyecto.

Este proyecto fue desarrollado como parte de la materia **Estructura de Datos**.

## Características
- Implementación de listas enlazadas simples.
- Inserción ordenada de caracteres (A-Z, a-z).
- Eliminación de un elemento específico de la lista.
- Búsqueda de caracteres en la lista con conteo de ocurrencias.
- Visualización del contenido de la lista.
- Borrado completo de la lista.
- Menú interactivo en la consola para seleccionar opciones.

## Tecnologías Utilizadas
- **Lenguaje**: C#
- **Entorno de desarrollo**: Visual Studio / Visual Studio Code
- **Paradigma**: Programación Orientada a Objetos (POO)

## Instalación y Ejecución
### Requisitos Previos
- Tener instalado .NET SDK en el sistema.
- Un entorno de desarrollo compatible con C# (Visual Studio, Visual Studio Code, etc.).

### Clonar el Repositorio
```bash
 git clone https://github.com/AetherDark/ListasEnlazadasProyecto.git
 cd ListasEnlazadasProyecto
```

### Compilar y Ejecutar
Para compilar el programa, usa el siguiente comando dentro del directorio del proyecto:
```bash
 dotnet build
```
Para ejecutarlo:
```bash
 dotnet run
```

## Uso del Programa
Al ejecutar el programa, se mostrará un menú en consola con las siguientes opciones:

1. **Inicializar / Borrar Lista**: Borra toda la lista.
2. **Insertar**: Agrega un nuevo caracter en la lista manteniendo el orden.
3. **Eliminar**: Permite eliminar una letra específica de la lista.
4. **Buscar**: Busca una letra en la lista y muestra cuántas veces aparece.
5. **Mostrar**: Muestra la lista enlazada en formato ordenado.
6. **Créditos**: Muestra información del desarrollador.
7. **Salir**: Finaliza la ejecución del programa.

## Estructura del Proyecto
```
ListasEnlazadasProyecto/
├── Program.cs           # Punto de entrada del programa y menú principal
├── CapturaDatos.cs      # Manejo de opciones del menú
├── Nodo.cs              # Definición de la estructura de un nodo
├── Lista.cs             # Implementación de la lista enlazada y sus operaciones
└── README.md            # Documentación del proyecto
```

## Ejemplo de Uso
Ejemplo de una sesión de usuario en consola:
```
=== Menú de Listas Enlazadas ===
1. Inicializar / Borrar Lista
2. Insertar
3. Eliminar
4. Buscar
5. Mostrar
6. Créditos
7. Salir
Seleccione una opcion: 2
Ingrese la letra a insertar: A
La letra 'A' se insertó en la lista.
Presiona Enter para volver al menú...
```

## Autor
- **Jaret Eduardo Gonzalez Carrasco**