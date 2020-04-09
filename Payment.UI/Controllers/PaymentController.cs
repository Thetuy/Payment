using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment.UI.Models;

namespace Payment.UI.Controllers
{
    public class PaymentController : Controller
    {
        private static readonly Encoding encoding = Encoding.UTF8;
        public IActionResult Generate()
        {
            Generate model = new Generate();
            model.Channel = "eTR";
            model.InvoiceNo = "INV20204091720";
            model.Product = "Redirect Payment";
            model.Amount = 100;
            return View("Generate", model);
        }

        [Consumes("application/json")]
        [Produces("application/json")]

        public IActionResult PaymentResult(IFormCollection form)
        {
            ViewBag.Message = form["channel_response_desc"].ToString();
            return View();
        }
        [HttpPost]
        public IActionResult Process(Generate model)
        {
            //Request information
            string version = "8.5";
            string currency = "702";
            string paymentAction = "https://demo2.2c2p.com/2C2PFrontEnd/RedirectV3/payment";
            string resultUrl = Url.Action("PaymentResult", "Payment", null, this.HttpContext.Request.Scheme);

            string merchantId = string.Empty, secretKey = string.Empty;

            //Merchant's account information
          
            merchantId = "JT01"; //Get MerchantID when opening account with 2C2P
            secretKey = "7jYcp4FxFdf0"; //Get SecretKey from 2C2P PGW Dashboard

            //Transaction information
            string paymentDescription = model.Product;
            string orderId = model.InvoiceNo;// DateTime.Now.ToLongTimeString();
            

            string amount = String.Format("{0:000000000000}", Convert.ToInt32(model.Amount.ToString("n").Replace(".", ""))); ;// "000000002500";

            string paymentOption = model.PaymentOption;



            string data = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}", version, merchantId, paymentDescription, orderId, currency, amount, resultUrl, paymentOption);
            string hashvalue = ToHashBase64(data, secretKey);  //Compute hash value


            string postMsg = string.Empty;

            postMsg = "<HTML>";
            postMsg = postMsg + "<HEAD>";
            postMsg = postMsg + "<META http-equiv='Content-Type' content='text/html; charset=windows-874'>";
            postMsg = postMsg + "</HEAD>";
            postMsg = postMsg + "<BODY onload=javascript:document.forms['sendform'].submit();>";
            postMsg = postMsg + "<FORM name='sendform' method='post' action='" + paymentAction + "'>";
            postMsg = postMsg + "<input type='hidden' name='version' value='" + version + "' />";
            postMsg = postMsg + "<INPUT type='hidden' name='merchant_id' value='" + merchantId + "'>";
            postMsg = postMsg + "<input type='hidden' name='currency' value='" + currency + "' />";
            postMsg = postMsg + "<input type='hidden' name='result_url_1' value='" + resultUrl + "' />";
            postMsg = postMsg + "<input type='hidden' name='hash_value' value='" + hashvalue + "' />";
            postMsg = postMsg + "<input type='hidden' name='payment_option' value='" + paymentOption + "' />";
            postMsg = postMsg + "<input type='hidden' name='payment_description' value='" + paymentDescription + "' />";
            postMsg = postMsg + "<input type='hidden' name='order_id' value='" + orderId + "' />";
            //postMsg = postMsg + "<input type='hidden' name='user_defined_1' value='" + orderId + "' />";
            //postMsg = postMsg + "<input type='hidden' name='user_defined_2' value='67890' />";
            //postMsg = postMsg + "<input type='hidden' name='user_defined_3' value='user_defined_3' />";
            postMsg = postMsg + "<input type='hidden' name='amount' value='" + amount + "' />";
            postMsg = postMsg + "</FORM>";
            postMsg = postMsg + "</BODY>";
            postMsg = postMsg + "</HTML>";

            return new ContentResult()
            {
                Content = postMsg,
                ContentType = "text/html",
            };
        }
       
        public string ToHashBase64(string plaintext, string key)
        {
            var keyByte = encoding.GetBytes(key);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                hmacsha256.ComputeHash(encoding.GetBytes(plaintext));

                return ByteToString(hmacsha256.Hash);
            }
        }
        public string ByteToString(byte[] buff)
        {
            string sbinary = "";
            for (int i = 0; i < buff.Length; i++)
                sbinary += buff[i].ToString("X2"); /* hex format */
            return sbinary;
        }
    }
}