// Lista para armazenar os itens
List<string> itens = new List<string>();

// TODO: Solicite os itens ao usuário
for (int i = 0; i <=2; i++)
{
    Console.WriteLine("Digite o nome do item que deseja cadastrar:");
    string nomeItem = Console.ReadLine();
    itens.Add(nomeItem);
}

// Exibe a lista de itens
Console.WriteLine("Lista de itens:");
foreach (string item in itens)
{
    Console.WriteLine($"- {item}");
}