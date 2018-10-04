namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using IKVM.Runtime;
    using java.io;
    using java.lang;
    using java.util;
    using java.util.function;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTMessagesContainer : TLObject
    {
        public const int CLASS_ID = 0x73f1f8dc;
        [Signature("Ljava/util/TreeSet<Lorg/telegram/mtproto/tl/MTMessage;>;")]
        private TreeSet messages;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0xe8, 0x35, 0xf6, 0x4d })]
        public MTMessagesContainer()
        {
            TreeSet.__<clinit>();
            this.messages = new TreeSet(new 1(this));
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0xe8, 0x39, 0xf6, 0x48, 0x6d })]
        public MTMessagesContainer(MTMessage[] messages)
        {
            TreeSet.__<clinit>();
            this.messages = new TreeSet(new 1(this));
            Collections.addAll(this.messages, messages);
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTMessagesContainer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 0x67, 0x6b, 0x66, 0x66, 0x68, 0xed, 0x3d, 230, 0x45 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            int num = StreamingUtils.readInt(stream);
            this.messages.clear();
            int num2 = 0;
            while (true)
            {
                if (num2 >= num)
                {
                    break;
                }
                MTMessage message = new MTMessage();
                message.deserializeBody(stream, context);
                this.messages.add(message);
                num2++;
            }
        }

        public override int getClassId() => 
            0x73f1f8dc;

        [Signature("()Ljava/util/TreeSet<Lorg/telegram/mtproto/tl/MTMessage;>;")]
        public virtual TreeSet getMessages() => 
            this.messages;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x71, 0x7f, 1, 0x67, 0x62 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.messages.size(), stream);
            Iterator iterator = this.messages.iterator();
            while (true)
            {
                if (!iterator.hasNext())
                {
                    break;
                }
                ((MTMessage) iterator.next()).serializeBody(stream);
            }
        }

        public override string toString() => 
            "msg_container#73f1f8dc";

        [Signature("Ljava/lang/Object;Ljava/util/Comparator<Lorg/telegram/mtproto/tl/MTMessage;>;"), EnclosingMethod(null, null, null)]
        internal class 1 : Object, Comparator
        {
            [Modifiers(0x1010)]
            internal MTMessagesContainer this$0;

            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1a)]
            internal 1(MTMessagesContainer container1)
            {
                this.this$0 = container1;
            }

            bool Comparator.Comparator::equals(object obj1) => 
                Object.instancehelper_equals(this, obj1);

            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1d)]
            public virtual int compare(MTMessage message1, MTMessage message2) => 
                ByteCodeHelper.f2i(Math.signum((float) (message1.getMessageId() - message2.getMessageId())));

            [MethodImpl(MethodImplOptions.NoInlining), Modifiers(0x1041), LineNumberTable(0x1a)]
            public virtual int compare(object obj1, object obj2) => 
                this.compare((MTMessage) obj1, (MTMessage) obj2);

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
    }
}

