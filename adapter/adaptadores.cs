using System.Collections.Generic;
using System.Xml;
using Newtonsoft.Json;

namespace adapter;

class IzapatoJSONAdapter : IzapatoJSONOrigin{
    public string GetZapatosXMLSpecifications(){
        List<Zapatos> zapatos = new List<Zapatos>();
        zapatos.Add(new Zapatos {
            tipo = "Bota de cuero",
            costo = 345.00
        });
        zapatos.Add(new Zapatos {
            tipo = "Botas de gamuza",
            costo = 345.00
        });
        dynamic collectionZapatos = new { Botas = zapatos };
        return JsonConvert.SerializeObject(collectionZapatos);

    }
}
    class IzapatoXMLAdapter : IzapatoXMLTarget {
    public XmlDocument GetZapatosXMLSpecifications(IzapatoJSONOrigin zapatoJSONAdapter) {
        string jsonZapato = zapatoJSONAdapter.GetZapatosXMLSpecifications();
        XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonZapato, "Zapatos", true);
        return doc;
    }
}