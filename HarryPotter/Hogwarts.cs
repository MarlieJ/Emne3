using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Hogwarts
    {
        public List<Character>  CharacterList {  get; private set; }
        public Character Player { get; private set; }
        public MagicStore MagicStore { get; private set; }
        public Hogwarts()//en ctor må ikke få tilsendt parametre. 
        {
            Console.WriteLine("Welcome to Hogwarts, choose a character:");
            MagicStore = new MagicStore();
            characterMenu();



            //MagicStore newStore = new MagicStore();//små forbokstaver på lokale variabler
            //newStore.WelcomeToTheStore(Person1);
            //newStore.WelcomeToTheStore(Person2);
            //Person1.showItemsInList();

            //Person1.Spell();//trenger ikke sende med parameter her, fordi det er sin egen klasse fordi spell er i CHaracter-klassen.
            //Person1.writeLetterToPerson(Person2);

        }
        public void characterMenu()
        {
            Console.WriteLine("Choose the character you wanna be. Type the number and press enter: ");
            CharacterList = new List<Character>() { new Character("Harry Potter", "Griffindor", "Owl", "Kristtorn"), new Character("Hermione Granger", "Griffindor", "Cat", "HokusStav") };
            for (int i = 0; i < CharacterList.Count; i++)
            {
                Console.WriteLine($"{i} {CharacterList[i].name}");
            }
            int chosenCharacterNumber = Convert.ToInt32(Console.ReadLine());
            Player = CharacterList[chosenCharacterNumber];
            chosenCharacterToPlay();
            //if (chosenCharacterNumber == 0)
            //{
            //    chosenCharacterToPlay(CharacterList[chosenCharacterNumber]);
            //}
            //else if (chosenCharacterNumber == 1)
            //{
            //    chosenCharacterToPlay(CharacterList[chosenCharacterNumber]);
            //}

        }
        public void chosenCharacterToPlay()
        {
            Player.PersonIntro();
            activityMenu();
        }

        public void activityMenu ()
        {
            bool activityIsRunning = true;
            while (activityIsRunning)
            {
                Console.WriteLine($"In this game, you can choose between different activities. Choose an activity you want to do by its number and press enter.\n " +
                $"1. Go to the store \n" +
                $"2. Throw a spell \n" +
                $"3. Send a letter to another student \n" +
                $"4. Type 4 to go to CharacterMenu." );
            long activityNumberInput = Convert.ToInt64(Console.ReadLine());
            
                if (activityNumberInput == 1)
                {
                    MagicStore.WelcomeToTheStore(Player);
                }
                else if (activityNumberInput == 2)
                {
                    Player.Spell();
                }
                else if (activityNumberInput == 3)
                {
                    Player.writeLetterToPerson(CharacterList);
                }
                else { 
                    activityIsRunning = false;
                    characterMenu();
                }
            }
        }

        /*
         * Menu to choose a thing to do
         * 
         */
    }
}
