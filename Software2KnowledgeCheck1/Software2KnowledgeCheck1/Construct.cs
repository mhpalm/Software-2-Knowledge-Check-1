using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Construct
    {
        public static void CreateBuilding<T>(T building) where T: Building
        {
            City city = new City();
            List<string> materials = MaterialsRepo.GetMaterials(building);
            bool permit = PermitRepo.GetPermit();
            bool zoning = ZoningRepo.GetZoningApproval();

            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                city.Buildings.Add(building);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
