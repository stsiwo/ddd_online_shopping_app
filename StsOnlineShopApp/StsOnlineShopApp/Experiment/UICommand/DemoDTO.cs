using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Experiment.UICommand
{
    [DataContract]
    public class DemoDTO : DTO
    {
        [DataMember]
        public String Id { get; private set; }

        [DataMember]
        public String Name { get; private set; }

        public DemoDTO(String id, String name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
