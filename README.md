# Facturacion y pagos (DDD y CQRS)
Proyecto de Facturación y pagos usando Domain Drive Design para el módulo de Arquitectura de Software.

Herramientas Utilizadas
1. Windows/Linux
2. netcore v3.1 (CLI)
2. Mysql
3. Entity Framework Core v3.1.0

Prerequisitos:
- Instalar SDK .NET Core 3.1 (Windows)
- Instalar de manera global Entity Framework Core v3.1.0 desde la consola:
    - > dotnet tool install --global dotnet-ef --version 3.1.0
- Instalar en MediatR desde la consola:
    - > dotnet add package MediatR --version 7.0.0
    - > dotnet add package MediatR.Extensions.Microsoft.DependencyInjection --version 7.0.0

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

5. Ejemplos para consultar la API REST desde Postman:

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

6. Ejemplos para consultar la REST de FACTURA (CQRS) desde Postman:
    
    - 6.1 GET:
    - 6.2 POST:
        - URL: http://localhost:5000/api/bills
        - BODY: {
                    "client" : "John Doe",
                    "telephone" : "77873056",
                    "email": "test@test.com",
                    "paymentType": "Contado",
                    "detail" : [
                        { "productId" : "2165f599-6cf3-48d4-b060-2f86a13b3726", "productName" : "Tablet Samsung", "quantity": 2, "price": 245},
                        { "productId" : "fe228f91-50d4-4fa6-b5b8-a6b46e7a80ea", "productName" : "Producto Actualizado", "quantity": 3, "price": 20.5}
                    ]
                }
