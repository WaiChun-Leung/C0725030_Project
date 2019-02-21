using System;


namespace C0725030_Project
{

    class CountrySide
    {
        static void Main()
        {
            new CountrySide().Run();
            
        }

        public void Run()
        {
            //Call the village and Alst is the starting point
            this.TravelVillages(Alst);

            Alst = new Village("Alst", false);
            Schvenig = new Village("Schenig", false);
            //Maeland = new Village("Maeland", false);
            //Helmholtz = new Village("Helmholtz", false);
            //Uster = new Village("Uster", false);
            //Badden = new Village("Badden", false);
            Wessig = new Village("Wessing", true);

            Alst.distanceToEastVillage = 19;
            Alst.distanceToWestVillage = 14;
            Alst.west = Schvenig;
            Alst.east = Wessig;

            //Schvenig.distanceToNextVillage = 14;
            Schvenig.west = null;
            Schvenig.east = null;

            //Wessig.distanceToNextVillage = 19;
            Wessig.west = null;
            Wessig.east = null;

            CurrentVillage = Alst;

        }
        
        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;
        Village CurrentVillage;

        public void TravelVillages(Village CurrentVillage)
        {

            if (CurrentVillage.isAstrildgeHere)
            {
                Console.WriteLine("I found Dear Astrildge in {}", CurrentVillage.VillageName);
                Console.WriteLine("*****FELLING HAPPY!!!*****");
                return;
            }

            //This is recursion
            TravelVillages(CurrentVillage.west);
            TravelVillages(CurrentVillage.east);
        }
    }                
        class Village
        {
            public Village(string _villageName, bool _isAHere)
            {
                isAstrildgeHere = _isAHere;
                VillageName = _villageName;
            }

            public string CurrentVillage;
            public Village west;
            public Village east;
            public string VillageName;
            public int distanceToNextVillage;
            public int distanceToWestVillage;
            public int distanceToEastVillage;
            public int distanceToPreviousVillage;
            public bool isAstrildgeHere;
        }
}
