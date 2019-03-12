using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Business_Layer
{
    class Project
    {

        private int projectID, topicID, typeID;
        private string projectName, codeLocation;
        private bool archive;

        public int ProjectID
        {
            get { return projectID; }
            set { projectID = value; }
        }

        public int TopicID
        {
            get { return topicID; }
            set { topicID = value; }
        }

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public string CodeLocation
        {
            get { return codeLocation; }
            set { codeLocation = value; }
        }
        public bool Archive
        {
            get { return archive; }
            set { archive = value; }
        }

        public int TypeID{
            get { return typeID; }
            set { typeID = value; }
        }

        public Project() { }

        public Project(int projectID, string projectName, int topicID, string codeLocation, bool archive, int typeID){

            ProjectID = projectID;
            ProjectName = projectName;
            TopicID = topicID;
            CodeLocation = codeLocation;
            Archive = archive;
            TypeID = typeID;
        }



    }
}
