using System;
using System.IO;
using System.Xml.Serialization;
class DataManager
{
    /// <summary>
    /// 把对象序列化成XML
    /// </summary>
    /// <param name="stream">序列化到此流</param>
    /// <param name="obj">要序列化的对象</param>
    public static void XMLWrite(Stream stream, Object obj)
    {
        XmlSerializer xmls = new XmlSerializer(obj.GetType());
        xmls.Serialize(stream, obj);
    }
    /// <summary>
    /// 把对象序列化成XML文件
    /// </summary>
    /// <param name="filePath">XML文件路径</param>
    /// <param name="obj">要序列化的对象</param>
    public static void XMLWriteToFile(string filePath, Object obj)
    {
        Stream stream = new FileStream(filePath, FileMode.Create);
        XMLWrite(stream, obj);
        stream.Close();
    }
    /// <summary>
    /// 返回反序列XML后的对象
    /// </summary>
    public static Object XMLRead(Stream stream, Object obj)
    {
        XmlSerializer xmls = new XmlSerializer(obj.GetType());
        return xmls.Deserialize(stream);
    }
    /// <summary>
    /// 返回反序列XML后的对象
    /// 失败返回null，在向下转型先判断
    /// </summary>
    public static Object XMLReadFormFile(string filePath, Object obj)
    {
        Object objects = null;
        try
        {
            Stream stream = new FileStream(filePath, FileMode.Open);
            objects = XMLRead(stream, obj);
            stream.Close();
        }
        catch { }
        return objects;
    }
}
