using System;

// Define the IMario interface
public interface IMario
{
    // Write your code here
}

// Implement the IMario interface in the Mario class
public class Mario : IMario
{
    public virtual void Ability()
    {
       // Write your code here
    }
}

// SuperMario class that inherits from Mario and hides the Ability() method
public class SuperMario : Mario
{
    public new void Ability()
    {
        // Write your code here
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Mario object
        // Write your code here

        // Create a SuperMario object
        // Write your code here
    }
}

