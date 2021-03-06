﻿using ModelLayer.General_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer.General_Models
{
    public class Message : IMessage
    {
        private IUser user;
        private string time;
        private string messageContent;

        public Message()
        {
            time = String.Empty;
            messageContent = String.Empty;
        }

        public IUser User
        {
            get { return user; }
            set { user = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string MessageContent
        {
            get { return messageContent; }
            set { messageContent = value; }
        }
    }
}
