# Plano de Testes de Software
## Projeto: Sistema de Gestão de Estoque

### Equipe do Projeto:
- Camilla Penteado Zatz
- Juliana Monik Moraes Silva
- Michael Benyamin Gorenstein Brasil
- Samara Raissa dos Santos Américo Guimarães
- Victor Rodrigues Magalhães
- Professor: Carlos Alberto Marques Pietrobon

### Data: Agosto/2024

## 1. Introdução
Este documento apresenta o Plano de Testes de Software para o Sistema de Gestão de Estoque, detalhando os casos de teste a serem realizados para garantir a qualidade e o funcionamento adequado do sistema. Os testes visam identificar e corrigir possíveis falhas, assegurando que os requisitos funcionais e não funcionais definidos sejam atendidos.

## 2. Estrutura dos Casos de Teste
Cada caso de teste é descrito com os seguintes campos:
- **Número do Caso de Teste:** Identificação única do caso de teste.
- **Pré-condições:** Condições que devem ser atendidas antes da execução do teste.
- **Procedimento:** Passos detalhados para realizar o teste.
- **Dados de Entrada:** Informações ou valores inseridos no sistema durante o teste.
- **Resultado Esperado:** Comportamento esperado do sistema após a execução do teste.
- **Resultado Obtido:** Comportamento real do sistema após a execução do teste.
- **Avaliação:** Indicação se o teste foi bem-sucedido (Sem Erro) ou se houve falhas (Com Erro).
- **Evidência:** Captura de tela ou registro da execução do teste.

## 3. Casos de Teste

| **Caso de Teste** 	| **CT-001 – Cadastro de Produto** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-001 - A aplicação deve permitir o cadastro de produtos com informações obrigatórias. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue cadastrar um novo produto na aplicação. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Cadastro de Produtos" <br> - Clicar em "Novo Produto" <br> - Preencher os campos obrigatórios (Nome, Descrição, Preço, Quantidade em Estoque) <br> - Clicar em "Salvar" |
| **Critério de Êxito** | - O produto foi cadastrado com sucesso e exibido na lista de produtos. |

| **Caso de Teste** 	| **CT-002 – Edição de Produto Cadastrado** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-002 - A aplicação deve permitir a edição das informações de produtos cadastrados. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue editar um produto existente. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Produtos" <br> - Selecionar o produto "Arroz 5kg" <br> - Clicar em "Editar" <br> - Alterar o preço para R$ 20,00 <br> - Clicar em "Salvar" |
| **Critério de Êxito** | - O preço do produto foi atualizado com sucesso. |

| **Caso de Teste** 	| **CT-003 – Exclusão de Produto** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-003 - A aplicação deve permitir a exclusão de produtos cadastrados. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue excluir um produto cadastrado. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Produtos" <br> - Selecionar o produto "Arroz 5kg" <br> - Clicar em "Excluir" <br> - Confirmar a exclusão |
| **Critério de Êxito** | - O produto foi excluído com sucesso e não aparece mais na lista. |

| **Caso de Teste** 	| **CT-004 – Visualização de Relatório de Estoque** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-004 - A aplicação deve gerar relatórios de estoque para análise. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue visualizar o relatório de estoque. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Relatórios" <br> - Selecionar "Relatório de Estoque" <br> - Filtrar por categoria "Alimentos" <br> - Clicar em "Gerar Relatório" |
| **Critério de Êxito** | - O relatório de estoque é exibido corretamente. |

| **Caso de Teste** 	| **CT-005 – Geração de Relatório de Vendas** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-005 - A aplicação deve permitir a geração de relatórios de vendas. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue gerar um relatório de vendas. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Relatórios" <br> - Selecionar "Relatório de Vendas" <br> - Definir o período de 01/09/2024 a 30/09/2024 <br> - Clicar em "Gerar Relatório" |
| **Critério de Êxito** | - O relatório de vendas é gerado corretamente para o período especificado. |

| **Caso de Teste** 	| **CT-006 – Autenticação de Usuário com Credenciais Válidas** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-006 - A aplicação deve permitir a autenticação de usuários. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue realizar login com credenciais válidas. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
| **Critério de Êxito** | - O login é realizado com sucesso e o usuário é direcionado ao painel principal. |

| **Caso de Teste** 	| **CT-007 – Autenticação de Usuário com Credenciais Inválidas** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-007 - A aplicação deve notificar o usuário em caso de credenciais inválidas. |
| **Objetivo do Teste** 	| Verificar se o sistema informa erro ao tentar login com credenciais inválidas. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Entrar" <br> - Preencher o campo de e-mail com um e-mail inválido <br> - Preencher o campo da senha com uma senha inválida <br> - Clicar em "Login" |
| **Critério de Êxito** | - Mensagem de erro é exibida indicando credenciais inválidas. |

| **Caso de Teste** 	| **CT-008 – Controle de Acesso por Perfil** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-008 - A aplicação deve restringir o acesso a funcionalidades de acordo com o perfil do usuário. |
| **Objetivo do Teste** 	| Verificar se o usuário tem acesso restrito às funcionalidades permitidas pelo seu perfil. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Autenticar-se com um perfil específico <br> - Tentar acessar funcionalidades restritas a outros perfis |
| **Critério de Êxito** | - O usuário acessa apenas as funcionalidades permitidas para seu perfil. |

| **Caso de Teste** 	| **CT-009 – Alerta de Estoque Crítico** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-009 - A aplicação deve alertar usuários sobre produtos com estoque abaixo do nível crítico. |
| **Objetivo do Teste** 	| Verificar se o sistema gera alertas para estoque crítico. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Produtos" <br> - Verificar o status do estoque dos produtos <br> - Identificar se há alertas para produtos com estoque crítico |
| **Critério de Êxito** | - Alertas visíveis indicam que o estoque de produtos está crítico. |
