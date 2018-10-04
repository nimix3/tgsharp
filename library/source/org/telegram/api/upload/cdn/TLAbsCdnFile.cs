namespace org.telegram.api.upload.cdn
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsCdnFile : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(9)]
        public TLAbsCdnFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsCdnFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

