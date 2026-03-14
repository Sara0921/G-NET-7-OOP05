namespace Assignment_5
{
    internal class Program
    {
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
            #endregion
        }
    }
}
