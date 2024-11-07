# Calabonga.Blazor.AppDefinitions.Template

## Описание

Модульный монолит на Blazor? Легко! `Calabonga.Blazor.AppDefinitions.Template` - пример такого приложения, которое содержит модули (Components) в отдельных проектах (в отдельных сборках). Для это используется nuget-пакет [Calabonga.Blazor.AppDefinitions](https://www.nuget.org/packages/Calabonga.Blazor.AppDefinitions/). 

Сборка [Calabonga.Blazor.AppDefinitions.Template](https://github.com/Calabonga/Calabonga.Blazor.AppDefinitions.Template) является шаблоном для Visual Studio (Rider), которые позволит "на лету" создать примеры модульного приложения на Blazor.

В сборку [Calabonga.Blazor.AppDefinitions](https://github.com/Calabonga/Calabonga.Blazor.AppDefinitions) входят контракты прочие необходимые для работы системы модулей артефакты.

## Возможный вариант архитектуры

В шаблоне реализована схема показанная ниже. Для этого используя `Calabonga.Blazor.AppDefinitions`. Модули на frontend работают с микросервисами на backend. Причем, можно позволить модулям UI "ходить" в разные сервисы на стороне backend.

![Proposed Frontend Architecture](whatnot/schema.png)

## Как установить

Чтобы установить шаблон для Visual Studio, Rider и dotnet CLI (сразу для всех) выполните команду в командной строке (Terminal/Powershell):

``` csharp
dotnet new install Calabonga.Blazor.AppDefinitions.Template
```

Результат выполнения будет примерно такой:

![install](whatnot/install.png)

После успешной установки можно найти новый шаблон в visual Studio, а также в JetBrains Rider и даже в dotnet CLI

![visual Studio](whatnot/vs.png)

## Как удалить шаблон

Чтобы удалить шаблон из списка шаблонов для Visual Studio, Rider и dotnet CLI выполните команду в командной строке (Terminal/Powershell):

``` csharp
dotnet new uninstall Calabonga.Blazor.AppDefinitions.Template
```

Результат выполнения будет примерно такой:

![install](whatnot/uninstall.png)

## Nuget-пакеты

* [Calabonga.Blazor.AppDefinitions.Template](https://www.nuget.org/packages/Calabonga.Blazor.AppDefinitions.Template/) - nuget-пакет, установка которого добавит в список шаблонов новый шаблон `Calabonga.Blazor.Shell`. Этот шаблон создает проект Blazor Server приложения как основа для модульного монолита (Shell). Шаблон работает и для Visual Studio, и для JetBrains Rider, и для dotnet CLI. (nuget-package as tool)
* 
* [Calabonga.Blazor.AppDefinitions](https://www.nuget.org/packages/Calabonga.Blazor.AppDefinitions/) - nuget-пакет (этот репозиторий), который собой представляет набор контактов для использования в модулях и в основном приложении. (nuget-package as usual)

## Description
 
This is a demo Application Modular Blazor application. All pages moved to the its own project in one solution, but those projects (modules) are not linked with main Shell project as reference. Just install package and try it.

## История версий

### Версия 1.0.0

* Первый релиз сборки.