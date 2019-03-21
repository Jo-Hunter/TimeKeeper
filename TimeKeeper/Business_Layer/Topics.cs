using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Business_Layer
{
    class Topics
    {
        private int topicID;
        private string topicName;

        public int TopicID
        {
            get { return topicID; }
            set { topicID = value; }
        }
        public string TopicName
        {
            get { return topicName; }
            set { topicName = value; }
        }

        public Topics() { }

        public Topics(int topicID, string topicName)
        {
            TopicID = topicID;
            TopicName = topicName;
        }

    }
}
