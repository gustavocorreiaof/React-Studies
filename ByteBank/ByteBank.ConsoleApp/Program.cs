using ByteBank.Common;
using System.Reflection;

MostrarBanner();

while (true)
{
    MostrarMenu();

    if (int.TryParse(Console.ReadLine(), out int escolha))
    {
        ExecutarEscolha(escolha);
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
    }
}

static void MostrarBanner()
{
    Console.WriteLine(@"


    ____        __       ____              __      
   / __ )__  __/ /____  / __ )____ _____  / /__    
  / __  / / / / __/ _ \/ __  / __ `/ __ \/ //_/    
 / /_/ / /_/ / /_/  __/ /_/ / /_/ / / / / ,<       
/_____/\__, /\__/\___/_____/\__,_/_/ /_/_/|_|      
      /____/                                       
                                
        ");
}

static void MostrarMenu()
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("1. Ler arquivo de boletos");
    Console.WriteLine();
    Console.WriteLine("2. Gravar Arquivo");
    Console.WriteLine();
    Console.WriteLine("3. Executar Pluguins");
    Console.WriteLine();
    Console.Write("Digite o número da opção desejada: ");
}

static void ExecutarEscolha(int escolha)
{
    switch (escolha)
    {
        case 1:
            LerArquivoBoletos();
            break;
        case 2:
            GravarGrupoBoletos();
            break;

        case 3:
            ExecutarPlugins();
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

static void LerArquivoBoletos()
{
    Console.WriteLine("Lendo arquivo de boletos...");

    var leitorDeBoleto = new LeitorDeBoleto();
    List<Boleto> boletos = leitorDeBoleto.LerBoletos("Boletos.csv");

    foreach (var boleto in boletos)
    {
        Console.WriteLine($"Cedente: {boleto.CedenteNome}, Valor: {boleto.Valor:#0.00}, Vencimento: {boleto.DataVencimento}");
    }
}

static void GravarGrupoBoletos()
{
    Console.WriteLine("Gravando arquivo de Boletos.");

    var leitorDeBoleto = new LeitorDeBoleto();
    List<Boleto> boletos = leitorDeBoleto.LerBoletos("Boletos.csv");

    //RelatorioDeBoleto gravadorDeCSV = new RelatorioDeBoleto("BoletosPorCedente.csv");
    //gravadorDeCSV.Processar(boletos);

    var nomeParametroContrutor = "nomeArquivoSaida";
    var parametroConstrutor = "BoletosPorCedente.csv";
    var nomeMetodo = "Processar";
    var parametroMetodo = boletos;

    ProcessarDinamicamente(nomeParametroContrutor, parametroConstrutor, nomeMetodo, parametroMetodo);
}

static void ProcessarDinamicamente(string nomeParametroContrutor, string parametroConstrutor, string nomeMetodo, List<Boleto> parametroMetodo)
{
    var tipoClasseRelatorio = typeof(RelatorioDeBoleto);
    var construtores = tipoClasseRelatorio.GetConstructors();

    foreach(var construtor in construtores)
    {
        Console.WriteLine($"Constructor: {construtor.Name}");
        Console.WriteLine($"N de parametros: {construtor.GetParameters().Length}");
    }

    var usedconstrutor = construtores.Single(c => c.GetParameters().Length == 1 && c.GetParameters()[0].Name == nomeParametroContrutor);

    var instanciaClasse = usedconstrutor.Invoke(new object[]{nomeParametroContrutor});


    var method = tipoClasseRelatorio.GetMethod(nomeMetodo);

    method.Invoke(instanciaClasse, new object[] { parametroMetodo });

}

static void ExecutarPlugins()
{
    //Ler boletos a partir do arquivo CSV
    var leitorDeCSV = new LeitorDeBoleto();
    List<Boleto> boletos = leitorDeCSV.LerBoletos("Boletos.csv");

    //Obter classes de plugin 
    List<Type> classesDePlugin = ObterClassesDePlugin<IRelatorio<Boleto>>();

    foreach (var classe in classesDePlugin)
    {
        // Criar uma instância do plugin
        var plugin = Activator.CreateInstance(classe, new object[] { "BoletosPorCedente.csv" });

        // Chamar o método Processar usando Reflection
        MethodInfo metodoSalvar = classe.GetMethod("Processar");
        metodoSalvar.Invoke(plugin, new object[] { boletos });
    }
}

static List<Type> ObterClassesDePlugin<T>()
{
    var tiposEncontrados = new List<Type>();

    Assembly assembly = Assembly.GetExecutingAssembly();

    Assembly assemblyDosPluguins = typeof(IRelatorio<Boleto>).Assembly;

    return tiposEncontrados;
}