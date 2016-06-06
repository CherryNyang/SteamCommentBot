using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
   public class DatagridDB
    {
        public string SteamID;

        public bool UserProfileStatus;

        public int UserFriendCount;



        [Description("UserSteamID")]
        [DisplayName("SteamID")]
        [Category("User")]
        [ReadOnly(true)]
        public string _SteamID
        {
            get { return this.SteamID; }
            set { this.SteamID = value; }
        }
        [Description("UserProfileStauts")]
        [DisplayName("UserPorfileStauts")]
        [Category("User")]
        [ReadOnly(true)]
        public bool _UserProfileStatus
        {
          get { return this.UserProfileStatus; }
            set { this.UserProfileStatus = value; }
        }
        [Description("UserFriendCount")]
        [DisplayName("UserFriendCount")]
        [Category("User")]
        [ReadOnly(true)]
        public int _UserFriendCount
        {
            get { return this.UserFriendCount; }
            set { this.UserFriendCount = value; }
        }
        public DatagridDB() { }
    }
}
