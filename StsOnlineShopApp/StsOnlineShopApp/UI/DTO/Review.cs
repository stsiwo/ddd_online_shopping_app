using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace StsOnlineShopApp.UI.DTO
{
    [DataContract]
    public class Review : DTO
    {
        [DataMember]
        public String Id { get; private set; }

        [DataMember]
        public String Author { get; private set; }

        [DataMember]
        public String Comment { get; private set; }

        [DataMember]
        public int Score { get; private set; }

        [DataMember]
        public String CreationDate { get; private set; }
    }
}
