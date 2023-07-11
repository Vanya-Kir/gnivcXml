// See https://aka.ms/new-console-template for more information
using gnivcXml;
using System.IO;

//var currentpath = Directory.GetCurrentDirectory();
const string xmlPath = @"..\..\..\..\UT_ZVREGBENZ_5252_5252_5252000777525201001_20210125_7F167963-6BF9-494E-90BB-461759218EY1.xml";
//currentpath = Path.GetFullPath(Path.Combine(currentpath, xmlPath));


var objFile = new XmlSerialize().ConvertXmlToObject<gnivcXml.zvregbenz.File>(xmlPath);
objFile.SaveMetaData(xmlPath);
Console.WriteLine(objFile.ToString());
