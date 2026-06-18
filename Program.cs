using System;


Console.WriteLine("--- Iniciando Conversor ---");

try 
{
    int numeroArabe = 1984;
    string romano = ConversorRomano.ParaRomano(numeroArabe);
    Console.WriteLine($"{numeroArabe} convertido para romano: {romano}");

    string romanoEntrada = "MCMXLIV";
    int arabe = ConversorRomano.ParaArabico(romanoEntrada);
    Console.WriteLine($"{romanoEntrada} convertido para arábico: {arabe}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}


public class ConversorRomano
{
    private static readonly (int valor, string simbolo)[] MapaRomanos =
    {
        (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
        (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
        (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
    };

    public static string ParaRomano(int numero)
    {
        if (numero < 1 || numero > 3999)
            throw new ArgumentOutOfRangeException(nameof(numero), "O número deve estar entre 1 e 3999.");

        string resultado = "";
        foreach (var item in MapaRomanos)
        {
            while (numero >= item.valor)
            {
                resultado += item.simbolo;
                numero -= item.valor;
            }
        }
        return resultado;
    }

    public static int ParaArabico(string romano)
    {
        if (string.IsNullOrWhiteSpace(romano)) return 0;
        
        romano = romano.ToUpper();
        int total = 0;
        int i = 0;

        while (i < romano.Length)
        {
            int atual = ValorSimbolo(romano[i]);
            
            if (i + 1 < romano.Length)
            {
                int proximo = ValorSimbolo(romano[i + 1]);
                if (proximo > atual)
                {
                    total += (proximo - atual);
                    i += 2;
                    continue;
                }
            }
            total += atual;
            i++;
        }
        return total;
    }

    private static int ValorSimbolo(char c) => c switch
    {
        'I' => 1, 'V' => 5, 'X' => 10, 'L' => 50,
        'C' => 100, 'D' => 500, 'M' => 1000,
        _ => 0
    };
}