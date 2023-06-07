//man må ikke ha main metoden lenger, det kjører i bakgrunnen.
using Friendface;

Console.WriteLine("Hello, World!");
var socialMediaAccounts = new List<Profile>();
socialMediaAccounts.Add(new Profile("Bjarne"));
socialMediaAccounts.Add(new Profile("Kurt"));
socialMediaAccounts.Add(new Profile("Stig"));
socialMediaAccounts.Add(new Profile("Nils"));

//innlogget bruker
var mainProfile = new Profile("Kåre");
mainProfile.AddFriend(socialMediaAccounts[0]);
var hei = 0;