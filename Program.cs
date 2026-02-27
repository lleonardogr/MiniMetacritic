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
            titulos.ForEach(titulo => Console.WriteLine(titulo.Name));
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
        Console.WriteLine("===NOVO CADASTRO DE TITULO===");
        Console.WriteLine("===DIGITE O NOME DO TITULO===");
        var nome = Console.ReadLine();
        Console.WriteLine("===DIGITE O DATA DE LANÇAMENTO DO TITULO (YYYY-MM-DD)===");
        var dataDeLancamento = Console.ReadLine();
        Console.WriteLine("===DIGITE A NOTA DOS CRITICOS DO TITULO===");
        var metaScore = Console.ReadLine();
        Console.WriteLine("===DIGITE A NOTA DO PUBLICO DO TITULO===");
        var userScore = Console.ReadLine();

        titulos.Add(new(nome, DateTime.Parse(dataDeLancamento),
            int.Parse(metaScore),
            int.Parse(userScore)));


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
        titulos.Add(new(nome));
        Console.WriteLine("===CADASTRO REALIZADO COM SUCESSO===");
    }
    catch (Exception ex)
    { 
        Console.WriteLine($"===ERRO AO CADASTRAR TITULO: {ex.Message}===");
    }
}