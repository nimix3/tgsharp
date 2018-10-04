namespace org.telegram.api.disablefeature
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDisabledFeature : TLObject
    {
        public const int CLASS_ID = -1369215196;
        private string description;
        private string feature;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 10, 0x68 })]
        public TLDisabledFeature()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDisabledFeature(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3e, 0x68, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.feature = StreamingUtils.readTLString(stream);
            this.description = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1369215196;

        public virtual string getDescription() => 
            this.description;

        public virtual string getFeature() => 
            this.feature;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x38, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.feature, stream);
            StreamingUtils.writeTLString(this.description, stream);
        }

        public virtual void setDescription(string description)
        {
            this.description = description;
        }

        public virtual void setFeature(string feature)
        {
            this.feature = feature;
        }

        public override string toString() => 
            "disableFeature#ae636f24";
    }
}

