# tinyTypes
tiny types in C#


[![Build Status](https://api.travis-ci.org/ignatandrei/tinyTypes.svg?branch=master)](https://api.travis-ci.org/ignatandrei/tinyTypes.svg?branch=master)


Tiny types is a NuGET dll , https://www.nuget.org/packages/TinyTypesObjects/

Also , you can find the construction here:
http://msprogrammer.serviciipeweb.ro/category/tinytypes/
 
The documentation is copied shameless from https://github.com/jan-molak/tiny-types

## Installation

To install the module from nuget :
...
Install-Package TinyTypesObjects 
...

## Defining Tiny Types

> An int on its own is just a scalar with no meaning. With an object, even a small one, you are giving both the compiler 
and the programmer additional information  about what the value is and why it is being used.
>
> &dash; [Jeff Bay, Object Calisthenics](http://www.xpteam.com/jeff/writings/objectcalisthenics.rtf)

### Single-value types

To define a single-value `TinyType` - extend from `TinyType<T>()` :

If you want operator ==, please use TinyTypeOf or TinyTypeOfString
```csharp
using TinyTypesObjects;

public class Age : TinyTypeOf<int>
    {
        public Age(int nr) : base(nr)
        {

        }
    }
public class FirstName : TinyTypeOfString
    {
        public FirstName(string str) : base(str)
        {

        }
    }

```


Every tiny type defined this way has
a get  property `value` of type `T`, which you can use to access the wrapped primitive value. For example:

```csharp
var firstName = new FirstName("Jan");

Assert.AreEqual(firstName.value , "Jan");
        
```

### Converting from / to original values

There are defined conversions between type `T` and the class
```csharp
public void TestConvert()
        {
            string s = "http://msprogrammer.serviciipeweb.ro";
            TinyTypeOfString tt = s;
            Assert.AreEqual(s, (string)tt);

            int nr = 7;
            TinyTypeOf<int> tt1 = nr;

            Assert.AreEqual(nr, (int)tt1);
        }
        
```

so the following code should work for the class with constructor string
```csharp
class TestConstructor
    {
        public TestConstructor(string firstName)
        {
            FirstName = firstName;
        }

        public string FirstName { get; }
    }
[TestMethod]
        public void TestConstructor()
        {
            var firstName = new FirstName("Jan");
            TestConstructor tc = new TestConstructor(firstName);
            Assert.AreEqual(tc.FirstName, "Jan");
        }
```

#### Equals

Each tiny type object has an `equals` method, which you can use to compare it by value:

```csharp
int nr = 7;
            TinyTypeOf<int> tt1 = nr;
            TinyTypeOf<int> tt2 = nr;

            Assert.AreEqual(tt1, tt2);
            Assert.IsTrue(tt1 == tt2);
```
