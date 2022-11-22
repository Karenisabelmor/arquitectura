using System.Xml;
using Newtonsoft.Json;

namespace adapter;

class Myclient{
    private IzapatoXMLTarget _zapatoXmlTarget;
    private IzapatoJSONOrigin _zapatoJSONOrigin;

    public Myclient(IzapatoXMLTarget zapatoXmlTarget, IzapatoJSONOrigin zapatoJSONOrigin){
        _zapatoXmlTarget = zapatoXmlTarget;
        _zapatoJSONOrigin = zapatoJSONOrigin;
    }

    public XmlDocument GetZapatoData(){
        return _zapatoXmlTarget.GetZapatosXMLSpecifications(_zapatoJSONOrigin);
    }
}