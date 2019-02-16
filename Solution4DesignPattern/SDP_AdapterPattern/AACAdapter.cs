using System;

namespace SDP_AdapterPattern
{
    class AACAdapter:Plugin
    {
        private AACDecoder decoder = new AACDecoder();
        public override void Decode()
        {
            Console.WriteLine("[AACAdapter] Decode");
            decoder.DecodeStream();
        }
    }
}