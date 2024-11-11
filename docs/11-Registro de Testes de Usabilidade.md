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


| **Caso de Teste** 	| **Tela Cadastro de Usuário** 	|
|:---:	|:---:	|
|	 **01)Características:**	| **Visibilidade do Status do Sistema** | 
|	 **1.1)**	| **As telas iniciam com um título que descreve seu conteúdo?** | 
|   Comentários: XXX|Sim (X)  Não ( ) N/A ( )| 
|	 **1.2)**	| **O sistema fornece feedback em tempo real sobre o status do cadastro?.** | 
|   Comentários: XXX|Sim (X)  Não ( ) N/A ( )| 
|	 **1.3)**	| **Aparecerá uma mensagem de sucesso ou erro durante o processo de envio dos dados?** | 
|   **Comentários**: Mensagem de sucesso aparece quando os dados são inseridos corretamente e registrados na tela Cadastro do usuário. Não há página de erro.|Sim (X)  Não ( ) | 
|	 **02)Características:**	| **Correspondência com o mundo real** | 
|	**2.1)** | **A interface utiliza termos familiares e claros, como "Nome", "E-mail" e "Senha", em vez de termos técnicos ou confusos?**|
|   Comentários: XXX | Sim (X)  Não ( ) N/A ( )| 
|	**2.2)** | **As cores empregadas estão de acordo com a paleta de cores previamente definida pela equipe?**|
|   Comentários: XXX | Sim (X)  Não ( ) N/A ( )  | 
|	 **03)Características:**	| **Controle e Liberdade do Usuário** | 
|	**3.1)** | **Os usuários podem facilmente corrigir erros ou retornar a passos anteriores no processo de cadastro, como modificar campos preenchidos incorretamente?**|
|   Comentários: Não oferece flexibilidade ao usuário para reverter ações, mantendo-o restrito a fluxos rígidos.| Sim ( )  Não (X) N/A ( )|
|	**3.2** | **Existe uma funcionalidade para desfazer ações realizadas pelo usuário?**|
|   Comentários: XXX| Sim ( )  Não (X) N/A ( ) |
|	**3.3** | **O usuário pode se mover entre campos e janelas livremente?**|
|   Comentários: XXX| Sim (X)  Não ( )  N/A ( )|
|	 **4.0)Características:**	| **Consistência e padrões** | 
|	 **4.1**	| **O sistema evita uso constante de letras maiúsculas?** | 
|   Comentários: XXX| Sim (X)  Não ( )  N/A ( )|
|	 **4.2**	| **A tela segue padrões de design consistentes, como a posição dos botões de ação, estilo de campos e feedback visual?** |
|   Comentários: XXX| Sim (X)  Não ( )  N/A ( )|
|	 **4.3**	| **A consistência reduz a carga cognitiva do usuário, uma vez que ele sabe o que esperar e como interagir com os elementos?** | 
|   Comentários: XXX| Sim (X)  Não ( )  N/A ( )|
| **5.0)Características:**	| **Prevenção de Erros** | 
| 	**5.1)** | **O sistema realiza validação de dados antes do envio, como verificar formatos de e-mail ou campos obrigatórios, prevenindo erros antes que eles ocorram?** |
| Comentários: XXX| Sim (X)  Não ( )  N/A ( )|
| 	**5.2)** | **O sistema alerta o usuário se ele estas prestes a erros críticos?** |
| Comentários: A ausência de alertas para erros críticos pode aumentar a probabilidade de falhas graves, comprometendo a experiência do usuário e a eficiência do sistema| Sim ()  Não (X)  N/A ( )|
|	 **06)Características:**	| **Reconhecimento em vez de Memorização** | 
| 	**6.1)** | **Os rótulos estão próximos dos campos e separados pelo menos por um espaço?** |
| Comentários: XXX| Sim (X)  Não ( )  N/A ( )|
| 	**6.2)** | **São utilizadas bordas para identificas possíveis grupos de elementos?** |
| Comentários:A ausência de bordas pode dificultar a identificação visual de agrupamentos, o que pode prejudicar a organização e a usabilidade do sistema.| Sim (X)  Não (X )  N/A ( )|
|	 **07)Características:**	| **Flexibilidade e Eficiência de Uso** | 
| 	**7.1)** | **Existem atalhos para as funções disponíveis no sistema?** |
| Comentários: O "menu hambúrguer" disponibiliza o acesso a outras páginas de maneira eficiente.| Sim (X)  Não X)  N/A ( )|
|	 **08)Características:**	| **Estética e Design Minimalista** | 
| 	**8.1)** | **Apenas a informação necessária para ação esta visível na tela?** |
| Comentários: XXX| Sim (X)  Não ( )  N/A ( )|
| 	**8.2)** | **A interface é limpa, sem elementos desnecessários ou poluídos visualmente, permitindo que o foco do usuário esteja apenas no que é relevante?** |
| Comentários: XXX| Sim (X)  Não ( )  N/A ( )|



## 01. Visibilidade do Status do Sistema:
- **Observação:** Assim como no cadastro de produtos, o sistema poderia fornecer um feedback mais claro sobre a validação de CNPJ e telefone. Mensagens de erro específicas ou ícones de sucesso/erro seriam úteis para indicar ao usuário se as informações estão corretas ou precisam de ajuste.
- **Impacto:** Alto. Uma visibilidade clara das validações de CNPJ e telefone ajudaria a melhorar a confiança do usuário durante o processo de cadastro.

## 02. Correspondência com o Mundo Real:
- **Observação:** A terminologia utilizada nos campos do formulário é apropriada e fácil de entender. Termos como "Nome do Fornecedor", "CNPJ", "Endereço", "E-mail" e "Telefone" estão alinhados com o que o usuário espera encontrar.
- **Impacto:** Alto. Usar uma linguagem familiar ajuda a evitar confusões e facilita o uso por parte do usuário, tornando o processo de cadastro mais simples.

## 03. Controle e Liberdade do Usuário:
- **Observação:** O sistema oferece uma boa navegação, permitindo que o usuário volte a editar dados facilmente. No entanto, uma melhoria na edição do CNPJ e telefone, como um formato padrão para esses campos, poderia ajudar na correção de eventuais erros.
- **Impacto:** Médio. Melhorias na liberdade de edição, como um botão de “voltar” visível ou um campo de CNPJ com formatação automática, poderiam facilitar a experiência do usuário.

## 04. Consistência e Padronização:
- **Observação:** A interface segue um padrão consistente em todos os campos do formulário, com uma apresentação coerente entre nome, endereço e e-mail. No entanto, a falta de padronização na verificação do CNPJ e do telefone prejudica a consistência.
- **Impacto:** Alto. Garantir que todos os campos, especialmente os de CNPJ e telefone, sigam padrões de validação e formatação consistentes é essencial para uma experiência fluida.

## 05. Prevenção de Erros:
- **Observação:** A validação do CNPJ precisa ser aprimorada, de forma a evitar que o usuário insira informações incorretas. O campo de telefone também poderia ter validação mais robusta para evitar números incompletos ou mal formatados.
- **Impacto:** Alto. Prevenir erros antes que eles aconteçam, através de validação automática e mensagens claras, melhora a confiança e reduz frustrações.

## 06. Reconhecimento em vez de Memorização:
- **Observação:** Assim como no cadastro de produtos, seria útil adicionar exemplos de entrada ao lado dos campos de CNPJ e telefone, o que ajudaria o usuário a saber qual o formato esperado sem precisar memorizar ou adivinhar.
- **Impacto:** Médio. Isso tornaria o processo mais intuitivo, ajudando o usuário a preencher os campos corretamente sem recorrer a documentações externas.

## 07. Flexibilidade e Eficiência de Uso:
- **Observação:**  A interface é intuitiva e eficiente, tanto para novos usuários quanto para os mais experientes. Atalhos como o preenchimento automático de campos, quando possível (por exemplo, o preenchimento do endereço a partir do CEP), poderiam aumentar ainda mais a eficiência.
- **Impacto:** Médio. A adição de recursos que facilitem o preenchimento de dados, especialmente em campos como endereço e telefone, tornaria o uso mais eficiente.

## 08. Estética e Design Minimalista:
- **Observação:** A página mantém um design funcional e agradável, sem excesso de elementos visuais desnecessários, o que facilita a navegação. Todos os campos estão claramente dispostos e bem organizados.
- **Impacto:** Alto. Um design minimalista ajuda a manter o foco do usuário nos campos importantes, tornando o processo de cadastro mais rápido e eficiente.

## 09. Ajuda e Documentação:
- **Observação:** Embora o formulário seja intuitivo, uma seção de ajuda ou dicas contextuais poderia enriquecer a experiência do usuário, principalmente nos campos de validação mais complexos, como CNPJ e telefone.
- **Impacto:** Baixo. A adição de dicas ao lado dos campos mais técnicos seria um plus para novos usuários ou para quem tenha dúvidas sobre o formato correto dos dados.

## 10. Feedback:
- **Observação:** Mensagens de erro mais específicas para campos como CNPJ e telefone ajudariam o usuário a entender melhor o que está errado e como corrigir. Ao invés de apenas “CNPJ inválido”, uma mensagem como “O CNPJ deve conter 14 dígitos, sem caracteres especiais” seria mais clara.
- **Impacto:** Médio. Um feedback mais detalhado melhora a experiência e facilita a correção de erros, evitando múltiplas tentativas frustrantes.

## Conclusão Geral
O Cadastro de Fornecedor atende à maioria dos requisitos funcionais, mas apresenta algumas oportunidades de melhoria, especialmente na validação de campos críticos como CNPJ e telefone. O design da interface é simples e funcional, proporcionando uma boa experiência geral, mas pode ser enriquecido com feedbacks mais claros e ferramentas de preenchimento automático para aumentar a eficiência e evitar erros.
