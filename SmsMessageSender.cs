﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    internal class SmsMessageSender : MessageSender
    {
        public SmsMessageSender(string @from) : base(@from)
        { }
        public override Message Send(string text)
        {
            return new SmsMessage();
        }
    }
}