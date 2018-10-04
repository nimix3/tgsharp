namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.phone.call;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdatePhoneCall : TLAbsUpdate
    {
        public const int CLASS_ID = -1425052898;
        private TLAbsPhoneCall phoneCall;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLUpdatePhoneCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdatePhoneCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.phoneCall = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPhoneCall>.Value);
        }

        public override int getClassId() => 
            -1425052898;

        public virtual TLAbsPhoneCall getPhoneCall() => 
            this.phoneCall;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.phoneCall, stream);
        }

        public override string toString() => 
            "updatePhoneCall#ab0f6b1e";
    }
}

