namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string veiculoAdicionado = Console.ReadLine();
            veiculos.Add(veiculoAdicionado);
            Console.WriteLine($"Veículo {veiculoAdicionado} cadastrado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para remover:");

            int horasEstacionadas;
            string placaSolicitadaParaRemocao = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaSolicitadaParaRemocao.ToUpper()))
            {


                while (true)
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    if (int.TryParse(Console.ReadLine(), out horasEstacionadas))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Por favor, insira um número inteiro válido.");                
                    }

                }
            }
            else
            {
                horasEstacionadas = 0;
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

            decimal valorTotal = precoInicial + precoPorHora * horasEstacionadas;
            veiculos.Remove(placaSolicitadaParaRemocao);
            Console.WriteLine($"O veículo {placaSolicitadaParaRemocao} foi removido e o preço total foi de: R$ {valorTotal}");
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}