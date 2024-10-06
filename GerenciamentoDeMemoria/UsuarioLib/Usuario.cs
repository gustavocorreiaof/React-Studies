using System.Diagnostics;

namespace UsuarioLib
{
    public  class Usuario
    {
        public Usuario(string nome, string email, List<string> telefones) 
        {
            Nome = nome;
            Email = email;
            Telefones = telefones;
            
            ChavesDeAcesso = new List<Guid>(new Guid[10]);
            ChavesDeAcessoLinked = new LinkedList<Guid>(new Guid[10]);
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for(int i = 0; i<100000; i++)
            {
                ChavesDeAcesso.Insert(1, Guid.NewGuid());
            }
            sw.Stop();
            Console.WriteLine($"O tempo para fazer a lista de Guid foi: { sw.Elapsed.TotalMilliseconds}");

            ChavesDeAcessoLinked = new LinkedList<Guid>(new Guid[10]);
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();

            for (int i = 0; i < 100000; i++)
            {
                ChavesDeAcessoLinked.AddAfter(ChavesDeAcessoLinked.First, Guid.NewGuid());
            }
            sw1.Stop();
            Console.WriteLine($"O tempo para fazer a LinkedList de Guid foi: {sw1.Elapsed.TotalMilliseconds}");

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<string> Telefones { get; set; }
        public List<Guid> ChavesDeAcesso { get; set; }
        public LinkedList<Guid> ChavesDeAcessoLinked { get; set; }

        public void PadronizaTelefones()
        {
            Telefones = Telefones.Select(telefone =>
                telefone.Length == 8 ?
                telefone = "9" + telefone : telefone
            ).ToList();
        }

        public void ExibeTelefones()
        {
            Telefones.ForEach(telefone => Console.WriteLine(telefone));
        }
    }
}
