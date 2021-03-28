# Prerequisitos para poder compilar el proyecto.
+ [Visual Studio 2019 16.8 o posterior](https://visualstudio.microsoft.com/es/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019) con ASP.NET y la carga de trabajo de desarrollo web.
+ [.NET 5.0 SDK or later](https://dotnet.microsoft.com/download/dotnet/5.0)
+ En caso que quieras trabajar con el [Visual Studio Code](https://code.visualstudio.com/download) tienes que tener [dotnet](https://dotnet.microsoft.com/download) para poder ejecutar los comandos desde la terminal

## Para poder ejecutar el proyecto tenemos varias opciones.

+ solo basta con abrirlo en el visual studio.
+ Puedes agregarlo al visual studio code y usar el run la 4 opcion del menu izquierdo quetiene un icono como de play y un escarabajo. 
Arriba solo seleccionan .NET Core Launch (web) (api) algo asi aparece y le dan al boton verde ala izquierda.
+ Desde la power shell o una terminal en linux simplemente escribes dotnet run.

## Para poder probar el crud en general ya que se iso en formato de api rest se puede utilizar la erramienta Postman o la de tu preferencia.

### Las distintas ruta y formas de mandara las peticiones son la siguientes.

**A.**  Para ver una lista de los Heroes. De peticion tipo GET.
* https://localhost:5001/api/hero/
* Devolvera algo como esto.
```JSON
[
    {
        "id": 1,
        "name": "Supermans",
        "superPower": "Fly"
    },
    {
        "id": 2,
        "name": "Flash",
        "superPower": "Time Travel"
    }
]
```
#### En las siguiente opciones simplemente devolvera un Status 200 ok

**B.**  Para poder guardar un Hero. De peticion tipo POST.
- https://localhost:5001/api/hero
- Se manda un JSON con el sigueinte formato.
```JSON
{ 
  "Name":"Flash", 
  "SuperPower":"Time Travel" 
}
```

**C.**  Para poder actualizar un Hero. De peticion tipo POST
- https://localhost:5001/api/hero/update/2
- En la direccion de arriba al final de ella se escribe el numero del registro a aptualizar en el caso es el registro 2.
- Tambien se manda un JSON con el sigueinte formato.
- En este caso actulizamos el SuperPower del Hero Flash.
```JSON
{
  "Name":"Flash",
  "SuperPower":"Speed Speak"
}
```

**D.**  Para poder eliminar un Hero. de peticion tipo DELETE.
- https://localhost:5001/api/hero/remove/1
- En la direccion de arriba al final de ella se escribe el numero del registro a eliminar en el caso es el registro 1.
- En este caso eliminamos al Hero Superman.

### Recuerden ya que es un crud de los mas basico no se le agregaron validaciones.
