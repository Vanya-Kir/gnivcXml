// See https://aka.ms/new-console-template for more information
using gnivcXml;

const string xmlPath = @"C:\Users\van-k\OneDrive\Рабочий стол\ГНИВЦ\UT_ZVREGBENZ_5252_5252_5252000777525201001_20210125_7F167963-6BF9-494E-90BB-461759218EY1.xml";

var objFile = new XmlSerialize().ConvertXmlToObject<gnivcXml.zvregbenz.File>(xmlPath);
objFile.SaveMetaData(xmlPath);
Console.WriteLine(objFile.ToString());
