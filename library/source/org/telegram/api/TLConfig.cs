namespace org.telegram.api
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLConfig : TLObject
    {
        private int callConnectTimeoutMs;
        private int callPacketTimeoutMs;
        private int callReceiveTimeoutMs;
        private int callRingTimeoutMs;
        private int chatBigSize;
        private int chatSizeMax;
        public const int CLASS_ID = -882895228;
        private int date;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/TLDcOption;>;")]
        private TLVector dcOptions;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/disablefeature/TLDisabledFeature;>;")]
        private TLVector disabledFeatures;
        private int editTimeLimit;
        private int expires;
        private const int FLAG_PHONE_CALLS_ENABLED = 2;
        private const int FLAG_TMP_SESSIONS = 1;
        private int flags;
        private int forwardedCountMax;
        private int megaGroupSizeMax;
        private string meUrlPrefix;
        private int notifyCloudDelayMs;
        private int notifyDefaultDelayMs;
        private int offlineBlurTimeoutMs;
        private int offlineIdleTimeoutMs;
        private int onlineCloudTimeoutMs;
        private int onlineUpdatePeriodMs;
        private int pinnedDialogsCountMax;
        private int pushChatLimit;
        private int pushChatPeriodMs;
        private int ratingEDecay;
        private int savedGifsLimits;
        private int stickersRecentLimit;
        private bool testMode;
        private int thisDc;
        private int tmpSessions;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 10, 0xe8, 0x3a, 0xeb, 0x47 })]
        public TLConfig()
        {
            this.disabledFeatures = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLConfig(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            160, 0x73, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x72, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c,
            0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c,
            0x72
        })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
            this.expires = StreamingUtils.readInt(stream);
            this.testMode = StreamingUtils.readTLBool(stream);
            this.thisDc = StreamingUtils.readInt(stream);
            this.dcOptions = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLDcOption>.Value);
            this.chatSizeMax = StreamingUtils.readInt(stream);
            this.megaGroupSizeMax = StreamingUtils.readInt(stream);
            this.forwardedCountMax = StreamingUtils.readInt(stream);
            this.onlineUpdatePeriodMs = StreamingUtils.readInt(stream);
            this.offlineBlurTimeoutMs = StreamingUtils.readInt(stream);
            this.offlineIdleTimeoutMs = StreamingUtils.readInt(stream);
            this.onlineCloudTimeoutMs = StreamingUtils.readInt(stream);
            this.notifyCloudDelayMs = StreamingUtils.readInt(stream);
            this.notifyDefaultDelayMs = StreamingUtils.readInt(stream);
            this.chatBigSize = StreamingUtils.readInt(stream);
            this.pushChatPeriodMs = StreamingUtils.readInt(stream);
            this.pushChatLimit = StreamingUtils.readInt(stream);
            this.savedGifsLimits = StreamingUtils.readInt(stream);
            this.editTimeLimit = StreamingUtils.readInt(stream);
            this.ratingEDecay = StreamingUtils.readInt(stream);
            this.stickersRecentLimit = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.tmpSessions = StreamingUtils.readInt(stream);
            }
            this.pinnedDialogsCountMax = StreamingUtils.readInt(stream);
            this.callReceiveTimeoutMs = StreamingUtils.readInt(stream);
            this.callRingTimeoutMs = StreamingUtils.readInt(stream);
            this.callConnectTimeoutMs = StreamingUtils.readInt(stream);
            this.callPacketTimeoutMs = StreamingUtils.readInt(stream);
            this.meUrlPrefix = StreamingUtils.readTLString(stream);
            this.disabledFeatures = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLDisabledFeature>.Value);
        }

        public virtual int getCallConnectTimeoutMs() => 
            this.callConnectTimeoutMs;

        public virtual int getCallPacketTimeoutMs() => 
            this.callPacketTimeoutMs;

        public virtual int getCallReceiveTimeoutMs() => 
            this.callReceiveTimeoutMs;

        public virtual int getCallRingTimeoutMs() => 
            this.callRingTimeoutMs;

        public virtual int getChatBigSize() => 
            this.chatBigSize;

        public virtual int getChatSizeMax() => 
            this.chatSizeMax;

        public override int getClassId() => 
            -882895228;

        public virtual int getDate() => 
            this.date;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/TLDcOption;>;")]
        public virtual TLVector getDcOptions() => 
            this.dcOptions;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/disablefeature/TLDisabledFeature;>;")]
        public virtual TLVector getDisabledFeatures() => 
            this.disabledFeatures;

        public virtual int getEditTimeLimit() => 
            this.editTimeLimit;

        public virtual int getExpires() => 
            this.expires;

        public virtual int getForwardedCountMax() => 
            this.forwardedCountMax;

        public virtual int getMegaGroupSizeMax() => 
            this.megaGroupSizeMax;

        public virtual string getMeUrlPrefix() => 
            this.meUrlPrefix;

        public virtual int getNotifyCloudDelayMs() => 
            this.notifyCloudDelayMs;

        public virtual int getNotifyDefaultDelayMs() => 
            this.notifyDefaultDelayMs;

        public virtual int getOfflineBlurTimeoutMs() => 
            this.offlineBlurTimeoutMs;

        public virtual int getOfflineIdleTimeoutMs() => 
            this.offlineIdleTimeoutMs;

        public virtual int getOnlineCloudTimeoutMs() => 
            this.onlineCloudTimeoutMs;

        public virtual int getOnlineUpdatePeriodMs() => 
            this.onlineUpdatePeriodMs;

        public virtual int getPinnedDialogsCountMax() => 
            this.pinnedDialogsCountMax;

        public virtual int getPushChatLimit() => 
            this.pushChatLimit;

        public virtual int getPushChatPeriodMs() => 
            this.pushChatPeriodMs;

        public virtual int getRatingEDecay() => 
            this.ratingEDecay;

        public virtual int getSavedGifsLimits() => 
            this.savedGifsLimits;

        public virtual int getStickersRecentLimit() => 
            this.stickersRecentLimit;

        public virtual int getThisDc() => 
            this.thisDc;

        public virtual int getTmpSessions() => 
            this.tmpSessions;

        public virtual bool hasPhoneCalls() => 
            ((this.flags & 2) != 0);

        public virtual bool hasTemporalSessions() => 
            ((this.flags & 1) != 0);

        public virtual bool isTestMode() => 
            this.testMode;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 
            160, 0x4f, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c,
            0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c,
            110
        })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.expires, stream);
            StreamingUtils.writeTLBool(this.testMode, stream);
            StreamingUtils.writeInt(this.thisDc, stream);
            StreamingUtils.writeTLVector(this.dcOptions, stream);
            StreamingUtils.writeInt(this.chatSizeMax, stream);
            StreamingUtils.writeInt(this.megaGroupSizeMax, stream);
            StreamingUtils.writeInt(this.forwardedCountMax, stream);
            StreamingUtils.writeInt(this.onlineUpdatePeriodMs, stream);
            StreamingUtils.writeInt(this.offlineBlurTimeoutMs, stream);
            StreamingUtils.writeInt(this.offlineIdleTimeoutMs, stream);
            StreamingUtils.writeInt(this.onlineCloudTimeoutMs, stream);
            StreamingUtils.writeInt(this.notifyCloudDelayMs, stream);
            StreamingUtils.writeInt(this.notifyDefaultDelayMs, stream);
            StreamingUtils.writeInt(this.chatBigSize, stream);
            StreamingUtils.writeInt(this.pushChatPeriodMs, stream);
            StreamingUtils.writeInt(this.pushChatLimit, stream);
            StreamingUtils.writeInt(this.savedGifsLimits, stream);
            StreamingUtils.writeInt(this.editTimeLimit, stream);
            StreamingUtils.writeInt(this.ratingEDecay, stream);
            StreamingUtils.writeInt(this.stickersRecentLimit, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.tmpSessions, stream);
            }
            StreamingUtils.writeInt(this.pinnedDialogsCountMax, stream);
            StreamingUtils.writeInt(this.callReceiveTimeoutMs, stream);
            StreamingUtils.writeInt(this.callRingTimeoutMs, stream);
            StreamingUtils.writeInt(this.callConnectTimeoutMs, stream);
            StreamingUtils.writeInt(this.callPacketTimeoutMs, stream);
            StreamingUtils.writeTLString(this.meUrlPrefix, stream);
            StreamingUtils.writeTLVector(this.disabledFeatures, stream);
        }

        public override string toString() => 
            "config#cb601684";
    }
}

