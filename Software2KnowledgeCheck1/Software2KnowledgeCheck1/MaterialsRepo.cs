using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class MaterialsRepo
    {
        public static List<string> GetMaterials(Building building)
        {
            List<string> materials = new();
            
            materials.Add("Electrical");
            materials.Add("Plumbing");

            switch (building)
            {
                case Apartment:
                    materials.Add("Concrete");
                    materials.Add("Apartment Materials");
                    break;
                case HighRise:
                    materials.Add("Steel");
                    materials.Add("High Rise Materials");
                    break;
                case Building:
                    materials.Add("Wood");
                    materials.Add("House Materials");
                    break;
                default:
                    break;
            }
            return materials;
        }
    }
}
