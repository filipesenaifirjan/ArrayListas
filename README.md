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
copiando um array para outro:

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine("Percorrendo o array com for");

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N {contador} - {arrayInteiros[contador]}");
}
-----------------------------------------------------------------
Trabalhando com listas com for e foreach:

List <string> listaString = new List<string>();

//Essa é a sintaxe de uma lista, não precisa determinar uma capacidade pra ela

listaString.Add("RJ");
listaString.Add("ES");
listaString.Add("MG");

Console.WriteLine("Percorrendo a lista com o for");
for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N {contador} - {listaString[contador]}");
}
Console.WriteLine("Percorrendo a lista com o foreach");
int contadorForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição N {contadorForeach} - {item}");
    contadorForeach++;
}
-------------------------------------------------------------



