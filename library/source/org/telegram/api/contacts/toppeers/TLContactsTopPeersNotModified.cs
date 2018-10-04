namespace org.telegram.api.contacts.toppeers
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLContactsTopPeersNotModified : TLAbsContactsTopPeers
    {
        public const int CLASS_ID = -567906571;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLContactsTopPeersNotModified()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContactsTopPeersNotModified(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -567906571;

        public override string toString() => 
            "contacts.topPeersNotModified#de266ef5";
    }
}

