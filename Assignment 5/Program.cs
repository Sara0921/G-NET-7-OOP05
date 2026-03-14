using System;
using System.Reflection;
using System.Threading.Channels;

namespace Assignment_5
{
    internal class Program
    {
        #region Part02
        ////Interfaces
        //interface IPrintable
        //{
        //    void PrintTicket();

        //}
        //interface IBookable
        //{
        //    bool IsBooked { get; }
        //    void Book();
        //    void Cancel();


        //}
        //enum TicketType
        //{
        //    Standard,
        //    VIP,
        //    IMAX
        //}
        //struct Seat
        //{
        //    public char Row;
        //    public int Number;
        //    public Seat(char row, int number)
        //    {
        //        Row = row;
        //        Number = number;
        //    }
        //    public override string ToString() => $"{Row}{Number}";
        //}
        //class Ticket : IPrintable , IBookable , ICloneable
        //{
        //    public static int counter = 0;
        //    public string MovieName { get; set; }
        //    public int Ticketid { get; set; }
        //    private decimal _price;
        //    public decimal Price
        //    {
        //        get
        //        {
        //            return _price;
        //        }
        //        set
        //        {
        //            if (value > 0)
        //                _price = value;
        //        }
        //    }
        //    public decimal PriceAfterTax => _price + (_price * 14m / 100);
        //    //IIBookable
        //    public bool IsBooked { get;  protected set; }

        //    public void Book()
        //    {
        //        if (IsBooked)
        //            Console.WriteLine($"Ticker #{Ticketid} is already booked.");
        //        else
        //            IsBooked = true;
        //    }

        //    public void Cancel()
        //    {
        //        if (!IsBooked)
        //            Console.WriteLine($"Ticker #{Ticketid} is not  booked , Can't cancel");
        //        else
        //            IsBooked = false;
        //    }

        //    public Ticket(string moviename, decimal price)
        //    {
        //        MovieName = moviename;
        //        Price = price;
        //        counter++;
        //        Ticketid = counter;
        //    }
        //    //IPrintable
        //    public virtual void PrintTicket()
        //    {
        //        Console.WriteLine($"Ticket #{Ticketid} | {MovieName} | Price :{Price} EGP | After Tax :{PriceAfterTax} EGP ");
        //    }
 
        //    // ICloneable 
        //    public virtual object Clone()
        //    {
        //        counter++;
        //        Ticket copy =(Ticket) this.MemberwiseClone();
        //        copy.Ticketid = counter;
        //        copy.IsBooked = false;
        //        return copy;
        //    }
        //    public static int GetTotalTickets() => counter;

        //}
        //class StandardTicket : Ticket
        //{
        //    public string SeatNumber { get; set; }
        //    public StandardTicket(string moviename, decimal price, string seatnumber) : base(moviename, price)
        //    {
        //        SeatNumber = seatnumber;
        //    }
          
        //    public override void PrintTicket()
        //    {
        //        Console.WriteLine($"[Ticket #{Ticketid}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");

        //    }
        //}
        //class VIPTicket : Ticket
        //{
        //    public bool LoungeAccess { get; set; }
        //    public decimal ServiceFee { get; } = 50;
        //    public VIPTicket(string moviename, decimal price, bool loungeAccess) : base(moviename, price)
        //    {
        //        LoungeAccess = loungeAccess;
        //    }
          
        //    public override void PrintTicket()
        //    {
        //        Console.WriteLine($"[Ticket #{Ticketid}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");

        //    }
        //    // Deep clone 
        //    public override object Clone()
        //    {
        //        VIPTicket copy =(VIPTicket) base.Clone();
        //        return copy;
        //    }
        //}
        //class IMAXTicket : Ticket
        //{
        //    private bool _is3D;
        //    public bool Is3D
        //    {
        //        get { return _is3D; }
        //        set
        //        {
        //            if (value && !_is3D)
        //                Price += 30;
        //            if (!value && _is3D)
        //                Price -= 30;
        //            value = _is3D;
        //        }
        //    }
        //    public IMAXTicket(string moviename, decimal price, bool is3D) : base(moviename, price)
        //    {
        //        if (is3D) Price += 30;
        //        _is3D = is3D;
        //    }
       
        //    public override void PrintTicket()
        //    {
        //        Console.WriteLine($"[Ticket #{Ticketid}] {MovieName} | IMAX | 3D: {(_is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");

        //    }
        //}
        //class Projector
        //{
        //    public bool IsRunning { get; private set; }
        //    public void Start()
        //    {
        //        IsRunning = true;
        //        Console.WriteLine("Projector started.");
        //    }
        //    public void Stop()
        //    {
        //        IsRunning = false;
        //        Console.WriteLine("Projector stopped.");
        //    }
        //}
        //class Cinema
        //{
        //    public string CinemaName { get; set; }
        //    private Projector _projector = new Projector();
        //    private Ticket[] tickets = new Ticket[20];
        //    public Cinema(string cinemaname)
        //    {
        //        CinemaName = cinemaname;
        //    }
        //    public Ticket this[int index]
        //    {
        //        get
        //        {
        //            if (index < 0 || index >= tickets.Length)
        //                return null;
        //            return tickets[index];
        //        }
        //        set
        //        {
        //            if (index < 0 || index >= tickets.Length)
        //                return;
        //            tickets[index] = value;
        //        }
        //    }
        //    public Ticket this[string movieName]
        //    {
        //        get
        //        {
        //            foreach (Ticket t in tickets)
        //            {
        //                if (t != null && t.MovieName == movieName)
        //                    return t;
        //            }
        //            return null;
        //        }
        //    }
        //    public bool AddTicket(Ticket t)
        //    {
        //        for (int i = 0; i < tickets.Length; i++)
        //        {
        //            if (tickets[i] == null)
        //            {
        //                tickets[i] = t;
        //                return true;
        //            }
        //        }
        //        Console.WriteLine("Cinema is full.");
        //        return false;
        //        {
        //        }
        //    }
        //    public void PrintAllTickets()
        //    {
        //        Console.WriteLine($"\n=== All Tickets ===");
        //        bool any = false;
        //        foreach (Ticket t in tickets)
        //        {
        //            if (t != null)
        //            {
                       
        //               t.PrintTicket();
        //            }
        //        }
        //    }
        //    public void OpenCinema()
        //    {
        //        Console.WriteLine("========== Cinema Opened ==========");
        //        //_projector.Start();
        //    }
        //    public void CloseCinema()
        //    {
        //        Console.WriteLine("========== Cinema Closed ==========");
        //        //_projector.Stop();
        //    }
        //}
        //static class BookingHelper
        //{
        //    private static int counter = 0;
        //    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        //    {
        //        double total = numberOfTickets * pricePerTicket;
        //        if (numberOfTickets > 5)
        //        {
        //            return total - (total * 10.0 / 100);
        //        }
        //        return total;
        //    }
        //    public static string GenerateBookingReference()
        //    {
        //        counter++;
        //        return $"BK-{counter}";
        //    }
        //    public static void ProcessTicket(Ticket t)
        //    {
        //        Console.WriteLine("========== Process Single Ticket ==========");
        //        t.PrintTicket();
        //    }
        //    // // Interface polymorphism
        //    public static void PrintAll(IPrintable[] items)
        //    {
        //        foreach (IPrintable item in items)
        //        {
        //            item.PrintTicket();
        //        }
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Part01
            #region Question01
            //>>An interface defines a contract that a class must follow. It specifies what a class can do, not how it does it.
            //>>Depending directly on a concrete class tightly couples your code to a specific implementation, making it rigid and hard to change.
            //>>Because Enable polymorphism without inheritance , Remove tight coupling between classes ,Enable multiple inheritance(behavior)

            #endregion
            #region Question02
            //A)>>Both interfaces have a method with the same name Greet(). 
            //>>Currently, calling Greet() from either interface will run the same method and print "Hello / Ahlan"
            //B)>>The Fix :
            //class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //    void IEnglishSpeaker.Greet () => Console.WriteLine("Hello");
            //    void IArabicSpeaker.Greet () => Console.WriteLine("Ahlan");
            //}
            //>>This technique is called Explicit Interface Implementation.
            //C)No. Explicitly implemented methods are not accessible on the concrete type — they are hidden from the class's public surface.
            //>>To call each version
            //((IEnglishSpeaker)translator).Greet();
            //((IArabicSpeaker)translator).Greet();

            #endregion
            #region Question03
            //>>Shallow Copy :duplicates the object itself, but any reference-type fields inside it still point to the same objects in memory as the original.
            //>>Deep Copy : A deep copy duplicates the object and every object it references, all the way down.
            //When would you use each one
            //shallow copy : Your object only contains value-type , You intentionally want both objects to share the same referenced data
            //Deep Copy : Your object contains reference-type , You need the copy to be fully independent
            //The Risk of Shallow Copy with Reference Fields
            //>>When you shallow-copy an object that has reference-type fields, both the original and the copy point to the exact same nested object. This means:
            //Changing a nested field through the copy also changes it in the original
            #endregion
            #region Question04
            //output :
            //>>Dev - Testing
            //>>QA - Testing
            //Why :
            //Title — each employee gets their own copy because assigning a new string("QA") creates a new string object for e2.e1.Title stays untouched.
            // Dept — MemberwiseClone() only copies the reference, not the actual Department object.So both e1 and e2 are pointing to the same Department in memory.When you change e2.Dept.Name,
            //you're changing the one shared object — which e1 also sees.

            #endregion
            #endregion
            #region Part02
            ////a
            //Cinema cinema01 = new Cinema("Galaxy");
            //cinema01.OpenCinema();

            ////b
            //StandardTicket s = new StandardTicket("Inception", 80, "A5");
            //VIPTicket v = new VIPTicket("Avengers", 200, true);
            //IMAXTicket i = new IMAXTicket("Dune", 100, true);
            //s.Book();
            //v.Book();
            //i.Book();
            //cinema01.AddTicket(s);
            //cinema01.AddTicket(v);
            //cinema01.AddTicket(i);

            ////c
            //cinema01.PrintAllTickets();

            ////d
            //VIPTicket Vclone =(VIPTicket) v.Clone();
            //Console.WriteLine("\n--- Clone Test ---");
            //Console.Write("Original : ");
            //v.PrintTicket();
            //Console.Write("Clone    : ");
            //Vclone.PrintTicket();

            ////e
            //s.Cancel(); 
            //Console.WriteLine("\n--- After Cancellation ---");
            //s.PrintTicket();

            ////f
            //Console.WriteLine("\n--- BookingHelper.PrintAll ---");
            //BookingHelper.PrintAll(new IPrintable[] {s,v,i});
            //Console.WriteLine();

            ////g

            //cinema01.CloseCinema();
            #endregion
        }
    }
}
