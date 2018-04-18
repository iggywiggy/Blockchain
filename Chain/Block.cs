using System;

namespace Chain
{
    public class Block
    {
        public string Hash;
        public string PreviousHash;
        private string _data;
        private long _timeStamp;

        public Block(string data, string previousHash)
        {
            _data = data;
            PreviousHash = previousHash;
            _timeStamp = DateTime.Now.Ticks;
            Hash = CalculateHash();
        }

        private string CalculateHash()
        {
            return StringExtensions.ApplySha256(PreviousHash + _timeStamp + _data);
        }
    }
}