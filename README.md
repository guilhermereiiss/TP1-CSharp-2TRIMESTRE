
# TP1-C#-2TRIMESTRE

Este repositório contém os projetos desenvolvidos como parte do Trabalho Prático 1 (TP1) do segundo trimestre da disciplina de programação em C#. O objetivo do trabalho é implementar soluções práticas utilizando C# em diferentes contextos, incluindo aplicações de console e web com Razor Pages.

## Estrutura do Repositório

O repositório está organizado em três projetos principais:

1. **TP1-C#-2TRIMESTRE**: Um projeto C++ configurado para compilar uma aplicação de console, embora não contenha arquivos de código-fonte ativos neste momento.
2. **TP1-CONSOLE**: Uma aplicação de console em C# que implementa três questões práticas:
   - **Questão 01**: Sistema de desconto que aplica um desconto padrão de 10% a um preço informado pelo usuário, utilizando delegates.
   - **Questão 02**: Sistema multilíngue que exibe mensagens em diferentes idiomas com base na escolha do usuário.
   - **Questão 03**: (Detalhes não fornecidos no código, mas segue a estrutura modular do projeto).
3. **TP1-RAZROPAGE**: Uma aplicação web desenvolvida com ASP.NET Core Razor Pages, incluindo páginas básicas como Index, Privacy e Error, com suporte a validação de formulários usando jQuery e Bootstrap para estilização.

### Estrutura de Diretórios

```
TP1-C#-2TRIMESTRE/
├── .vs/                           # Arquivos de configuração do Visual Studio
├── TP1-C#-2TRIMESTRE/            # Projeto C++ (console)
├── TP1-CONSOLE/                  # Projeto de console em C#
│   ├── Questao01/                # Código da Questão 01
│   ├── Questao02/                # Código da Questão 02
│   ├── Questao03/                # Código da Questão 03
│   ├── Program.cs                # Ponto de entrada da aplicação
│   └── TP1-CONSOLE.csproj        # Arquivo de projeto
├── TP1-RAZROPAGE/                # Projeto web com Razor Pages
│   ├── Pages/                    # Páginas Razor (Index, Privacy, Error)
│   ├── wwwroot/                  # Arquivos estáticos (CSS, JS, Bootstrap, jQuery)
│   ├── Program.cs                # Configuração da aplicação web
│   └── TP1-RAZROPAGE.csproj      # Arquivo de projeto
└── TP1-C#-2TRIMESTRE.sln         # Arquivo de solução do Visual Studio
```

## Pré-requisitos

Para executar os projetos, você precisará dos seguintes requisitos:

- **.NET 8.0 SDK**: Necessário para compilar e executar os projetos `TP1-CONSOLE` e `TP1-RAZROPAGE`.
- **Visual Studio 2022** (ou superior): Recomendado para desenvolvimento e depuração, com suporte a C# e C++.
- **Node.js** (opcional): Para gerenciar dependências de front-end no projeto `TP1-RAZROPAGE`, se necessário.
- **Git**: Para clonar e gerenciar o repositório.

## Como Executar

### 1. Clonar o Repositório
```bash
git clone https://github.com/seu-usuario/TP1-C#-2TRIMESTRE.git
cd TP1-C#-2TRIMESTRE
```

### 2. Executar o Projeto TP1-CONSOLE
1. Abra o arquivo `TP1-C#-2TRIMESTRE.sln` no Visual Studio.
2. Defina `TP1-CONSOLE` como o projeto de inicialização.
3. Execute o projeto em modo Debug ou Release.
4. Siga as instruções no console para interagir com as questões (por exemplo, inserir o preço para a Questão 01 ou escolher um idioma para a Questão 02).

Alternativamente, via linha de comando:
```bash
cd TP1-CONSOLE
dotnet run
```

### 3. Executar o Projeto TP1-RAZROPAGE
1. Abra o arquivo `TP1-C#-2TRIMESTRE.sln` no Visual Studio.
2. Defina `TP1-RAZROPAGE` como o projeto de inicialização.
3. Tertiary
4. Execute o projeto em modo Debug ou Release.
5. Acesse a aplicação no navegador (geralmente em `https://localhost:5001`).

Via linha de comando:
```bash
cd TP1-RAZROPAGE
dotnet run
```

### 4. Executar o Projeto TP1-C#-2TRIMESTRE (C++)
1. Abra o projeto no Visual Studio.
2. Configure as propriedades de compilação (Debug/Release, x64/Win32).
3. Compile e execute. Note que este projeto atualmente não possui arquivos de código-fonte ativos.

## Funcionalidades

- **TP1-CONSOLE**:
  - **Questão 01**: Calcula um desconto de 10% em um preço informado, com validação de entrada e uso de delegates.
  - **Questão 02**: Interface multilíngue com suporte a português, inglês e espanhol, utilizando dicionários e delegates.
  - **Questão 03**: (Funcionalidade específica não detalhada no código fornecido).
- **TP1-RAZROPAGE**:
  - Páginas web responsivas com Bootstrap.
  - Validação de formulários com jQuery Validation.
  - Configuração de ambiente para desenvolvimento e produção.

## Contribuição

1. Faça um fork do repositório.
2. Crie uma branch para sua feature (`git checkout -b minha-feature`).
3. Commit suas alterações (`git commit -m 'Adiciona minha feature'`).
4. Envie para o repositório remoto (`git push origin minha-feature`).
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Autor

- **Guilherme Reiiss** - [GitHub](https://github.com/seu-usuario)

## Agradecimentos

- À equipe do .NET pela documentação e ferramentas.
- À comunidade open-source pelas bibliotecas utilizadas (Bootstrap, jQuery, etc.).
