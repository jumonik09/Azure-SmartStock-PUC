# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT-001 – Cadastro de Produto** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - O sistema deve permitir o cadastro de produtos, incluindo atributos como nome, descrição, preço e quantidade em estoque|
|Registro de evidência | ![Imagem do WhatsApp de 2024-10-15 à(s) 20 34 44_57183825](https://github.com/user-attachments/assets/ff1a2cde-b938-4640-a8cc-b059308f7ed0)
 

| **Caso de Teste** 	| **CT-02 – ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-14 - O sistema deve permitir a execução de consultas SQL em um banco de dados e a formatação dos dados retornados para exibição em uma página HTML.|
|Registro de evidência | <figure><img src="img/lista_usuario.png"> </figure> |
|Registro de evidência | <figure><img src="img/dados_usuario.png"> </figure> | 

<br/>

| **Caso de Teste** 	| **CT-03 – Cadastro de Usuários 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - O sistema deve permitir o cadastro do Usuario, incluindo atributos como nome, telefone, cargo, email, ativo e senha |
|Registro de evidência | <figure><img src="img/M_cadastrando.png"> </figure> |
|Registro de evidência | <figure><img src="img/M_efetuando.png"> </figure> | 
|Registro de evidência | <figure><img src="img/M_Listagem.png"> </figure> |
|Registro de evidência | <figure><img src="img/M_registrobanco.png"> </figure> | 

<br/>

## Caso de Teste 004: Tela Cadastro de Fornecedor
<p> Testado por Samara Raíssa </p>

| **Caso de Teste** 	| CT-04 – Tela Cadastro de Fornecedor 	|
|:---:	|:---:	|
|	Requisito Associado	| RF-01 -O sistema deve permitir a execução de consultas SQL em um banco de dados e a formatação dos dados retornados para exibição em uma página HTML.|
|Houve erro| Não, não houve erro.|
|Correspondeu ao Esperado| Sim, o comportamento do sistema correspondeu aos requisitos. |
|Registro de evidência | <figure><img src="img/tela cadastro de fornecedor.png"> </figure> |
|Registro de evidência | <figure><img src="img/tela registro efetuado.png"> </figure> | 
|Registro de evidência | <figure><img src="img/tabela lista de fornecedor .png"> </figure> |
|Registro de evidência | <figure><img src="img/php fornecedor.png"> </figure> | 

<br/>

## Caso de Teste 005: Tela Cadastro Ordem de Compra 
<p> Testado por Samara Raíssa </p>

| **Caso de Teste** 	| CT-05 – Cadastro Ordem de Compra 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - O sistema deve permitir a execução de consultas SQL em um banco de dados, o processamento das informações retornadas e a formatação para exibição em uma página HTML, com opções de aprovação e controle de status de ordens de compra.|
|Houve erro| Não, não houve erro.|
|Correspondeu ao Esperado| Sim, o comportamento do sistema correspondeu aos requisitos. |
|Registro de evidência | <figure><img src="img/cadastro ordem de compra 1.png"> </figure> |
|Registro de evidência | <figure><img src="img/ordem de compra phpadmin.png"> </figure> | 
| **Caso de Teste** 	| **Ordens de Compra** 	|
|Registro de evidência | <figure><img src="img/Lista Ordem de compra 1.png"> </figure> |
|Registro de evidência | <figure><img src="img/ordem de compra aprovada.png"> </figure> | 

<br/>

## Caso de Teste 002: Execução de Consultas SQL

| **Caso de Teste** 	| **CT-02 – Gestão de estoque 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-14 - O sistema deve permitir a execução de consultas SQL em um banco de dados e a formatação dos dados retornados para exibição em uma página HTML.|
|Registro de evidência | <figure><img src="img/lista_usuario.png"> </figure> |
|Registro de evidência | <figure><img src="img/dados_usuario.png"> </figure> | 

---

## Caso de Teste 004: Visualização de Relatório de Estoque

| **Número do Caso de Teste** | CT-004 - Gestão de estoque |
|-------------------------------|----------------------------|
| **Pré-condições**             | Produtos cadastrados no sistema. Usuário autenticado como Analista de Estoque. |
| **Procedimento**              | 1. Acessar o menu "Relatórios".<br>2. Selecionar "Relatório de Estoque".<br>3. Filtrar por categoria "Alimentos".<br>4. Clicar em "Gerar Relatório". |
| **Dados de Entrada**          | Categoria: Alimentos |
| **Resultado Esperado**        | Relatório exibido com a lista detalhada de produtos na categoria "Alimentos". |
| **Resultado Obtido**          | O princípio de um relatório está sendo gerado, porém o sistema por ainda ser um protótipo, não possui o mapeamento de telas nem filtragem de dados. |
| **Avaliação**                 | [Sucesso] |
| **Evidência**                 | <figure><img src="img/tela gestao de estoque.png" alt="Tela de Gestão de Estoque"></figure><figure><img src="img/produtos_banco.png" alt="Produtos no Banco de Dados"></figure> |


