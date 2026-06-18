# Conversor de Números Romanos

Este projeto é uma aplicação em C# desenvolvida para realizar a conversão bidirecional entre números arábicos (o nosso sistema decimal comum) e o sistema de numeração romana.

## Funcionalidades

- **Conversão de Arábico para Romano:** Converte números inteiros entre 1 e 3999 para o formato de numerais romanos.
- **Conversão de Romano para Arábico:** Converte strings de numerais romanos para o seu valor correspondente em números inteiros.
- **Validação:** Implementa as regras restritivas do sistema romano (limite de repetição de caracteres, regras de subtração para valores como IV, IX, XC, etc.).

## Regras Implementadas

O sistema segue rigorosamente as normas históricas da numeração romana:
1. **Valores Base:** I=1, V=5, X=10, L=50, C=100, D=500, M=1000.
2. **Repetição:** Os símbolos I, X, C e M podem ser repetidos até três vezes consecutivas.
3. **Soma:** Símbolos de menor valor à direita de um símbolo de maior valor são somados.
4. **Subtração:** Símbolos de menor valor à esquerda de um símbolo de maior valor são subtraídos (ex: IV, IX, XL, XC, CD, CM).

## Tecnologias Utilizadas

- **Linguagem:** C# (.NET)
- **Paradigma:** Orientação a Objetos com foco em lógica de algoritmos.
- **Ambiente:** Console Application (pode ser integrado em qualquer projeto .NET).

## Como Utilizar

O projeto é baseado na classe `ConversorRomano`. Para utilizá-lo em seu próprio código, basta chamar os métodos estáticos:

```csharp
// Exemplo de conversão para Romano
string romano = ConversorRomano.ParaRomano(1984); // Retorna "MCMXLIV"

// Exemplo de conversão para Arábico
int arabe = ConversorRomano.ParaArabico("MCMXLIV"); // Retorna 1984
