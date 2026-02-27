// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao MiniMetacritic!");

var titulos = new List<Title>();


while (true)
{
    Console.WriteLine(
    """
    Digite a opção desejada:
    1 - Cadastrar Titulo Completo
    2 - Cadastrar Titulo Simplificado
    3 - Mostrar Titulo
    0 - Sair
    """);

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "0":
            Environment.Exit(0);
            break;
        case "1":
            CadastrarTituloCompleto();
            break;
        case "2":
            CadastrarTituloSimplificado();
            break;
        case "3":
            Console.WriteLine($"===TITULOS===");
            titulos.ForEach(titulo => Console.WriteLine(titulo));
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void CadastrarTituloCompleto()
{
    try
    {
        Title novoTitulo;

        Console.WriteLine("""
        ===DIGITE O TIPO DE TITULO===)
        1 - JOGO
        2 - FILME
        3 - SÉRIE
        """);
        var tipo = Console.ReadLine();
        switch (tipo)
        {
            case "1":
                novoTitulo = new Game("Sem nome");
                break;
            case "2":
                novoTitulo = new Movie("Sem nome");
                break;
            case "3":
                novoTitulo = new TvShow("Sem nome");
                break;
            default:
                Console.WriteLine("Opção inválida");
                return;
        }

        Console.WriteLine("===NOVO CADASTRO DE TITULO===");
        Console.WriteLine("===DIGITE O NOME DO TITULO===");
        var nome = Console.ReadLine();
        Console.WriteLine("===DIGITE O DATA DE LANÇAMENTO DO TITULO (YYYY-MM-DD)===");
        var dataDeLancamento = Console.ReadLine();
        Console.WriteLine("===DIGITE A NOTA DOS CRITICOS DO TITULO===");
        var metaScore = Console.ReadLine();
        Console.WriteLine("===DIGITE A NOTA DO PUBLICO DO TITULO===");
        var userScore = Console.ReadLine();

        if (novoTitulo is Game)
        {
            Console.WriteLine("===DIGITE PLATAFORMA DO JOGO===");
            ((Game)novoTitulo).Plataform = Console.ReadLine();
        }
        else if (novoTitulo is Movie)
        { 
            Console.WriteLine("===DIGITE A DURAÇÃO DO JOGO===");
            ((Movie)novoTitulo).Duration = int.Parse(Console.ReadLine());
        }

        titulos.Add(novoTitulo);


        Console.WriteLine("===CADASTRO REALIZADO COM SUCESSO===");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"===ERRO AO CADASTRAR TITULO: {ex.Message}===");
    }
}

void CadastrarTituloSimplificado()
{
    try
    {
        Console.WriteLine("===NOVO CADASTRO DE TITULO===");
        Console.WriteLine("===DIGITE O NOME DO TITULO===");
        var nome = Console.ReadLine();

        Console.WriteLine("""
        ===DIGITE O TIPO DE TITULO===)
        1 - JOGO
        2 - FILME
        3 - SÉRIE
        """);
        var tipo = Console.ReadLine();
        switch (tipo)
        {
            case "1":
                titulos.Add(new Game(nome));
                break;
            case "2":
                titulos.Add(new Movie(nome));
                break;
            case "3":
                titulos.Add(new TvShow(nome));
                break;
            default:
                Console.WriteLine("Opção inválida");
                return;

        }

        Console.WriteLine("===CADASTRO REALIZADO COM SUCESSO===");
    }
    catch (Exception ex)
    { 
        Console.WriteLine($"===ERRO AO CADASTRAR TITULO: {ex.Message}===");
    }
}