﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures
{
    public class SupportedTopic
    {
        public SupportedTopic()
        {
            SupportedMessages = new List<string>();
        }

        public string TopicName
        {
            get;
            set;
        }

        /// <summary>
        /// If an endpoint does not support ALL CFX messages that have been defined for a given CFX topic,
        /// then it must explicitly list which messages is does support.  An empty list implies that the 
        /// endpoint supports ALL messages of this topic.
        /// </summary>
        public List<string> SupportedMessages
        {
            get;
            set;
        }
    }
}
