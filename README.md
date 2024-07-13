
# Unity CI/CD Test

Este proyecto muestra una pequeña prueba sobre la implementación de la filosofía DevOps para un proyecto de Unity.


## Proceso

Mediante el uso de [Game CI GitHub Actions](https://github.com/game-ci/unity-actions) se ha logrado automatizar el proceso DevOps para un proyecto de Unity.

El flujo comienza con la creación de un requerimiento, el cual se desarrollará en el editor de Unity, posteriormente este trabajo se subirá al repositorio del proyecto, en el cual se activarán las GitHub Actions que se encargarán de realizar la build del proyecto, correr los testeos necesarios y, si todo sale bien, desplegar el resultado en una página de GitHub Pages.

De esta manera los cambios hechos en desarrollo se pueden observar automáticamente en entorno de producción, haciendo el proceso de despliegue del proyecto mucho mas fluido, e incluyendo integración continua y despliegue continuo de manera automática.


## Stack Utilizado

![DevOps Stack](https://i.ibb.co/0Kwr6B0/Dev-Ops-Stack.png)

1. Plan: Trello
2. Code: GitHub para versionamiento / Visual Studio para IDE
3. Build: Unity
4. Test: Unity Testing
5. Release: GitHub Actions
6. Deploy: GutHub Pages
7. Operate / Monitor: Unity Analytics


## 🔗 Links

<a href="https://www.linkedin.com/in/ignacio-rivas-urra-91074814a/">
  <img src="https://upload.wikimedia.org/wikipedia/commons/1/19/LinkedIn_logo.svg" alt="Descripción de la imagen" height="50"/>
</a>
