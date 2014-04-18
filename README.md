BabelTest
=========

### Code

```c#
using System;
using System.Reflection;

namespace BabelTest {
    class Program {
        static void Main(string[] args) {
            Console.ReadLine();
        }
    }

    public interface ITest1 {
        void SameMethod();
    }

    [Obfuscation(Feature = "renaming")]
    public interface ITest2 {
        void SameMethod(); // This should not be renamed
        void OriginalMethod();
    }
}

```

### Rule

```xml

      <XmlRules>
        <Rules targetAssembly="BabelTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null">
          <Rule name="Internalize renamed symbols" feature="renaming" exclude="false">
            <Pattern>*</Pattern>
            <Properties>
              <Internalize>true</Internalize>
            </Properties>
          </Rule>
        </Rules>
      </XmlRules>
```

### Output

* ___ITest2#SameMethod___ has been renamed too

![image](/BabelTest.png)
