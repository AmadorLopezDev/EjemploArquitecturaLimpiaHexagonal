# Ejemplo Arquitectura Limpia Hexagonal

Proyecto de Ejemplo basado en arquitectura limpia de Robert C. Martin.

## Fuentes

[Blog Clean Code - Robert C. Martin](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)

[Youtube LatinoNet Online <Introducción a Clean Architecture con .Net> - Miguel Muñoz Serafin](https://www.youtube.com/watch?v=aXsYR9sUqZc&list=PLkMxIFe9hm2NxD-I9hW9coGSkJYt6JKwH&index=41)

## Descripción

El proyecto se ha realizado en base a las indicaciones de D. Miguel Muñoz en el vídeo, sin embargo, se han realizado pequeños cambios en los nombres de los proyectos, aunque son facilmente reconocibles. También se ha integrado Docker en el proyecto del API.

La solución se ha realizado con Net6, aunque la versión del vídeo es anterior. Para el proyecto del API, se ha mantenido el la estructura con Controladores y no se ha cambiado a una Minimal API.

## Cosas por hacer

- Agregar un proyecto de Test, tanto unitarios como de integración.
- Agregar la gestión de excepciones.
- Agregar autenticación y gestión de roles.
- Agregar Validadores para las peticiones Http - Post y Put.
- Agregar una gestión de Log.