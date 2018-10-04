namespace org.telegram.mtproto.secure.pq
{
    using IKVM.Attributes;
    using java.lang;
    using java.math;
    using System;
    using System.Runtime.CompilerServices;

    public class PQSolver : Object
    {
        private static PQImplementation currentImplementation = new PQLopatin();

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x99, 0x88 })]
        private PQSolver()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void __<clinit>()
        {
        }

        public static void setCurrentImplementation(PQImplementation implementation)
        {
            currentImplementation = implementation;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(20)]
        public static BigInteger solvePq(BigInteger src)
        {
            BigInteger.__<clinit>();
            return new BigInteger(new StringBuilder().append("").append(currentImplementation.findDivider(src.longValue())).toString());
        }
    }
}

