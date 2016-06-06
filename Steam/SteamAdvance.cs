using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    public class Player
    {
        public string steamid { get; set; }
        public int communityvisibilitystate { get; set; }
        public string personaname { get; set; }
        public int commentpermission { get; set; }

    }

    public class Response
    {
        public List<Player> players { get; set; }
    }

    public class SteamAdvance
    {
        public Response response { get; set; }
    }
}
