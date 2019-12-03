using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeper.Business_Layer;

namespace TimeKeeper
{
    class GlobalVariables
    {

        // Keeps track of the current session.
        public static int currentSessionID;

        public static int selectedCategoryID = 0;
        public static int selectedTopicID;
        public static string selectedTopicName;

        public static Session sess = new Session();

    }
}
