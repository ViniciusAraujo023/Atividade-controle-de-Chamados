# Atividade controle de Chamados
Atividade proposta em aula, controle de chamados feito em C# e registro feito em json, com gerenciamento e solicitação de chamados para TI.

# Conceito geral do programa
  Sistema de controle de chamados onde o usuário pode fazer o registro de um chamado onde vai ser necessário colocar suas credencias para fazer a solicitação, e o administrador pode fazer o controle e administrar os chamados.

## Funcionalidades
  O programa oferece um menu interativo onde os usuários podem acessar:
  
- Menu incial – Tela inicial serve para escolher qual função deseja selecionar uma das três disponíveis, solicitar chamado, gerenciar chamado e sair.

- Solicitar chamado – O usuário vai precisar preencher com seus dados e data para poder descrever o motivo do chamado para ser regristrado.

- Gerenciar chamados – Para acessar essa tela é necessário senha do admistrador (pode ser alterada dentro do código), onde pode acessar a lista dos chamados com os solicitantes e data e descrição podendo definir o status de cocluído para o mesmo. 

## Tecnologias Utilizadas
- C# – Linguagem de programação para estruturar o projeto.

- JSON – Registro dos chamados mesmo com o programa encerrado.

## Estrutura do Projeto
### Pré requisitos
- .NET 10++

## 📁 Controle_e_Solicitação_de_chamados
```C#
program.cs              # Arquivo de inicialização (executa a função Main)  
Chamado.cs              # Tela de preenchimento para abertura do chamado (Executa classe pública de chamados para iniciar um chamado)
ListadeChamados.cs      # Exibe a condição do chamado com as informações que o usuário preencheu (Executa a classe privada para mostrar descrição do chamados e informações do solicitante) 
Menu.cs                 # Consiste em 3 telas menu iniciall, solicitar chamado e gerenciar chamado (As 3 classes são voids que não necessitam de valor, servem apenas para confirmar a seleção)
statuschamado.cs        # Coloca a condição do chamado (Classe pública para definir o status)
chamados.json           # Registro dos chamados      
README.md               # Documentação  
```

# Feito por:
Vinícius Araújo de Almeida - https://www.linkedin.com/in/vinicius-araujo-de-almeida/
