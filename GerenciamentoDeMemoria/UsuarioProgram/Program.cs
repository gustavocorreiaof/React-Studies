using UsuarioLib;

Usuario usuario = new Usuario("Daniel", "daniel@email.com", new List<string>() { "12345678" });

usuario.ExibeTelefones();

usuario.PadronizaTelefones();

usuario.ExibeTelefones();

/*Stack = armazena valores de tipos primitivos(int, double,...) e referencia as propriedades na memoria
Heap = armazena valores de objetos na memoria 
LOH = Large Object Heap, basicamente um heap para objetos maiores, que ultrapassem os 85kb de memoria

Uma stack pode armazenar o local da memoria onde um valor esta sendo guardado. 
Quando criamos um usuario essa instancia fica armazenada numa stack que armazena
o local onde a heap dele armazena os seus dados.*/