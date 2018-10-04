namespace org.telegram.api.contact.link
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLContactLinkHasPhone : TLAbsContactLink
    {
        public const int CLASS_ID = 0x268f3f59;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLContactLinkHasPhone()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContactLinkHasPhone(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x268f3f59;

        public override string toString() => 
            "contacts.contactLinkHasPhone#268f3f59";
    }
}

