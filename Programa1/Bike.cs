namespace Programa1
{
    class Bike
   {
        //declarações
        public string? Modelo { get; set; }

        public double Bateria { get; set; }

        public double PesoCiclista { get; set; }

        public int RecargaMes { get; set; }

        //Métodos(Ações)

        public double CalcularAutonomia()
        {
            double autonomiaBase = Bateria / 15.0;
            bool peso = PesoCiclista > 90;
            //Se o peso do ciclista for maior que 90 quilos reduza a autônomia
            //para 15% senão autonomia normal
            return peso ? (autonomiaBase * 0.05) : autonomiaBase;
        }

        public double CalcularConsumoMenasal()
        {
            double CargaPorKM = Bateria / 1000.0;
            return CargaPorKM * RecargaMes;
        }

        public double CalcularCustoMensal()
        {
            const double PRECO = 0.80;
            return CalcularConsumoMenasal() * PRECO;
        }

        public bool BikeEconomica()
        {
            return (CalcularCustoMensal() < 15.00) || (CalcularAutonomia() > 40);
        }
   }
}