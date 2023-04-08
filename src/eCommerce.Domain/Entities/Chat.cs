﻿using eCommerce.Domain.Commons;

namespace eCommerce.Domain.Entities
{
    public class Chat : Auditable
    {
        public long FirstUserId { get; set; }
        public User FirstUser { get; set; }

        public long SecondUserId { get; set; }
        public User SecondUser { get; set; }
    }
}
