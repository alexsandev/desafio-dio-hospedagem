using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Reserva> reservas = new List<Reserva>();

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes1 = new()
{
    new Pessoa { Nome = "Hóspede 1" },
    new Pessoa { Nome = "Hóspede 2" },
};

List<Pessoa> hospedes2 = new()
{
    new Pessoa { Nome = "Hóspede 1" },
    new Pessoa { Nome = "Hóspede 2" },
    new Pessoa { Nome = "Hóspede 3" },
    new Pessoa { Nome = "Hóspede 4" },
    new Pessoa { Nome = "Hóspede 5" },
    new Pessoa { Nome = "Hóspede 6" },
    new Pessoa { Nome = "Hóspede 7" },
    new Pessoa { Nome = "Hóspede 8" },
    new Pessoa { Nome = "Hóspede 9" },
    new Pessoa { Nome = "Hóspede 10" },
    new Pessoa { Nome = "Hóspede 11" },
    new Pessoa { Nome = "Hóspede 12" },
};

List<Pessoa> hospedes3 = new()
{
    new Pessoa { Nome = "Hóspede 1" },
    new Pessoa { Nome = "Hóspede 2" },
    new Pessoa { Nome = "Hóspede 3" },
    new Pessoa { Nome = "Hóspede 4" },
    new Pessoa { Nome = "Hóspede 5" },
};

List<Pessoa> hospedes4 = new()
{
    new Pessoa { Nome = "Hóspede 1" },
    new Pessoa { Nome = "Hóspede 2" },
    new Pessoa { Nome = "Hóspede 3" },
    new Pessoa { Nome = "Hóspede 4" },
    new Pessoa { Nome = "Hóspede 5" },
};

List<Pessoa> hospedes5 = new()
{
    new Pessoa { Nome = "Hóspede 1" },
    new Pessoa { Nome = "Hóspede 2" },
    new Pessoa { Nome = "Hóspede 3" },
    new Pessoa { Nome = "Hóspede 4" },
    new Pessoa { Nome = "Hóspede 5" },
    new Pessoa { Nome = "Hóspede 6" },
    new Pessoa { Nome = "Hóspede 7" },
    new Pessoa { Nome = "Hóspede 8" },
    new Pessoa { Nome = "Hóspede 9" },
};

// Cria a suíte
Suite suite1 = new Suite(tipoSuite: "Premium Love", capacidade: 2, valorDiaria: 300);
Suite suite2 = new Suite(tipoSuite: "Party", capacidade: 15, valorDiaria: 600);
Suite suite3 = new Suite(tipoSuite: "Basico", capacidade: 5, valorDiaria: 100);
Suite suite4 = new Suite(tipoSuite: "Premium", capacidade: 6, valorDiaria: 200);
Suite suite5 = new Suite(tipoSuite: "Master", capacidade: 4, valorDiaria: 300);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva1 = new Reserva(diasReservados: 5);
reserva1.CadastrarSuite(suite1);
reserva1.CadastrarHospedes(hospedes1);
reservas.Add(reserva1);

Reserva reserva2 = new Reserva(diasReservados: 5);
reserva2.CadastrarSuite(suite2);
reserva2.CadastrarHospedes(hospedes2);
reservas.Add(reserva2);

Reserva reserva3 = new Reserva(diasReservados: 10);
reserva3.CadastrarSuite(suite3);
reserva3.CadastrarHospedes(hospedes3);
reservas.Add(reserva3);

Reserva reserva4 = new Reserva(diasReservados: 10);
reserva4.CadastrarSuite(suite4);
reserva4.CadastrarHospedes(hospedes4);
reservas.Add(reserva4);

try
{
    Reserva reserva5 = new Reserva(diasReservados: 5);
    reserva5.CadastrarSuite(suite5);
    reserva5.CadastrarHospedes(hospedes5);
    reservas.Add(reserva5);
}
catch (Exception ex)
{
    Console.WriteLine($"Não foi possível cadastrar a reserva 5: {ex.Message}");
    Console.WriteLine("------------------------------");
}

// Exibe a quantidade de hóspedes e o valor da diária
foreach (var reserva in reservas)
{
        Console.WriteLine($"Suite: {reserva.Suite.TipoSuite}");
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total: {reserva.CalcularValorTotal()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
        Console.WriteLine("------------------------------");
}
