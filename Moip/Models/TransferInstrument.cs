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
    public class TransferInstrument : BaseModel
    {
        private BankAccountRequest bankAccount;
        private MoipAccountCustomer moipAccount;
        private String method;

        [JsonProperty("method")]
        public String Method
        {
            get
            {
                return this.method;
            }
            set
            {
                this.method = value;
                onPropertyChanged("Method");
            }
        }

        [JsonProperty("bankAccount")]
        public BankAccountRequest BankAccount
        {
            get
            {
                return this.bankAccount;
            }
            set
            {
                this.bankAccount = value;
                onPropertyChanged("BankAccount");
            }
        }

        [JsonProperty("moipAccount")]
        public MoipAccountCustomer MoipAccount
        {
            get
            {
                return this.moipAccount;
            }
            set
            {
                this.moipAccount = value;
                onPropertyChanged("MoipAccount");
            }
        }
    }
}
