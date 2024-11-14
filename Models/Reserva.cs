namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = new List<Pessoa>();
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"A suite não suporta a capacidade de hospedes indicada. /n Hospedes:{hospedes.Count} Capacidade da Suite:{Suite.Capacidade} ");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes() => Hospedes.Count;

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria ;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            decimal valorDesconto = valor;
            if (DiasReservados >= 10)
            {
                 valorDesconto = valor * 0.9M;
                Console.WriteLine($"Parabens! Por ficar acima de 10 dias você ganhou um desconto! Valor Original: {valor} Valor Com Desconto: {valorDesconto}");
            }

            return valorDesconto;
        }
    }
}