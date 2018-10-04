namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.contact.link;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateContactLink : TLAbsUpdate
    {
        public const int CLASS_ID = -1657903163;
        private TLAbsContactLink foreignLink;
        private TLAbsContactLink myLink;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateContactLink()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateContactLink(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x30, 0x6c, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readInt(stream);
            this.myLink = StreamingUtils.readTLObject(stream, context);
            this.foreignLink = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -1657903163;

        public virtual TLAbsContactLink getForeignLink() => 
            this.foreignLink;

        public virtual TLAbsContactLink getMyLink() => 
            this.myLink;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLObject(this.myLink, stream);
            StreamingUtils.writeTLObject(this.foreignLink, stream);
        }

        public virtual void setForeignLink(TLAbsContactLink foreignLink)
        {
            this.foreignLink = foreignLink;
        }

        public virtual void setMyLink(TLAbsContactLink myLink)
        {
            this.myLink = myLink;
        }

        public virtual void setUserId(int userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "updateContactLink#9d2e67c5";
    }
}

