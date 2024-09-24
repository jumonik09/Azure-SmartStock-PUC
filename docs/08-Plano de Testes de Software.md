# Plano de Testes de Software

**Projeto:** Sistema de Gestão de Estoque  
**Equipe do Projeto:**  
- Camilla Penteado Zatz  
- Juliana Monik Moraes Silva  
- Michael Benyamin Gorenstein Brasil  
- Samara Raissa dos Santos Américo Guimarães  
- Victor Rodrigues Magalhães  
**Professor:** Carlos Alberto Marques Pietrobon  
**Data:** Agosto/2024  

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

### Caso de Teste 001: Cadastro de Produto
- **Número do Caso de Teste:** CT-001
- **Pré-condições:** Usuário autenticado como Administrador.
- **Procedimento:**
  1. Acessar o menu "Cadastro de Produtos".
  2. Clicar em "Novo Produto".
  3. Preencher os campos obrigatórios (Nome, Descrição, Preço, Quantidade em Estoque).
  4. Clicar em "Salvar".
- **Dados de Entrada:** Nome: Arroz 5kg, Descrição: Pacote de Arroz 5kg, Preço: R$ 25,00, Quantidade em Estoque: 100.
- **Resultado Esperado:** Produto cadastrado com sucesso e exibido na lista de produtos.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 002: Edição de Produto Cadastrado
- **Número do Caso de Teste:** CT-002
- **Pré-condições:** Produto já cadastrado no sistema. Usuário autenticado como Administrador.
- **Procedimento:**
  1. Acessar o menu "Produtos".
  2. Selecionar o produto "Arroz 5kg".
  3. Clicar em "Editar".
  4. Alterar o preço para R$ 20,00.
  5. Clicar em "Salvar".
- **Dados de Entrada:** Produto: Arroz 5kg, Novo Preço: R$ 20,00.
- **Resultado Esperado:** Preço do produto atualizado para R$ 20,00 na lista de produtos.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 003: Exclusão de Produto
- **Número do Caso de Teste:** CT-003
- **Pré-condições:** Produto já cadastrado no sistema. Usuário autenticado como Administrador.
- **Procedimento:**
  1. Acessar o menu "Produtos".
  2. Selecionar o produto "Arroz 5kg".
  3. Clicar em "Excluir".
  4. Confirmar a exclusão.
- **Dados de Entrada:** Produto: Arroz 5kg.
- **Resultado Esperado:** Produto removido da lista de produtos com uma mensagem de confirmação.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 004: Visualização de Relatório de Estoque
- **Número do Caso de Teste:** CT-004
- **Pré-condições:** Produtos cadastrados no sistema. Usuário autenticado como Analista de Estoque.
- **Procedimento:**
  1. Acessar o menu "Relatórios".
  2. Selecionar "Relatório de Estoque".
  3. Filtrar por categoria "Alimentos".
  4. Clicar em "Gerar Relatório".
- **Dados de Entrada:** Categoria: Alimentos.
- **Resultado Esperado:** Relatório exibido com a lista detalhada de produtos na categoria "Alimentos".
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 005: Geração de Relatório de Vendas
- **Número do Caso de Teste:** CT-005
- **Pré-condições:** Vendas registradas no sistema. Usuário autenticado como Gerente de Loja.
- **Procedimento:**
  1. Acessar o menu "Relatórios".
  2. Selecionar "Relatório de Vendas".
  3. Definir o período de 01/09/2024 a 30/09/2024.
  4. Clicar em "Gerar Relatório".
- **Dados de Entrada:** Período: 01/09/2024 - 30/09/2024.
- **Resultado Esperado:** Relatório gerado com detalhes das vendas realizadas no período especificado.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 006: Autenticação de Usuário com Credenciais Válidas
- **Número do Caso de Teste:** CT-006
- **Pré-condições:** Usuário previamente cadastrado no sistema.
- **Procedimento:**
  1. Acessar a tela de login.
  2. Inserir nome de usuário e senha válidos.
  3. Clicar em "Entrar".
- **Dados de Entrada:** Usuário: admin, Senha: admin123.
- **Resultado Esperado:** Acesso concedido ao painel principal do sistema conforme o perfil do usuário.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 007: Autenticação de Usuário com Credenciais Inválidas
- **Número do Caso de Teste:** CT-007
- **Pré-condições:** Nenhuma específica além de ter a tela de login disponível.
- **Procedimento:**
  1. Acessar a tela de login.
  2. Inserir nome de usuário ou senha incorretos.
  3. Clicar em "Entrar".
- **Dados de Entrada:** Usuário: admin, Senha: senhaErrada.
- **Resultado Esperado:** Mensagem de erro indicando credenciais inválidas e impedimento de acesso.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 008: Controle de Acesso por Perfil
- **Número do Caso de Teste:** CT-008
- **Pré-condições:** Usuários com diferentes perfis cadastrados no sistema (Administrador, Gerente, Analista, etc.).
- **Procedimento:**
  1. Autenticar-se com um perfil específico.
  2. Tentar acessar funcionalidades restritas a outros perfis.
  3. Verificar se o acesso é negado ou permitido corretamente.
- **Dados de Entrada:** Usuário: julia (Analista de Estoque), Senha: julia123.
- **Resultado Esperado:** Usuário julia consegue acessar funcionalidades permitidas ao seu perfil e não consegue acessar funcionalidades restritas a outros perfis.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 009: Alerta de Estoque Crítico
- **Número do Caso de Teste:** CT-009
- **Pré-condições:** Produto com quantidade abaixo do nível crítico definido.
- **Procedimento:**
  1. Acessar o menu "Produtos".
  2. Verificar o status do estoque dos produtos.
  3. Identificar se há alertas para produtos com estoque crítico.
- **Dados de Entrada:** Produto: Feijão 1kg, Quantidade Crítica: 10, Quantidade Atual: 5.
- **Resultado Esperado:** Sistema exibe um alerta indicando que o estoque do produto Feijão 1kg está abaixo do nível crítico.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 010: Cadastro de Ordem de Compra
- **Número do Caso de Teste:** CT-010
- **Pré-condições:** Usuário autenticado como Paulo (Analista de Compras).
- **Procedimento:**
  1. Acessar o menu "Ordens de Compra".
  2. Clicar em "Nova Ordem de Compra".
  3. Selecionar o fornecedor.
  4. Adicionar produtos e quantidades.
  5. Enviar para aprovação.
- **Dados de Entrada:** Fornecedor: Fornecedor A, Produtos: Feijão 1kg - 50 unidades.
- **Resultado Esperado:** Ordem de Compra criada e enviada para aprovação da Gerente de Loja.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 011: Aprovação de Ordem de Compra
- **Número do Caso de Teste:** CT-011
- **Pré-condições:** Ordem de Compra criada e aguardando aprovação.
- **Procedimento:**
  1. Acessar o menu "Ordens de Compra Pendentes".
  2. Selecionar a ordem de compra pendente.
  3. Clicar em "Aprovar".
- **Dados de Entrada:** Ordem de Compra: Ordem #123.
- **Resultado Esperado:** Ordem de compra aprovada e atualizada para o status "Aprovada".
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 012: Geração de Nota Fiscal
- **Número do Caso de Teste:** CT-012
- **Pré-condições:** Ordem de Compra aprovada.
- **Procedimento:**
  1. Acessar o menu "Ordens de Compra".
  2. Selecionar a ordem de compra aprovada.
  3. Clicar em "Gerar Nota Fiscal".
- **Dados de Entrada:** Ordem de Compra: Ordem #123.
- **Resultado Esperado:** Nota Fiscal gerada e disponibilizada para download.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 013: Cadastro de Fornecedor
- **Número do Caso de Teste:** CT-013
- **Pré-condições:** Usuário autenticado como Administrador.
- **Procedimento:**
  1. Acessar o menu "Cadastro de Fornecedores".
  2. Clicar em "Novo Fornecedor".
  3. Preencher os dados do fornecedor (Nome, CNPJ, Endereço, Telefone).
  4. Clicar em "Salvar".
- **Dados de Entrada:** Nome: Fornecedor A, CNPJ: 12.345.678/0001-90, Endereço: Rua A, Telefone: (11) 1234-5678.
- **Resultado Esperado:** Fornecedor cadastrado com sucesso e exibido na lista de fornecedores.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 014: Edição de Fornecedor
- **Número do Caso de Teste:** CT-014
- **Pré-condições:** Fornecedor já cadastrado no sistema.
- **Procedimento:**
  1. Acessar o menu "Fornecedores".
  2. Selecionar o fornecedor "Fornecedor A".
  3. Clicar em "Editar".
  4. Alterar o telefone para (11) 9876-5432.
  5. Clicar em "Salvar".
- **Dados de Entrada:** Fornecedor: Fornecedor A, Novo Telefone: (11) 9876-5432.
- **Resultado Esperado:** Telefone do fornecedor atualizado na lista de fornecedores.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 015: Exclusão de Fornecedor
- **Número do Caso de Teste:** CT-015
- **Pré-condições:** Fornecedor já cadastrado no sistema.
- **Procedimento:**
  1. Acessar o menu "Fornecedores".
  2. Selecionar o fornecedor "Fornecedor A".
  3. Clicar em "Excluir".
  4. Confirmar a exclusão.
- **Dados de Entrada:** Fornecedor: Fornecedor A.
- **Resultado Esperado:** Fornecedor removido da lista de fornecedores com uma mensagem de confirmação.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 016: Filtragem de Produtos por Categoria
- **Número do Caso de Teste:** CT-016
- **Pré-condições:** Produtos cadastrados no sistema, organizados por categoria.
- **Procedimento:**
  1. Acessar o menu "Produtos".
  2. Filtrar por categoria "Alimentos".
- **Dados de Entrada:** Categoria: Alimentos.
- **Resultado Esperado:** Lista de produtos filtrada apenas para a categoria "Alimentos".
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 017: Pesquisa de Produtos
- **Número do Caso de Teste:** CT-017
- **Pré-condições:** Produtos cadastrados no sistema.
- **Procedimento:**
  1. Acessar o menu "Produtos".
  2. Utilizar a barra de pesquisa para buscar "Arroz".
- **Dados de Entrada:** Pesquisa: Arroz.
- **Resultado Esperado:** Resultados da pesquisa exibem todos os produtos relacionados a "Arroz".
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 018: Atualização em Lote de Produtos
- **Número do Caso de Teste:** CT-018
- **Pré-condições:** Produtos cadastrados e com estoque disponível.
- **Procedimento:**
  1. Acessar o menu "Produtos".
  2. Selecionar múltiplos produtos.
  3. Clicar em "Atualizar Estoque em Lote".
  4. Definir nova quantidade e confirmar.
- **Dados de Entrada:** Produtos selecionados: Arroz, Feijão, Macarrão; Nova Quantidade: 150.
- **Resultado Esperado:** Quantidade de todos os produtos selecionados atualizada para 150.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 019: Notificação de Baixo Estoque
- **Número do Caso de Teste:** CT-019
- **Pré-condições:** Sistema configurado para enviar notificações de baixo estoque.
- **Procedimento:**
  1. Verificar o status do estoque de produtos.
  2. Confirmar se o sistema envia notificações para produtos abaixo do estoque mínimo.
- **Dados de Entrada:** Produto: Macarrão, Quantidade Atual: 5, Limite Crítico: 10.
- **Resultado Esperado:** Notificação recebida sobre o produto Macarrão abaixo do estoque mínimo.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 020: Exportação de Relatórios
- **Número do Caso de Teste:** CT-020
- **Pré-condições:** Relatórios gerados e disponíveis.
- **Procedimento:**
  1. Acessar o menu "Relatórios".
  2. Selecionar um relatório.
  3. Clicar em "Exportar" e escolher o formato (PDF, Excel).
- **Dados de Entrada:** Relatório: Relatório de Vendas, Formato: Excel.
- **Resultado Esperado:** Relatório exportado com sucesso no formato escolhido.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 021: Acesso Offline
- **Número do Caso de Teste:** CT-021
- **Pré-condições:** Sistema configurado para operar offline.
- **Procedimento:**
  1. Desconectar a internet.
  2. Tentar acessar o sistema.
- **Dados de Entrada:** N/A.
- **Resultado Esperado:** Sistema permite acesso e visualização de dados offline.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---

### Caso de Teste 022: Acesso à Ajuda do Sistema
- **Número do Caso de Teste:** CT-022
- **Pré-condições:** Nenhuma específica.
- **Procedimento:**
  1. Acessar a tela de ajuda.
  2. Navegar pelas opções disponíveis.
- **Dados de Entrada:** N/A.
- **Resultado Esperado:** Acesso a conteúdo de ajuda e documentação do sistema.
- **Resultado Obtido:** [A ser preenchido após a execução do teste]
- **Avaliação:** [Sucesso/Falha]
- **Evidência:** [Anexar captura de tela]

---
## 4. Conclusão
Este plano de testes serve como guia para a validação do Sistema de Gestão de Estoque. A execução adequada dos casos de teste garantirá que as funcionalidades atendam aos requisitos e que o sistema seja confiável e eficiente.
