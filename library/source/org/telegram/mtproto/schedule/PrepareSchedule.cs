namespace org.telegram.mtproto.schedule
{
    using java.lang;
    using System;

    public class PrepareSchedule : Object
    {
        private int[] allowedContexts;
        private long delay;
        private bool doWait;

        public virtual int[] getAllowedContexts() => 
            this.allowedContexts;

        public virtual long getDelay() => 
            this.delay;

        public virtual bool isDoWait() => 
            this.doWait;

        public virtual void setAllowedContexts(int[] allowedContexts)
        {
            this.allowedContexts = allowedContexts;
        }

        public virtual void setDelay(long delay)
        {
            this.delay = delay;
        }

        public virtual void setDoWait(bool doWait)
        {
            int num = (int) doWait;
            this.doWait = (bool) num;
        }
    }
}

