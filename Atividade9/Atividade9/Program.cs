string[] nomes = { "Ana", "Bruno", "Carla", "Daniel", "Eva" };


Console.WriteLine("Digite um nome para pesquisar:");
string nomeParaPesquisar = Console.ReadLine();


bool nomeEncontrado = false;

foreach (string nome in nomes)
{
    
    if (nome.ToLower() == nomeParaPesquisar.ToLower())
    {
        nomeEncontrado = true;
        break; 
    }
}

if (nomeEncontrado)
{
    Console.WriteLine($"O nome {nomeParaPesquisar} foi encontrado .");
}
else
{
    Console.WriteLine($"O nome {nomeParaPesquisar} não está .");
}