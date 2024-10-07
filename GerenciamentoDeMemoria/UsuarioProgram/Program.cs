using System.Diagnostics;
using UsuarioLib;


#region Seção 1 e 2
/*Usuario usuario = new Usuario("Daniel", "daniel@email.com", new List<string>() { "12345678" });

usuario.ExibeTelefones();

usuario.PadronizaTelefones();

usuario.ExibeTelefones();

Stack = armazena valores de tipos primitivos(int, double,...) e referencia as propriedades na memoria
Heap = armazena valores de objetos na memoria 
LOH = Large Object Heap, basicamente um heap para objetos maiores, que ultrapassem os 85kb de memoria

Uma stack pode armazenar o local da memoria onde um valor esta sendo guardado. 
Quando criamos um usuario essa instancia fica armazenada numa stack que armazena
o local onde a heap dele armazena os seus dados.*/
#endregion

#region SEÇÃO 3
/*Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
for (int i = 0; i < 100000000; i++)
{
    Coordenada coordenada = new Coordenada(123.132, -123.456);
    var latitude = coordenada.Latitude;
    var longitude = coordenada.Longitude;
}

stopwatch.Stop();

Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalMilliseconds}");

O acesso a objetos na Heap é normalmente mais lento;
Utilizar o dotPeek a fim de inspecionar o código compilado pela nossa aplicação;
Structs são tipos de valor e por conta disso são armazenadas na Stack;
Structs são armazenadas na Stack e possuem tempo de acesso mais rápido.*/
#endregion

