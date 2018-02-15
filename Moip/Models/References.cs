using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Moip;
using Moip.Utilities;
namespace Moip.Models
{
    public class References : BaseModel
    {
        private String value;
        private String type;

        [JsonProperty("value")]
        public String Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
                onPropertyChanged("Value");
            }
        }
        [JsonProperty("type")]
        public String Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

    }
}
