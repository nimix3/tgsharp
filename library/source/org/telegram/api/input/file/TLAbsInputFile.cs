namespace org.telegram.api.input.file
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsInputFile : TLObject
    {
        protected internal long id;
        protected internal string name;
        protected internal int parts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        protected internal TLAbsInputFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsInputFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual long getId() => 
            this.id;

        public virtual string getName() => 
            this.name;

        public virtual int getParts() => 
            this.parts;

        public virtual void setId(long value)
        {
            this.id = value;
        }

        public virtual void setName(string value)
        {
            this.name = value;
        }

        public virtual void setParts(int value)
        {
            this.parts = value;
        }
    }
}

