namespace org.telegram.api.help
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsAppUpdate : TLObject
    {
        protected internal bool critical;
        protected internal int id;
        protected internal string text;
        protected internal string url;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        protected internal TLAbsAppUpdate()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsAppUpdate(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual int getId() => 
            this.id;

        public virtual string getText() => 
            this.text;

        public virtual string getUrl() => 
            this.url;

        public virtual bool isCritical() => 
            this.critical;

        public virtual void setCritical(bool critical)
        {
            int num = (int) critical;
            this.critical = (bool) num;
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual void setText(string text)
        {
            this.text = text;
        }

        public virtual void setUrl(string url)
        {
            this.url = url;
        }
    }
}

