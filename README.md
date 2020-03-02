# Facturacion y pagos (DDD)
Proyecto de Facturación y pagos usando Domain Drive Design para el módulo de Arquitectura de Software.

Herramientas Utilizadas
1. Windos/Linux
2. netcore v3.1 (CLI)
2. Mysql
3. Entity Framework Core v3.1.0

Prerequisitos:
- Instalar SDK .NET Core 3.1
- Instalar de manera global Entity Framework Core v3.1.0 desde la consola
    - > dotnet tool install --global dotnet-ef --version 3.1.0

Pasos para ejecutar la aplicación
1.  Actualizar dependencias
    - 1.1 Ir hasta el directorio /src y ejecutar desde la consola:
        - > dotnet build

2. Verificar cadena de conexión a MySQL
    - 2.1 Abrir el archivo facpag/src/Facpag.Data/Context/ContextFactory.cs
    - 2.2 En la linea 11 colocar la cadena de conexión a MySQL
        - var connectionString = "Server=localhost;Port=3306;Database=facturacion; Uid=root;Pwd=;"; //MySql

3. Ejecutar migrations
    - 2.2 Ir hasta el directorio /src/Facpag.Data y ejecutar desde la consola:
        - > dotnet ef data base update

4. Ejecutar aplicación
    - 2.1 Abrir el archivo /src/Facpag.CrossCutting/DependencyInjection/ConfigureRepository.cs    
    - 2.2 En la linea 16 colocar la cadena de conexión a MySQL:
        - "Server=localhost;Port=3306;Database=facturacion; Uid=root;Pwd=;"
    - 2.3 Ir hasta el directorio src/Facpag.Application y ejecutar desde la consola:
        - > dotnet run

5. Ejemplos para consultar la API REST desde Postman

    - 5.1 GET:
        - URL: http://localhost:5000/api/products
    - 5.2 POST:
        - URL: http://localhost:5000/api/products 
        - BODY: {
                "name": "Test",
                "price": "19.90",
                "stock": "10"
            }
    - 5.3 PUT:
        - URL: http://localhost:5000/api/products
        - BODY: {
                "id": "996de62d-78a5-4b1a-a6ed-916ca0fd5cfe",
                "name": "Test Actualiza",
                "price": "115",
                "stock": "2"
            }
    - 5.4 DELETE:
        - URL: http://localhost:5000/api/Products/{id}
    
