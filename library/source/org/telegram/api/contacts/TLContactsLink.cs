namespace org.telegram.api.contacts
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.contact.link;
    using org.telegram.api.user;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLContactsLink : TLObject
    {
        public const int CLASS_ID = 0x3ace484c;
        private TLAbsContactLink foreignLink;
        private TLAbsContactLink myLink;
        private TLAbsUser user;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68 })]
        public TLContactsLink()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContactsLink(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3f, 0x72, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.myLink = StreamingUtils.readTLObject(stream, context);
            this.foreignLink = StreamingUtils.readTLObject(stream, context);
            this.user = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x3ace484c;

        public virtual TLAbsContactLink getForeignLink() => 
            this.foreignLink;

        public virtual TLAbsContactLink getMyLink() => 
            this.myLink;

        public virtual TLAbsUser getUser() => 
            this.user;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x37, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.myLink, stream);
            StreamingUtils.writeTLObject(this.foreignLink, stream);
            StreamingUtils.writeTLObject(this.user, stream);
        }

        public virtual void setForeignLink(TLAbsContactLink value)
        {
            this.foreignLink = value;
        }

        public virtual void setMyLink(TLAbsContactLink value)
        {
            this.myLink = value;
        }

        public virtual void setUser(TLAbsUser value)
        {
            this.user = value;
        }

        public override string toString() => 
            "contacts.link#3ace484c";
    }
}

