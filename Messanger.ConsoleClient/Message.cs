﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger.ConsoleClient
{
    [Serializable]
    public class Message
    {
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }

        public Message(string userName, string messageText, DateTime timeStamp)
        {
            UserName = userName;
            MessageText = messageText;
            TimeStamp = timeStamp;
        }

        public Message()
        {
            UserName = "yarponomarev";
            MessageText = "Server is running...";
            TimeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            string output = string.Format("{0} <{2}>: {1}", UserName, MessageText, TimeStamp);
            return output;
        }
    }
}