// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


bool repate = false;
string caratteriDoppi = "riccdrdino";
for (int i = 0; i < caratteriDoppi.Length; i++)
{
    repate = false;
    for (int j = 0; j < caratteriDoppi.Length; j++)
    {
        if ((i != j) && (caratteriDoppi[i] == caratteriDoppi[j]))
        {
            repate = true;
            Console.WriteLine($"Questo carattere {caratteriDoppi[j]} si ripete");
        }
    }

    if (!repate)
    {
        Console.WriteLine($"il primo carattre che non si ripete è {caratteriDoppi[i]}");
        break;
    }
}



Console.ReadLine();