using System.Xml;

namespace adapter;

interface IzapatoJSONOrigin {
    String GetZapatosXMLSpecifications();
}
interface IzapatoXMLTarget {
    XmlDocument GetZapatosXMLSpecifications(IzapatoJSONOrigin zapatoJSONAdapter);
}

