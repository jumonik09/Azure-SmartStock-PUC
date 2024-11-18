# Plano de Testes de Usabilidade
<p> As Heurísticas de Nielsen são um conjunto de dez princípios que orientam o design e a avaliação de interfaces de usuário, visando otimizar a usabilidade. Desenvolvidas por Jakob Nielsen, especialista em usabilidade, essas diretrizes oferecem uma abordagem prática para identificar problemas de usabilidade em diversos sistemas, desde websites complexos até aplicativos móveis simples (NIELSEN, 1993).</p>

<p> Cada uma das heurísticas aborda um aspecto específico da experiência do usuário, como a importância da comunicação clara entre o sistema e o usuário, e a minimização de erros. A aplicação dessas heurísticas durante o design e os testes permite que desenvolvedores e designers criem interfaces mais intuitivas e eficientes, melhorando a satisfação do usuário e contribuindo para o sucesso comercial (NIELSEN, 1993).</p>

<p> As 10 Heurísticas de Nielsen são princípios fundamentais que orientam o design de interfaces, cada uma abordando um aspecto crucial da experiência do usuário. Elas são: </p>

<b> 01) Visibilidade do status do sistema:</b> 
<p >O usuário deve sempre saber o que está acontecendo no sistema por meio de feedback claro.</p>
      <br>

<b> 02)Correspondência entre o sistema e o mundo real:</b>
<p> A interface deve utilizar linguagem e conceitos familiares ao usuário.</p>
      <br>

<b> 03)Liberdade e controle do usuário:</b> 
<p> Usuários devem ter a capacidade de desfazer e refazer ações facilmente.</p>
       <br>

<b> 04) Consistência e padrões:</b> 
<p> Elementos da interface devem seguir convenções estabelecidas para evitar confusão.</p>
      <br>

<b> 05) Prevenção de erros:</b> 
<p> O design deve minimizar as possibilidades de erro, oferecendo dicas e opções claras.</p>
  <br>
 
  <b> 06) Reconhecer ao invés de lembrar:</b> 
  <p> A interface deve facilitar o reconhecimento de informações, reduzindo a carga de memória do usuário. </p>
    <br>
 
  <b> 07) Eficiência e flexibilidade de uso:</b>
  <p> A interface deve atender tanto a usuários iniciantes quanto a experientes, permitindo personalização.</p>
    <br>
   
  <b> 08) Estética e design minimalista: <b>
  <p> O design deve ser simples e relevante, evitando informações excessivas.</p>
    <br>
  
    
  <b> 09) Recuperação diante de erros:</b> 
  <p> O sistema deve oferecer soluções claras para erros que possam ocorrer.</p>
    <br>
   
   <b> 10) Ajuda e documentação:</b>
   <p> Mesmo que o sistema seja utilizável sem documentação, deve haver suporte acessível para os usuários.</p>
   
   <br>

  <p>Essas heurísticas ajudam a criar interfaces mais intuitivas e eficazes, promovendo uma melhor experiência do usuário.</p>
  <br>


  <p> Referência: NIELSEN, Jakob. Usability Engineering. San Francisco: Morgan Kaufmann, 1993.</p>
  <p> Referência: NIELSEN, Jakob. Heuristic evaluation. In: Usability engineering. San Francisco: Morgan Kaufmann, 1993. p. 251-272. </p>
  
   <br>
 <hr>
  
  ### **1. Index.cshtml (Home)**


- **Links de navegação:** Testar se todos os links na homepage direcionam corretamente para as respectivas páginas.

---

### **2. Listagem de Usuário**

- **Exibição de usuários:** Verificar se a lista de usuários é exibida corretamente com todos os dados (nome, telefone, e-mail).
- **Corretude dos dados:** Certificar-se de que os dados exibidos são os mesmos que estão armazenados no banco de dados.

---

### **3. Sucesso.cshtml**

- **Confirmação de ação:** Testar se, ao realizar uma ação como o cadastro de um usuário, produto ou fornecedor, o usuário é corretamente redirecionado para a página de sucesso.

---

### **4. Tabela de Fornecedores**

- **Listagem de fornecedores:** Testar se todos os fornecedores cadastrados estão sendo exibidos com as informações corretas (nome, e-mail, telefone).
- **Exibição de dados corretos:** Verificar se os dados exibidos correspondem ao que foi inserido no banco de dados.

---

### **5. Tabela de Produtos**

- **Listagem de produtos:** Testar se a lista de produtos está sendo exibida corretamente, mostrando o nome e a categoria de cada produto.
- **Corretude dos dados:** Garantir que as informações dos produtos exibidos correspondam às que foram cadastradas no banco de dados.

---

### **6. Cadastrar Produto**

- **Validação de formulário:** Testar se o formulário de cadastro valida corretamente os campos obrigatórios (nome, descrição, preço, categoria).
- **Submissão de dados:** Verificar se, ao preencher e submeter o formulário, o produto é salvo corretamente no banco de dados e se há redirecionamento apropriado para uma página de confirmação/sucesso.

---

### **7. Cadastro de Usuário**

- **Validação de formulário:** Testar se o formulário de cadastro de usuário valida corretamente os campos obrigatórios (nome, telefone, cargo, e-mail, senha, ativo).
- **Submissão de dados:** Verificar se, ao submeter o formulário, o usuário é salvo corretamente no banco de dados.
- **Testar campos individuais:** Verificar se os campos de telefone, e-mail e senha são validados corretamente para o formato adequado.

---

### **8. Cadastro de Fornecedor**

- **Validação de formulário:** Testar se o formulário de cadastro de fornecedor valida corretamente os campos obrigatórios (nome, e-mail, telefone, endereço, CNPJ).
- **Submissão de dados:** Verificar se, ao preencher e submeter o formulário, o fornecedor é salvo corretamente no banco de dados.
- **Verificação do CNPJ:** Testar a validação do campo de CNPJ para garantir que formatos incorretos sejam rejeitados.

---

### **9. Gestão de Estoque**

- **Listagem de produtos com checkbox:** Testar se os produtos são listados com checkboxes ao lado de cada um e se o comportamento de seleção funciona corretamente (marcar e desmarcar).
- **Atualização visual ao marcar:** Verificar se, ao marcar um produto, o ícone de Check aparece e desaparece corretamente.
- **Validação de ID de produto:** Garantir que os IDs de produtos associados aos checkboxes correspondam ao banco de dados.


### **10. Ordem de Compra**

---

#### **Listagem de Usuários**
- **Listagem de usuários:** Testar se todos os usuários são listados corretamente para seleção no select.
- **Validação de seleção:** Verificar se a seleção de usuários funciona corretamente ao clicar no nome.

---

#### **Listagem de Fornecedores**
- **Listagem de fornecedores:** Testar se todos os fornecedores são listados corretamente para seleção no select.
- **Validação de seleção:** Garantir que a seleção de fornecedores funcione corretamente ao clicar no nome.

---

#### **Listagem de Produtos**
- **Listagem de produtos:** Testar se todos os produtos são listados corretamente para seleção no select.
- **Validação de seleção:** Verificar se a seleção de produtos funciona corretamente ao clicar no nome.

---

#### **Adição de Produtos**
- **Adicionar produto:** Ao clicar no ícone de `+`, o produto deve ser adicionado à tabela de produtos adicionados.
- **Verificação na tabela:** Garantir que o produto apareça corretamente na tabela após a adição.

---

#### **Atualização da Quantidade de Produtos**
- **Aumentar quantidade:** Ao aumentar a quantidade de um produto, o total da ordem de compra deve aumentar conforme a quantidade incrementada.
- **Validação do total:** Verificar se o total é atualizado corretamente na interface.

---

#### **Exclusão de Produtos**
- **Excluir produto:** Ao excluir um produto da tabela, o total da ordem de compra deve ser decrementado de acordo com o valor total do produto multiplicado pela quantidade.
- **Verificação da tabela:** Garantir que o produto seja removido da tabela após a exclusão.

---

#### **11. Tela de Listagem de Ordens de Compra**
- **Listagem de ordens de compra:** As ordens de compra devem ser listadas corretamente com as informações descritas no cabeçalho de cada coluna.
- **Validação de status:** Se a ordem de compra está pendente, a coluna de status deve refletir isso corretamente, indicando "Pendente" ou "Aprovado".
- **Botão de aprovar:** O botão para aprovar deve estar habilitado para ordens pendentes e desabilitado com a indicação "Aprovado" para ordens já aprovadas.

---

#### **Aprovação de Ordens de Compra**
- **Aprovar ordem de compra:** Ao aprovar uma ordem de compra, a linha correspondente deve ser atualizada, e o botão de aprovar deve mudar para refletir o novo status.
- **Validação do status:** Verificar se o status da ordem de compra muda para "Aprovado" após a aprovação.

---
