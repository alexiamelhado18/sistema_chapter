<h1>Olá, Dev!</h1>
<p>Este repositório é referente ao segundo dia do plantão individual sobre BackEnd. Serão abordadas as UCs 13(Banco de daodos), 9(Codificação para Back-End), 14(Desenvolvimento de API), 15(Teste de BackEnd)</p>

<h1>BANCO DE DADOS</h1> 

Para fazer essa preparação precisamos ter instalado em nossa máquina:
- SQL Server - Sistema de gerenciamento de banco de dados
- SSMS(**SQL Server Management Studio**) Ferramenta usada para administrar e interagir com o SQL Server

 <h2>Instalação do SQL Server</h2>
a) Procure no navegador por: **SQL Server Download**

b) Clique no seguinte link: 
<br>
[Downloads do SQL Server | Microsoft](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

c) Rolando um pouco a tela para baixo, você vai clicar em “Baixe agora” na opção Developer
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/fd845ad8-fc64-40f6-9b48-a35cae11fcbb)

b) Abra o arquivo e permita que ele altere seu dispositivo.

c) Abrirá essa interface, e selecione o **Personalizado**, para conseguirmos selecionar o que desejamos dentro do SQL:
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/96be1835-4072-4fc1-a590-494177d605b8)

d) Clique em Instalar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/378ea71b-fd99-4077-b081-61861648a851)

e) Aguarde a instalação
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/d05ee115-4590-4ca2-b3b2-c2fc0d469045)

f) No menu lateral, selecione Instalação
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/a85170ba-5338-42ae-8e9c-5d67f210c240)

g) Dentro de Instalação, selecione o link de Nova instalação autônoma do SQL Server ou adicionar recursos a uma instalação existente.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/798fbb46-e0f5-4e92-baed-9258b4f1d87c)

h) Aguarde.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/a57b69b8-dad9-4b3c-ae18-7b9d7f4f8020)

i) Em seguida, em “Especifique uma edição gratuita” deixe a opção **Developer** e clique em **Avançar**.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/eb17e1fb-3ddf-497e-8fe1-55356d55e68e)

j) Nessa parte de Termos de Licença, aceite os termos e condições e clique em Avançar
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/984d9607-ab74-40c4-a6c0-c7c63faec789)

k) Clique em Avançar
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/090014e9-387e-4ab1-9aaf-1216e812bfe7)

l) Clique em Avançar
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/6f8074f2-e893-43f5-8113-b6549ae63f30)

m) Não selecione a opção Extensão do Azure para SQL Se. E clique em Avançar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/baa2b842-f443-44f6-a33f-a0c46e85e280)

n) Selecione as opções das imagens e clique em Avançar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/115a9449-737a-4ef9-a7cd-38d6f3a08f81)

o) Clique em Instância nomeada e coloque “SQLExpress” e em ID da instância, “SQLEXPRESS”. Por fim, clique em Avançar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/605108c6-0036-42f1-974a-c2f71a0f4423)

p) Selecione o check de “Conceder o privilégio Realizar a Tarefa de Manutenção de Volume…”. E clique em Avançar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/9a90a18f-9f08-4f0f-900c-f5abe7db5d30)

q) Selecione o Modo Misto e coloque em Digitar Senha a senha “1234” e em Confirmar Senha, a mesma senha “1234”.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/daf96156-a75e-4bd7-b784-ca31482a526a)

r) Em seguida, clique em Adicionar Usuário Atual e ao finalizar, clique em Avançar. 
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/6ef83c57-4de4-4a3e-ba02-3399cf6872cb)

s) Clique em Instalar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/88229cdf-bd86-4200-a049-64291a685f6f)

t) Assim que tudo estiver com Status Exito, clique em Fechar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/3ad192e3-5ea3-4e26-926e-72a76b2184b9)

 <h2>Instalação do SSMS</h2>
 a) Procure no navegador por: *SSMS Download*

b) Clique no seguinte link:
<br>
[SQL Server Management Studio (SSMS) - SQL Server Management Studio (SSMS)](https://learn.microsoft.com/pt-br/sql/ssms/sql-server-management-studio-ssms?view=sql-server-ver16)

c) Rolando um pouco a tela para baixo, você vai clicar em ***Baixar o SQL Server Management Studio (SSMS)***
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/686ec8a6-7423-4ef6-8e62-9f34f258efdd)

d) Ele irá te direcionar a outra tela, então clique em Download gratuito do SSMS(SQL Server Managment Studio)
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/2884d036-69c9-464e-89ba-56b6bbbfa75b)

e) Assim que baixar, clique no arquivo e permita que faça alterações em seu dispositivo. Assim que aceitar, aparecerá uma aba de bem-vindo. Clique em Instalar. 
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/96e227c9-1ab0-438f-aee7-a3fd96907008)

f) Aguarde a instalação.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/b228053b-9e3a-4972-9450-6477b7ad1a75)

g) Por fim, clique em fechar
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/669120e5-236a-41b5-9cbf-1f4ce24a9e83)

O ambiente está OK, então vamos ver como é a interface do SSMS. 
Clique na barra de pesquisa do Windowns e pesquise por SSMS, selecione o SQL Server Management Studio Management Studo 19.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/f0fc35fe-616f-4dbe-93df-bcf8e8a16fd8)

Toda vez que abrir o SSMS aparecerá de primeiro momento o ambiente de conexão com o servidor. Aqui você pode deixar da seguinte forma e em seguida, clicar em “Conectar”.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/7e0621f2-ae72-42ef-a900-5969ef40f4d1)

Quando abrir, terá uma a chamada Pesquisador de Objetos e dentro dele, estará os bancos de dados, informações de segurança e gerenciamento etc. O que será muito importante para nós é pasta Banco de dados, pois será nele que veremos nossos bancos com suas tabelas.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/9c5975f2-a527-47af-bcf9-fccfe64f6025)

Para iniciar o uso, Clique em Nova Consulta na aba de ferramentas.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/0b202463-641c-4f8f-9fc8-d7e66dbac6e8)

Ao clicar em Nova Consulta, Irá abrir uma consulta, na qual conseguiremos escrever nossos comandos.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/d4a712ec-5c64-432f-87ce-385220bc2f62)

Primeiro precisamos entender que faremos hoje. Vamos criar um banco de dados de uma biblioteca. E o que temos em bibliotecas? LIVROS! 

Então, para criar nosso banco de dados devemos escrever dentro da consulta o comando:
```
CREATE DATABASE Chapter;
```
E em seguida, clique em Executar:

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/e10b714a-3634-458a-9bed-fa7c61564ca5)

Assim que clicar em executar, verifique que na aba de mensagens temos um retorno de “Comandos concluídos com êxito.” Isso significa que nosso banco foi criado.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/33db05fd-6397-4294-89d8-864e10fe676d)

Mas para verificar qualquer mudança e melhor, para qualquer mudança feita, sendo criação de banco ou até mesmo de tabelas é importante dar o comando F5, ou vá na aba de pesquisador de objetos e clique no ícone de atualizar. Isso é importante, pois às vezes demora para atualizar sozinho.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/320af3cb-f9d1-4188-8783-145d60658124)


Então vamos seguir. É importante que a partir de agora, sempre que for escrever algum comando, seja ele um SELECT, DELETE, INSERT, ou outros, informe qual banco estará fazendo esses comandos. Então, escreva o comando, para especificar que está utilizando o banco de dados Chapter: 

```
USE Chapter;
```
Já que nosso banco já está criado, vamos para a criação das tabelas, ok? Para isso iremos usar esse comando, e em seguida clicar em Executar ou dar F5, para rodar o comando:
```
CREATE TABLE Livros (
	Id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(150) NOT NULL,
	QuantidadePaginas INT,
	Disponivel BIT
);
```

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/9d3abf74-070a-4447-8b1a-882beb1ccbd0)

Agora, para inserir registros dentro das colunas da tabela Livros, será necessário usar este comando, e em seguida clicar em Executar ou dar F5, para rodar o comando:
```
INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel) VALUES ('Titulo A', 120, 1);

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel) VALUES ('Titulo B', 220, 0);
```

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/1442961c-8d05-45e7-addf-0f58f8b3f287)


E para alterar qualquer informação de registro, dentro da tabela Livros será necessário usar este comando. E em seguida clicar em Executar ou dar F5, para rodar o comando
```
UPDATE Livros SET Titulo = 'Titulo A1' Where Id = 1;
```

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/1080ca06-6941-4c6a-ad50-67685c2a1c1d)

E para consultar a nossa tabela e seus campos podemos dar este comando. E em seguida clicar em Executar ou dar F5, para rodar o comando

SELECT Id, Titulo, QuantidadePaginas, Disponivel FROM Livros;
ou
SELECT * FROM Livros;

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/b4778563-ea5a-47d2-a9ac-f71394741aec)

Finalizando, aqui o importante é você compreender que no banco de dados podemos manipular, organizar os dados do nosso sistema. E usando a linguagem SQL conseguimos dar os SELECT, INSERT, UPDATE e CREATE. A atividade de hoje é para que vocês consigam criar o banco, suas tabelas e preencher com registros. 



<h1>DESENVOLVIMENTO DE API</h1> 

- Iniciando projeto no Visual Studio
Com o Visual Studio aberto, clique em **Criar um projeto**, na direita.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/8e9de0fd-5286-4d73-aada-a1f5bd1a540e)

Em Criar um novo projeto, terá modelos em que você pode criar o projeto. Na aba de pesquisa chamada “Pesquisar modelos(Alt+S)” procure por API web do ASP.NET core - C# selecione-o e clique no botão no canto inferior na direta, escrito próximo.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/1318c43d-7863-4185-8c6f-48e50b83c78f)
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/3b8766da-9a68-4498-80da-e76f6f663136)

Na aba de Configurar seu novo projeto, escreva o nome do projeto e caso queira, pode colocar o local em que o arquivo estará. Assim, clique em Próximo.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/234cdaeb-a8cd-4235-8890-42c5c67d308c)

Em Informações adicionais, não altere nada e clique em “Criar”. Observe se a estrutura está com a versão do .NET em 6.0.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/53ac2159-f022-4a0e-ae1b-b08d5d581c82)

Aguarde criar o projeto
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/c9b38054-c492-4728-8b48-500913182d10)

E logo abrirá o projeto criado pronto para ser alterado.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/c2b0d133-ef52-435b-ab4e-33b3c50cb7a6)

Com o ambiente todo preparado, agora sim, vamos começar a mexer no projeto.

Primeiro, precisamos criar três pastas:

- [ ]  Criar a pasta Models

Dentro dessa pasta haverá modelos que representam os objetos de dados que a sua aplicação manipula. Eles geralmente refletem as entidades do mundo real com as quais sua aplicação está lidando. Por exemplo, se sua aplicação lida com usuários, você pode ter um modelo de usuário que inclua atributos como nome, email e senha.

1. Clique com o botão direito no nome do projeto Chapter.
   
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/fb104c9f-8f30-49f6-9a70-04bb2d933209)

3. Procure por Adicionar e em seguida, clique em Nova Pasta
   
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/9680b870-6c67-47e1-945d-1dcc739875d5)

5. Escreva no nome da pasta a palavra Models
   
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/34598693-7db7-4969-9f15-fa6514fcfdfd)

- [ ]  Criar a pasta Repositories
Dentro da pasta haverá repositórios responsáveis por lidar com a lógica de acesso a dados. Eles fornecem uma abstração sobre como os dados são armazenados e recuperados. Por exemplo, se você está lidando com dados de usuário, o repositório de usuário pode ser responsável por recuperar, atualizar, criar e excluir usuários no banco de dados.

1. Clique com o botão direito no nome do projeto Chapter.
   ![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/20ec97ef-13a2-4e0b-a160-ef4481f9a1df)

2. Procure por Adicionar e em seguida, clique em Nova Pasta
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/8a74dfbe-a49e-4c65-ba9e-23869306151f)

3. Escreva no nome da pasta a palavra Repositories
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/fb9d0a8e-3be8-42df-9aae-c54c594a5a40)

- [ ]  Criar a pasta Contexts
Na pasta Contexts será o contexto é uma noção abstrata que geralmente se refere ao estado ou ambiente no qual uma operação específica está ocorrendo. Em uma API, o contexto pode se referir ao estado atual da solicitação, como as informações do usuário que fez a solicitação, as permissões de acesso, configurações específicas da aplicação e assim por diante. O contexto ajuda a determinar como as solicitações devem ser tratadas com base nas condições atuais.

1. Clique com o botão direito no nome do projeto Chapter.
   
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/0d935e84-28e1-4556-8b8d-65c8b36b8d2e)

3. Procure por Adicionar e em seguida, clique em Nova Pasta
   
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/ba4680ff-cc6a-471a-b267-79e141d71c06)

5. Escreva no nome da pasta a palavra Contexts
   
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/3066337a-58fb-462e-b5d7-c9161fd0dd18)

Agora, dentro da pasta Models, terão todas as classes do nosso sistema. Será nela que terão as classes com os atributos e métodos.

Para criar a classe, você precisa clicar em Models e depois no botão direito. Procure por Adicionar e em seguida, Classe.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/ce5b8995-d74d-4d02-9eec-8128789a70fa)
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/0b924d33-2d82-4701-bbfa-269ac578a08d)

Abrirá um campo para criar a classe. A única coisa que vai precisar mudar será o nome da classe. Coloque Livro.cs e em seguida clique no botão **Adicionar**.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/2ab1483f-3e7a-46af-9cd5-fd986d139ca5)
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/dbaa0001-9238-4e82-85dc-0bcb02f22075)

Dentro da classe iremos criar os atributos públicos com seus tipos de dados. Então para ID será int por ser numérico, o título string por ser texto, e o bool para Disponível que é um tipo de dado que retorna true ou false.

Os métodos de acesso **`get`** e **`set`** servem para controlar os valores do atributo.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/37ba7425-1b54-4088-a276-a2e5a7a4409f)

Agora no Context vamos aplicar as configurações para conectarmos nossa API ao banco.

Para isso precisamos instalar um pacote do sql server. E isso é um dos pontos positivos do Visual Studio, dentro dele tem um gerenciador de pacotes nuget e ele traz várioss pacotes para instalarmos.

Para acessar o gerenciador de pacotes do NuGet, clique no botão direito em cima do nome do projeto e procure por “Gerenciar Pacotes do NuGet.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/3e4fd9e2-e350-4e18-b5c3-b08ff1a6b9c6)


Será aberto uma janela de pacores NuGet, clique em Procurar e pesquise por “Sql Server”

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/e7662f1f-e088-4ae2-8c0a-58dfd7b3eab2)
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/3b8990e7-8741-4375-a3af-2ecc410653b1)

Clique em:
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/6a9fe118-a82f-4267-b21c-c6e8263fd97f)

Verifique se a versão é 6.0.21 e depois clique em Instalar:

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/193b1f90-3210-4065-9b0f-2128858d9c70)

Aguarde a instalação.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/405fba48-7bc0-428c-9be9-153d14e125a3)

Clique em aplicar:
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/56dc090f-4eec-4f53-95bb-c6b291c23a27)

E em seguida, clique em Eu aceito:
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/c50018b8-4c01-42dc-9645-043dd3407b30)

Assim que aparecer essa imagem, seu pacote foi instalado:
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/4bbf6ab8-df7d-4b38-a194-5841162aa486)

Agora na pasta Context vamos adicionar a classe ChapterContext.cs (sem plural).

Para criar a classe, você precisa clicar em Context e depois no botão direito. Procure por **Adicionar** e em seguida clique em **Classe**.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/9215c92c-9ee0-4d79-a535-616518d54700)

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/281ee678-2fbc-41d2-a9eb-65a40f7cd05c)

Escreva o nome da classe como ChapterContext.cs

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/86545d02-ad99-46ec-b81f-046533d94718)

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/c7ab2273-4260-4652-bb6b-4693c9cbd6a6)

Dentro da classe ChapterContext será necessário herdar o DbContext:
```
using ChapterFST1.Models;
using Microsoft.EntityFrameworkCore;
namespace ChapterFST1.Contexts
{
    public class ChapterContext : DbContext
    {
     
    }
}

```
Em seguida, será necessário criar o método OnConfiguring e depois, chamar as entidades que serão usadas na leitura.

```
using ChapterFST1.Models;
using Microsoft.EntityFrameworkCore;
namespace ChapterFST1.Contexts
{
    public class ChapterContext : DbContext
    {

        // vamos utilizar esse método para configurar o banco de dados
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }
    }
}
```
Para colocar as informações necessárias dentro do ***optionsBuilder.UseSqlServer("");***  você precisa ir no seu banco de dados, se conectar e seguir os passos para pegar algumas informações de conexão;

Entre no SSMS e em cima do nome do servidos, clique no botão direito e em seguida, em **propriedades**.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/f6551ee2-f643-48d0-98d9-568e135274ec)

Copie a informação do nome desse banco.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/c0389b5a-c4d7-4463-985a-ef377a77cae5)

E aplique dentro de Data Source:

As demais informações são padrões.

```
using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //cada provedor tem sua sintaxe
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-AP18MAI\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true;  TrustServerCertificate = True");

            }
        }

        //entidade que vamos usar:
        public DbSet<Livro> Livros { get; set; }
    }
}

```
Agora no repositories, vamos criar uma classe chamada Livro Repository.cs

Clique na pasta Repositories e em seguida botão direito, procure por **Adicionar** e em seguida **Classe**.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/83100f61-e93b-46cb-b2a8-676b4c2730af)

Escreva o nome da classe, LivroRepository.cs

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/a4bed30a-156a-4898-b470-3926bb610029)

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/9d5d925d-63a7-4963-a7ec-1cf78c773d23)

Dentro da classe você vai criar primeiro um método construtor privado e de leitura da Classe ChapterContext.

```
using ChapterFST1.Contexts;
using ChapterFST1.Models;
namespace ChapterFST1.Repositories
{
    public class LivroRepository
    {
				//Método construtor
				//Somente leitura
        private readonly ChapterContext _context;
    }
}
```
E em seguida, criar outro método construtor público, agora com o nome LivroRepository que possui como parâmetro uma variável context do tipo ChapterContext. 

```
using ChapterFST1.Contexts;
namespace ChapterFST1.Repositories
{
    public class LivroRepository
    {
//Método construtor
//Somente leitura
        private readonly ChapterContext _context;
//Método conbstrututor
//
        public LivroRepository(ChapterContext context)
        {
            _context = context;
        }
    }
}
```
Depois disso, crie um método público chamado Listar() que tem como retorno uma lista de livros, e dentro desse método um return que lista os livros que estão dentro do bancok, no caso do _context.

```
using Chapter.Contexts;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;
            
        public LivroRepository(ChapterContext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }

    }
}

```
Agora no Controller, vamos criar um controlador chamado LivroController.cs

Clique na pasta Controllers e em seguida, no botão direito. Procure por **Adicionar** e em seguida **Controlador**. 

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/a1cca9d2-adf2-4fc4-9834-390f2a8d6576)

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/a49d6278-e967-433a-92db-dc3f934db9b7)

Assim que abrir uma aba para Adicionar Novo Item com Scaffolding, na aba da esquerda em Comum, clique em API. Depois selecione a opção Controlador MVC - Vazio e depois isso clique em Adicionar.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/1ece9ad9-f748-4b8c-a042-e6a070fbfdad)

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/6744d928-3451-4dc1-9bdd-4722bfe79528)

Em seguida aplique o nome do controller como LivroController.cs e depois clique em Adicionar.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/e698ede1-d43c-4635-8ab0-276c0a001e4a)

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/fe104a7c-ac70-4f56-a118-29e4283cceaa)

Acima de “  [Route("api/[controller]")]” será colocado o “[Produces("application/json")] ” que serve para informar que utilizaremos o arquivo json para comunicação:

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/7a41930e-3539-4022-afcc-33ead8b15fe9)

Em seguida, será criado um método construtor privado e de leitura da nossa classe LivroRepository. E além disso, um método construtor da própria classe que receberá como parametro o livroRepository.

```
[Produces("application/json")]
    
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;
        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }
    }
```
Em seguida, crie o [HttpGet] e abaixo dele, um método de listagem que dentro terá um try catch com retornos de erro e OK.

```
[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class LivroController : ControllerBase
{
    private readonly LivroRepository _livroRepository;

    public LivroController(LivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    [HttpGet]
    public IActionResult Listar()
    {
        try
        {
            return Ok(_livroRepository.Listar());
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
```
Em seguida, no arquivo program.cs você precisa adicionar essas duas linhas de código:
```
builder.Services.AddScoped<ChapterContext, ChapterContext>();
builder.Services.AddTransient<LivroRepository, LivroRepository>();
```
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/dea1a900-fde3-4e1f-a19e-580833401690)

Agora, a API está pronta para rodar. Clique em Chapter.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/27fd8904-e4c8-4a6c-862c-dd99235adafe)

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/7c15078e-731c-4583-927f-6c76955444c3)

Aguarde a execução.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/10e3935d-3037-4055-9560-33dfa9004e98)

Será aberto em seu  navegador padrão um cara chamado Swagger, que será uma interface gráfica para nós de back que facilitará a interação do usuário com a API. 

Abra a Aba em azul
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/5d36fc56-60c8-4692-9570-1c8a9d0a34b8)

Clique em Try it out

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/5eb5aa7a-b569-4e2e-a41b-242d2bd65098)

Em seguida clique no botão grande escrito Execute

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/46101503-cc22-486f-9a8f-a218a55d09c2)

E você verá o Code, um código de retorno. O 200 siginfica que tudo deu certooo e além disso, na aba de Response body terá a listagem dos livros.

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/98fffb18-15b0-4f63-8d96-6843ad0d0a75)


<h1>TESTE DE BACK</h1>

Começamos criando uma pasta e abrindo ela.
Digitamos na parte de endereço "cmd"
![1](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/7d4413f2-6945-4c5e-be00-3edc8da9647a)

No prompt de comando, digitamos "code ." (com o ponto separado) e pressionamos enter
![2](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/b2146eea-25af-4709-9e94-f9361b752d34)

Abrimos o terminal
![3](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/b9512a73-647d-40ec-bdb3-fa02f082293d)

E nele digitamos `dotnet new classlib -f net6.0 -o Operacoes` e pressionamos enter

Um projeto de classes será criado. Agora, dentro da pasta Operacoes, renomeamos o arquivo Class1.cs para Operacoes.cs
![4](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/d75f511c-ddf5-4817-bda8-5b38081f37c4)

Clicamos no arquivo e trocamos o Class1 escrito dentro dele para Operacoes
![5](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/c8edbc7c-8bd5-41c3-81cb-229794b6d5cf)

Depois, vamos criar uma função somar

![6](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/575c2171-da6a-48f2-a57f-83e06b5aaf67)

Agora vamos criar um projeto de testes. Para isso, usamos o comando `dotnet new xunit -o Operacoes.xunit`

Depois disso, precisamos apontar para o projeto de testes onde está o projeto de classes. Para isso, usamos o comando
`dotnet add ./Operacoes.xunit/Operacoes.xunit.csproj reference ./Operacoes/Operacoes.csproj`

Depois, na pasta Operacoes.xunit, abrimos o arquivo UnitTest1.cs
Criamos a seguinte estrutura
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/f7ad2244-7806-4d89-aad0-6a9c31801890)

Onde num1 e num2 são os números a serem somados, res o resultado esperado.

Para rodarmos o teste, precisamos entrar na pasta pelo terminal, já que atualmente ele está na pasta que vem antes. Para isso, usamos o comando `cd Operacoes.xunit`

Depois disso, usamos o comando `dotnet test` para fazermos o teste. O resultado deve ser parecido com esse
![8](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/00247a81-4a69-4baa-ad0a-baa04c1e8d14)

Agora faremos um teste com variáveis de valor diferente. Segue a estrutura a ser escrita embaixo da primeira função
![9](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/d57641c2-1335-4ac3-b492-8725bf1ec235)

Depois disso, rodamos o teste de novo com o comando `dotnet test`
![10](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/2fbd7d68-44c7-404e-89c6-cbf6a1f316af)

Nesse caso, o teste teve uma falha porque um dos conjuntos que passamos para a função tem 1, 2 e 4, porém 1 + 2 não dá 4

Segue o código final do teste
```
using Operacoes;

namespace Operacoes.xunit;

public class UnitTest1
{
    [Fact]
    public void SomarDoisNumeros()
    {
        double num1 = 1;
        double num2 = 1;
        double res = 2;

        var resultado = Operacoes.Somar(num1, num2);

        Assert.Equal(resultado, res);
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(1, 2, 4)]
    [InlineData(2, 2, 4)]
    public void SomarDoisNumerosLista(double num1, double num2, double res) 
    {
        var resultado = Operacoes.Somar(num1, num2);

        Assert.Equal(res, resultado);
    }
}
```

E o da classe Operacoes
```
namespace Operacoes;
public class Operacoes
{
    public static double Somar(double num1, double num2) {
        return num1 + num2;
    }
}
```


