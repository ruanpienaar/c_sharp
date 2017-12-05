# Gtk# Hello World

```
using Gtk;
using System;

class Hello
{
    static void Main ()
    {
        Application.Init ();

        Window window = new Window ("Hello Mono World");
        window.Show ();

        Application.Run ();
    }
}
```

```
mcs hello.cs -pkg:gtk-sharp-2.0
```


## On Mac Osx
```
mono --arch=32 hello.exe
```