using System;
using System.Collections;

//ref link:https://www.youtube.com/watch?v=LTFyh_WRZ3c&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=11
// C# doesnt support multiple inheritance but C++ do

class ClassOne { 
    public ClassOne() { }
    public void Foo() { }
    public void Bar() { }
}
//class ClassTwo { public ClassTwo(int i, char c) { } } // no parameter list constructor
class ClassTwo : ClassOne { public ClassTwo() { } } // inherits class one
//class ClassThree : ClassOne { public ClassThree() { } } // inherits class one
class ClassThree { public ClassThree() { } }

//class FishyClass : ClassOne, ClassThree { } // does not support multiple inheritance
//class FishyClass : ClassThree { } // allowed only one

class SatisfiesEveryone : ClassThree,
    IConvertible, ICloneable, 
    IEnumerable, IFormattable
{
    public object Clone()
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
    public TypeCode GetTypeCode()
    {
        throw new NotImplementedException();
    }
    public bool ToBoolean(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public byte ToByte(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public char ToChar(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public DateTime ToDateTime(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public decimal ToDecimal(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public double ToDouble(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public short ToInt16(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public int ToInt32(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public long ToInt64(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public sbyte ToSByte(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public float ToSingle(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public string ToString(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        throw new NotImplementedException();
    }
    public object ToType(Type conversionType, IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public ushort ToUInt16(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public uint ToUInt32(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
    public ulong ToUInt64(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
}

class MainClass
{
    //static T ProduceA<T>() where T : ClassOne, new()
    //static T ProduceA<T>() where T : ClassOne, ClassThree, new()    // primary constraint --- only the first class type
    //static T ProduceA<T>() where T : ClassThree, IConvertible, ICloneable, IEnumerable, IFormattable, new()
    static SatisfiesEveryone ProduceASatisfiesEveryone()
    {
        //T returnVal = new T();
        //returnVal.Foo(); //ClassOne
        //returnVal.Bar();  //ClassOne
        SatisfiesEveryone returnVal = new SatisfiesEveryone();
        return returnVal;
    }
    static void Main()
    {
        //ProduceA<ClassOne>();
        //ProduceA<ClassTwo>();
        //ProduceA<ClassThree>();
        //ProduceA<SatisfiesEveryone>();
        ProduceASatisfiesEveryone();
    }
}