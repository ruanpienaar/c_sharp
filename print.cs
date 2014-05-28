using System;

namespace Application
{
	
	class Base
{
    public virtual void Foo(int x)
    {
        Console.WriteLine ("Base.Foo(int)");
    }
}

class Derived : Base
{
    public override void Foo(int x)
    {
        Console.WriteLine ("Derived.Foo(int)");
    }
    
    public void Foo(object o)
    {
        Console.WriteLine ("Derived.Foo(object)");
    }
}

class Test
{
    static void Main()
    {
        Derived d = new Derived();
        int i = 10;
        d.Foo(i);
    }
}
	
}