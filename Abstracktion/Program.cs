namespace Abstracktion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition= new Addition();
            addition.Operate(5,2);



            Substraction substraction= new Substraction();
            substraction.Operate(5, 2);




            Multiplication multiplication= new Multiplication();    
            multiplication.Operate(5, 2);   




            Division division= new Division();  
            division.Operate(5, 2);
        }
    }
}