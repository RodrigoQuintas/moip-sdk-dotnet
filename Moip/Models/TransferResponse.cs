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
    public class TransferResponse : BaseModel
    {
        private Int32 amount;

        private Int32 fee;
        private String updatedAt;
        private String id;
        private String status;
        private String createdAt;
        private List<EventOrder> events;   

        private TransferInstrument transferInstrument;

        [JsonProperty("amount")]
        public Int32 Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        [JsonProperty("transferInstrument")]
        public TransferInstrument TransferInstrument
        {
            get
            {
                return this.transferInstrument;
            }
            set
            {
                this.transferInstrument = value;
                onPropertyChanged("TransferInstrument");
            }
        }


    }
}
