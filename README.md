
# 📅 MauiAppEventos — Cadastro de Eventos

Projeto desenvolvido em **C# com .NET MAUI** para a atividade da **Agenda 15 de Programação Mobile I**, com o objetivo de criar um aplicativo para cadastro e gerenciamento das informações de eventos.

## 📌 Sobre o Projeto

O **MauiAppEventos** é um aplicativo que permite cadastrar eventos e visualizar um resumo completo com os dados informados.

O sistema calcula automaticamente a duração do evento em dias e o custo total, considerando a quantidade de participantes e o valor por participante.

## 🚀 Funcionalidades

- ✅ Cadastro do nome do evento
- ✅ Seleção das datas de início e término
- ✅ Definição da quantidade de participantes
- ✅ Cadastro do local do evento
- ✅ Informação do custo por participante
- ✅ Cálculo automático da duração do evento
- ✅ Cálculo automático do custo total
- ✅ Validação dos campos preenchidos
- ✅ Exibição do resumo em uma nova tela
- ✅ Navegação entre as telas

## 🛠️ Tecnologias Utilizadas

- **C#** — Linguagem de programação
- **.NET MAUI** — Framework multiplataforma
- **XAML** — Desenvolvimento das interfaces
- **Visual Studio 2022** — Ambiente de desenvolvimento
- **Git e GitHub** — Controle de versão

## 📂 Estrutura do Projeto

```text
MauiAppEventos/
│
├── Models/
│   └── Evento.cs
│
├── Views/
│   ├── ResumoEvento.xaml
│   └── ResumoEvento.xaml.cs
│
├── Resources/
│   └── Fonts/
│
├── MainPage.xaml
├── MainPage.xaml.cs
├── App.xaml
├── App.xaml.cs
├── MauiProgram.cs
└── MauiAppEventos.csproj
```

## 🧠 Conceitos Aplicados

### Programação Orientada a Objetos
Utilização da classe `Evento` para armazenar as informações do evento e realizar os cálculos.

### BindingContext
Transferência do objeto `Evento` entre as telas, permitindo apresentar os dados cadastrados por meio de Data Binding.

### DateTime e TimeSpan
Utilização de `DateTime` para armazenar as datas e `TimeSpan` para calcular a duração do evento.

### StringFormat
Formatação das datas, dos valores monetários e das informações exibidas na tela de resumo.

## 🧮 Exemplo de Funcionamento

**Dados cadastrados:**

- **Evento:** Feira de Tecnologia
- **Data de início:** 10/11/2026
- **Data de término:** 13/11/2026
- **Participantes:** 50
- **Local:** Auditório
- **Custo por participante:** R$ 25,00

**Resultados:**

- **Duração:** 3 dias
- **Custo total:** R$ 1.250,00

### Fórmulas Utilizadas

```csharp
public TimeSpan Duracao =>
    DataTermino.Date - DataInicio.Date;

public int DuracaoDias =>
    Duracao.Days;

public decimal CustoTotal =>
    NumeroParticipantes * CustoPorParticipante;
```

## ▶️ Como Executar

1. Clone ou baixe este repositório.
2. Abra a solução no **Visual Studio 2022**.
3. Verifique se a carga de trabalho do **.NET MAUI** está instalada.
4. Selecione o dispositivo ou emulador desejado.
5. Pressione **F5** para executar o aplicativo.
6. Preencha o formulário e clique em **Cadastrar Evento**.
7. Visualize o resumo e os cálculos realizados.

## 🎯 Objetivo da Atividade

Aplicar os conhecimentos da Agenda 15 de Programação Mobile I, desenvolvendo um aplicativo com múltiplas telas, utilização de classes, passagem de objetos por `BindingContext`, formatação de dados e cálculos com datas e valores monetários.

---

**Desenvolvido por Gustavo Cipulo**  
📚 **Curso Técnico em Desenvolvimento de Sistemas — ETEC**  
📅 **2026**
