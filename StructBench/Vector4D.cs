using System.Runtime.CompilerServices;

namespace StructBench
{
    struct Vector4D
    {
        public double W, X, Y, Z;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public double DotCopyNotInline(Vector4D v) => W * v.W + X * v.X + Y * v.Y + Z * v.Z;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double DotCopyInline(Vector4D v) => W * v.W + X * v.X + Y * v.Y + Z * v.Z;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public double DotInNotInline(in Vector4D v) => W * v.W + X * v.X + Y * v.Y + Z * v.Z;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double DotInInline(in Vector4D v) => W * v.W + X * v.X + Y * v.Y + Z * v.Z;
    }
}
