// See https://aka.ms/new-console-template for more information

using AM.Core.Domain;
using AM.Core.Interface;
using AM.Core.Service;
using AM.Data;

//Console.WriteLine("Hello, World!");
////TP1.Question7
Plane plane = new Plane();
plane.Capacity = 300;
plane.ManufactureDate = new DateTime(2000, 1, 1);
plane.MyPlaneType = PlaneType.Boeing;
////TP1.Question8
//Plane plane1 = new Plane(PlaneType.Airbus, 100, new DateTime(2001, 9, 12));
////Tp1.Question9
//Plane plane2 = new Plane()
//{
//    Capacity = 100,
//    ManufactureDate = new DateTime(2011, 2, 14)
//};
////tp1.Question12.b
//Passenger passenger= new Passenger();
//Console.WriteLine(passenger.GetPassengerType());
//Staff staff= new Staff();
//Console.WriteLine(staff.GetPassengerType());
//Traveller traveller= new Traveller();
//Console.WriteLine(traveller.GetPassengerType());
//TP 5 QUEST 9 
//Passenger p = new Passenger() {
//    BirthDate= new DateTime(2000,1,1),
//    PassportNumber = "0000001",
//    EmailAddress = "mm@mm",
//    MyFullName = new FullName()
//    {
//        FirstName= "Mariem",
//        LastName= "Meddeb"
//    },
//    TelNumber= "25555554"
//};

//Flight f = new Flight()
//{
//    Destination="Paris",
//    Departure="Tunis",
//    FlightDate= new DateTime(2022,1,1),
//    EffectiveArrival= new DateTime(2022,1,2),
//    EstimatedDuration=120

//};

//Reservation r = new Reservation()
//{
//    Price= 100,
//    Seat= "coté fenetre",
//    VIP= true,
//    MyPassenger= p,
//    MyFlight= f
//};
AMContext ctxt= new AMContext(); //permet d'acceder la base
//ctxt.Add(r);
//ctxt.Add(p);   
//ctxt.Add(f);    
//ctxt.SaveChanges();


//TP5 Q10

//Plane pl = new Plane()
//{
//    Capacity= 100,
//    ManufactureDate= new DateTime(1999,1,1),
//    MyPlaneType=PlaneType.Airbus
//};

Flight fl = new Flight()
{
    Destination = "Paris",
    Departure = "Tunis",
    FlightDate = new DateTime(2022, 1, 1),
    EffectiveArrival = new DateTime(2022, 1, 2),
    EstimatedDuration = 120
};

//ctxt.Add(fl); //exec du code en mémoire
//ctxt.Add(pl);
//ctxt.SaveChanges();
//Console.WriteLine(fl);
//Console.WriteLine(fl.MyPlane);

//tp5 q11
//Flight flightFromDB = (Flight)ctxt.Find(typeof(Flight), 2); //extraire de la bd
//Console.WriteLine(flightFromDB);
//Console.WriteLine(flightFromDB.MyPlane);  

//tp6 quest 6
//Plane plane1 = new Plane() { Capacity = 300, ManufactureDate = new DateTime(2000, 1, 1), MyPlaneType = PlaneType.Boeing };
//AMContext aMContext = new AMContext();


//IRepository<Plane> repository = new Repository<Plane>(aMContext);
//IPlaneService planeService = new PlaneService(repository);
//planeService.Add(plane1);



//IRepository<Flight> repository1 = new Repository<Flight>(aMContext);
//IFlightService flightService = new FlightService(repository1);

//flightService.Add(fl);

Plane plane1 = new Plane() { Capacity = 300, ManufactureDate = new DateTime(2000, 1, 1), MyPlaneType = PlaneType.Boeing };
AMContext aMContext = new AMContext();
IUnitOfWork unitOfWork = new UnitOfWork(aMContext);
IPlaneService planeService = new PlaneService(unitOfWork);
planeService.Add(plane1);


IFlightService flightService = new FlightService(unitOfWork);

flightService.Add(fl);