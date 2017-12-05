# Winforms Hello World

```
using System;
using System.Windows.Forms;

public class HelloWorld : Form
{
    static public void Main ()
    {
        Application.Run (new HelloWorld ());
    }

    public HelloWorld ()
    {
        Text = "Hello Mono World";
    }
}
```

```
mcs hello.cs -pkg:dotnet
```

# On Mac Osx
```
mono --arch=32 hello.exe
```