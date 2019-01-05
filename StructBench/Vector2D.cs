using System.Runtime.CompilerServices;

namespace StructBench
{
    struct Vector2D
    {
        public double X, Y;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public double DotCopyNotInline(Vector2D v) => X * v.X + Y * v.Y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double DotCopyInline(Vector2D v) => X * v.X + Y * v.Y;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public double DotInNotInline(in Vector2D v) => X * v.X + Y * v.Y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double DotInInline(in Vector2D v) => X * v.X + Y * v.Y;
    }
}
