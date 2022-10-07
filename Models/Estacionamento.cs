public class Estacionamento
{
    private decimal PrecoInicial = 0;
    private decimal PrecoPorHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        PrecoInicial = precoInicial;
        PrecoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        string placa;
        do
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            placa = Console.ReadLine();
        } while (placa == "");
        veiculos.Add(placa);
    }

    public void RemoverVeiculo()
    {
        if (veiculos.Any())
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = PrecoInicial + PrecoPorHora * horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }

    public void ListarVeiculos()
    {
        // Verifica se há veículos no estacionamento
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (string veiculo in veiculos)
            {
                System.Console.WriteLine(veiculo);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
