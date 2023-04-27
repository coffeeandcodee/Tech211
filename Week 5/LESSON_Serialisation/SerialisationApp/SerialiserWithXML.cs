using System.Xml.Serialization;

namespace SerialisationApp;

internal class SerialiserWithXML : ISerialiser
{
    public T DeserialiseObject<T>(string filePath)
    {
        FileStream fileStream = File.OpenRead(filePath);
        XmlSerializer reader =  new XmlSerializer(typeof(T));
        T obj = (T)reader.Deserialize(fileStream);
        fileStream.Close();

        return obj;

    }
    public bool SerialiseObject<T>(string filePath, T obj)
    {
        try
        {
            FileStream fileStream = File.Create(filePath);
            XmlSerializer writer = new XmlSerializer(typeof(T));
            writer.Serialize(fileStream, obj);
            fileStream.Close();
            return true; 
           /* FileStream fileStream = File.Create(filePath);
            XmlSerializer writer = new XmlSerializer(typeof(T));
            writer.Serialize(fileStream, obj);
            fileStream.Close();
            return true;*/
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }

    }
}
