using System;

namespace StructBench
{
    class Program
    {
        static void Main(string[] args)
        {
            const int loop = 1000000000;
            Console.WriteLine("[2D]");
            {
                var v1 = new Vector2D() { X = 1, Y = 2 };
                var v2 = new Vector2D() { X = 3, Y = 4 };
                var sum = 0.0;
                var start = DateTime.Now;
                for (var i = 0; i < loop; i++)
                {
                    sum += v1.DotCopyNotInline(v2);
                }
                var end = DateTime.Now;
                Console.WriteLine($"{end - start} DotCopyNotInline({sum})");
            }
            {
                var v1 = new Vector2D() { X = 1, Y = 2 };
                var v2 = new Vector2D() { X = 3, Y = 4 };
                var sum = 0.0;
                var start = DateTime.Now;
                for (var i = 0; i < loop; i++)
                {
                    sum += v1.DotCopyInline(v2);
                }
                var end = DateTime.Now;
                Console.WriteLine($"{end - start} DotCopyInline({sum})");
            }
            {
                var v1 = new Vector2D() { X = 1, Y = 2 };
                var v2 = new Vector2D() { X = 3, Y = 4 };
                var sum = 0.0;
                var start = DateTime.Now;
                for (var i = 0; i < loop; i++)
                {
                    sum += v1.DotInNotInline(v2);
                }
                var end = DateTime.Now;
                Console.WriteLine($"{end - start} DotInNotInline({sum})");
            }
            {
                var v1 = new Vector2D() { X = 1, Y = 2 };
                var v2 = new Vector2D() { X = 3, Y = 4 };
                var sum = 0.0;
                var start = DateTime.Now;
                for (var i = 0; i < loop; i++)
                {
                    sum += v1.DotInInline(v2);
                }
                var end = DateTime.Now;
                Console.WriteLine($"{end - start} DotInInline({sum})");
            }

            Console.WriteLine("[4D]");
            {
                var v1 = new Vector4D() { W = 1, X = 2, Y = 3, Z = 4 };
                var v2 = new Vector4D() { W = 5, X = 6, Y = 7, Z = 8 };
                var sum = 0.0;
                var start = DateTime.Now;
                for (var i = 0; i < loop; i++)
                {
                    sum += v1.DotCopyNotInline(v2);
                }
                var end = DateTime.Now;
                Console.WriteLine($"{end - start} DotCopyNotInline({sum})");
            }
            {
                var v1 = new Vector4D() { W = 1, X = 2, Y = 3, Z = 4 };
                var v2 = new Vector4D() { W = 5, X = 6, Y = 7, Z = 8 };
                var sum = 0.0;
                var start = DateTime.Now;
                for (var i = 0; i < loop; i++)
                {
                    sum += v1.DotCopyInline(v2);
                }
                var end = DateTime.Now;
                Console.WriteLine($"{end - start} DotCopyInline({sum})");
            }
            {
                var v1 = new Vector4D() { W = 1, X = 2, Y = 3, Z = 4 };
                var v2 = new Vector4D() { W = 5, X = 6, Y = 7, Z = 8 };
                var sum = 0.0;
                var start = DateTime.Now;
                for (var i = 0; i < loop; i++)
                {
                    sum += v1.DotInNotInline(v2);
                }
                var end = DateTime.Now;
                Console.WriteLine($"{end - start} DotInNotInline({sum})");
            }
            {
                var v1 = new Vector4D() { W = 1, X = 2, Y = 3, Z = 4 };
                var v2 = new Vector4D() { W = 5, X = 6, Y = 7, Z = 8 };
                var sum = 0.0;
                var start = DateTime.Now;
                for (var i = 0; i < loop; i++)
                {
                    sum += v1.DotInInline(v2);
                }
                var end = DateTime.Now;
                Console.WriteLine($"{end - start} DotInInline({sum})");
            }
        }
    }
}
