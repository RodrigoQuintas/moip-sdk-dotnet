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
    public class BankAccountRequest : BaseModel
    {
        private String id;
        private String type;
        private String bankNumber;
        private String agencyNumber;
        private Int32 accountNumber;
        private HolderRequest holder;
       

        [JsonProperty("id")]
        public String Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
                onPropertyChanged("Id");
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

        [JsonProperty("BankNumber")]
        public String BankNumber
        {
            get
            {
                return this.bankNumber;
            }
            set
            {
                this.bankNumber = value;
                onPropertyChanged("BankNumber");
            }
        }

        [JsonProperty("agencyNumber")]
        public String AgencyNumber
        {
            get
            {
                return this.agencyNumber;
            }
            set
            {
                this.agencyNumber = value;
                onPropertyChanged("AgencyNumber");
            }
        }

        [JsonProperty("accountNumber")]
        public Int32 AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
            set
            {
                this.accountNumber = value;
                onPropertyChanged("AccountNumber");
            }
        }

        [JsonProperty("holder")]
        public HolderRequest Holder
        {
            get
            {
                return this.holder;
            }
            set
            {
                this.holder = value;
                onPropertyChanged("Holder");
            }
        }
    }
}
