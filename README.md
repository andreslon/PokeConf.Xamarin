# PokeConf.Xamarin

Este aplicativo fue realizado para el taller del NetConf Colombia 2017, construido en Xamarin Forms y estructurado para el primer acercamiento a DevOps.

## Objetivo

DevOps es una metodologia para la creación de software que se basa en un cambio cultural para su implementación, este cambio cultural va desde la colaboración, la comunicacion y la total integración entre las areas de desarrollo y sistemas (Infraestructura).

Para este laboratorio se ha construido un aplicativo movil llamado PokeConf el cual seguira creciendo según necesidades del mercado, por lo que los desarrolladores deberan establecer un esquema de entrega continua agil mediante herramientas de DevOps, en nuestro caso, se utilizara la plataforma de mobile center, encargada de gestionar, probar y distribuir nuestro aplicativo movil realizado en Xamarin.

La aplicación con la que trabajaremos el taller sera la siguiente, llamada PokeConf y disponible para iOS y Android.

**Android**

<img src="images/-1.png" style="height:400px;text-align:center" />
<img src="images/-2.png" style="height:400px;text-align:center" />

**iOS**

<img src="images/-3.png" style="height:400px;text-align:center" />
<img src="images/-4.png" style="height:400px;text-align:center" />

# Mobile Center

Mobile center es una plataforma creada por Microsoft que actualmente es gratis, la cual permite gestionar el desarrollo de nuestros aplicativos moviles android, ios y Windows bajo el esquema de DevOps, contando con compilación, pruebas, distribución y métricas.

### Configuración
1. Para comenzar es necesario disponer de una cuenta en [Github](https://www.github.com).
![recursos](images/0.png)
1. Abre el repositorio donde se encuentra alojado el aplicativo prueba [Pokeconf](https://github.com/andreslon/PokeConf.Xamarin.git) y dale 
"fork" para clonarlo a tu cuenta github.
![recursos](images/0-1.png)
1. Descarga el proyecto desde tu repositorio, abrelo y recompila para restaurar los paquetes, más adelante lo necesitaremos.
![recursos](images/0-2.png)
1. Abre en el navegador la plataforma [Mobile Center](https://mobile.azure.com) e inicia sesión con la cuenta Github.
![recursos](images/1.png)
1. Al loguearse correctamente, podremos darle click al boton "Add new App" para crear nuestra aplicación.
**Nota**: Se requiere crear una aplicación por cada plataforma (Android, iOS y Windows)
![recursos](images/2.png)
1. Ingresamos los datos de la aplicación, es nuestro caso este lab será bajo el sistema operativo Android y la plataforma Xamarin.
![recursos](images/3.png)
1. Ya podemos previsualizar nuestro panel general.
![recursos](images/4.png)

### Compilación (Build)

1. En el panel izquierdo ingresa a la opción **"Build"**, luego selecciona **Github** como ek servicio de repositorio a utilizar.
![recursos](images/5.png)
1. El sistema se vinculará con la cuenta **Github**, luego selecciona el repositorio "Pokeconf.Xamarin" el cual fue clonado anteriormente a tu cuenta.
![recursos](images/6.png)
1. Posteriormente podras ver las ramas

![recursos](images/9.png)

![recursos](images/10.png)

![recursos](images/11.png)

![recursos](images/12.png)

![recursos](images/13.png)

![recursos](images/14.png)

![recursos](images/15.png)

![recursos](images/16.png)

![recursos](images/17.png)

![recursos](images/18.png)

![recursos](images/19.png)

![recursos](images/20.png)

![recursos](images/21.png)

![recursos](images/22.png)

![recursos](images/23.png)

![recursos](images/24.png)

![recursos](images/25.png)

![recursos](images/26.png)

![recursos](images/27.png)

![recursos](images/28.png)

![recursos](images/29.png)

![recursos](images/30.png)






## Pruebas UI

En el proceso de DevOps uno de los pasos más importantes que asegura la calidad del producto y seguridad a cliente, son las pruebas de la aplicación en entornos reales, como sabemos existen miles variaciones de dispositivos, según marca, versión sistema operativo y caracteristicas.

A continuación realizaremos las configuraciones necesarias y ejecutaremos el código de pruebas de interfaz escritos con anterioridad.

1. Instalar Node.js, version 6.3 o superior
1. Abrir una terminal.
1. Instalar el paquete npm mobile-center-cli con el comando: 
```
npm install -g mobile-center-cli
```
1. Es necesario loguearnos en la terminal con el comando: 
```
mobile-center login
```
Nos abrira el navegador indicando un codigo para pegar en la consola y autorizar la autenticació.
![recursos](images/32.png)
![recursos](images/31.png)
1. Por ultimo procedemos a ejecutar las pruebas de interfaz, con la configuración de dispositivos configurados.
```
mobile-center test run uitest --app "andreslon/PokeConf.App.Android" --devices "andreslon/dev1" --app-path /Users/d_p/Documents/GIT/PokeConf.Xamarin/builds/com.PokeConf.App.apk  --test-series "master" --locale "es_MX" --build-dir /Users/d_p/Documents/GIT/PokeConf.Xamarin/src/PokeConf/PokeConf.App/PokeConf.App.UITests/bin/debug
```
![recursos](images/1.png)


## Contribución
 
Andrés Londoño - Software architect and MVP Microsoft[@Andreslon](https://twitter.com/andreslon).
 
# Comunidad Xamarin Medellin

<img src="images/XamarinMedellin.jpeg" style="height:80px;text-align:center" />

[Únete a la comunidad](https://www.meetup.com/es-ES/Xamarin-Medellin/)
