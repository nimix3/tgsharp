namespace org.telegram.mtproto
{
    using org.telegram.tl;

    public interface CallWrapper
    {
        TLObject wrapObject(TLMethod tlm);
    }
}

