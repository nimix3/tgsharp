namespace org.telegram.mtproto.transport
{
    using IKVM.Attributes;
    using java.lang;
    using java.util;
    using java.util.function;
    using org.telegram.mtproto.log;
    using org.telegram.mtproto.state;
    using System;
    using System.Runtime.CompilerServices;

    public class TransportRate : Object
    {
        private Random rnd = new Random();
        private const string TAG = "TransportRate";
        [Signature("Ljava/util/HashMap<Ljava/lang/Integer;Lorg/telegram/mtproto/transport/TransportRate$Transport;>;")]
        private HashMap transports = new HashMap();

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0x9f, 0xa4, 0xe8, 60, 0x8b, 0xab, 0x66, 0x66, 0x67, 0x6f, 15, 0xc6, 0x67, 0x77, 0x7e, 0x10,
            0x26, 230, 0x45, 0x68
        })]
        public TransportRate(ConnectionInfo[] connectionInfos)
        {
            int num = 0x7fffffff;
            int num2 = -2147483648;
            int index = 0;
            while (true)
            {
                if (index >= connectionInfos.Length)
                {
                    break;
                }
                num = Math.min(connectionInfos[index].getPriority(), num);
                num2 = Math.max(connectionInfos[index].getPriority(), num2);
                index++;
            }
            index = 0;
            while (true)
            {
                if (index >= connectionInfos.Length)
                {
                    break;
                }
                this.transports.put(Integer.valueOf(connectionInfos[index].getId()), new Transport(this, new ConnectionType(connectionInfos[index].getId(), connectionInfos[index].getAddress(), connectionInfos[index].getPort(), 0), (float) ((connectionInfos[index].getPriority() - num) + 1), null));
                index++;
            }
            this.normalize();
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 14, 0x66, 0x7f, 6, 0x7a, 0x62, 0x7f, 9, 0x72, 0x75, 0x7f, 0x58, 0x65 })]
        private void normalize()
        {
            Integer integer;
            float num = 0f;
            Iterator iterator = this.transports.keySet().iterator();
            while (true)
            {
                if (!iterator.hasNext())
                {
                    break;
                }
                integer = (Integer) iterator.next();
                num += Transport.access$100((Transport) this.transports.get(integer));
            }
            iterator = this.transports.keySet().iterator();
            while (true)
            {
                if (!iterator.hasNext())
                {
                    break;
                }
                integer = (Integer) iterator.next();
                Transport transport = (Transport) this.transports.get(integer);
                Transport transport2 = transport;
                Transport.access$102(transport2, Transport.access$100(transport2) / num);
                Logger.d("TransportRate", new StringBuilder().append("Transport: #").append(Transport.access$200(transport).getId()).append(" ").append(Transport.access$200(transport).getHost()).append(":").append(transport.getConnectionType().getPort()).append(" #").append(transport.getRate()).toString());
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 2, 0x7f, 5, 0x7f, 0x11, 0x68 })]
        public virtual void onConnectionFailure(int id)
        {
            Logger.d("TransportRate", new StringBuilder().append("onConnectionFailure #").append(id).toString());
            Transport transport = (Transport) this.transports.get(Integer.valueOf(id));
            Transport.access$102(transport, (float) (Transport.access$100(transport) * 0.5));
            this.normalize();
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 8, 0x7f, 5, 0x7f, 13, 0x68 })]
        public virtual void onConnectionSuccess(int id)
        {
            Logger.d("TransportRate", new StringBuilder().append("onConnectionSuccess #").append(id).toString());
            Transport transport = (Transport) this.transports.get(Integer.valueOf(id));
            Transport.access$102(transport, Transport.access$100(transport) * 1f);
            this.normalize();
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized), LineNumberTable(new byte[] { 0x9f, 180, 0x6c, 0x7c, 0xec, 70, 0x69, 0x7f, 10 })]
        public virtual ConnectionType tryConnection()
        {
            this.rnd.nextFloat();
            Transport[] transportArray = (Transport[]) this.transports.values().toArray(new Transport[0]);
            Arrays.sort(transportArray, new 1(this));
            ConnectionType type = transportArray[0].getConnectionType();
            Logger.d("TransportRate", new StringBuilder().append("tryConnection #").append(type.getId()).toString());
            return type;
        }

        [Signature("Ljava/lang/Object;Ljava/util/Comparator<Lorg/telegram/mtproto/transport/TransportRate$Transport;>;"), EnclosingMethod(null, "tryConnection", "()Lorg.telegram.mtproto.transport.ConnectionType;")]
        internal class 1 : Object, Comparator
        {
            [Modifiers(0x1010)]
            internal TransportRate this$0;

            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(40)]
            internal 1(TransportRate rate1)
            {
                this.this$0 = rate1;
            }

            bool Comparator.Comparator::equals(object obj1) => 
                Object.instancehelper_equals(this, obj1);

            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x2b)]
            public virtual int compare(TransportRate.Transport transport1, TransportRate.Transport transport2) => 
                -Float.compare(transport1.getRate(), transport2.getRate());

            [MethodImpl(MethodImplOptions.NoInlining), Modifiers(0x1041), LineNumberTable(40)]
            public virtual int compare(object obj1, object obj2) => 
                this.compare((TransportRate.Transport) obj1, (TransportRate.Transport) obj2);

            [HideFromJava(0x600000e)]
            public virtual Comparator reversed() => 
                Comparator.<default>reversed(this);

            [HideFromJava(0x600000e)]
            public virtual Comparator thenComparing(Comparator comparator1) => 
                Comparator.<default>thenComparing(this, comparator1);

            [HideFromJava(0x600000e)]
            public virtual Comparator thenComparing(Function function1) => 
                Comparator.<default>thenComparing(this, function1);

            [HideFromJava(0x600000e)]
            public virtual Comparator thenComparing(Function function1, Comparator comparator1) => 
                Comparator.<default>thenComparing(this, function1, comparator1);

            [HideFromJava(0x600000e)]
            public virtual Comparator thenComparingDouble(ToDoubleFunction function1) => 
                Comparator.<default>thenComparingDouble(this, function1);

            [HideFromJava(0x600000e)]
            public virtual Comparator thenComparingInt(ToIntFunction function1) => 
                Comparator.<default>thenComparingInt(this, function1);

            [HideFromJava(0x600000e)]
            public virtual Comparator thenComparingLong(ToLongFunction function1) => 
                Comparator.<default>thenComparingLong(this, function1);
        }

        [InnerClass(null, 2)]
        internal class Transport : Object
        {
            private ConnectionType connectionType;
            private float rate;
            [Modifiers(0x1010)]
            internal TransportRate this$0;

            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x1d, 0x6f, 0x67, 0x68 })]
            private Transport(TransportRate rate1, ConnectionType type1, float single1)
            {
                this.this$0 = rate1;
                this.connectionType = type1;
                this.rate = single1;
            }

            [MethodImpl(MethodImplOptions.NoInlining), Modifiers(0x1000), LineNumberTable(0x4b)]
            internal Transport(TransportRate rate1, ConnectionType type1, float single1, TransportRate.1) : this(rate1, type1, single1)
            {
            }

            [Modifiers(0x1008), LineNumberTable(0x4b)]
            internal static float access$100(TransportRate.Transport transport1) => 
                transport1.rate;

            [Modifiers(0x1008), LineNumberTable(0x4b)]
            internal static float access$102(TransportRate.Transport transport1, float single1)
            {
                float num = single1;
                TransportRate.Transport transport = transport1;
                transport.rate = num;
                return num;
            }

            [Modifiers(0x1008), LineNumberTable(0x4b)]
            internal static ConnectionType access$200(TransportRate.Transport transport1) => 
                transport1.connectionType;

            public virtual ConnectionType getConnectionType() => 
                this.connectionType;

            public virtual float getRate() => 
                this.rate;

            public virtual void setConnectionType(ConnectionType type1)
            {
                this.connectionType = type1;
            }

            public virtual void setRate(float single1)
            {
                this.rate = single1;
            }
        }
    }
}

