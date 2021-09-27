
public class FactFilter
{
    public static int fact(int factorial)
    {

        if (factorial <= 1)
            return factorial;

        int total = factorial;
        while (factorial > 1)
        {
            factorial--;
            total *= factorial;
        }
        return total;
    }

    public static int[] facts(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = fact(xs[i]);
        }
        return result;
    }
}

