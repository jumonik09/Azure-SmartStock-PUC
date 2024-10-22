# Plano de Testes de Usabilidade

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
