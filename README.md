# Sistema de Login em C# - ASP.NET Core MVC

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET](https://img.shields.io/badge/ASP.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

## Descricao do Projeto

Sistema de autenticacao completo desenvolvido em C# utilizando ASP.NET Core MVC. Inclui funcionalidades de login, cadastro de usuarios e area restrita (dashboard).

## Funcionalidades

- Login de usuarios com validacao
- Cadastro de novos usuarios
- Sessao de usuario autenticado
- Dashboard protegido (area restrita)
- Design responsivo e moderno
- Validacao de formularios no servidor

## Tecno Utilizadas

- **C#** - Linguagem de programacao
- **ASP.NET Core MVC** - Framework web
- **.NET 8.0** - Plataforma de desenvolvimento
- **HTML5** - Estrutura das paginas
- **CSS3** - Estilizacao e design responsivo

## Estrutura do Projeto

```
LoginApp/
├── Controllers/
│   ├── HomeController.cs      # Controlador principal
│   └── AccountController.cs   # Controlador de autenticacao
├── Models/
│   └── User.cs                # Modelos de usuario e ViewModels
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml       # Pagina inicial
│   │   └── Dashboard.cshtml   # Dashboard (area restrita)
│   ├── Account/
│   │   ├── Login.cshtml       # Pagina de login
│   │   └── Register.cshtml    # Pagina de cadastro
│   └── Shared/
│       └── _Layout.cshtml     # Layout principal
├── wwwroot/
│   └── css/
│       └── site.css           # Estilos CSS
├── Program.cs                 # Configuracao da aplicacao
└── LoginApp.csproj            # Arquivo de projeto
```

## Como Executar

1. Certifique-se de ter o .NET 8.0 SDK instalado
2. Clone o repositorio
3. Navegue ate a pasta do projeto
4. Execute os comandos:

```bash
dotnet restore
dotnet run
```

5. Acesse no navegador: `https://localhost:5001`

## Screenshots

### Pagina Inicial
![Home](screenshots/home.png)

### Pagina de Login
![Login](screenshots/login.png)

### Pagina de Cadastro
![Register](screenshots/register.png)

### Dashboard
![Dashboard](screenshots/dashboard.png)

## Autor

**Vitor Silva**
- GitHub: [@kanongemini](https://github.com/kanongemini)
- LinkedIn: [Vitor Silva](https://www.linkedin.com/in/vitorsilva)

## Licenca

Este projeto esta sob a licenca MIT.
