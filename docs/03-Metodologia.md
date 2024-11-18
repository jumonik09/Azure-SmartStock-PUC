
# Metodologia

 Oliveira e Seabra (2015) explicam que as metodologias de desenvolvimento são desenvolvidas por meio da aplicação coordenada de métodos, ferramentas e processos, com o objetivo de produzir um software eficiente e seus artefatos relacionados. Essas metodologias visam otimizar a utilização de recursos, reduzindo custos, prazos e aprimorando a qualidade do produto final.
 De acordo com Garcia et al. (2022), as metodologias de desenvolvimento de software são compostas por diferentes abordagens que podem ser aplicadas na criação de sistemas de processamento de informações. Os autores destacam que a escolha da metodologia mais apropriada é fundamental para o sucesso do projeto, como no caso do desenvolvimento de um site para gestão de estoque, pois a escolha correta influencia diretamente o andamento e o resultado final do trabalho.

Considerando a relevância das metodologias na condução e execução de um projeto de desenvolvimento de um site para gestão de estoque, esta seção detalhará como a equipe se organizará, como as atividades serão distribuídas e realizadas, além das ferramentas que serão utilizadas no desenvolvimento e na manutenção do código e dos demais artefatos do sistema de controle de estoque.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

> **Links Úteis**:
> - [Tutorial GitHub](https://guides.github.com/activities/hello-world/)
> - [Git e Github](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA)
>  - [Comparando fluxos de trabalho](https://www.atlassian.com/br/git/tutorials/comparing-workflows)
> - [Understanding the GitHub flow](https://guides.github.com/introduction/flow/)
> - [The gitflow workflow - in less than 5 mins](https://www.youtube.com/watch?v=1SXpE08hvGs)

## Gerenciamento de Projeto

### Divisão de Papéis

| Nome                            | Papel                         | Funções                        |
|-------------------------------------|------------------------------------|----------------------------------------|
| Camilla Penteado Zatz       | Scrum Master e Desenvolvedora                         | Responsável por garantir que a equipe siga os princípios e práticas do Scrum, facilitando as cerimônias e removendo impedimentos que possam atrapalhar o progresso
|Juliana Monik Moraes Silva  | QA e Desenvolvedora              |  Responsável por implementar processos, políticas e padrões para garantir a qualidade do software durante todo o ciclo de desenvolvimento                       
|Michael Benyamin Gorenstein Brasil   | QA e Desenvolvedor           | Responsável por implementar processos, políticas e padrões para garantir a qualidade do software durante todo o ciclo de desenvolvimento
|Samara Raissa dos Santos Américo Guimarães   | QA e Desenvolvedora         | Responsável por implementar processos, políticas e padrões para garantir a qualidade do software durante todo o ciclo de desenvolvimento
|Victor Rodrigues Magalhães   | Product Owner e Desenvolvedor  | Responsável por maximizar o valor do produto, atuando como ponto de contato principal entre as partes interessadas e a equipe de desenvolvimento           

### Processo

<p>Com o objetivo de distribuir as tarefas a serem realizadas entre os membros da equipe do projeto, estamos utilizando o repositório GitHub em conformidade com as práticas do framework Scrum. Essa abordagem permite uma gestão eficiente das atividades, assegurando que cada integrante tenha clareza sobre suas responsabilidades e prazos. Além disso, a utilização do GitHub facilita a colaboração e o monitoramento do progresso, promovendo uma comunicação mais eficaz e a integração entre os membros da equipe. Dessa forma, garantimos um fluxo de trabalho organizado e produtivo, essencial para o sucesso do projeto.</p>

### Ferramentas

As ferramentas utilizadas são os softwares:

• GITHUB: ferramenta de gestão de código fonte;

· FIGMA: ferramenta utilizada para criação de wireframes com a finalidade de planejar protótipos de baixa qualidade.

· LUCIDCHART: ferramenta de diagramação online que permite criar diversos tipos de diagramas. Nesta etapa, foram elaborados o Diagrama de Caso de Uso, o Diagrama de Classes e o Diagrama de Entidade-Relacionamento.


| AMBIENTE                            | PLATAFORMA                         | LINK DE ACESSO                         |
|-------------------------------------|------------------------------------|----------------------------------------|
| Ferramente de Gestão de Código        | Github                          | https://github.com/ICEI-PUC-Minas-PMV-ADS/PMV-ADS-2024-2-E2-Proj-Smart-Stock| Documentos do projeto               | GitHub                             |                            | Figma                              | http://....                            |
|Projeto de interface e wireframes    | Figma              |https://www.figma.com/design/C08lggIBwVW4fyLHmZVPjx/Untitled?node-id=0-1&node-type=canvas&t=2GSWQQ9GQg1Jb48t-0
|Ferramente de Diagramação   | Diagrama Caso de Uso           |https://lucid.app/lucidchart/610345b9-5c7b-4c48-8acb-da8e5638e064/edit?invitationId=inv_384f7e54-52cc-407c-bc7c-1bcc5fd1b0ea&page=.Q4MUjXso07N#
|Ferramente de Diagramação   | Diagrama de Classes         |https://lucid.app/lucidchart/9342c5b3-9a26-4988-802a-5d5ad34c5663/edit?invitationId=inv_59132baf-9384-4cf4-bd59-81f3d47307fe&page=HWEp-vi-RSFO#
|Ferramente de Diagramação   |Modelo Entidade Relacionamento  |https://lucid.app/lucidchart/9342c5b3-9a26-4988-802a-5d5ad34c5663/edit?invitationId=inv_59132baf-9384-4cf4-bd59-81f3d47307fe&page=E.mb4kc.4tQh#
|Ferramente de Diagramação   |Projeto da Base de Dados |https://lucid.app/lucidchart/9342c5b3-9a26-4988-802a-5d5ad34c5663/edit?invitationId=inv_59132baf-9384-4cf4-bd59-81f3d47307fe&page=YUHb3c2fn28t#
