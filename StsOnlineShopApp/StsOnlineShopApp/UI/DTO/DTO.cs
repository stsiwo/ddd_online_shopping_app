using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using System.Runtime.Serialization;

namespace StsOnlineShopApp.UI.DTO
{
    [DataContract]
    public class DTO : IDTO
    {
        public string ToJson()
        {
            // create stream to serialize the object to
            MemoryStream ms = new MemoryStream();

            // create serializer to searialize object to stream
            DataContractJsonSerializer ser = new DataContractJsonSerializer(this.GetType());

            // serialize this object to stream
            ser.WriteObject(ms, this);

            // change stream to array
            byte[] json = ms.ToArray();

            // close stream since unnecessary
            ms.Close();

            // convert the array to json string and return 
            return Encoding.UTF8.GetString(json, 0, json.Length);
            
        }
    }
}
