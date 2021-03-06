namespace Fundamentos.OOP.Classe_x_Objeto
{
    public class Carro
    {
        public string Cor { get; set; }
        public int QuantidadePortas { get; set; }
        public class Objeto {
            public Objeto()
            {
                 Carro objeto = new Carro();
                 objeto.Cor = "Branco";
                 objeto.QuantidadePortas = 4;
            }
        }
    }
}