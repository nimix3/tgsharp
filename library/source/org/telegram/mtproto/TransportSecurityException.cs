namespace org.telegram.mtproto
{
    using IKVM.Attributes;
    using java.io;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TransportSecurityException : IOException
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9a, 0x68 })]
        public TransportSecurityException()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x69 })]
        public TransportSecurityException(Exception throwable) : base(throwable)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x69 })]
        public TransportSecurityException(string s) : base(s)
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TransportSecurityException(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa2, 0x6a })]
        public TransportSecurityException(string s, Exception throwable) : base(s, throwable)
        {
        }
    }
}

