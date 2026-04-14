# Exercício de ProjOO - Padrão Decorator (Sistema de Cafeteria)

Este repositório contém a minha resolução para o exercício sobre o padrão de projeto **Decorator**, aplicado a um sistema de bebidas personalizadas, conforme a atividade do Prof. Fábio Fagundes Silveira.

## O que eu fiz no projeto:
A ideia foi criar um sistema para uma cafeteria onde o cliente pode montar sua própria bebida. Em vez de criar uma classe para cada combinação possível, usei o **Decorator**. 

Com esse padrão, eu consigo "envolver" um café simples com vários adicionais (como chantilly e chocolate). O sistema calcula o preço final somando o valor de cada camada e monta a descrição da bebida automaticamente.

## Estrutura dos arquivos:

- **Bebida.cs**: Define a classe abstrata base e o nosso "item real", que é o Café Expresso.
- **AdicionalDecorator.cs**: É a classe base para os complementos. Ela garante que um adicional continue sendo tratado como uma "Bebida".
- **Adicionais.cs**: Aqui estão as classes `Chantilly` e `Chocolate`. Elas adicionam seu próprio custo e nome ao café que estão decorando.
- **Program.cs**: Arquivo de teste onde eu montei um pedido personalizado, "embrulhando" o café com os adicionais para ver o preço e a descrição mudarem.

## Como rodar o código:
O repositório contém o arquivo de projeto (`.csproj`). Para executar e ver a mágica dos preços somando no terminal, basta digitar:

```bash
dotnet run
