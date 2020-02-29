# Facturacion y pagos (DDD)
Proyecto de Facturación y pagos usando Domain Drive Design para el módulo de Arquitectura de Software.

Herramietas Utilizadas
1. netcore v3.1 (CLI)
2. Mysql
3. Entity Framework Core v3.1.0

Pasos para ejecutar la aplicación
1.  Actualizar dependencias
    1.1 Ir hasta el directorio /src y ejecutar:
        > dotnet build

2. Verificar cadena de conexión a MySQL
    2.1 Abrir el archivo facpag/src/Facpag.Data/Context/ContextFactory.cs
    2.2 En la linea 11 colocar la cadena de conexión a MySQL
        var connectionString = "Server=localhost;Port=3306;Database=facturacion; Uid=root;Pwd=;"; //MySql

3. Ejecutar migrations
    2.2 Ir hasta el directorio /src/Facpag.Data y ejecutar:
        > dotnet ef data base update

4. Ejecutar aplicación
