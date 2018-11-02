# Oculus Go Apk GUI Installer
English version of this README below

**Lo primero, decir que esto es solo una aplicación gráfica para facilitar la conexión e instalación de aplicaciones y juegos en las Oculus Go para aquellos que no sepan usar la consola cmd o les de pereza. En todo caso no me hago responsable de los fallos que pueda producir no solo por la aplicación en sí, sino por el echo de estar instalando cosas de origen distinto a la tienda oficial.**

## Pasos:
* **Darse de alta como desarrollador en el Dashboard de Oculus:**
Hay que acceder a https://dashboard.oculus.com/organizations/create/ y poner la misma cuenta que tengamos en nuestras Oculus Go. Un avez hecho esto, sincronizamos el movil con las Oculus Go y te reconocerá como Desarrollador.
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

* **Desinstalar aplicaciones:**
Una vez realizada la conexión, pulsando en **List Apps** se mostrará en el Log y el comboBox las aplicaciones instaladas, escondiendo las que no se deban tocar por seguridad. Seleccionando en el comboBox la aplicación y pulsando el botón de **Uninstall App** se eliminará la aplicación de nuestras Oculus Go.

* **Ejecutar lo instalado:**
Para probar lo que acabamos de instalar, tenemos que ir a **Library** en nuestras Oculus Go en la barra inferior de navegación, **Unknown Sources** que aparece tras haber activado el modo desarrollador en la aplicación de Oculus en el teléfono.
Buscamos la aplicación o juego y la ejecutamos.
---
Versiones:
- V0.0.1:
Primera versión que conecta el Pc con las Oculus Go e instala la aplicación o juego.
- V0.0.2:
Fix para cerrar el servicio adb que se quedaba abierto al salir de la aplicación.
Nuevo instalador de aplicación y desinstalador para windows.
- V0.0.3:
Añadido botón para listar las aplicaciones de terceros instaladas por adb.
- V0.0.4:
Añadido comboBox para mostrar las aplicaciones de terceros filtrando las que sean de sistema, oculus o samsung (se siguen mostrando como referencia en el Log inferior). Al seleccionar la aplicación en el comboBox y pulsar el nuevo botón de Unistall se desinstala la aplicación.
- v0.0.5:
Añadidos 3 botones para cambiar la resolución. normal 1024 - high 1536 - very high 2048.
(No añadi perfiles superiores porque se recomienda subir la cpu y gpu y es necesario sistema de refrigeración, del que no dispongo para probar. Solo he puesto los que son seguros).
- v0.0.6:
Añadidos 3 botones más en un grupo color rojo para subir la resolución y a la vez la gpu y la cpu para evitar lag en los juegos y aplicaciones. Ojo!!! Es recomendado o incluso necesario tener montado el kit de refrigeración extra o las gafas se calentarán y se reiniciarán.
- V0.0.7:
Añadidos 2 botones para activar y desactivar un fix en la aberración cromática. La forma más sencilla de comprobarlo es en el propio menú de oculus home, mirando al frente las letras de abajo se ven con un borde rojo y verde. Con el fix activado esa aberración se elimina. Tmabién se ha añadido icono en la ventana de la aplicación y se ha fijado el tamaño de la ventana para que no se deformara.


---
**TO-DO:**
Crear enlaces a los paquetes com.company.app para que se muestren en el comboBox con nombre más fáciles de leer, pero no siguen una norma, hay aplicaciones que tienen cuatro partes en el nombre, otras solo dos. Investigaré sobre ello.
Añadir un botón para lanzar ALVR y poder cargar juegos de PC VR en las Oculus Go.
Me comentan que el filtro de aplicaciones no está funcionando como debe. En breve lo arreglaré para que oculte las que no se deben mostrar como debería hacer desde el principio.


---
README English:

First of all, this is just a graphical application to facilitate the connection and installation of applications and games in the Oculus Go for those who do not know how to use the cmd console or lazy them. In any case, I am not responsible for any failures that may occur not only due to the application itself, but also due to the fact that I am installing things from other sources than the official shop.

## Steps ##
* **Register as a developer on the Dashboard of Oculus:**
You have to go to https://dashboard.oculus.com/organizations/create/ and put the same account that we have in our Oculus Go. Once this is done, we synchronize the mobile with the Oculus Go and will recognize you as a Developer.
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

* **Uninstall applications:**
Once the connection has been made, clicking on **List Apps** will show the installed applications in the Log and comboBox, hiding those that should not be touched for security reasons. Selecting the application in the comboBox and pressing the **Uninstall App** button will remove the application from our Oculus Go.

* **Run as installed:**
To test what we have just installed, we have to go to **Library** on our Oculus Go in the lower navigation bar, **Unknown Sources** that appears after having activated the developer mode in the Oculus application on the phone.
We search for the application or game and run it.
---
Versions:
- V0.0.1:
First version that connects the PC with the Oculus Go and installs the application or game.
- V0.0.2:
Fix to close the adb service that was open when you left the application.
New application installer and uninstaller for windows.
- V0.0.3:
Added button to list third-party applications installed by adb.
- V0.0.4:
Added comboBox to show the third party applications filtering the system, oculus or samsung applications (they are still shown as reference in the lower Log). Selecting the application in the comboBox and pressing the new Unistall button uninstalls the application.
- V0.0.5:
Added 3 buttons to change the resolution. normal 1024 - high 1536 - very high 2048.
(I didn't add higher profiles because it is recommended to raise the cpu and gpu and it is necessary to have a cooling system, which I don't have for testing. I've only put out the ones that are safe).
- v0.0.6:
Added 3 more buttons in a red group to increase the resolution and at the same time the gpu and the cpu to avoid lag in the games and applications. Watch out!!!!! It is recommended or even necessary to have the extra cooling kit mounted or the glasses will heat up and restart.
- V0.0.7:
Added 2 buttons to enable and disable a fix on chromatic aberration. The easiest way to check this is in the oculus home menu itself, looking at the front the letters below are shown with a red and green border. With the fix activated, this aberration is eliminated. Icon has also been added to the application window and the size of the window has been set so that it does not deform.


---
**TO-DO:**
Create links to the packages com.company.app so that they are shown in the comboBox with name easier to read, but they do not follow a standard, there are applications that have four parts in the name, others only two. I'll look into it.
Add a button to connect with ALVR for play Pc VR games in Oculus Go.
They tell me that the application filter is not working as it should. I will soon arrange for you to hide those that should not be shown as they should be from the outset.
