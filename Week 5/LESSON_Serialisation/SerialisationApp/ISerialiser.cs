using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationApp;

internal interface ISerialiser
{
    //<T> refers to type to be referred to 
    //later
    bool SerialiseObject<T>(string filePath, T obj);

    T DeserialiseObject<T>(string fileath);
    
}
