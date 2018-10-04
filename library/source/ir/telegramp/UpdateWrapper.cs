namespace ir.telegramp
{
    using IKVM.Attributes;
    using java.lang;
    using java.util;
    using java.util.function;
    using org.telegram.api.update;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;

    public class UpdateWrapper : Object
    {
        private int channelId;
        private bool checkPts;
        private int date;
        private bool isChannel;
        private bool isGettingDifferences;
        private int pts;
        private int ptsCount;
        private int seq;
        private int seqStart;
        private TLObject update;
        private bool updatePts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68, 0x67, 0x68, 0x67, 0x93, 0x87, 0x67, 0x67 })]
        public UpdateWrapper(TLObject update)
        {
            this.update = update;
            if (update is TLChannelUpdate)
            {
                this.isChannel = true;
                this.channelId = ((TLChannelUpdate) update).getChannelId();
            }
            else
            {
                this.channelId = 0;
            }
            this.checkPts = true;
            this.updatePts = true;
        }

        public virtual void disablePtsCheck()
        {
            this.checkPts = false;
        }

        public virtual void disableUpdatePts()
        {
            this.updatePts = false;
        }

        public virtual void enableGettingDifferences()
        {
            this.isGettingDifferences = true;
        }

        public virtual int getChannelId() => 
            this.channelId;

        public virtual int getDate() => 
            this.date;

        public virtual int getPts() => 
            this.pts;

        public virtual int getPtsCount() => 
            this.ptsCount;

        public virtual int getSeq() => 
            this.seq;

        public virtual int getSeqStart() => 
            this.seqStart;

        public virtual TLObject getUpdate() => 
            this.update;

        public virtual bool isChannel() => 
            this.isChannel;

        public virtual bool isCheckPts() => 
            this.checkPts;

        public virtual bool isGettingDifferences() => 
            this.isGettingDifferences;

        public virtual bool isUpdatePts() => 
            this.updatePts;

        public virtual void setParams(int pts, int ptsCount, int date, int seq, int seqStart)
        {
            this.pts = pts;
            this.ptsCount = ptsCount;
            this.date = date;
            this.seq = seq;
            this.seqStart = seqStart;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x70)]
        public override string toString() => 
            this.update?.toString();

        [Signature("Ljava/lang/Object;Ljava/util/Comparator<Lir/telegramp/UpdateWrapper;>;")]
        internal class UpdateWrapperComparator : Object, Comparator
        {
            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x73)]
            internal UpdateWrapperComparator()
            {
            }

            bool Comparator.Comparator::equals(object obj1) => 
                Object.instancehelper_equals(this, obj1);

            [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x44, 0x72, 0x63, 0x92 })]
            public virtual int compare(UpdateWrapper wrapper1, UpdateWrapper wrapper2)
            {
                int num = Integer.compare(wrapper1.getPts(), wrapper2.getPts());
                if (num == 0)
                {
                    num = Integer.compare(wrapper2.getPtsCount(), wrapper1.getPtsCount());
                }
                return num;
            }

            [MethodImpl(MethodImplOptions.NoInlining), Modifiers(0x1041), LineNumberTable(0x73)]
            public virtual int compare(object obj1, object obj2) => 
                this.compare((UpdateWrapper) obj1, (UpdateWrapper) obj2);

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

