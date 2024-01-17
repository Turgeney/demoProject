В проекте реализовано автоматическое внесение значений в базу данных, достаточно сделать новую миграцию и обновить базу данных, после чего запустить отладку Visual Studio (IIS Express).

В VS необходимо открыть консоль диспетчера пакетов:
Средства - Диспетчер пакетов NuGet - Консоль диспетчера пакетов

В консоли ввести следующие значения:
Add-Migration NewMigration
Update-Database

Опционально перед запуском команд выше, в той консоли может помочь переустановка Entity Framework в проект (мне помогла при переносе проекта на другую машину):
Uninstall-Package Microsoft.EntityFrameworkCore.Design
Uninstall-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Design -Version 6.0.24
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.24
