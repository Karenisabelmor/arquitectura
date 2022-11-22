using System.Xml;

namespace adapter;
class Program {
    static void Main(string[] args){
        Myclient cliente = new Myclient(new IzapatoXMLAdapter(), new IzapatoJSONAdapter());
        XmlDocument xml = cliente.GetZapatoData();

        XmlNodeList lista = xml.GetElementsByTagName("Zapatos");
        XmlNodeList zapatos = ((XmlElement)lista[0]).GetElementsByTagName("Botas");

        foreach (System.Xml.XmlElement xEle in zapatos){
            Console.WriteLine(xEle.OuterXml);
        }
    }
}

