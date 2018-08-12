# Oculus Go Apk GUI Installer
English version of this README below

**Lo primero, decir que esto es solo una aplicación gráfica para facilitar la conexión e instalación de aplicaciones y juegos en las Oculus Go para aquellos que no sepan usar la consola cmd o les de pereza. En todo caso no me hago responsable de los fallos que pueda producir no solo por la aplicación en sí, sino por el echo de estar instalando cosas de origen distinto a la tienda oficial.**

## Pasos:
* **Activar el modo desarrollador en las Oculus Go:**
Desde la aplicación de Oculus en el teléfono, una vez emparejadas las gafas, vais a la ruta y hacéis click en  **More Settings>Developer Mode** y activamos **Developer Mode** On.
* **Instalación de los drivers de Oculus Go:**
En la carpeta drivers de la aplicación os he puesto los drivers para cuando se conecte las gafas al Pc, seleccionéis esta ruta para buscarlos.
* **Adb y cosas que no necesitais porque os lo incluyo yo:**
No tenéis que descargar nada más ni instalar el Android Studio. Os incluyo en la aplicación una versión minima de Adb y Fastboot con la que os vale para instalar y desinstalar cosas en las Go.

Al conectar las gafas al Pc por usb C, tras instalar los drivers, pulsamos en la aplicación **Connect** y en la caja de texto de abajo os saldrá el modelo de dispositivo y un código que es el identificador de vuestro dispositivo. (Sí, todo esto vale para cualquier teléfono Android, yo he probado con mi Note 8).
Si no os sale el mensaje indicado, puede hacer falta autorizar la conexión desde las gafas. Dais permiso y volvéis a pulsar **Connect**.

* **Instalar Apks:**
Pulsamos en **Install Apk** y seleccionamos el juego o aplicación que queremos instalar. Se abrirá una ventana de consola en negro sin nada que mostrar, no la he ocultado para que así sepamos que se está instalando y no que se ha colgado. Una vez acaba, se cierra y muestra el mensaje de que se ha instalado correctamente.
_Si la ventana de consola se abre y cierra muy rápido, es muy posible que ya tengamos la aplicación o juego instalada previamente y por eso diga que la ha instalado cuando realmente no lo ha hecho._ En caso de querer actualizar alguna aplicación hay que desinstalar antes de volver a instalar la nueva.

* **Ejecutar lo instalado:**
Para probar lo que acabamos de instalar, tenemos que ir a **Library** en nuestras Oculus Go en la barra inferior de navegación, **Unknown Sources** que aparece tras haber activado el modo desarrollador en la aplicación de Oculus en el teléfono.
Buscamos la aplicación o juego y la ejecutamos.
---
Versiones:
V. 001:
Primera versión que conecta el Pc con las Oculus Go e instala la aplicación o juego.

---
**TO-DO:**
La próxima versión intentaré añadir la opción de desinstalar las aplicaciones y juegos, pero el nombre de las aplicaciones es distinta a como la vemos en el explorador, es como se muestra en el menú de **Unknoun Sources** por lo que no se si poner una caja de texto para que se meta a mano el nombre de la aplicación o juego a desinstalar o investigar como listar las aplicaciones y poder eliminarla con un simple click y confirmación.

---
README English:

First of all, this is just a graphical application to facilitate the connection and installation of applications and games in the Oculus Go for those who do not know how to use the cmd console or lazy them. In any case, I am not responsible for any failures that may occur not only due to the application itself, but also due to the fact that I am installing things from other sources than the official shop.

## Steps ##
* **Enable developer mode on the Oculus Go:**
From the Oculus application on your phone, once you have paired the glasses, go to the route and click on **More Settings>Developer Mode** and activate **Developer Mode** On.
* **Oculus Go driver installation:**
In the drivers folder of the application I have put the drivers for when you connect the glasses to the PC, select this path to look for them.
? Adb and things you don't need because I include you?
You don't have to download anything else or install the Android Studio. I include in the application a minimum version of Adb and Fastboot with which you can install and uninstall things in the Go.

When connecting the glasses to the PC via USB C, after installing the drivers, click on the application **Connect** and the text box below will show you the device model and a code that is the identifier of your device (Yes, all this is valid for any Android phone, I have tried my Note 8).
If the message does not appear, you may need to authorize the connection from your glasses. You give permission and then press **Connect** again.

* **Install Apks:**
Click on **Install Apk** and select the game or application you want to install. A black console window will open with nothing to show, I have not hidden it so that we know it is being installed and not that it has been hung. Once it is finished, it closes and displays the message that it has been successfully installed.
If the console window opens and closes very quickly, it is very possible that we already have the application or game installed previously and that's why it says that you have installed it when you really haven't. In case you want to update an application you have to uninstall it before reinstalling the new one.

* **Run as installed:**
To test what we have just installed, we have to go to **Library** on our Oculus Go in the lower navigation bar, **Unknown Sources** that appears after having activated the developer mode in the Oculus application on the phone.
We search for the application or game and run it.
---
Versions:
V. 001:
First version that connects the PC with the Oculus Go and installs the application or game.

---
**TO-DO:**
The next version will try to add the option to uninstall the applications and games, but the name of the applications is different from the way we see it in the browser, it is as shown in the menu of **Unknoun Sources** so I do not know whether to put a text box to manually put the name of the application or game to uninstall or investigate how to list the applications and remove it with a simple click and confirmation.