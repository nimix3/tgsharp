namespace org.telegram.mtproto.state
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
    public class ConnectionInfo : Object, Serializable.__Interface, ISerializable
    {
        private string address;
        private int id;
        private int port;
        private int priority;

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected ConnectionInfo(SerializationInfo info1, StreamingContext)
        {
            Serialization.readObject(this, info1);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9f, 0x68, 0x67, 0x67, 0x67, 0x68 })]
        public ConnectionInfo(int id, int priority, string address, int port)
        {
            this.id = id;
            this.priority = priority;
            this.address = address;
            this.port = port;
        }

        public virtual string getAddress() => 
            this.address;

        public virtual int getId() => 
            this.id;

        [SecurityCritical, HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected virtual void GetObjectData(SerializationInfo info1, StreamingContext)
        {
            Serialization.writeObject(this, info1);
        }

        public virtual int getPort() => 
            this.port;

        public virtual int getPriority() => 
            this.priority;

        [HideFromJava]
        public static implicit operator Serializable(ConnectionInfo info1)
        {
            Serializable serializable;
            serializable.__<ref> = info1;
            return serializable;
        }
    }
}

