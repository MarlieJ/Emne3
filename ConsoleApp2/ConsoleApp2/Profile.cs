using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendface
{
    internal class Profile
    {
        public string Name { get; set; } //magisk get set for å sette og sende attributtene?
        public int Age { get; set; }

        public string RelationShipStatus { get; set; }
        public string Address { get; set; }
        public List<Profile> Friends { get; set; }
       
        public Profile(string name)
        {
            Name = name;
            Friends = new List<Profile>();
        }

        public void AddFriend(Profile friendToAdd) //profile er for å sende med hele profilen fra classen.
        {
            Friends.Add(friendToAdd);
        }
        public void RemoveFriend()
        {

        }

    }
}
