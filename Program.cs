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