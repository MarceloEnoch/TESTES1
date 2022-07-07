## Olá novamente
# Para criar esse documento eu usei dotnet ef migrations add InitialMigrations -o Data/Migrations
Note que no comando:
dotnet ef migrations add InitialMigrations -o Data/Migrations
não há referencai para o aquivo models, ele foi usado dentro da myapp.API, viu os settings e entendeu onde o models estava.
## Outro ponto
Para criar o banco de dados, ou seja, rodar as migrations, usei o comando:
dotnet ef database update
Que não especifica onde o migrations está, mas ele acha sozinho também.
Como no startup.cs já tem a referencia pro default, e no default está que o nome do meu banco de dados é Data source=MeuBancoDeEventos.db
o comando de
dotnet ef database update
ja o nomeia de acordo!