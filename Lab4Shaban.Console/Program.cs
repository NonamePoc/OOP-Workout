using Lab4Shaban.Lib;

namespace Lab4Shaban.Console
{
    public class Program
    {
        public static void Main()
        {
            Ray ray1 = new Ray(1, 1, 1, 1);
            Ray ray2 = new Ray(1, 1, 1, 1);
            var resultIsParallel = Ray.IsParallel(ray1, ray2);
            ray2.AddVertexValue(new Point(2,2));
            var isEquals = ray1.Equals(ray2);
        }
    }
}