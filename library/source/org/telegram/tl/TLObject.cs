namespace org.telegram.tl
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security;
    using System.Security.Permissions;

    [Serializable, Implements(new string[] { "java.io.Serializable" })]
    public abstract class TLObject : Object, Serializable.__Interface, ISerializable
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x16)]
        public TLObject()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLObject(SerializationInfo info1, StreamingContext)
        {
            Serialization.readObject(this, info1);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x67, 0x69, 0x7f, 6, 0x9f, 0, 0x6a })]
        public virtual void deserialize(InputStream stream, TLContext context)
        {
            int num = StreamingUtils.readInt(stream);
            if (num != this.getClassId())
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new DeserializeException(new StringBuilder().append("Wrong class id. Founded:").append(Integer.toHexString(num)).append(", expected: ").append(Integer.toHexString(this.getClassId())).toString());
            }
            this.deserializeBody(stream, context);
        }

        [Throws(new string[] { "java.io.IOException" })]
        public virtual void deserializeBody(InputStream stream, TLContext context)
        {
        }

        public abstract int getClassId();
        [SecurityCritical, HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected virtual void GetObjectData(SerializationInfo info1, StreamingContext)
        {
            Serialization.writeObject(this, info1);
        }

        [HideFromJava]
        public static implicit operator Serializable(TLObject obj1)
        {
            Serializable serializable;
            serializable.__<ref> = obj1;
            return serializable;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x66, 0x67 })]
        public virtual byte[] serialize()
        {
            ByteArrayOutputStream stream = new ByteArrayOutputStream();
            this.serialize(stream);
            return stream.toByteArray();
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c, 0x69 })]
        public virtual void serialize(OutputStream stream)
        {
            StreamingUtils.writeInt(this.getClassId(), stream);
            this.serializeBody(stream);
        }

        [Throws(new string[] { "java.io.IOException" })]
        public virtual void serializeBody(OutputStream stream)
        {
        }

        public abstract override string toString();
    }
}

