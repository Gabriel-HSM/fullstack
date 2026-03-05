using Udemy_Delegate.services;

//Delegate é um tipo.
// *Tipo referência (para um ou mais métodos)
//*Usado para comunicação entre objetos de forma flexivel e extensivo (eventos/callbacks)
//*Usado tbm para parametrização de operações por métodos (Programação Funcional) (função como parâmetro para outra função )


//Predefinidos:
// Action
// Func
// Predicate

delegate double BinaryNumericOperation(double n1, double n2);

class program
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        BinaryNumericOperation op = CalculationService.Max;
        // BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum)

        double result = op(a,b);
        // double result = op.Invoke(a,b);
        
        Console.WriteLine(result);
    }
}
