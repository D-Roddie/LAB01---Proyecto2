namespace Calculadora_API.Models
{
    public class Operacion
    {
        public Operacion() //Constructor vacío.
        {
        }

        public Operacion(string tipo, int pNumA, int pNumB)
        {
            tipo_op = tipo;
            numA = pNumA;
            numB = pNumB;
        }

        public string tipo_op { get; set; }
        public int numA { get; set; }
        public int numB { get; set; }
        public int resultado { get; set; }

        public Operacion procesar(Operacion op)
        {
            switch (op.tipo_op)
            {
                case "Suma":
                    op.resultado = op.numA + op.numB;
                    break;
                case "Resta":
                    op.resultado = op.numA - op.numB;
                    break;
                case "Multiplicacion":
                    op.resultado = op.numA * op.numB;
                    break;
                case "Division":
                    op.resultado = op.numA / op.numB;
                    break;
            }

            return op;
        }
    }
}