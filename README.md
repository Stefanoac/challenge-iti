# Descrição

Considere uma senha sendo válida quando a mesma possuir as seguintes definições:

- Nove ou mais caracteres
- Ao menos 1 dígito
- Ao menos 1 letra minúscula
- Ao menos 1 letra maiúscula
- Ao menos 1 caractere especial
  - Considere como especial os seguintes caracteres: !@#$%^&*()-+
- Não possuir caracteres repetidos dentro do conjunto

Exemplo:  

```c#
IsValid("") // false  
IsValid("aa") // false  
IsValid("ab") // false  
IsValid("AAAbbbCc") // false  
IsValid("AbTp9!foo") // false  
IsValid("AbTp9!foA") // false
IsValid("AbTp9 fok") // false
IsValid("AbTp9!fok") // true
```

> **_Nota:_**  Espaços em branco não devem ser considerados como caracteres válidos.

## Problema

Construa uma aplicação que exponha uma api web que valide se uma senha é válida.

Input: Uma senha (string).  
Output: Um boolean indicando se a senha é válida.

Embora nossas aplicações sejam escritas em Kotlin e C# (.net core), você não precisa escrever sua solução usando elas. Use a linguagem de programação que considera ter mais conhecimento.

## Arquitetura

![image](https://user-images.githubusercontent.com/1659676/120355456-b24cc700-c2d9-11eb-820c-7a039a06ce91.png)

Solution: 
  - ChallengeItau.Domain
      - Entity Models / Interfaces
  - ChallengeItau.Service
      - Service and Validators
  - ChallengeItau.Services.API
      - API Controllers
  - ChallengeItau.Tests
      - Unit and integration tests
      - Used Xunit

## Próximos passos

- Aplicar Repository Patterns
- Rever se é necessário mais abstrações (acho que não é necessário pelo projeto ser muito pequeno)
- Escrever mais testes unitários caso cresça o projeto
- Implementar novos Validators caso seja necessário

## API

![image](https://user-images.githubusercontent.com/1659676/120355683-db6d5780-c2d9-11eb-95d0-6fcc13782c3c.png)

## Executando a Aplicação

1. Clonar esse repositório e entrar no diretório backend 
2. Setar o ChallengeItau.Services.API como projeto padrão
  - Clique no projeto "ChallengeItau.Services.API" com o botão direito, escolha a opção "Set as StartUp Project", irá ficar como imagem abaixo
  ![image](https://user-images.githubusercontent.com/1659676/120355963-30a96900-c2da-11eb-9c22-567d0d99524c.png)
3. Rodar a aplicação

## Unit tests

![image](https://user-images.githubusercontent.com/1659676/120356349-a1508580-c2da-11eb-975a-546015a4d92e.png)

Como executar os testes:

1. Abrir o Test Explorer localizado dentro do menu superior "View"

![image](https://user-images.githubusercontent.com/1659676/120356799-1b810a00-c2db-11eb-9913-5f7219d2a299.png)

2. Clicar no primeiro ícone (duas flechas) para rodar todos testes

![image](https://user-images.githubusercontent.com/1659676/120356913-3a7f9c00-c2db-11eb-92b0-8ba893bd5f30.png)


