namespace Calculadora_Client
{
    internal class Operacion
    {
        public Operacion()
        {
        }

        public Operacion(string pTipo, int pNumA, int pNumB)
        {
            tipo_op = pTipo;
            numA = pNumA;
            numB = pNumB;
            resultado = 0;
        }

        public string tipo_op { get; set; }
        public int numA { get; set; }
        public int numB { get; set; }
        public int resultado { get; set; }
    }
}
