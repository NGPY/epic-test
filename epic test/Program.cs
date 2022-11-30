namespace Program
{
    class Program
    {
        static string TemperatureCheck(float MinTemp, float MaxTemp, float CurTemp)
        {
            if (CurTemp > MaxTemp || CurTemp < MinTemp)
            {
                return "Temperature not within range";
            }
            else
            {
                return "Temperature within range";
            }
        }
        static void Fibonacci(Int32 n)
        {
            Int32 d1 = 0;
            Int32 d2 = 1;
            Int32 placeholder = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(d1);
                placeholder = d2;
                d2 = d1 + d2;
                d1 = placeholder;
            }
        }
        static bool IsTriangular(Int32 n)
        {
            Int32 step = 1;
            Int32 triangleN = 1;
            for (int i = 0; i < n; i++)
            {
                if (triangleN == n)
                {
                    return true;
                }
                step++;
                triangleN += step;

            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsTriangular(1));
            Console.WriteLine(IsTriangular(5));
            Console.WriteLine(IsTriangular(21));
        }
    }
}