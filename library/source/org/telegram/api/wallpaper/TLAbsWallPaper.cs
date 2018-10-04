namespace org.telegram.api.wallpaper
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsWallPaper : TLObject
    {
        protected internal int color;
        protected internal int id;
        protected internal string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        protected internal TLAbsWallPaper()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsWallPaper(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual int getColor() => 
            this.color;

        public virtual int getId() => 
            this.id;

        public virtual string getTitle() => 
            this.title;

        public virtual void setColor(int value)
        {
            this.color = value;
        }

        public virtual void setId(int value)
        {
            this.id = value;
        }

        public virtual void setTitle(string value)
        {
            this.title = value;
        }
    }
}

