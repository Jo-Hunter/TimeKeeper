using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Business_Layer
{
    class Session
    {
        //Declare properties of a Customer
        //Set-Get properties
        //Declare default constuctor
        //Parameterised Constructor

        private int sessionID, topicID, projectID, sessionTagsID, sessionNotesID, extraID, sessionLinksID;
        private DateTime startTime, stopTime;
        private bool archive;

        //Set-Get properties
        public int SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }

        public int TopicID
        {
            get { return topicID; }
            set { topicID = value; }
        }

        public int ProjectID
        {
            get { return projectID; }
            set { projectID = value; }
        }

        public int SessionTagsID
        {
            get { return sessionTagsID; }
            set { sessionTagsID = value; }
        }

        public int SessionNotesID
        {
            get { return sessionNotesID; }
            set { sessionNotesID = value; }
        }

        public int ExtraID
        {
            get { return extraID; }
            set { extraID = value; }
        }

        public int SessionLinksID
        {
            get { return sessionLinksID; }
            set { sessionLinksID = value; }
        }

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public DateTime StopTime
        {
            get { return stopTime; }
            set { stopTime = value; }
        }
        public bool Archive
        {
            get { return archive; }
            set { archive = value; }
        }

        public Session() { }




        public Session(int sessionID, int topicID, int projectID, int sessionTagsID, int sessionNotesID, 
            int extraID, int sessionLinksID, DateTime startTime, DateTime stopTime, bool archive)
        {
            SessionID = sessionID;
            TopicID = topicID;
            ProjectID = projectID;
            SessionTagsID = sessionTagsID;
            SessionNotesID = sessionNotesID;
            ExtraID = extraID;
            SessionLinksID = sessionLinksID;
            StartTime = startTime;
            StopTime = stopTime;
            Archive = archive;

        }





    }
}
