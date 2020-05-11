using System;

namespace Object_Oriented_Assignment
{
    class Painting
    {
        public string groupName = "Painting";
        public void greet()
        {
            Console.WriteLine("Welcome to Painting!");
        }
    }

    class Name : Painting
    {
        private string paintName;
        public string MyPaintname
        {
            get
            {
                return paintName;
            }
            set
            {
                paintName = value;
            }
        }
    }
    class Artist : Painting
    {
        private string artistName;

        public string MyArtistname
        {
            get
            {
                return artistName;
            }
            set
            {
                artistName = value;
            }
        }
    }
    class Medium : Painting
    {

        private string mediumName;

        public string MyMediumname
        {
            get
            {
                return mediumName;
            }
            set
            {
                mediumName = value;
            }
        }

    }
    class Year : Painting
    {

        private string yearName;

        public string MyYearname
        {
            get
            {
                return yearName;
            }
            set
            {
                yearName = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Name newName = new Name();
            Artist newArtist = new Artist();
            Medium newMedium = new Medium();
            Year newYear = new Year();

            newArtist.MyArtistname="John Doe";
            newName.greet();
             Console.WriteLine("ArtistName: " + newArtist.MyArtistname);
            Console.WriteLine("Good Bye!");
        }
    }
}
