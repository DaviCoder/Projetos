# Avaliação
Davi Silva Nascimento
## Avaliação de Proficiência Tecnológica / Negócios 


Essa avaliação foi feita no Visual Studio e abaixo explicarei os passos para rodar tanto a API como o FrontEnd.
### Rodando o Back-End
- Primeiro abra o projeto com o Visual Studio e abra o "RDB-API"
- Você deve mudar o ConnectionString para um banco SQL existente, ou utilizar a String atual que conecta a um banco SQL-Server chamado "RDB_DB"
- Foi utilizado o método Code First, então todo o banco de dados esta pronto, basta executar o comando "Update-Database" no PM.
- O script para polular o banco de dados está na pasta "Services" no arquivo "SeendingService", ele será executado automaticamente na primeira vez que o projeto for ligado
- Agora só precisa colocar para funcionar com o "IIS express" que ira abarir a porta 44319

### Rodando o front-end

- Abra a pasta chamada "Front-End" nelá havera dois arquivos, um HTML e um JS
- Basta abrir essa pasta com o Visual Studio Code e rodar o HTML com a extensão "Live Server"
- Pronto, agora é só testar o sistema


##### Diagrama do banco de dados
![Screenshot](screenshot.png)