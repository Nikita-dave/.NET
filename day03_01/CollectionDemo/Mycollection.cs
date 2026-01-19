using System;
using System.Collections;
using System.Collections.Generic;
class MyCollection : IEnumerable
{
    int[] data = {1,2,3};

    public IEnumerator GetEnumerator()
    {
        return data.GetEnumerator();
    }
}