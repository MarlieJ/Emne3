using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TippeKupongEnKampMerOOP
{
    internal class Match
    {
        public int homeGoals { get; private set; }
        public int awayGoals { get; private set; }
        public string bet { get; private set; }
        public bool matchIsRunning { get; private set; }
        public Match(int Home, int Away, string betting, bool matchStatus)
        {
            homeGoals = Home; 
            awayGoals = Away;
            bet = betting;
            matchIsRunning = matchStatus;
        }
        public void oneMatch()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            
            while (matchIsRunning == true)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();
                matchIsRunning = command != "X";
                if (command == "H") homeGoals++;
                else if (command == "B") awayGoals++;
                Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
            }
        }
        public void results()
        {
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            var isBetCorrect = bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }
}
