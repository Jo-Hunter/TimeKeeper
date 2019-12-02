using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Business_Layer
{
    class Link
    {

        private int linkID, sessionID;
        private string linkName;

        public int LinkID
        {
            get { return linkID; }
            set { linkID = value; }
        }
        public int SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }
        public string LinkName
        {
            get { return linkName; }
            set { linkName = value; }
        }

        public Link(int linkID, int sessionID, string linkName)
        {
            LinkID = linkID;
            SessionID = sessionID;
            LinkName = linkName;
        }
    }
}
