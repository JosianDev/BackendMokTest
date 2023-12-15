# BibliotecaBack API (.NET 6)

Bienvenido a BibliotecaBack, una API construida con .NET 6.

## Configuración del Proyecto

### Prerrequisitos

Asegúrate de tener instalado lo siguiente:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/sql-server/)

### Clonación del Proyecto

1. Abre una terminal y ejecuta el siguiente comando para clonar el repositorio:

    ```bash
    git clone https://github.com/JosianDev/BackendMokTest.git
    ```

2. Navega al directorio del proyecto:

    ```bash
    cd BackendMokTest
    ```

### Configuración de la Base de Datos

1. Abre el archivo `appsettings.json` en el directorio raíz del proyecto.

2. Modifica la sección `"ConnectionStrings"` con la información de conexión a tu instancia de SQL Server. Asegúrate de tener una base de datos llamada `BibliotecaBack`.

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=BibliotecaBack;Trusted_Connection=True;"
    },
    ```

3. Opcionalmente, puedes personalizar la configuración JWT en la sección `"Jwt"`. Ajusta las claves y valores según tus preferencias.

    ```json
    "Jwt": {
      "Key": "MOK2023*TEST2023",
      "Issuer": "TestMok2023",
      "Audience":  "no",
      "ExpireMinutes": "60"
    },
    ```
4. Correr el script Sql ubicar


### Ejecución del Proyecto

1. Abre una terminal y navega al directorio raíz del proyecto.

2. Ejecuta el siguiente comando para restaurar las dependencias:

    ```bash
    dotnet restore
    ```

3. Aplica las migraciones para crear la base de datos:

    ```bash
    dotnet ef database update
    ```

    **Opcional:** Si prefieres ejecutar un script SQL manualmente, puedes encontrar el script en `./DatabaseScripts/CreateDatabase.sql`.

4. Inicia la aplicación con el siguiente comando:

    ```bash
    dotnet run
    ```

    La API estará disponible en `https://localhost:5001` o https://localhost:7183 .
    Swagger estará disponible en `https://localhost:5001/swagger` o `https://localhost:7183/swagger` .


## Preguntas o Problemas

Si tienes alguna pregunta o encuentras algún problema, no dudes en abrir un problema en el [repositorio](https://github.com/tu-usuario/tu-repositorio).

¡Disfruta explorando la API de BibliotecaBack!
