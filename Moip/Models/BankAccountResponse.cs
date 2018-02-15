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
    public class BankAccountResponse : BaseModel
    {
        private String id;
        private String type;
        private String bankNumber;
        private String agencyNumber;
        private String bankName;
        private String status;
        private String createdAt;

        private Int32 accountNumber;
        private HolderRequest holder;


        [JsonProperty("id")]
        public String Id
        {
            get
            {
                return this.id;
            }
        }

        [JsonProperty("bankName")]
        public String BankName
        {
            get
            {
                return this.bankName;
            }
        }

        [JsonProperty("status")]
        public String Status
        {
            get
            {
                return this.status;
            }
        }

        [JsonProperty("createdAt")]
        public String CreatedAt
        {
            get
            {
                return this.createdAt;
            }
        }

        [JsonProperty("type")]
        public String Type
        {
            get
            {
                return this.type;
            }
        }

        [JsonProperty("BankNumber")]
        public String BankNumber
        {
            get
            {
                return this.bankNumber;
            }

        }

        [JsonProperty("agencyNumber")]
        public String AgencyNumber
        {
            get
            {
                return this.agencyNumber;
            }
        }

        [JsonProperty("accountNumber")]
        public Int32 AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
        }

        [JsonProperty("holder")]
        public HolderRequest Holder
        {
            get
            {
                return this.holder;
            }
        }
    }
}
