namespace org.telegram.api.input.media
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.input.game;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputMediaGame : TLAbsInputMedia
    {
        public const int CLASS_ID = -750828557;
        private TLAbsInputGame id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLInputMediaGame()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaGame(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 190, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputGame>.Value);
        }

        public override int getClassId() => 
            -750828557;

        public virtual TLAbsInputGame getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.id, stream);
        }

        public virtual void setId(TLAbsInputGame id)
        {
            this.id = id;
        }

        public override string toString() => 
            "inputMediaGame#d33f43f3";
    }
}

