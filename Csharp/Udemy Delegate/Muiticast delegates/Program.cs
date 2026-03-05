//Delegates que guardam referência para mais de um método

//Para adicionar uma referência, pode-se usar o operador +=

//A chamada Invoke (ou sintaxe reduzida) executa todos os métodos na ordem em que foram adicionados

//Uso faz sentido para métodos void

using Muiticast_delegates.Services;

delegate void BinaryNumericOperation(double n1, double n2);

class Program
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        BinaryNumericOperation op = CalculationService.ShowSum;
        op += CalculationService.ShowMax;

        op.Invoke(a, b);
        //op(a,b);
    }
}