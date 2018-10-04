namespace org.telegram.api.upload.file
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsFile : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(8)]
        public TLAbsFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

