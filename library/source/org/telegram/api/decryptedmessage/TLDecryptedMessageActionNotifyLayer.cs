namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageActionNotifyLayer : TLDecryptedMessageAction
    {
        public const int CLASS_ID = -217806717;
        private int layer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0xe8, 0x3a, 0xe8, 0x47 })]
        public TLDecryptedMessageActionNotifyLayer()
        {
            this.layer = 0x17;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageActionNotifyLayer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.layer = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -217806717;

        public virtual int getLayer() => 
            this.layer;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xad, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.layer, stream);
        }

        public virtual void setLayer(int layer)
        {
            this.layer = layer;
        }

        public override string toString() => 
            "decryptedMessageActionNotifyLayer#f3048883";
    }
}

