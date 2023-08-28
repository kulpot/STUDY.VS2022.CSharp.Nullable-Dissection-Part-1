using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


struct JNullable<T> where T : struct
{
    T value;
    bool hasValue;
    public JNullable(T value)
    {
        this.value = value;
        hasValue = true;
    }
    public override string ToString()
    {
        return value.ToString();
    }
}

