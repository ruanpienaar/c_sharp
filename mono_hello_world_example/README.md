# Console Hello World

hello.cs :
```
using System;
 
public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine ("Hello Mono World");
    }
}
```

```
mcs hello.cs
```

```
mono hello.exe
```