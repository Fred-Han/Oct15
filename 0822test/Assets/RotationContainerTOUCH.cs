using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

// source ref: http://wiki.unity3d.com/index.php?title=Saving_and_Loading_Data:_XmlSerializer

[XmlRoot("RotationLogTOUCH")]

public class RotationContainerTOUCH
{
    [XmlArray("Rotation"), XmlArrayItem("Log")]
    //public Target[] Targets;
    public List<RotationDataTOUCH> RotationLogTOUCH = new List<RotationDataTOUCH>();

    public void createFile(string path)
    {
        var serializer = new XmlSerializer(typeof(RotationContainerTOUCH));
        using (var stream = new FileStream(path, FileMode.Create))
        {
            serializer.Serialize(stream, this);
        }
    }

    // save data to XML
    public void Save(string path)
    {
        var serializer = new XmlSerializer(typeof(RotationContainerTOUCH));

        using (var stream = new FileStream(path, FileMode.Append))
        {
            serializer.Serialize(stream, this);
           
        }
    }

}