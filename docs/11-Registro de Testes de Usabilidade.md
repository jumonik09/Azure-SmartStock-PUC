# Registro de Testes de Usabilidade

Após realizar os testes de usabilidade, obtém-se um relatório a partir das análises realizadas. O Registro de Testes de Usabilidade é um relatório que contém as evidências dos testes e relatos dos usuários participantes, baseado no Plano de Testes de Usabilidade desenvolvido para os casos de uso desta etapa.

 ## Cadastro de Produto - CT-001

O teste do requisito RF-01, que aborda o cadastro de produtos com atributos como nome, descrição, preço e quantidade em estoque, teve um resultado parcial. Enquanto os campos de nome, descrição e preço funcionaram corretamente, a funcionalidade de inserção da quantidade de produtos ainda precisa de ajustes. Embora a maior parte do requisito tenha sido atendida, a funcionalidade de quantidade requer melhorias.


01) Visibilidade do status do sistema: A página Cadastro de Produto poderia se beneficiar de um feedback mais claro sobre a validação da quantidade inserida, ajudando o usuário a se sentir mais seguro durante o processo.

02) Correspondência entre o sistema e o mundo real: A terminologia utilizada nos campos é apropriada e fácil de entender.

03) Controle e liberdade do usuário: O sistema permite uma boa navegação, mas algumas melhorias na edição da quantidade poderiam facilitar a correção de eventuais erros.

04) Consistência e padronização: A consistência nos campos de nome, descrição e preço é positiva, e uma uniformidade da interface.

05) Prevenção de erros: A validação da quantidade é um aspecto a ser aprimorado, evitando que os usuários enfrentem pequenos obstáculos durante o cadastro.

06) Reconhecimento em vez de lembrança: Incluir exemplos de entrada ao lado do campo de quantidade seria uma boa prática, facilitando o entendimento.

07) Flexibilidade e eficiência de uso: A interface é intuitiva.

08) Estética e design minimalista: O design é funcional e agradável.

09) Ajuda e documentação: Embora a interface seja intuitiva, uma seção de ajuda ou dicas contextuais poderia enriquecer a experiência do usuário.

10) Feedback do usuário: Mensagens de erro mais específicas quando a quantidade não é aceita poderiam facilitar a compreensão e a correção por parte do usuário.

Em geral, enquanto os campos de nome, descrição e preço funcionaram bem, a funcionalidade de quantidade apresenta oportunidades para melhorias que podem enriquecer a experiência do usuário.

 ## Página Lista de Usuários - CT-002 

<b> Registro de Teste:</b> O sistema executou consultas SQL com sucesso, armazenou os dados e os formatou em uma tabela HTML com cabeçalhos dinâmicos. A tabela foi estilizada de forma clara, confirmando que todas as funcionalidades atenderam ao requisito RF-14.

Registro de Teste de Usabilidade

Objetivo do Teste: Avaliar a usabilidade do sistema em relação à execução de consultas SQL, armazenamento de dados e formatação em uma tabela HTML.

Resultados do Teste:

<b>Visibilidade do Status do Sistema:</b> O sistema forneceu feedback claro durante a execução das consultas, indicando o progresso e o sucesso da operação.

<b>Correspondência com o Mundo Real:</b> As mensagens e termos utilizados estavam em linguagem acessível, facilitando a compreensão para os usuários.

<b>Liberdade e Controle do Usuário:</b> Os usuários puderam facilmente refazer consultas na página Cadastro de Usuário, permitindo maior controle sobre suas ações.

<b>Consistência e Padrões:</b> A formatação da tabela HTML seguiu padrões estabelecidos, garantindo uma apresentação intuitiva dos dados.

<b>Prevenção de Erros:</b> O sistema validou as entradas antes da execução das consultas, minimizando erros potenciais.

<b>Reconhecer ao Invés de Lembrar:</b> Os cabeçalhos dinâmicos da tabela permitiram que os usuários reconhecessem rapidamente as informações apresentadas.

<b> Eficiência e Flexibilidade de Uso:</b> A tabela foi estilizada de forma clara e eficiente, permitindo uma visualização rápida e fácil.

<b>Estética e Design Minimalista:</b> A apresentação da tabela foi limpa e focada, evitando informações desnecessárias.

<b> Recuperação Diante de Erros:</b> Apesar de a interface ser fácil de navegar, adicionar uma seção de ajuda ou sugestões contextuais poderia melhorar a experiência do usuário.

<b>Ajuda e Documentação:</b> Mensagens de erro mais claras quando a quantidade não é aceita poderiam ajudar o usuário a compreender e resolver o problema.

<p> Conclusão: O sistema executou consultas SQL com sucesso, armazenou os dados e formatou-os em uma tabela HTML com cabeçalhos dinâmicos e estilização clara. Todas as funcionalidades testadas atenderam ao requisito RF-14, garantindo uma experiência de usuário satisfatória.</p>

----------

# Tela de Cadastro de Usuário

## 1. Visibilidade do Status do Sistema
- **Observação**: O sistema fornece feedback em tempo real sobre o status do cadastro, como mensagens de sucesso ou erro durante o processo de envio dos dados.
- **Impacto**: Alto. A visibilidade clara mantém o usuário informado sobre o progresso e resultado de suas ações, evitando incertezas.

## 2. Correspondência com o Mundo Real
- **Observação**: A interface utiliza termos familiares e claros, como "Nome", "E-mail" e "Senha", em vez de termos técnicos ou confusos.
- **Impacto**: Alto. Isso facilita a compreensão e o uso da tela, tornando o sistema acessível para diversos perfis de usuários.

## 3. Controle e Liberdade do Usuário
- **Observação**: Os usuários podem facilmente corrigir erros ou retornar a passos anteriores no processo de cadastro, como modificar campos preenchidos incorretamente.
- **Impacto**: Médio. Proporciona flexibilidade para o usuário refazer ações sem ficarem presos em fluxos rígidos.

## 4. Consistência e Padrões
- **Observação**: A tela segue padrões de design consistentes, como a posição dos botões de ação, estilo de campos e feedback visual.
- **Impacto**: Alto. A consistência reduz a carga cognitiva do usuário, já que ele sabe o que esperar e como interagir com os elementos.

## 5. Prevenção de Erros
- **Observação**: O sistema realiza validação de dados antes do envio, como verificar formatos de e-mail ou campos obrigatórios, prevenindo erros antes que eles ocorram.
- **Impacto**: Alto. Isso minimiza a ocorrência de erros e aumenta a confiança do usuário no processo.

## 6. Reconhecimento em vez de Memorização
- **Observação**: Os campos estão claramente identificados e apresentam exemplos ou placeholders, permitindo que os usuários entendam facilmente o que devem inserir.
- **Impacto**: Médio. Reduz a necessidade de o usuário lembrar-se de detalhes ou instruções para completar o cadastro.

## 7. Flexibilidade e Eficiência de Uso
- **Observação**: A tela é projetada para ser eficiente tanto para novos usuários quanto para usuários mais experientes, com atalhos ou preenchimento automático.
- **Impacto**: Médio. Usuários experientes conseguem realizar o cadastro mais rapidamente, mas a simplicidade também ajuda novatos.

## 8. Estética e Design Minimalista
- **Observação**: A interface é limpa, sem elementos desnecessários ou poluídos visualmente, permitindo que o foco do usuário esteja apenas no que é relevante.
- **Impacto**: Alto. Um design simples facilita a navegação e torna o processo mais rápido e agradável.

## 9. Ajuda aos Usuários para Reconhecer, Diagnosticar e Corrigir Erros
- **Observação**: Quando ocorre um erro, o sistema informa claramente o que deu errado, como "O e-mail inserido é inválido", e orienta sobre como corrigi-lo.
- **Impacto**: Médio. Isso ajuda o usuário a retificar rapidamente os problemas, sem frustração.

## 10. Ajuda e Documentação
- **Observação**: A documentação ou ajuda disponível é clara e fácil de acessar, caso o usuário tenha dúvidas sobre o processo de cadastro.
- **Impacto**: Baixo. Se bem implementado, pode ajudar, mas geralmente o processo de cadastro é simples o suficiente para não precisar de ajuda detalhada.

## Conclusão Geral
A tela de cadastro de usuário foi bem-sucedida nos testes e atende a maioria dos princípios heurísticos de usabilidade. Ela proporciona uma experiência intuitiva, consistente e eficiente, com um foco claro na prevenção de erros e visibilidade do status do sistema. A flexibilidade e o design minimalista aumentam a eficiência do uso, tornando o processo fluido e agradável para diferentes tipos de usuários.
