using System;

namespace Object_Oriented_Assignment
{
    abstract class Painting
    {
        public string groupName = "Painting";
        public void message()
        {
            Console.WriteLine("Private message!");
        }
        public virtual void entry()
        {
            Console.WriteLine("main entry");
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
        public void myPublicMessage()
        {
            Console.WriteLine("public message!");
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
        public override void entry()
        {
            Console.WriteLine("new entry");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Name newName = new Name();
            Artist newArtist = new Artist();
            Medium newMessage = new Medium();
            Year newYear = new Year();

            Painting myEntry = new Year();

            newMessage.myPublicMessage();
            newMessage.message();

            myEntry.entry();

            newName.MyPaintname = "Painting number one";
            newArtist.MyArtistname = "John Doe";
            Console.WriteLine("PaintName: " + newName.MyPaintname);
            Console.WriteLine("ArtistName: " + newArtist.MyArtistname);
            Console.WriteLine("Good Bye!");
        }
    }
}
