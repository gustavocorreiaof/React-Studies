using LibraryMenagement;

int i = 0;

Autor theuzin  = new Autor()
{
    Id = 0,
    Nome = "Theuzin"
};
Autor dieguin = new Autor()
{
    Id = 1,
    Nome = "Dieguin"
};

List<Autor> autores = new List<Autor>();
autores.Add(theuzin);
autores.Add(dieguin);

List<Livro> livros = new List<Livro>();
livros.Add(new Livro()
{
    Nome = "A arte da guerra.",
    autor = theuzin
});
livros.Add(new Livro()
{
    Nome = "Como vender drogas online.",
    autor = dieguin
});

List<Usuario> usuarios = new List<Usuario>();
List<Emprestimo> emprestimos = new List<Emprestimo>();

do
{
    Console.WriteLine("Qual ação deseja fazer?");
    Console.WriteLine("1 - Adicionar Livros;");
    Console.WriteLine("2 - Registrar emprestimo;");
    Console.WriteLine("3 - Devolver Livros;");
    Console.WriteLine("4 - Sair;");
    int action = int.Parse(Console.ReadLine());
    switch (action)
    {
        case 1:
            Console.WriteLine("Digite o nome do livro que deseja adicionar:");
            string NomeDoLivro = Console.ReadLine();


            Console.WriteLine("Digito id do nome do autor ao qual publicou esse livro:");
            string NomeDoAutor = Console.ReadLine();

            if (autores.First(x => x.Nome == NomeDoAutor) == null)
                Console.WriteLine("Autor nao existe!"); //nessa area eu podia adicionar um trecho dizendo pra digitar um autor valido ou sair para o menu ou ate mesmo cadastrar um novo autor mas n da tempo n

            livros.Add(new Livro() { Nome = NomeDoLivro, autor = autores.First(x => x.Nome == NomeDoAutor) });

            Console.WriteLine("Livro cadastrado");
            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("Digite o nome do livro que deseja criar o emprestimo");
            string NomeDoLivroEmprestimo = Console.ReadLine();

            if (livros.First(x => x.Nome == NomeDoLivroEmprestimo) == null)
                Console.WriteLine("Livro nao existe!");

            //verificaria dentro da lista atual de emprestimos se ha algum emprestimo vinculado aquele livro. Se sim, informaria ao usuario que nao é possivel emprestar aquele livro, se nao continuaria.

            Console.WriteLine("Digite o Id do usuario ao qual o livro vai ser emprestado:");
            int idDoUsuario = int.Parse(Console.ReadLine());

            Emprestimo emprestimo = new Emprestimo()
            {
                LivroEmprestado = livros.First(x => x.Nome == NomeDoLivroEmprestimo),
                Usuario = usuarios.First(x => x.Id == idDoUsuario)
            };

            emprestimos.Add(emprestimo);
            break;
        case 3:
            Console.WriteLine("Digite o nome do livro a ser devolvido");
            string NomeDoLivroDevolvido = Console.ReadLine();

            emprestimos.Remove(emprestimos.FirstOrDefault(x => x.LivroEmprestado.Nome == NomeDoLivroDevolvido));
            break;
        case 4: 
            i = 1;
            break;

    }
}
while (i == 0);