using System;
using System.Data;
using System.Collections;

namespace Interview
{
    public interface IStoreable<T>
    {
        T Id { get; set; }
    }
    
}