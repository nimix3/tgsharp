namespace org.telegram.api.message.action
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageActionChatEditPhoto : TLAbsMessageAction
    {
        public const int CLASS_ID = 0x7fcb13a8;
        private TLAbsPhoto photo;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLMessageActionChatEditPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageActionChatEditPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.photo = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x7fcb13a8;

        public virtual TLAbsPhoto getPhoto() => 
            this.photo;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.photo, stream);
        }

        public virtual void setPhoto(TLAbsPhoto photo)
        {
            this.photo = photo;
        }

        public override string toString() => 
            "messageActionChatEditPhoto#7fcb13a8";
    }
}

