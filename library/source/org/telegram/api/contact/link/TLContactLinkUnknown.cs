namespace org.telegram.api.contact.link
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLContactLinkUnknown : TLAbsContactLink
    {
        public const int CLASS_ID = 0x5f4f9247;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLContactLinkUnknown()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContactLinkUnknown(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x5f4f9247;

        public override string toString() => 
            "contacts.contactLinkHasPhone#5f4f9247";
    }
}

