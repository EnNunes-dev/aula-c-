using Programa1;

Console.WriteLine(" **** SISTEMA DA LOJA DE BIKE ***");
Console.WriteLine();

// INSTANCIANDO O OBJETO DA CLASSE
Bike bike = new Bike();

Console.WriteLine("Modelo Bike:");
bike.Modelo = Console.ReadLine();

Console.WriteLine("Capacidade da Bateria:");
bike.Bateria = double.Parse(Console.ReadLine());

Console.WriteLine("Peso do Ciclista:");
bike.PesoCiclista = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quantidade de Recargas por Mês:");
bike.RecargaMes = int.Parse(Console.ReadLine());

//Exibir Resultado na Tela

Console.WriteLine("\n--Relatório de desempenho da Bike");
Console.WriteLine($"Bicicleta:{bike.Modelo.ToUpper()}");
Console.WriteLine($"Autonomia Estimada:{bike.CalcularAutonomia():F1}por carga");
Console.WriteLine($"Consumo Mensal: {bike.CalcularConsumoMenasal():F2}KWm");
Console.WriteLine($"Custo Mensal: {bike.CalcularCustoMensal():N2}");
Console.WriteLine($"A bike é Economica:{bike.BikeEconomica}");
