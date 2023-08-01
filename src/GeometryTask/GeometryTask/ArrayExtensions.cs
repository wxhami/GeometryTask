namespace GeometryTask;

public static class ArrayExtensions
{
    public static void Sort(this double[] sides)
    {
        double max = double.MinValue;
        for (int i = 0; i < sides.Length - 1; i++)
        {
            for (int j = i + 1; j < sides.Length; j++)
            {
                if (sides[i].CompareTo(sides[j]) > 0)
                {
                    max = sides[j];
                    sides[j] = sides[i];
                    sides[i] = max;
                }
            }
        }
    }
}