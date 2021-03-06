using System.Xml.Serialization;

namespace EVEMon.Common.Serialization.Eve
{
    public sealed class SerializableContractItemsListItem
    {
        [XmlAttribute("recordID")]
        public long RecordID { get; set; }

        [XmlAttribute("typeID")]
        public int TypeID { get; set; }

        [XmlAttribute("quantity")]
        public long Quantity { get; set; }

        [XmlAttribute("rawQuantity")]
        public int RawQuantity { get; set; }

        [XmlAttribute("singleton")]
        public bool Singleton { get; set; }

        [XmlAttribute("included")]
        public bool Included { get; set; }
    }
}