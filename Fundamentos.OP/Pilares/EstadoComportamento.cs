namespace Fundamentos.OOP.Pilares
{
    public class Carro
    {
        public string Modelo { get; set; }
        public int Quilometragem { get; set; }

        public void AdicionaQuilometragem()
        {
            Quilometragem =+ 300;
        }
    }
}