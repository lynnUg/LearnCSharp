using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnCSharp.Models;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ViewHelloWorld();
           // ViewClassesObjects();
           // ViewPolymorphism();
           //ViewDelegates();
           //ViewLinq();
           // ViewExtensionMethods();
            ViewActors();
            InsertDestination();
           
        }
        private static void ViewHelloWorld()
        {
            Console.WriteLine("Helloworld");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        private static void ViewClassesObjects()
        {
            Plane someBoeing777 = new Plane
             {
               Identifier="BA009",
               Direction=Plane.DirectionOfApproach.Approaching,
               SpeedInMilesPerHour=150,
               Position=new PolarPoint3D(20,180,14500) 
             };
            someBoeing777.SpeedInMilesPerHour = 150.0;
            Console.WriteLine("Your Plane identifier {0},"+
                "and is travelling at {1:0.00} mph [{2:0.00}kph]",
                someBoeing777.Identifier,
                someBoeing777.SpeedInMilesPerHour,
                someBoeing777.SpeedInKilometersPerHour
                );
            someBoeing777.SpeedInMilesPerHour = 140.0;
            Console.WriteLine("Your Plane identifier {0}," +
                "and is travelling at {1:0.00} mph [{2:0.00}kph]",
                someBoeing777.Identifier,
                someBoeing777.SpeedInMilesPerHour,
                someBoeing777.SpeedInKilometersPerHour
                );
            someBoeing777.Direction = Plane.DirectionOfApproach.Approaching;
            Console.ReadKey();
        }
        private static void ViewPolymorphism()
        {
            FireFighter joe = new FireFighter { Name = "Joe" };
            joe.ExtinguishFire();

            TraineeFireFighter bill = new TraineeFireFighter { Name = "Bill" };
            bill.ExtinguishFire();

            FireStation station = new FireStation();
            station.ClockIn(joe);
            station.ClockIn("bill");
           
            station.RollCall();
            Console.ReadKey();

        }
        private static void ViewDelegates()
        {
              Document doc1 = new Document
            {
                Author = "Mathew Adams",
                DocumentDate = new DateTime(2000, 01, 01),
                Text = "Am I one year early?"

            };

            DocumentProcessor processor = DocumentProcessor.Configure();
            processor.Process(doc1);
            Console.ReadKey();
        }
        private static void ViewLinq()
        {
            LinqSamples sample1 = new LinqSamples();
            sample1.FirstSample();
            sample1.SecondSample();
            sample1.thirdSample();

        }
        private static void ViewExtensionMethods()
        {
            double pi = "3.1415926535".ToDouble();
            Console.WriteLine(pi);
            Console.ReadKey();
        }
        private static void ViewActors()
        {
           DvdContext db =new DvdContext();
           var Actors = db.Actors.Where(i => i.Name == "Chris").ToList();
           Console.WriteLine("Actors Names");
           foreach (var aActor in Actors)
           {
             Console.WriteLine(aActor.Name);
           }
           Console.ReadKey();
        }
        private static void GetInsertDvd()
        {
            using (DvdContext db = new DvdContext())
            {

                // film generes
                FilmGenere actionGenere = db.FilmGeneres.Where
                (g => g.Name == "Action").SingleOrDefault();
                // find the producer
                Producer jjAbrams = db.Producers.Where
                (p => p.FullName == "J.J. Abrams").SingleOrDefault();
                // we found the producer
                if (jjAbrams != null)
                {
                    // add some films to that producer
                    FilmTitle film1 = new FilmTitle()
                    {
                        Title = "Mission: Impossible III",
                        ReleaseDate = DateTime.Now,
                        Duration = 126,
                        Story = "Ethan Hunt comes face to face with a dangerous and ...",
                        FilmGenere = actionGenere
                    };
                    film1.Producers = new List<Producer>();
                    film1.Producers.Add(jjAbrams);
                    db.FilmTitles.Add(film1);
           
                    // add some film role
                    Role leadRole = db.Roles.Where(r =>
                    r.Name == "Lead").SingleOrDefault();
                   
                    // load the actor
                    Actor tom = db.Actors.Where(a =>
                    a.Surname == "Cruise").SingleOrDefault();
                   
                    // add filmrole
                    db.FilmActorRoles.Add(new FilmActorRole()
                    {
                        Actor = tom,
                        Role = leadRole,
                        FilmTitle = film1,
                        Character = "Ethan",
                        Description = "Ethan Hunt comes face to face with"
                        + "a dangerous and sadistic arms dealer while trying to "
                        + "keep his identity secret in order to protect his girlfriend."
                    });
                   
                }

                db.SaveChanges();
            }
            
          

        }
        private static void InsertDestination()
        {
            var destination = new Destination
            {
                Country = "Indonesia",
                Description = "EcoTourism at its best in exquisite Bali",
                //Name = "Bali"
            };
            using (var context = new TravelContext())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
        }
        
        
    }
}
