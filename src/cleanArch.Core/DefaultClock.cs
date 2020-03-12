using System;

namespace cleanArch.Core
{
    public class DefaultClock : IClock
    {
        public DateTime Now() {
            return DateTime.Now;
        }
    }
}
