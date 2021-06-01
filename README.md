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

