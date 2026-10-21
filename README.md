# SIGEM: Sistema de Gestão de Equipamentos e Manutenção

Aplicação desktop em C# (Windows Forms) com banco SQL Server, feita para o desafio do 2º bimestre das disciplinas de Aplicações Desktop e Banco de Dados (3º semestre de Sistemas de Informação).

## Funcionalidades

- Login e cadastro de usuários (com endereço preenchido pelo CEP via [ViaCEP](https://viacep.com.br))
- Perfis de acesso: administrador e usuário
- Cadastro de equipamentos e peças
- Registro de tarefas de manutenção

## Estrutura

O projeto segue a separação em camadas:

| Camada | Arquivos |
|---|---|
| Interface (UIL) | `LoginUIL`, `InscricaoUIL`, `UsuarioUIL`, `AdministradorUIL`, `PecasUIL` |
| Regras de negócio (BLL) | `UsuarioBLL`, `EquipamentoBLL`, `TarefaBLL` |
| Acesso a dados (DAL) | `UsuarioDAL`, `EquipamentoDAL`, `TarefaDAL`, `ApisDAL` |
| Modelos | `Usuario`, `Endereco`, `Equipamentos`, `Tarefas` |

Em `Documents/` estão o enunciado do desafio (`Desafio_AD_BD.pdf`) e o script do banco (`Desafio_AD_BD.sql`). A pasta `lib/` tem a DLL `ClassErro` usada pelo projeto.

## Como rodar

1. Instale o Visual Studio com o workload de desenvolvimento para desktop .NET (.NET Framework 4.7.2) e o SQL Server Express.
2. Execute `Documents/Desafio_AD_BD.sql` no SQL Server para criar o banco `desafio2bimestre`.
3. Abra `Desafio_AD_BD.sln` no Visual Studio. Os pacotes NuGet são restaurados automaticamente no primeiro build.
4. Se o seu SQL Server não for `localhost\SQLEXPRESS`, ajuste a string de conexão nas classes `*DAL.cs`.
5. Rode o projeto (F5).
