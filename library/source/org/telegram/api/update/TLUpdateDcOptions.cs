namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateDcOptions : TLAbsUpdate
    {
        public const int CLASS_ID = -1906403213;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/TLDcOption;>;")]
        private TLVector dcOptions;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0xe8, 0x3a, 0xeb, 0x47 })]
        public TLUpdateDcOptions()
        {
            this.dcOptions = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateDcOptions(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.dcOptions = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -1906403213;

        public virtual TLVector getDcOptions() => 
            this.dcOptions;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 4, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.dcOptions, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/TLDcOption;>;)V")]
        public virtual void setDcOptions(TLVector dcOptions)
        {
            this.dcOptions = dcOptions;
        }

        public override string toString() => 
            "updateDcOptions#8e5e9873";
    }
}

