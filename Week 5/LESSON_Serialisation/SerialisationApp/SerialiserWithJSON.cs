using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerialisationApp;

internal class SerialiserWithJSON : ISerialiser 
{
    public T DeserialiseObject<T>(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        var obj = JsonConvert.DeserializeObject<T>(jsonString);

        return obj;

    }

    public bool SerialiseObject<T>(string filePath, T obj)
    {
        try
        {
            string jsonString = JsonConvert.SerializeObject(obj);
            File.WriteAllTextAsync(filePath, jsonString);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }
}