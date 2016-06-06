
using System.Collections.Generic;

namespace Steam
{

        public class Friend
        {
            public string steamid { get; set; }
        }

        public class Friendslist
        {
            public List<Friend> friends { get; set; }
        }

        public class SteamFriendAdvance
        {
            public Friendslist friendslist { get; set; }
        }
    
}
