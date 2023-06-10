#  📇 Contas A Pagar App  📇

ContasAPagar é um aplicativo de gerenciamento de contas a pagar desenvolvido em C# usando o Windows Forms. Ele permite criar, visualizar, atualizar e excluir contas de pagamento, além de salvar e carregar os dados em formato XML.

## ⚙  Funcionalidades

-  💸   Inserir uma nova conta a pagar
-  💸   Atualizar uma conta a pagar existente
-  💸   Excluir uma conta a pagar
-  💸   Pesquisar uma conta a pagar por código
-  💸   Salvar os dados em formato XML
-  💸   Carregar os dados a partir de um arquivo XML

## 🖥 Requisitos do Sistema

- Microsoft .NET Framework 4.5 ou superior
- Windows 7, 8, 8.1 ou 10

## ✔ Como usar

1. Faça o download do código-fonte do projeto e abra-o no Visual Studio.
2. Compile e execute o projeto.
3. A interface principal do aplicativo será exibida.
4. Use os botões e campos disponíveis para interagir com as funcionalidades do aplicativo.
5. A pasta em que o XML é salvo se chama App Data e pode ser acessada através do comando %App Data%

## 🧾 Estrutura do Projeto

- `ContasAPagar`: Projeto principal que contém a interface do usuário e a lógica de apresentação.
- `ContasAPagar.Model`: Classes de modelo para representar contas a pagar.
- `ContasAPagar.View`: Classes de visualização responsáveis por todas as  visualizações na aplicação.
- `ContasAPagar.Controler`: Classes de Controlador responsável por receber as interações do usuário e coordenar a interação entre a visualização e o modelo.
