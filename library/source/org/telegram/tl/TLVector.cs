namespace org.telegram.tl
{
    using IKVM.Attributes;
    using ikvm.internal;
    using ikvm.lang;
    using java.io;
    using java.lang;
    using java.util;
    using java.util.function;
    using java.util.stream;
    using org.telegram.mtproto.log;
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("<T:Ljava/lang/Object;>Lorg/telegram/tl/TLObject;Ljava/util/List<TT;>;"), Implements(new string[] { "java.util.List" })]
    public class TLVector : TLObject, List, Collection, Iterable, IEnumerable
    {
        public const int CLASS_ID = 0x1cb5c415;
        private Class destClass;
        [Signature("Ljava/util/ArrayList<TT;>;")]
        private ArrayList items;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 200, 0x6b })]
        public TLVector()
        {
            this.destClass = ClassLiteral<TLObject>.Value;
            this.items = new ArrayList();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLVector(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        bool Collection.Collection::equals(object obj1) => 
            Object.instancehelper_equals(this, obj1);

        int Collection.Collection::hashCode() => 
            Object.instancehelper_hashCode(this);

        bool List.List::equals(object obj1) => 
            Object.instancehelper_equals(this, obj1);

        int List.List::hashCode() => 
            Object.instancehelper_hashCode(this);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(TT;)Z"), LineNumberTable(0x84)]
        public virtual bool add(object t) => 
            this.items.add(t);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(ITT;)V"), LineNumberTable(new byte[] { 160, 0x44, 0x6f })]
        public virtual void add(int i, object t)
        {
            this.items.add(i, t);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Ljava/util/Collection<+TT;>;)Z"), LineNumberTable(0x93)]
        public virtual bool addAll(Collection ts) => 
            this.items.addAll(ts);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(ILjava/util/Collection<+TT;>;)Z"), LineNumberTable(0x98)]
        public virtual bool addAll(int i, Collection ts) => 
            this.items.addAll(i, ts);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x75, 0x6d })]
        public virtual void clear()
        {
            this.items.clear();
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x70)]
        public virtual bool contains(object o) => 
            this.items.contains(o);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Ljava/util/Collection<*>;)Z"), LineNumberTable(0x8e)]
        public virtual bool containsAll(Collection objects) => 
            this.items.containsAll(objects);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            0x1d, 0x68, 0x90, 0x67, 0x69, 0x7f, 0x4e, 0x6d, 0x79, 0x6d, 0x79, 0x6d, 0x94, 0x93, 0xff, 0x15,
            0x35, 0xe9, 0x4d
        })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            if (this.destClass == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("DestClass not set");
            }
            int num = StreamingUtils.readInt(stream);
            for (int i = 0; i < num; i++)
            {
                Logger.d("TLVECTOR", new StringBuilder().append("reading: ").append(i).append(" from ").append(num).append(" (").append(this.items.size()).append(")").append(" --> ").append(this.destClass).toString());
                if (this.destClass == ClassLiteral<Integer>.Value)
                {
                    this.items.add(Integer.valueOf(StreamingUtils.readInt(stream)));
                }
                else if (this.destClass == ClassLiteral<Long>.Value)
                {
                    this.items.add(Long.valueOf(StreamingUtils.readLong(stream)));
                }
                else if (this.destClass == ClassLiteral<String>.Value)
                {
                    this.items.add(StreamingUtils.readTLString(stream));
                }
                else
                {
                    this.items.add(context.deserializeMessage(stream));
                }
                Logger.d("TLVECTOR", new StringBuilder().append("Extracted ").append(Object.instancehelper_toString(this.items.get(i))).toString());
            }
        }

        [HideFromJava(0x600000e)]
        public virtual void forEach(Consumer consumer1)
        {
            Iterable.<default>forEach(this, consumer1);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(I)TT;"), LineNumberTable(0xac)]
        public virtual object get(int i) => 
            this.items.get(i);

        public override int getClassId() => 
            0x1cb5c415;

        public virtual Class getDestClass() => 
            this.destClass;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0xc0)]
        public virtual int indexOf(object o) => 
            this.items.indexOf(o);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x6b)]
        public virtual bool isEmpty() => 
            this.items.isEmpty();

        [MethodImpl(MethodImplOptions.NoInlining), Signature("()Ljava/util/Iterator<TT;>;"), LineNumberTable(0x75)]
        public virtual Iterator iterator() => 
            this.items.iterator();

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0xc5)]
        public virtual int lastIndexOf(object o) => 
            this.items.lastIndexOf(o);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("()Ljava/util/ListIterator<TT;>;"), LineNumberTable(0xca)]
        public virtual ListIterator listIterator() => 
            this.items.listIterator();

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(I)Ljava/util/ListIterator<TT;>;"), LineNumberTable(0xcf)]
        public virtual ListIterator listIterator(int i) => 
            this.items.listIterator(i);

        [HideFromJava(0x600000e)]
        public virtual Stream parallelStream() => 
            Collection.<default>parallelStream(this);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(I)TT;"), LineNumberTable(0xbb)]
        public virtual object remove(int i) => 
            this.items.remove(i);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x89)]
        public virtual bool remove(object o) => 
            this.items.remove(o);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Ljava/util/Collection<*>;)Z"), LineNumberTable(0x9d)]
        public virtual bool removeAll(Collection objects) => 
            this.items.removeAll(objects);

        [HideFromJava(0x600000e)]
        public virtual bool removeIf(Predicate predicate1) => 
            Collection.<default>removeIf(this, predicate1);

        [HideFromJava(0x600000e)]
        public virtual void replaceAll(UnaryOperator operator1)
        {
            List.<default>replaceAll(this, operator1);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(Ljava/util/Collection<*>;)Z"), LineNumberTable(0xa2)]
        public virtual bool retainAll(Collection objects) => 
            this.items.retainAll(objects);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            7, 0x71, 0x6d, 0x7b, 0x71, 0x67, 0x6d, 0x7b, 0x71, 0x67, 0x6d, 0x7b, 0x6c, 0x84, 0x7b, 0x6c,
            130
        })]
        public override void serializeBody(OutputStream stream)
        {
            Iterator iterator;
            StreamingUtils.writeInt(this.items.size(), stream);
            if (this.destClass == ClassLiteral<Integer>.Value)
            {
                iterator = this.items.iterator();
                while (iterator.hasNext())
                {
                    StreamingUtils.writeInt(((Integer) iterator.next()).intValue(), stream);
                }
            }
            else if (this.destClass == ClassLiteral<Long>.Value)
            {
                iterator = this.items.iterator();
                while (iterator.hasNext())
                {
                    StreamingUtils.writeLong(((Long) iterator.next()).longValue(), stream);
                }
            }
            else if (this.destClass == ClassLiteral<String>.Value)
            {
                iterator = this.items.iterator();
                while (iterator.hasNext())
                {
                    StreamingUtils.writeTLString((string) iterator.next(), stream);
                }
            }
            else
            {
                iterator = this.items.iterator();
                while (iterator.hasNext())
                {
                    StreamingUtils.writeTLObject((TLObject) iterator.next(), stream);
                }
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(ITT;)TT;"), LineNumberTable(0xb1)]
        public virtual object set(int i, object t) => 
            this.items.set(i, t);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x63, 0x70, 0x7f, 6, 0x90, 0x67 })]
        public virtual void setDestClass(Class destClass)
        {
            if (destClass == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new RuntimeException("DestClass could not be null");
            }
            if (((destClass != ClassLiteral<Integer>.Value) && (destClass != ClassLiteral<Long>.Value)) && ((destClass != ClassLiteral<String>.Value) && !ClassLiteral<TLObject>.Value.isAssignableFrom(destClass)))
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new RuntimeException("Unsupported DestClass");
            }
            this.destClass = destClass;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x66)]
        public virtual int size() => 
            this.items.size();

        [HideFromJava(0x600000e)]
        public virtual void sort(Comparator comparator1)
        {
            List.<default>sort(this, comparator1);
        }

        [HideFromJava(0x600000e)]
        public virtual Spliterator spliterator() => 
            List.<default>spliterator(this);

        [HideFromJava(0x600000e)]
        public virtual Stream stream() => 
            Collection.<default>stream(this);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(II)Ljava/util/List<TT;>;"), LineNumberTable(0xd4)]
        public virtual List subList(int i, int i2) => 
            this.items.subList(i, i2);

        [HideFromJava]
        IEnumerator IEnumerable.GetEnumerator() => 
            new IterableEnumerator(this);

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x7a)]
        public virtual object[] toArray() => 
            this.items.toArray();

        [MethodImpl(MethodImplOptions.NoInlining), Signature("<T1:Ljava/lang/Object;>([TT1;)[TT1;"), LineNumberTable(0x7f)]
        public virtual object[] toArray(object[] t1s) => 
            this.items.toArray(t1s);

        public override string toString() => 
            "vector#1cb5c415";
    }
}

