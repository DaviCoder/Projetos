# Avaliação
## Primeira alternativa

Essa é a primeira questão da avaliação, foi feita no Visual Studio e abaixo explicarei os passos para rodar tanto a API como o FrontEnd.

- Primeiro abra o projeto e vá no projeto "API" e dentro vá para "appsettings" 
- Você deve mudar o ConnectionString para um banco SQL existente
- Agora no Console Package Manager (PM) execute o comando "Update-Database" para usar a migration do EF

## Configurar o Visual Studio para rodar 2 projetos

- Clicke com o botão direito em cima do nome da solução "ProjetoAPI" e vá em Propriedades
- Na nova aba vá em "Propriedades comuns" e depois "Projeto de inicialização"
- Marque a opção "Vários projetos de inicialização"
- Defina o "API" como "Iniciar sem Depuração"
- Defina o "ConsumindoAPI" como "Iniciar"
- Pronto


Dessa forma o Visual Studio irá executar a API e abrir o FrontEnd logo em seguida.