namespace GeometryTask;

public static class ArrayExtensions
{
    public static void Sort(this double[] sides)
    {
        double min = double.MinValue;
        for (int i = 0; i < sides.Length - 1; i++)
        {
            for (int j = i + 1; j < sides.Length; j++)
            {
                if (sides[i].CompareTo(sides[j]) > 0)
                {
                    min = sides[j];
                    sides[j] = sides[i];
                    sides[i] = min;
                }
            }
        }
    }
}