# 🔓 JWT Decoder – Blazor Server

Um decodificador de JSON Web Tokens (JWT) construído com Blazor Server e C#.  
Basta colar o token e ver o **Header**, **Payload** e **Signature** decodificados.

## 🚀 Como executar

1. Clone o repositório  
   `git clone https://github.com/christianocj/jwt-decoder-blazor.git`
2. Entre na pasta do projeto  
   `cd jwt-decoder-blazor`
3. Execute com .NET CLI  
   `dotnet run --project JwtDecoder`
4. Abra o navegador em `https://localhost:5001` ou na porta correta exibida no terminal.

##Exemplo

**Token:**  
`eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c`

**Resultado:**  
Header:
```json```
{
  "alg": "HS256",
  "typ": "JWT"
}
Payload:
```json```
{
  "sub": "1234567890",
  "name": "John Doe",
  "iat": 1516239022
}

## Tecnologias
1. .NET 10
2. Blazor Server
3. System.Text.Json (library)


Autor: Cristiano Júlio
GitHub: [christianocj](https://github.com/christianocj)