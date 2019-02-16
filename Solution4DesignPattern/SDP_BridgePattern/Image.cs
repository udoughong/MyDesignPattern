using System;

namespace SDP_BridgePattern
{
    public abstract class Image
    {
        protected Platform platform;
        public void SetPlatform(Platform platform)
        {
            this.platform = platform;
        }
        public abstract void Init();
    }
}