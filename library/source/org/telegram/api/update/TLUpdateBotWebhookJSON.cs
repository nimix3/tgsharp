namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateBotWebhookJSON : TLAbsUpdate
    {
        public const int CLASS_ID = -2095595325;
        private TLDataJSON data;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68 })]
        public TLUpdateBotWebhookJSON()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateBotWebhookJSON(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.data = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLDataJSON>.Value);
        }

        public override int getClassId() => 
            -2095595325;

        public virtual TLDataJSON getData() => 
            this.data;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.data, stream);
        }

        public override string toString() => 
            "updateBotWebhookJSON#8317c0c3";
    }
}

