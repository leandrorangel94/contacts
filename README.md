<h1 align="center">lista-contatos-app</h1>

<p align="center">
|&nbsp;&nbsp;&nbsp;<a href="#memo-sobre">Sobre</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
<a href="#rocket-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
<a href="#information_source-como-usar">Como Usar</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
<a href="#thinking-como-contribuir">Como Contribuir</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
<a href="#scroll-licença">Licença</a>&nbsp;&nbsp;&nbsp;|
</p>

<p align="center">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/leandrorangel94/lista-contatos-app?color=7159c1">
    <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/leandrorangel94/lista-contatos-app?color=7159c1">
    <img alt="GitHub" src="https://img.shields.io/github/license/leandrorangel94/lista-contatos-app?color=7159c1">
    &nbsp;&nbsp;
</p>

<blockquote align="center">
&nbsp; Aplicação de lista de contatos desenvolvida como trabalho para a disciplina de Programação para Web 2 - Faculdade Pitágoras
</blockquote>

<p align="center">
<img src="https://user-images.githubusercontent.com/39461509/134230432-fa27a8a4-a7b9-4c84-a85c-56ff5231cee7.png">
</p>

## :memo: Sobre

Esta é uma aplicação básica criada com intuito de aprender sobre o desenvolvimento de API e como consumi-la com o front-end, onde foi feito um CRUD de lista de contatos.

## :rocket: Tecnologias

Este projeto foi desenvolvido utilizando as seguintes tecnologias:

- [.NET Core Web API](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio)
- [Angular](https://angular.io/)
- [SCSS](https://sass-lang.com/documentation)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Bootstrap](https://getbootstrap.com/)
- [Font Awesome](https://fontawesome.com/)

## :information_source: Como Usar

Para clonar e rodar essa aplicação, você precisará do [Git](https://git-scm.com) e [Node.js](https://nodejs.org/pt-br/) instalados no seu computador. Depois, no seu terminal, faça:

```bash
# Clone este repositório
$ git clone https://github.com/leandrorangel94/lista-contatos-app.git

# Entre dentro do repositório (front-end)
$ cd ContactApp

# Instale as dependências
$ npm install

# Rode o front-end do app
$ ng serve --o

# Entre dentro do repositório (back-end)
$ cd ContactAPI

# Compile a aplicação
$ dotnet build

#Mapeie o banco de dados pelo back-end (Necessário ter SQL Server e SSMS instalado)
$ Update-Database

# Rode o back-end do app
$ dotnet --watch run

```

## :thinking: Como contribuir

- Faça um fork desse repositório;
- Cria uma branch com a sua feature: `git checkout -b minha-feature`;
- Faça commit das suas alterações: `git commit -m 'feat: Minha nova feature'`;
- Faça push para a sua branch: `git push origin minha-feature`.

## :scroll: Licença 

> Esse projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

##### <p align="center"> <strong> < Feito por <a href="http://github.com/leandrorangel94"> @leandrorangel94  </a> /> </strong>  :wave:
