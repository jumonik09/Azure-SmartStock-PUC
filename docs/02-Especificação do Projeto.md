# Especificações do Projeto

## 1º Persona

<table>
  <tr>
    <th colspan="3">Perfil 1: Paulo - Analista de Compras</th>
  </tr>
  <tr>
    <td rowspan="3">
      <ul>
        <li><b>Idade:</b> 32 anos;</li>
        <li><b>Profissão:</b> Analista de Compras;</li>
        <li><b>Formação:</b> Graduação em Administração de Empresas;</li>
        <li><b>Objetivo:</b> Melhorar a eficiência do processo de compra e reduzir custos, garantindo a satisfação dos clientes e a gestão eficiente do estoque.</li>
      </ul>
      <img width="2000" src="https://github.com/user-attachments/assets/c7b2cb15-0c49-4541-907d-2c5c21c4e9a1" />
    </td>
    <td><b>Descrição</b></td>
    <td>Paulo negocia com fornecedores e faz pedidos de produtos no supermercado, precisando de dados confiáveis para tomar decisões.</td>
  </tr>
  <tr>
    <td><b>Necessidades</b></td>
    <td>
      <ul>
        <li>Visualizar relatório do estoque;</li>
        <li>Validar as Ordens de Compra geradas automaticamente ao atingir uma Quantidade Crítica;</li>
        <li>Entrar em contato com o fornecedor e verificar a quantidade de itens disponíveis e seus valores;</li>
        <li>Ter a Ordem de Compra validada pela Gerente de Loja;</li>
        <li>Atualizar o estoque após finalizar uma Ordem de Compra.</li>
      </ul>
    </td>
  </tr>
  <tr>
    <td><b>Perspectivas</b></td>
    <td>
      <b>Angústias:</b>
      <br>
      Paulo se preocupa em manter o equilíbrio entre a oferta e a demanda, temendo que produtos faltem ou que itens em excesso não sejam vendidos.
      <br>
      <br>
      <b>Frustrações:</b>
      <br>
      A frustração de Paulo vem principalmente da dificuldade em obter informações precisas e atualizadas do estoque. Ele se preocupa tanto em evitar a falta de produtos quanto em não comprar itens em excesso que podem acabar não sendo vendidos.
      <br>
      <br>
      <b>Expectativas:</b>
      <br>
      Paulo espera que o sistema forneça dados confiáveis, permitindo que ele faça pedidos de forma mais eficiente e segura. Ele deseja que as Ordens de Compra sejam automatizadas ao atingir níveis críticos de estoque, para que ele possa focar em negociações estratégicas e melhorar o relacionamento com fornecedores.
    </td>
  </tr>
</table>

## 2º Persona

<table>
  <tr>
    <th colspan="3">Perfil 2: Júlia - Analista de Estoque</th>
  </tr>
  <tr>
    <td rowspan="3">
      <ul>
        <li><b>Idade:</b> 29 anos;</li>
        <li><b>Profissão:</b> Analista de Estoque;</li>
        <li><b>Formação:</b> Graduação em Logística;</li>
        <li><b>Objetivo:</b> Otimizar o gerenciamento do estoque e reduzir perdas devido a produtos vencidos, utilizando tecnologia para melhorar o processo de reabastecimento.</li>
      </ul>
      <img width="2000" src="https://github.com/user-attachments/assets/218570f6-6fa7-4145-8ba9-cc7804923800" />
    </td>
    <td><b>Descrição</b></td>
    <td>Júlia recebe, confere e verifica o relatório com os vencimentos dos produtos e a quantidade que
      precisa ser abastecida no supermercado, gerando as Fichas de Reabastecimento de Estoque.</td>
  </tr>
  <tr>
    <td><b>Necessidades</b></td>
    <td>
      <ul>
        <li>Visualizar relatório contendo dados do estoque;</li>
        <li>Priorizar produtos com data de validade próxima do vencimento para serem armazenados na frente de cada seção, além de segmentar produtos que precisam ser expostos na seção de ofertas;</li>
        <li>Gerar as Fichas de Reabastecimento de Estoque e enviar para a aprovação da Gerente de Loja;</li>
        <li>Imprimir as Fichas de Reabastecimento de Estoque aprovadas e direcionar para a estoquista.</li>
      </ul>
    </td>
  </tr>
  <tr>
    <td><b>Perspectivas</b></td>
    <td>
      <b>Angústias:</b>
      <br>
      Júlia se preocupa com a possibilidade de produtos vencerem sem serem vendidos, o que causaria perdas para o supermercado.
      <br>
      <br>
      <b>Frustrações:</b>
      <br>
      Ela se frustra com a necessidade de verificar manualmente as datas de validade e decidir quais produtos devem ser priorizados.
      <br>
      <br>
      <b>Expectativas:</b>
      <br>
      Júlia espera que o sistema automatize a priorização de produtos com validade próxima e facilite o processo de reabastecimento, minimizando erros e perdas.
    </td>
  </tr>
</table>

## 3º Persona

<table>
  <tr>
    <th colspan="3">Perfil 3: Mariana - Estoquista</th>
  </tr>
  <tr>
    <td rowspan="3">
      <ul>
        <li><b>Idade:</b> 19 anos;</li>
        <li><b>Profissão:</b> Estoquista;</li>
        <li><b>Formação:</b> Ensino Médio Completo;</li>
        <li><b>Objetivo:</b> Melhorar a organização e eficiência no reabastecimento do supermercado, utilizando ferramentas que facilitem seu trabalho e aumentem a precisão.</li>
      </ul>
      <img width="2000" src="https://github.com/user-attachments/assets/3ad33517-cc6d-44f5-aeb7-3471db0bd30d" />
    </td>
    <td><b>Descrição</b></td>
    <td>Mariana é responsável por manter o supermercado organizado e abastecido. Ela deve respeitar as orientações que são emitidas em suas Fichas de Reabastecimento de Estoque.</td>
  </tr>
  <tr>
    <td><b>Necessidades</b></td>
    <td>
      <ul>
        <li>Receber Fichas de Reabastecimento de Estoque de seus superiores para concluir seu trabalho de forma lógica e eficaz;</li>
        <li>Concluir a Ficha de Reabastecimento de Estoque no sistema;</li>
        <li>Saber quais produtos serão colocados na frente de cada seção e na oferta.</li>
      </ul>
    </td>
  </tr>
  <tr>
    <td><b>Perspectivas</b></td>
    <td>
      <b>Angústias:</b>
      <br>
      Mariana se sente sobrecarregada com a pressão de manter o supermercado organizado e bem abastecido. Ela teme cometer erros que possam prejudicar o abastecimento e causar problemas para os clientes.
      <br>
      <br>
      <b>Frustrações:</b>
      <br>
      Mariana se frustrava com o antigo método de orientações em papel, que não era eficiente e frequentemente levava a erros e retrabalho.
      <br>
      <br>
      <b>Expectativas:</b>
      <br>
      Mariana espera que o sistema automatize as informações de abastecimento das seções, proporcionando dados claros e precisos para facilitar seu trabalho e manter o supermercado bem organizado.
    </td>
  </tr>
</table>

## 4º Persona

<table>
  <tr>
    <th colspan="3">Perfil 4: Silvana - Gerente de Loja</th>
  </tr>
  <tr>
    <td rowspan="3">
      <ul>
        <li><b>Idade:</b> 47 anos;</li>
        <li><b>Profissão:</b> Gerente de Loja;</li>
        <li><b>Formação:</b> Graduação em Administração de Empresas;</li>
        <li><b>Objetivo:</b> Garantir a operação eficiente do supermercado e a satisfação dos clientes, com acesso a informações claras e bem distribuídas sobre o estoque.</li>
      </ul>
      <img width="2000" src="https://github.com/user-attachments/assets/4a9f019a-e6b8-49a0-839b-834cb1ab20d3" />
    </td>
    <td><b>Descrição</b></td>
    <td>Silvana supervisiona as operações do supermercado e a gestão de estoque. Ela precisa de documentos que lhe forneça uma visão básica do estoque para tomar decisões.</td>
  </tr>
  <tr>
    <td><b>Necessidades</b></td>
    <td>
      <ul>
        <li>Monitorar níveis de estoque com informações básicas;</li>
        <li>Aprovar ou recusar demandas de outros setores;</li>
        <li>Receber notificações simples na tela do sistema para garantir a disponibilidade dos itens.</li>
      </ul>
    </td>
  </tr>
  <tr>
    <td><b>Perspectivas</b></td>
    <td>
      <b>Angústias:</b>
      <br>
      Silvana se preocupa com a operação geral do supermercado e teme que a falta de uma visibilidade eficaz e de informações bem distribuídas sobre o estoque comprometa a satisfação dos clientes e a eficiência das operações.
      <br>
      <br>
      <b>Frustrações:</b>
      <br>
      Fica frustrada com a complexidade do sistema atual e a dificuldade em obter informações claras, o que dificulta a tomada de decisões.
      <br>
      <br>
      <b>Expectativas:</b>
      <br>
      Espera que o sistema ofereça uma visão simplificada e acessível do estoque, com notificações automáticas que facilitem a tomada de decisões.
    </td>
  </tr>
</table>

## 5º Persona

<table>
  <tr>
    <th colspan="3">Perfil 5: Lucas - Administrador do Sistema</th>
  </tr>
  <tr>
    <td rowspan="3">
      <ul>
        <li><b>Idade:</b> 34 anos;</li>
        <li><b>Profissão:</b> Administrador do Sistema;</li>
        <li><b>Formação:</b> Graduação em Ciência da Computação;</li>
        <li><b>Objetivo:</b> Manter o sistema seguro e eficiente, gerenciando permissões de acesso e garantindo a integridade dos dados.</li>
      </ul>
      <img width="2000" src="https://github.com/user-attachments/assets/3a4ad7fe-d366-4086-8a58-784826809e6a" />
    </td>
    <td><b>Descrição</b></td>
    <td>Lucas cuida da parte administrativa do sistema, sendo responsável por decisões importantes, como acessos e permissões.</td>
  </tr>
  <tr>
    <td><b>Necessidades</b></td>
    <td>
      <ul>
        <li>Gerenciar os níveis de permissões do sistema com base nas funções de cada gestor e colaborador;</li>
        <li>Garantir que o sistema funcione de forma segura de maneira que cada usuário tenha acesso apenas ao que é necessário para seu trabalho.</li>
      </ul>
    </td>
  </tr>
  <tr>
    <td><b>Perspectivas</b></td>
    <td>
      <b>Angústias:</b>
      <br>
      Lucas se preocupa com a segurança e a funcionalidade do sistema, temendo que falhas possam comprometer as operações do supermercado e a proteção dos dados.
      <br>
      <br>
      <b>Frustrações:</b>
      <br>
      Lucas se frustra com as limitações do sistema atual, que dificultam a gestão flexível das permissões de acesso dos usuários.
      <br>
      <br>
      <b>Expectativas:</b>
      <br>
      Lucas espera que o sistema seja seguro, fácil de administrar, e permita a configuração precisa das permissões, minimizando riscos e garantindo a eficiência operacional.
    </td>
  </tr>
</table>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

| EU COMO... `PERSONA` | QUERO/PRECISO ... `FUNCIONALIDADE` | PARA ... `MOTIVO/VALOR` |
| -------------------- | ------------------------------------------------------------- |
------------------------------------------------------ |
| Ana Clara | Uma forma de identificar se uma agência é realmente confiável | Me sentir mais segura ao contratar seus
serviços |
| Ana Clara | Ter um mecanismo eficiente e rápido de comunicação | Que eu possa sanar todas as minhas dúvidas
rapidamente |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário
consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua
aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte
do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User
Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos
entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID | Descrição do Requisito | Prioridade |
| ------ |
---------------------------------------------------------------------------------------------------------------------------------
| ---------- |
| RF-001 | A aplicação deve permitir que o usuário avalie uma agência de intercâmbio com base na sua experiência | ALTA
|
| RF-002 | A aplicação deve permitir que o usuário inclua comentários ao fazer uma avaliação de uma agência de
intercâmbio | ALTA |
| RF-003 | A aplicação deve permitir que o usuário consulte todas as agências de intercâmbio cadastradas ordenando-as
com base em suas notas | ALTA |

### Requisitos não Funcionais

| ID | Descrição do Requisito | Prioridade |
| ------- | ----------------------------------------------------------------- | ---------- |
| RNF-001 | A aplicação deve ser responsiva | MÉDIA |
| RNF-002 | A aplicação deve processar requisições do usuário em no máximo 3s | BAIXA |

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
(RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
correspondem a uma funcionalidade que deve estar presente na
plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
(RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
correspondem a uma característica técnica, seja de usabilidade,
desempenho, confiabilidade, segurança ou outro (ex: suporte a
dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

| ID | Restrição |
| --- | ----------------------------------------------------- |
| 01 | O projeto deverá ser entregue até o final do semestre |
| 02 | Não pode ser desenvolvido um módulo de backend |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não
Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não
funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

<p>Este diagrama ilustra as funcionalidades do sistema do ponto de vista do usuário. Dessa forma, ele detalha as
  principais funcionalidades do sistema e como essas aplicabilidades interagem com os usuários.</p>

<figure>
  <img src="img/Diagrama _caso_de_uso.jpeg" width="350">
  <figcaption> Figura - Diagrama de Caso de Uso </figcaption>
</figure>
