using GerenciadorDeArquivosApp.Entities;

string caminhoOrigem, caminhoDestino;
bool retry = true;


while (retry)
{

    try
    {
        Dictionary<int, string> opcoesPossiveis = new Dictionary<int, string> {
        { 1, "Organizar arquivos - Metódo OrganizeFiles" },
        { 2, "Analisar extensoes - Método AnalyzeExtensions"},
        { 3, "LogActivity"},
        { 4, "Sair"}   };

        Console.WriteLine("Digite alguma opção de serviço:\r\n ");

        foreach (var x in opcoesPossiveis)
            Console.WriteLine($"{x.Key} - {x.Value}");


        var opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                OrganizeFiles();
                break;

            case "2":
                AnalyzeExtensions();
                break;

            case "3":
                Console.WriteLine("Opção não implementada. \r\n\r\n");
                break;

            case "4":
                retry = false;
                break;

            default:
                Console.WriteLine("Opção inválida! Tente novamente...\r\n\r\n");
                break;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro inesperado!\r\n\r\n\r\nMensagem de erro: {ex.Message}");
        Console.WriteLine($"Por favor, tente novamente.");
        Console.WriteLine($"------------------------------------------------\r\n\r\n\r\n");
        
    }


}


#region FUNCIONALIDADES
void OrganizeFiles()
{
    Console.WriteLine("Por favor digite o caminho Origem");
    caminhoOrigem = Console.ReadLine() ?? "";

    Console.WriteLine("Por favor digite o caminho Destino");
    caminhoDestino = Console.ReadLine() ?? "";

    if (string.IsNullOrEmpty(caminhoOrigem) || string.IsNullOrEmpty(caminhoDestino))
    {
        Console.WriteLine("Atenção, os caminhos não foram digitados corretamente! Tente novamente...");
    }
    else
    {
        FileOrganizer.OrganizeFiles(caminhoOrigem, caminhoDestino);
        Console.WriteLine($"Arquivos organizados com sucesso!");
        Console.WriteLine($"------------------------------------------------\r\n\r\n\r\n");
    }
}

void AnalyzeExtensions()
{

    Console.WriteLine("Por favor digite o diretorio para analise dos arquivos");
    var pathAnalyze = Console.ReadLine() ?? "";


    var result = FileAnalyzer.AnalyzeExtensions(pathAnalyze);


    foreach (var ext in result)
    {
        Console.WriteLine($"Extensão: {ext.Key}");
        Console.WriteLine($"Qtde arquivos: {ext.Value}");
        Console.WriteLine($"------------------------------------------------\r\n\r\n\r\n");
    }
}

#endregion