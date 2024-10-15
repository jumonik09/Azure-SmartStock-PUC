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

## Caso de Teste 001: Cadastro de Produto
| **Número do Caso de Teste** | CT-001 |
|-------------------------------|--------|
| **Pré-condições**             | Usuário autenticado como Administrador. |
| **Procedimento**              | 1. Acessar o menu "Cadastro de Produtos".<br>2. Clicar em "Novo Produto".<br>3. Preencher os campos obrigatórios (Nome, Descrição, Preço, Quantidade em Estoque).<br>4. Clicar em "Salvar". |
| **Dados de Entrada**          | Nome: Arroz <br>Descrição: Arroz tipo 1 <br>Preço: R$ 35,00<br>Quantidade em Estoque: 100 |
| **Resultado Esperado**        | Produto cadastrado com sucesso e exibido na lista de produtos. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 002: Edição de Produto Cadastrado
| **Número do Caso de Teste** | CT-002 |
|-------------------------------|--------|
| **Pré-condições**             | Produto já cadastrado no sistema. Usuário autenticado como Administrador. |
| **Procedimento**              | 1. Acessar o menu "Produtos".<br>2. Selecionar o produto "Arroz 5kg".<br>3. Clicar em "Editar".<br>4. Alterar o preço para R$ 20,00.<br>5. Clicar em "Salvar". |
| **Dados de Entrada**          | Produto: Arroz 5kg<br>Novo Preço: R$ 20,00 |
| **Resultado Esperado**        | Preço do produto atualizado para R$ 20,00 na lista de produtos. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 003: Exclusão de Produto
| **Número do Caso de Teste** | CT-003 |
|-------------------------------|--------|
| **Pré-condições**             | Produto já cadastrado no sistema. Usuário autenticado como Administrador. |
| **Procedimento**              | 1. Acessar o menu "Produtos".<br>2. Selecionar o produto "Arroz 5kg".<br>3. Clicar em "Excluir".<br>4. Confirmar a exclusão. |
| **Dados de Entrada**          | Produto: Arroz 5kg |
| **Resultado Esperado**        | Produto removido da lista de produtos com uma mensagem de confirmação. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 004: Visualização de Relatório de Estoque
| **Número do Caso de Teste** | CT-004 |
|-------------------------------|--------|
| **Pré-condições**             | Produtos cadastrados no sistema. Usuário autenticado como Analista de Estoque. |
| **Procedimento**              | 1. Acessar o menu "Relatórios".<br>2. Selecionar "Relatório de Estoque".<br>3. Filtrar por categoria "Alimentos".<br>4. Clicar em "Gerar Relatório". |
| **Dados de Entrada**          | Categoria: Alimentos |
| **Resultado Esperado**        | Relatório exibido com a lista detalhada de produtos na categoria "Alimentos". |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 005: Geração de Relatório de Vendas
| **Número do Caso de Teste** | CT-005 |
|-------------------------------|--------|
| **Pré-condições**             | Vendas registradas no sistema. Usuário autenticado como Gerente de Loja. |
| **Procedimento**              | 1. Acessar o menu "Relatórios".<br>2. Selecionar "Relatório de Vendas".<br>3. Definir o período de 01/09/2024 a 30/09/2024.<br>4. Clicar em "Gerar Relatório". |
| **Dados de Entrada**          | Período: 01/09/2024 - 30/09/2024 |
| **Resultado Esperado**        | Relatório gerado com detalhes das vendas realizadas no período especificado. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 006: Autenticação de Usuário com Credenciais Válidas
| **Número do Caso de Teste** | CT-006 |
|-------------------------------|--------|
| **Pré-condições**             | Usuário previamente cadastrado no sistema. |
| **Procedimento**              | 1. Acessar a tela de login.<br>2. Inserir nome de usuário e senha válidos.<br>3. Clicar em "Entrar". |
| **Dados de Entrada**          | Usuário: admin<br>Senha: admin123 |
| **Resultado Esperado**        | Acesso concedido ao painel principal do sistema conforme o perfil do usuário. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 007: Autenticação de Usuário com Credenciais Inválidas
| **Número do Caso de Teste** | CT-007 |
|-------------------------------|--------|
| **Pré-condições**             | Nenhuma específica além de ter a tela de login disponível. |
| **Procedimento**              | 1. Acessar a tela de login.<br>2. Inserir nome de usuário ou senha incorretos.<br>3. Clicar em "Entrar". |
| **Dados de Entrada**          | Usuário: admin<br>Senha: senhaErrada |
| **Resultado Esperado**        | Mensagem de erro indicando credenciais inválidas e impedimento de acesso. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 008: Controle de Acesso por Perfil
| **Número do Caso de Teste** | CT-008 |
|-------------------------------|--------|
| **Pré-condições**             | Usuários com diferentes perfis cadastrados no sistema (Administrador, Gerente, Analista, etc.). |
| **Procedimento**              | 1. Autenticar-se com um perfil específico.<br>2. Tentar acessar funcionalidades restritas a outros perfis.<br>3. Verificar se o acesso é negado ou permitido corretamente. |
| **Dados de Entrada**          | Usuário: julia (Analista de Estoque)<br>Senha: julia123 |
| **Resultado Esperado**        | Usuário julia consegue acessar funcionalidades permitidas ao seu perfil e não consegue acessar funcionalidades restritas a outros perfis. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 009: Alerta de Estoque Crítico
| **Número do Caso de Teste** | CT-009 |
|-------------------------------|--------|
| **Pré-condições**             | Produto com quantidade abaixo do nível crítico definido. |
| **Procedimento**              | 1. Acessar o menu "Produtos".<br>2. Verificar o status do estoque dos produtos.<br>3. Identificar se há alertas para produtos com estoque crítico. |
| **Dados de Entrada**          | Produto: Feijão 1kg<br>Quantidade Crítica: 10<br>Quantidade Atual: 5 |
| **Resultado Esperado**        | Sistema exibe um alerta indicando que o estoque do produto Feijão 1kg está abaixo do nível crítico. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 010: Cadastro de Ordem de Compra
| **Número do Caso de Teste** | CT-010 |
|-------------------------------|--------|
| **Pré-condições**             | Usuário autenticado como Paulo (Analista de Compras). |
| **Procedimento**              | 1. Acessar o menu "Ordens de Compra".<br>2. Clicar em "Nova Ordem de Compra".<br>3. Selecionar o fornecedor.<br>4. Adicionar produtos e quantidades.<br>5. Enviar para aprovação. |
| **Dados de Entrada**          | Fornecedor: Fornecedor A<br>Produtos: Feijão 1kg - 50 unidades |
| **Resultado Esperado**        | Ordem de Compra criada e enviada para aprovação da Gerente de Loja. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 011: Aprovação de Ordem de Compra
| **Número do Caso de Teste** | CT-011 |
|-------------------------------|--------|
| **Pré-condições**             | Ordem de Compra pendente de aprovação. Usuário autenticado como Silvana (Gerente de Loja). |
| **Procedimento**              | 1. Acessar o menu "Ordens de Compra".<br>2. Visualizar as ordens pendentes.<br>3. Selecionar a ordem de compra.<br>4. Aprovar ou recusar a ordem. |
| **Dados de Entrada**          | Ordem de Compra: OC-001<br>Decisão: Aprovar |
| **Resultado Esperado**        | Ordem de Compra OC-001 é aprovada e atualiza o status no sistema. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 012: Recebimento de Produtos
| **Número do Caso de Teste** | CT-012 |
|-------------------------------|--------|
| **Pré-condições**             | Ordem de Compra aprovada. Usuário autenticado como Analista de Estoque (Júlia). |
| **Procedimento**              | 1. Acessar o menu "Recebimento de Produtos".<br>2. Selecionar a Ordem de Compra aprovada.<br>3. Registrar a entrada dos produtos no estoque.<br>4. Confirmar o recebimento. |
| **Dados de Entrada**          | Ordem de Compra: OC-001<br>Produtos Recebidos: Feijão 1kg - 50 unidades |
| **Resultado Esperado**        | Produtos recebidos são adicionados ao estoque e a Ordem de Compra é marcada como concluída. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 013: Atualização Automática de Estoque após Venda
| **Número do Caso de Teste** | CT-013 |
|-------------------------------|--------|
| **Pré-condições**             | Produto cadastrado no sistema com quantidade disponível. Usuário autenticado como Estoquista (Mariana). |
| **Procedimento**              | 1. Acessar o menu "Vendas".<br>2. Registrar a venda de um produto.<br>3. Confirmar a venda.<br>4. Verificar a atualização do estoque. |
| **Dados de Entrada**          | Produto: Arroz 5kg<br>Quantidade Vendida: 2 unidades |
| **Resultado Esperado**        | Estoque do produto Arroz 5kg é reduzido em 2 unidades automaticamente. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 014: Alerta de Vencimento Próximo
| **Número do Caso de Teste** | CT-014 |
|-------------------------------|--------|
| **Pré-condições**             | Produto com data de validade próxima (10 dias). |
| **Procedimento**              | 1. Acessar o menu "Produtos".<br>2. Verificar se o sistema exibe alertas para produtos com validade próxima. |
| **Dados de Entrada**          | Produto: Leite UHT<br>Data de Validade: 05/10/2024<br>Data Atual: 25/09/2024 |
| **Resultado Esperado**        | Sistema exibe um alerta indicando que o produto Leite UHT está próximo da data de vencimento. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 015: Cadastro de Ficha de Reabastecimento
| **Número do Caso de Teste** | CT-015 |
|-------------------------------|--------|
| **Pré-condições**             | Usuário autenticado como Júlia (Analista de Estoque). |
| **Procedimento**              | 1. Acessar o menu "Reabastecimento".<br>2. Clicar em "Nova Ficha de Reabastecimento".<br>3. Selecionar os produtos e definir as quantidades.<br>4. Enviar para aprovação. |
| **Dados de Entrada**          | Produtos: Leite UHT - 30 unidades<br>Produtos: Feijão 1kg - 20 unidades |
| **Resultado Esperado**        | Ficha de Reabastecimento criada e enviada para aprovação da Gerente de Loja. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 016: Aprovação de Ficha de Reabastecimento
| **Número do Caso de Teste** | CT-016 |
|-------------------------------|--------|
| **Pré-condições**             | Ficha de Reabastecimento pendente de aprovação. Usuário autenticado como Silvana (Gerente de Loja). |
| **Procedimento**              | 1. Acessar o menu "Reabastecimento".<br>2. Visualizar as fichas pendentes.<br>3. Selecionar a ficha específica.<br>4. Aprovar ou recusar a ficha. |
| **Dados de Entrada**          | Ficha de Reabastecimento: FR-001<br>Decisão: Aprovar |
| **Resultado Esperado**        | Ficha de Reabastecimento FR-001 é aprovada e enviada para a estoquista (Mariana) para execução. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 017: Recebimento de Ficha de Reabastecimento
| **Número do Caso de Teste** | CT-017 |
|-------------------------------|--------|
| **Pré-condições**             | Ficha de Reabastecimento aprovada. Usuário autenticado como Mariana (Estoquista). |
| **Procedimento**              | 1. Acessar o menu "Reabastecimento".<br>2. Visualizar fichas aprovadas.<br>3. Receber e processar a ficha.<br>4. Atualizar o sistema com as ações realizadas. |
| **Dados de Entrada**          | Ficha de Reabastecimento: FR-001<br>Produtos Recebidos: Leite UHT - 30 unidades<br>Feijão 1kg - 20 unidades |
| **Resultado Esperado**        | Produtos adicionados ao estoque conforme a ficha e estoque atualizado no sistema. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 018: Teste de Segurança - Acesso Não Autorizado
| **Número do Caso de Teste** | CT-018 |
|-------------------------------|--------|
| **Pré-condições**             | Sistema protegido por autenticação. |
| **Procedimento**              | 1. Tentar acessar uma URL restrita sem autenticação.<br>2. Tentar acessar funcionalidades de outro perfil usando métodos alternativos. |
| **Dados de Entrada**          | Tentativas de acesso não autorizado. |
| **Resultado Esperado**        | Acesso negado com redirecionamento para a tela de login ou mensagem de erro adequada. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 019: Teste de Recuperação de Senha
| **Número do Caso de Teste** | CT-019 |
|-------------------------------|--------|
| **Pré-condições**             | Usuário precisa de recuperação de senha. |
| **Procedimento**              | 1. Acessar a tela de login.<br>2. Clicar em "Esqueci a senha".<br>3. Inserir e-mail associado à conta.<br>4. Verificar o e-mail recebido e seguir instruções. |
| **Dados de Entrada**          | E-mail: usuario@exemplo.com |
| **Resultado Esperado**        | E-mail de recuperação enviado com sucesso. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## Caso de Teste 020: Logout do Sistema
| **Número do Caso de Teste** | CT-020 |
|-------------------------------|--------|
| **Pré-condições**             | Usuário autenticado e em sessão ativa. |
| **Procedimento**              | 1. Clicar no botão "Logout".<br>2. Verificar se o sistema redireciona para a tela de login. |
| **Dados de Entrada**          | N/A |
| **Resultado Esperado**        | Usuário desconectado com sucesso e redirecionado para a tela de login. |
| **Resultado Obtido**          | [A ser preenchido após a execução do teste] |
| **Avaliação**                 | [Sucesso/Falha] |
| **Evidência**                 | [Anexar captura de tela] |

---

## 4. Conclusão
Este plano de testes serve como guia para a validação do Sistema de Gestão de Estoque. A execução adequada dos casos de teste garantirá que as funcionalidades atendam aos requisitos e que o sistema seja confiável e eficiente.
