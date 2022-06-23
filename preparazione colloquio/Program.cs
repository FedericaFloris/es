// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//In una Classe Esercizio1 scrivere un metodo minVettore che riceve in ingresso un Array di interi e 
//restituisce il minimo degli interi presenti nell’Array.



int[] v = { 1, 12, 4, 2, 7 };
int minore = RestituisciMinimo(v);
Console.WriteLine($"Il minimo è {minore}");

int RestituisciMinimo(int[] v)
{
    int minore = v[0];
    for (int i = 1; i < v.Length - 1; i++)
    {
        if (v[i] < minore)
        {
            minore = v[i];
        }
    }
    return minore;
}


//Scrivere un programma in C che legge un 
//vettore di interi di dimensione fissata e ne 
//stampa la somma


int somma = RestituisciSomma(v);
Console.WriteLine(somma);

int RestituisciSomma(int[] v)
{
    int somma = 0;
    for(int i=0; i<v.Length; i++)
    {
        somma = somma + v[i];
    }
    return somma;
}

//Scrivere un programma in C che legge un 
//vettore di interi di dimensione fissata, inverte 
//il vettore e lo stampa. 

VettoreInvertito(v);

void VettoreInvertito(int[] v)
{
    
    for(int i = 0; i < v.Length/2; i++)
    {
        int temp = v[i];
        v[i] = v[v.Length-1-i];
        v[v.Length - i-1] = temp;
    }

    for(int i=0; i < v.Length; i++)
    {
        Console.WriteLine(v[i]);
    }

}

//Scrivere un programma C che legge un vettore 
//di lunghezza arbitraria e stampa 1 se il vettore 
//contiene solo valori diversi, 0 altrimenti.
int[] t = { 2,1 , 3, 2, 4, 5 };
Console.WriteLine("----------------------------------");
int controllo = CaratteriDiversi(v);
Console.WriteLine(controllo);
int CaratteriDiversi(int[] v) 
{
    int valore = 0;
    for (int j = 0; j < v.Length; j++)
    {
        for (int i = 1; i < v.Length ; i++)
        {
            if (v[i] == v[j])
            {
                valore++;
            }


        }
    }
    if (valore == 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }


}


//  Si scriva un programma C che all'interno del main consenta di 
//inizializzare da tastiera un vettore di interi di lunghezza massima 
//pari a 20. 
//• La lunghezza effettiva della sequenza acquisita è stabilita dall'utente 
//(ad esempio, acquisendo da tastiera il valore di una variabile n). 
//• Il programma dovrà stampare il vettore, scorrere il vettore e 
//stampare gli elementi del vettore che hanno un numero pari nella 
//posizione immediatamente precedente alla propria. 
//• Per esempio, se l'utente sceglie di inserire 10 valori, avendo letto in 
//input e memorizzato nell'array i seguenti interi: 
//1 2 3 4 5 6 7 8 9 0 
//Il programma produrrà il seguente output: 
//1 2 3 4 5 6 7 8 9 0
//3 5 7 9
Console.WriteLine("----------------------------------");
int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
Scorri(x);
void Scorri(int [] v)
{
    for(int i = 0; i < v.Length; i++)
    {
        Console.Write(v[i]+" " );
    }
    Console.WriteLine("");
   for(int i=1; i < v.Length; i++)
   {
        if (v[i - 1] % 2 ==0)
        {
            Console.Write(v[i] + " ");
        }
      
   }
}




