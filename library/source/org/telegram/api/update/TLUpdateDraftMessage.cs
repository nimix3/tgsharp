namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.draft;
    using org.telegram.api.peer;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateDraftMessage : TLAbsUpdate
    {
        public const int CLASS_ID = -299124375;
        private TLAbsDraftMessage draft;
        private TLAbsPeer peer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateDraftMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateDraftMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.draft = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -299124375;

        public virtual TLAbsDraftMessage getDraft() => 
            this.draft;

        public virtual TLAbsPeer getPeer() => 
            this.peer;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeTLObject(this.draft, stream);
        }

        public override string toString() => 
            "updateDraftMessage#ee2bb969";
    }
}

