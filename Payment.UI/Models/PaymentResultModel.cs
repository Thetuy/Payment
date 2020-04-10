using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.UI.Models
{
    public class PaymentResultModel
    {
        public string Version { get; set; }
public string Request_timestamp { get; set; }
public string merchant_id { get; set; }
public int currency { get; set; }
public string order_id { get; set; }
public int amount { get; set; }
public string invoice_no { get; set; }
public string transaction_ref { get; set; }
public string approval_code { get; set; }
public int eci { get; set; }
public string transaction_datetime { get; set; }
public int payment_channel { get; set; }
public int payment_status { get; set; }
public int channel_response_code { get; set; }
public string channel_response_desc { get; set; }
public string masked_pan { get; set; }
public string stored_card_unique_id { get; set; }
public string backend_invoice { get; set; }
public string paid_channel { get; set; }
public int recurring_unique_id { get; set; }
public string paid_agent { get; set; }
public string payment_scheme { get; set; }
public string user_defined_1 { get; set; }
public string user_defined_2 { get; set; }
public string user_defined_3 { get; set; }
public string user_defined_4 { get; set; }
public string user_defined_5 { get; set; }
public string browser_info { get; set; }
public int ippPeriod { get; set; }
public string ippInterestType { get; set; }
public string ippInterestRate { get; set; }
public string ippMerchantAbsorbRate { get; set; }
public string process_by { get; set; }
public string sub_merchant_list { get; set; }
public string hash_value { get; set; }

    }
}
