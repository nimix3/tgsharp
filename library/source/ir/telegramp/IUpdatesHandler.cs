namespace ir.telegramp
{
    using IKVM.Attributes;
    using java.util;
    using org.telegram.api.updates;
    using org.telegram.api.updates.difference;
    using System;

    public interface IUpdatesHandler
    {
        bool checkSeq(int i1, int i2, int i3);
        void getDifferences();
        [Signature("(Ljava/util/List<Lorg/telegram/api/chat/TLAbsChat;>;)V")]
        void onChats(List l);
        void onTLAbsDifference(TLAbsDifference tlad);
        [Signature("(Ljava/util/List<Lorg/telegram/api/user/TLAbsUser;>;Ljava/util/List<Lorg/telegram/api/message/TLAbsMessage;>;Ljava/util/List<Lorg/telegram/api/update/TLAbsUpdate;>;Ljava/util/List<Lorg/telegram/api/chat/TLAbsChat;>;)V")]
        void onTLChannelDifferences(List l1, List l2, List l3, List l4);
        void onTLUpdatesTooLong();
        [Signature("(Ljava/util/List<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        void onUsers(List l);
        void processUpdate(UpdateWrapper uw);
        void updateStateModification(TLUpdatesState tlus);
    }
}

