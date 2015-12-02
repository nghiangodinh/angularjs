using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APM.WebAPI.Models
{
    public class Product
    {
        //[JsonProperty("description")]
        public string Description { get; set; }

        //[JsonProperty("price")]
        public decimal Price { get; set; }

        //[JsonProperty("productCode")]
        public string ProductCode { get; set; }

        //[JsonProperty("productId")]
        public int ProductId { get; set; }

        //[JsonProperty("productName")]
        public string ProductName { get; set; }

        //[JsonProperty("releaseDate")]
        public DateTime ReleaseDate { get; set; }

    }
}