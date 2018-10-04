namespace org.telegram.api.input.sticker.media
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.input.document;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputStickeredMediaDocument : TLAbsInputStickeredMedia
    {
        public const int CLASS_ID = 0x438865b;
        private TLAbsInputDocument id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x11)]
        public TLInputStickeredMediaDocument()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputStickeredMediaDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputDocument>.Value);
        }

        public override int getClassId() => 
            0x438865b;

        public virtual TLAbsInputDocument getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb3, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.id, stream);
        }

        public virtual void setId(TLAbsInputDocument id)
        {
            this.id = id;
        }

        public override string toString() => 
            "inputStickeredMediaDocument#438865b";
    }
}

