

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Corrected by Ramon Soto
namespace Activity10
{
    class Program //C# class
    { //Main() method
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();//object of class Set
            Set B = new Set();//object of class Set
                              //put some stuff in the sets
            Random r = new Random();
            //using for loop
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }
            //display each set and the union
            Console.WriteLine("A: " + A);//print set A
            Console.WriteLine("B: " + B);//print set B
            Console.WriteLine("A union B: " + A.union(B));
            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);//print set A
            Console.WriteLine("B: " + B);//print set B
        }
    }
}
namespace Activity10
{
class Set //C# class Set
{
    //need to create the List of int instead of generic list
    private List<int> elements;
    //Constructor
    public Set()
    {
        elements = new List<int>();
    }
    //method to add elements into the List
    public bool addElement(int val)
    {
        if (containsElement(val)) return false;
        else
        {
            elements.Add(val);
            return true;
        }
    }
    private bool containsElement(int val)
    { //using for loop
        for (int i = 0; i < elements.Count; i++)
        {
            //checking value with element
            if (val == elements[i])
                return true;
            else
                return false;
        }
        return false;
    }
    //ToString() method
    public override string ToString()
    {
        string str = "";
        //using for each loop
        foreach (int i in elements)
        {
            str += i + " ";
        }
        return str;
    }
    //This method used to clear set
    public void clearSet()
    {
        elements.Clear();
    }
    //This method is used for Union
    public Set union(Set rhs)
    { //using for loop
        for (int i = 0; i < rhs.elements.Count; i++)
        { //call method addElement()
            this.addElement(rhs.elements[i]);
        }
        return rhs;//return union of two sets
    }
}
}
