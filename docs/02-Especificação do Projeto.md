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

Com base na análise das personas foram identificadas as seguintes histórias de usuários:

| EU COMO... `PERSONA` | QUERO/PRECISO ... `FUNCIONALIDADE` | PARA ... `MOTIVO/VALOR` |
| -------------------- | ---------------------------------- |------------------------ |
| Paulo(Analista de Compras) | Visualizar um relatório de estoque dos produtos. | Identificar a demanda necessária e levantar os itens com o fornecedor. |
| Paulo(Analista de Compras) | Visualizar relatórios sobre os fornecedores. | Negociar melhores condições e registrar no sistema a Ordem de Compra e enviar para aprovação. |
| Júlia(Analista de Estoque) | Visualizar um relatório de estoque dos produtos. | Identificar todos os produtos em estoque, priorizando aqueles com validade próxima do vencimento para evitar desperdícios. |
| Júlia(Analista de Estoque) | Cadastrar Fichas de Reabastecimento de Estoque. | Gerar as fichas e enviá-las para aprovação visando organizar a exposição de todos os itens de forma adequada. |
| Mariana(Estoquista) | Receber fichas de reabastecimento de estoque claras. | Garantir a organização dos produtos corretamente e manter a loja abastecida de acordo com as necessidades. |
| Mariana(Estoquista) | Concluir e atualizar a Ficha no sistema com as informações sobre os produtos que foram reabastecidos. | Manter o estoque sempre atualizado e evitar problemas de falta de produtos e organização. |
| Silvana(Gerente de Loja) | Visualizar as solicitações para aprovação da Ordens de Compra e Fichas e Reabastecimento de Estoque. | Conferir as informações e aprovar ou recusar as solicitações. |
| Silvana(Gerente de Loja) | Receber um alerta na tela do sistema quando um produto atingir um nível crítico de estoque ou estiver próximo da data de validade. | Garantir que seja reabastecido a tempo e assim atender as demandas dos clientes solicitando a compra de novos produtos. |
| Lucas(Administrador do Sistema) | Configurar as permissões de acesso para diferentes perfis de usuário. | Assegurar que cada colaborador tenha acesso apenas às funcionalidades necessárias para suas funções. |
| Lucas(Administrador do Sistema) | Monitorar e testar as permissões. | Garantir que um usuário não acesse informações de outro. |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID     | Descrição do Requisito                                                                                                                                           | Prioridade |
|--------|------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RF-01  | O sistema deve permitir o cadastro de produtos, incluindo atributos como nome, descrição, preço e quantidade em estoque.                                          | ALTA       |
| RF-02  | O sistema deve permitir a visualização de uma lista detalhada de todos os produtos cadastrados.                                                                   | ALTA       |
| RF-03  | O sistema deve permitir a edição de itens cadastrados.                                                                                                           | ALTA       |
| RF-04  | O sistema deve remover a exclusão de produtos cadastrados.                                                                                                        | MÉDIA      |
| RF-05  | O sistema deve atualizar o estoque com base nas compras e saídas do estoque.                                         | ALTA       |
| RF-06  | O sistema deve permitir a visualização e geração de relatórios detalhados sobre o inventário e o desempenho de vendas.                                             | ALTA       |
| RF-07  | O sistema deve permitir o registro e análise do histórico de compras e vendas para facilitar o planejamento de reabastecimento.                                    | ALTA       |
| RF-08  | O sistema deve permitir a autenticação e autorização de usuários para acesso ao sistema de gestão de estoque, com diferentes níveis de permissão para gestores e colaboradores. | MÉDIA      |
| RF-09  | O sistema deve fornecer um alerta básico quando o estoque de um produto estiver abaixo de um limite definido.                                                     | ALTA       |
| RF-10  | O sistema deve fornecer um alerta básico quando um lote de produto estiver 10 dias próximo a data de vencimento.                                                  | ALTA       |
| RF-11  |O sistema deve cadastrar o fornecedor e criar uma página informando que o cadastro foi realizado com sucesso.| ALTA       |
| RF-12  |O sistema deve permitir a inclusão de um novo fornecedor tendo incluso nome, email, telefone, endereço, cnpj. | ALTA       |
| RF-13  |O sistema deve cadastrar o produto e criar uma página informando que o cadastro foi realizado com sucesso. | ALTA       |
|RF-14 | O sistema deve permitir a execução de consultas SQL em um banco de dados e a formatação dos dados retornados para exibição em uma página HTML. | Alta |

| ID      | Descrição do Requisito                                                                                                                                                   | Prioridade |
|---------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RNF-01  | O sistema deve ter uma interface simples e fácil de usar, com design básico para facilitar a navegação para os funcionários da empresa.                                    | ALTA       |
| RNF-02  | O sistema deve ter uma estrutura de código clara e bem documentada, para facilitar a compreensão e manutenção por estudantes.                                              | ALTA       |
| RNF-03  | O sistema deve ser responsivo o suficiente para ser usado em diferentes tamanhos de tela, como monitores e laptops.                                                        | MÉDIA      |
| RNF-04  | O sistema deve carregar rapidamente, com um tempo de resposta menor ou igual a 3 segundos.                                                                                 | MÉDIA      |
| RNF-05  | O sistema deve ser acessível para navegadores web comuns (Chrome, Firefox) sem necessidade de plugins extras.                                                              | ALTA       |
| RNF-06  | Apenas usuários autenticados devem ter acesso ao sistema, com diferentes níveis de permissão conforme o perfil.                                                            | ALTA       |

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
  <img src="img/Diagrama _caso_de_uso.png" width="350">
  <figcaption> Figura - Diagrama de Caso de Uso </figcaption>
</figure>
