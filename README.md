# NecaxaTravelTuristas
Esta es la aplicacion que utilizaremos para crear un recorrido con realidad aumentada.<br>
Realizado en el centro de nuevo necaxa, perteneciente al municipio de Juan Galindo.<br>
Siendo esta la version que utilizaran los turistas, debido a que la otra aplicacion que se esta desarrollando<br>
es una aplicacion que nos permitira canjear los puntos que se consigan en esta aplicacion por productos que los <br> mismos negocios proporcionaran para incentivar el turismo y reactivar su economia.

# Version unity:
 2022.3.20f1


# Ligas de donde descargamos ligtship:
 
 I.  [ardk-upm-3.4.0](https://github.com/niantic-lightship/ardk-upm/releases/tag/3.4.0) <br>
 II. [sharedar-upm-3.4.0](https://github.com/niantic-lightship/sharedar-upm/releases/tag/3.4.0)

# Configuraciones del proyecto:
<h6>Nos tenemos que dirigir a las player settings, al apartado de android y por ultimo en la opcion de "Other Settings" configuraremos las siguientes opciones:<br></h6>
- Color Space : "Linear"<br>
- Eliminaremos "Vilkan"<br>
- Minimum Api Level: "Android 7 o posterior"<br>
- Scripting backend: "IL2CPP"<br>
- Api Compatibility level: ".NET Framework"<br>
- Target Architectures: "Marcamos la opcion ARM64"<br>


# Base de datos:
<br>
Se agregaron las base de datos con las unity Request cuya documentacion la encuentras abajo <br>
- https://docs.unity3d.com/es/530/Manual/UnityWebRequest.html<br>

# Codigos php de respuesta en nuestra aplicacion:

Codigos Exitosos:<br>
codigo: 201, mensaje: "Usuario creado correctamente", respuesta:"Nombre de usuario"<br>
codigo: 202, mensaje: "Inicio de sesion exitoso", respuesta :"Hola user_name bienvenid@"<br>
codigo: 203, mensaje: "Correo electronico actualizado correctamente", respuesta:"nuevo Email"<br>
codigo: 204, mensaje: "Nombre de usuario actualizado correctamente", respuesta:"Nuevo nombre de usuario"<br>
codigo: 205, mensaje: "La operacion se realizo exitosaente", respuesta:"Json con datos extraidos"<br>
codigo: 206, mensaje: "Contraseña cambiada correctamente", respuesta:"'.$row['user_name'].'"<br>
codigo: 207, mensaje: "Se actualizaron los puntos correctamente", respuesta:"'.$varNpuntos.'"<br>
codigo: 208, mensaje: "Se envio el correo correctamente","respuesta":"El correo se envio correctamente"<br>

Codigos de error:<br>
codigo: 400, mensaje: "Ya existe un usuario registrado con ese correo", respuesta:"Usuario existente"<br>
codigo: 401, mensaje: "Error al conectar con el servidor", respuesta:"$e"<br>
codigo: 402, mensaje: "Error al intentar crear el usuario", respuesta: "No se puede crear el usuario"<br>
codigo: 403, mensaje: "Faltan datos para realizar la operacion", respuesta: "Datos incompletos"<br>
codigo: 405, mensaje: "Inicio de sesion incorrecto", respuesta:"El usuario o la contraseña son incorrectos"<br>
codigo: 406, mensaje: "Actualizasion incorrecta", respuesta:"El usuario o la contraseña son incorrectos"<br>
codigo: 407, mensaje: "No se pudo realizar la operacion", respuesta: "Nombre de usuario o correo incorrectos"<br>
codigo: 408, mensaje: "No se pudo enviar el correo, algo salio mal", respuesta: "'.{$mail->ErrorInfo}.'";<br>
codigo: 409, mensaje: "No se pudo realizar la operacion", respuesta: "El correo del negocio es incorrecto";<br>
codigo: 410, mensaje: "No se pudo realizar la operacion", respuesta: "Los puntos que tiene el usuaro son insuficientes";<br>