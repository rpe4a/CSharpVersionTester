using System.Linq.Expressions;

namespace ExtendedPropertyPatterns;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            Do();
        }
        catch (Exception e)
        {
            if (e is MethodCallExpression { Method.Name: "MethodName" })
        }
    }
}