using System;
using System.Reflection;
using System.Threading.Channels;

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
        }
    }
}
