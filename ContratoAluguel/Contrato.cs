using Common;

namespace ContratoAluguel
{
    public class Contrato
    {
        public int NumId { get; private set; }
        public ICliente Contratante { get; set; }
        public IVeiculo CarroContratado { get; set; }
        private int Valor { get; set; }

        public Contrato()
        {
            NumId = GerarNumId();
            Valor = 0;
        }

        public void DefinirValor(int novoValor) => Valor = novoValor;

        public void GerarContrato(ICliente contratante, IVeiculo carroContratado)
        {
            Contratante = contratante;
            CarroContratado = carroContratado;
        }
        private static int contadorNumId = 0;
        private static int GerarNumId() => contadorNumId++;
        public void MostrarContrato(ICliente contratante, IVeiculo carroContratado)
        {
            Console.WriteLine($"Contrato ID: {NumId}");
            Console.WriteLine($"Contratante: {Contratante.Nome}"); // Assuming ICliente has a property 'Nome'
            Console.WriteLine($"Veículo Contratado: {CarroContratado.Nome}"); // Assuming IVeiculo has a property 'Modelo'
            Console.WriteLine($"Valor: {Valor:C}"); // Assuming Valor is in currency format
        }

    }
}
