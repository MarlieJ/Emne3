namespace HarryPotter
{
    internal class Animal : StoreItem
    {
        public Animal(string AnimalName) : base(AnimalName)
        {
        }
        public void flyWithLetter(Letter letterToSend, Character person2)
        {
            person2.recieveLetter(letterToSend);
            ////          letterText + Person2
            //var receiver = letterToSend.LetterReciever;//letterToSend er nå bare brevet som er lukket. Og derfor vet ikke uglen hvilken person, derfor må vi si letterReciever. 
            //receiver.recieveLetter();
        }
    }
}
