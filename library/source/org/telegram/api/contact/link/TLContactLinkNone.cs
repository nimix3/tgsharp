namespace org.telegram.api.contact.link
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLContactLinkNone : TLAbsContactLink
    {
        public const int CLASS_ID = -17968211;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLContactLinkNone()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContactLinkNone(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -17968211;

        public override string toString() => 
            "contacts.contactLinkNone#feedd3ad";
    }
}

