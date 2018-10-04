namespace engine
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using java.util;
    using org.telegram.api;
    using org.telegram.api.engine.storage;
    using org.telegram.mtproto.state;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security;
    using System.Security.Permissions;

    [Serializable, Implements(new string[] { "org.telegram.api.engine.storage.AbsApiState", "java.io.Serializable" })]
    public class MemoryApiState : Object, AbsApiState, Serializable.__Interface, ISerializable
    {
        [Signature("Ljava/util/HashMap<Ljava/lang/Integer;[Lorg/telegram/mtproto/state/ConnectionInfo;>;")]
        private HashMap connections;
        [Signature("Ljava/util/HashMap<Ljava/lang/Integer;Ljava/lang/Boolean;>;")]
        private HashMap isAuth;
        [Signature("Ljava/util/HashMap<Ljava/lang/Integer;[B>;")]
        private HashMap keys;
        private int primaryDc;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0xe8, 0x3a, 0x6b, 0x6b, 0x8b, 0xa7, 0xff, 0x3d, 70 })]
        public MemoryApiState(bool isTest)
        {
            this.connections = new HashMap();
            this.keys = new HashMap();
            this.isAuth = new HashMap();
            this.primaryDc = 1;
            ConnectionInfo[] infoArray1 = new ConnectionInfo[] { new ConnectionInfo(1, 0, "149.154.175.50", 80), new ConnectionInfo(2, 0, "149.154.167.51", 80), new ConnectionInfo(3, 0, "149.154.175.100", 80), new ConnectionInfo(4, 0, "149.154.167.91", 80) };
            this.connections.put(Integer.valueOf(1), infoArray1);
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MemoryApiState(SerializationInfo info1, StreamingContext)
        {
            Serialization.readObject(this, info1);
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(0x4c)]
        public virtual byte[] getAuthKey(int dcId) => 
            ((byte[]) this.keys.get(Integer.valueOf(dcId)));

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 0x24, 0x73, 0xa7 })]
        public virtual ConnectionInfo[] getAvailableConnections(int dcId)
        {
            if (!this.connections.containsKey(Integer.valueOf(dcId)))
            {
                return new ConnectionInfo[0];
            }
            return (ConnectionInfo[]) this.connections.get(Integer.valueOf(dcId));
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(0x5f)]
        public virtual AbsMTProtoState getMtProtoState(int dcId) => 
            new 1(this, dcId);

        [SecurityCritical, HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected virtual void GetObjectData(SerializationInfo info1, StreamingContext)
        {
            Serialization.writeObject(this, info1);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public virtual int getPrimaryDc() => 
            this.primaryDc;

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x73, 0x9e })]
        public virtual bool isAuthenticated(int dcId) => 
            (this.isAuth.containsKey(Integer.valueOf(dcId)) && ((Boolean) this.isAuth.get(Integer.valueOf(dcId))).booleanValue());

        [HideFromJava]
        public static implicit operator Serializable(MemoryApiState state1)
        {
            Serializable serializable;
            serializable.__<ref> = state1;
            return serializable;
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 0x1f, 0x73 })]
        public virtual void putAuthKey(int dcId, byte[] key)
        {
            this.keys.put(Integer.valueOf(dcId), key);
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 0x4d, 0x6b, 0x6d })]
        public virtual void reset()
        {
            this.isAuth.clear();
            this.keys.clear();
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 0x48, 0x6d })]
        public virtual void resetAuth()
        {
            this.isAuth.clear();
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 0x9f, 0x81, 130, 120 })]
        public virtual void setAuthenticated(int dcId, bool auth)
        {
            int num = (int) auth;
            this.isAuth.put(Integer.valueOf(dcId), Boolean.valueOf((bool) num));
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public virtual void setPrimaryDc(int dc)
        {
            this.primaryDc = dc;
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 9, 0x6b, 0x66, 0x62, 0x7f, 4, 0x73, 0x97, 0x7f, 20, 0x85, 0x7f, 2, 0x7f, 7, 0x62 })]
        public virtual void updateSettings(TLConfig config)
        {
            this.connections.clear();
            HashMap map = new HashMap();
            int id = 0;
            Iterator iterator = config.getDcOptions().iterator();
            while (true)
            {
                if (!iterator.hasNext())
                {
                    break;
                }
                TLDcOption option = (TLDcOption) iterator.next();
                if (!map.containsKey(Integer.valueOf(option.getId())))
                {
                    map.put(Integer.valueOf(option.getId()), new ArrayList());
                }
                id++;
                ((ArrayList) map.get(Integer.valueOf(option.getId()))).add(new ConnectionInfo(id, 0, option.getIpAddress(), option.getPort()));
            }
            iterator = map.keySet().iterator();
            while (true)
            {
                if (!iterator.hasNext())
                {
                    break;
                }
                Integer integer = (Integer) iterator.next();
                this.connections.put(integer, ((ArrayList) map.get(integer)).toArray(new ConnectionInfo[0]));
            }
        }

        [EnclosingMethod(null, "getMtProtoState", "(I)Lorg.telegram.mtproto.state.AbsMTProtoState;")]
        internal class 1 : AbsMTProtoState
        {
            private KnownSalt[] knownSalts;
            [Modifiers(0x1010)]
            internal MemoryApiState this$0;
            [Modifiers(0x1010)]
            internal int val$dcId;

            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x2d, 0x76 })]
            internal 1(MemoryApiState state1, int num1)
            {
                this.this$0 = state1;
                this.val$dcId = num1;
                this.knownSalts = new KnownSalt[0];
            }

            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(100)]
            public override byte[] getAuthKey() => 
                this.this$0.getAuthKey(this.val$dcId);

            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x69)]
            public override ConnectionInfo[] getAvailableConnections() => 
                this.this$0.getAvailableConnections(this.val$dcId);

            public override KnownSalt[] readKnownSalts() => 
                this.knownSalts;

            protected internal override void writeKnownSalts(KnownSalt[] saltArray1)
            {
                this.knownSalts = saltArray1;
            }
        }
    }
}

