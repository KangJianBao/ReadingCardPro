using System.Drawing;

namespace RTISModels
{
    class Resource
    {
        public int UniqueId { get; set; }

        public int ResourceId { get; set; }

        public string ResourceName { get; set; }

        public int Color { get; set; }

        public string Image { get; set; }

        public string CustomField1 { get; set; }
        //UniqueId, ResourceId, ResourceName, Color, Image, CustomField1
    }
}
