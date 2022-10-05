# ArrayListas
Array e Listas
-----------------------------------------------------
implementando um array de inteiros:

Percorrendo com for e foreach:

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//arrayInteiros[3] = 1;



Console.WriteLine("Percorrendo o array com for");

for(int contador = 0; contador < arrayInteiros.Length; contador++)   
{
    Console.WriteLine($"Posição N {contador} - {arrayInteiros[contador]}");
}
int contadorForeach = 0;

Console.WriteLine("Percorrendo o array com foreach");
foreach(int valor in arrayInteiros){
Console.WriteLine($"Posição N {contadorForeach} - {valor}");
contadorForeach++;

}
-----------------------------------------------------------------
redimensionando um array:

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//arrayInteiros[3] = 1;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine("Percorrendo o array com for");

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N {contador} - {arrayInteiros[contador]}");
}
----------------------------------------------------------
