# DesafioNF
Desafio da empresa NF para estágio - Primeira parte da entrevista.

Criar um sistema seguindo as seguintes obrigações:

- O sistema deve conter telas para o cadastro de Livros, Gêneros e Autores
- Deve ser respeitado o relacionamento entre as entidades. Sendo que:
    - 1 livro pode ter vários gêneros e 1 gênero pode representar vários livros
    - 1 autor pode ter vários livros, mas cada livro pode ter somente 1 autor
- No cadastro de livros deve haver um espaço para informar vários gêneros. Fica aberto a forma como será feita (Javascript ou texto)
- Deve haver uma tela para consulta de livros disponíveis para "locação", de forma que se todos os exemplares de um título estiverem "locados", o sistema deverá exibir estes livros juntamente com uma informação dizendo que o livro existe mas não está disponível no momento.
- Na tela de consulta deve haver dois botões onde um informará a locação do livro e outro informará a devolução do livro.
- Para o front end pode utilizar um template bootstrap ou outro qualquer (a vontade).
- O sistema deve ser feito utilizando estrutura orientada a objetos
- Utilizar banco de dados MySQL e disponibilizar sua estrutura juntamente com o projeto
Diferenciais:

- Implementar paginação na tela de consulta.
- Criar filtro de livros por título na tela de consulta.
- Utilizar o framework CakePHP na sua versão 2
- Implementar controle de usuários com login do CakePHP
