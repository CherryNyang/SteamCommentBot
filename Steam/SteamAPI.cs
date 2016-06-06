using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    public class SteamAPI
    {
        protected static string API_DevKey = "832E44347F8AAA3F697222FEE7676B31";
        public static string API_AdvancePlayer(string profile)
        {
            string str = "http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=" + API_DevKey + "&steamids=" + profile;
            return str;
        }
        public static string API_GetFriend(string profile)
        {
            string str = "http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key="+API_DevKey+"&steamid="+profile+"&relationship=friend";
            return str;
        }
    }
}
