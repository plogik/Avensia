using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Avensia.Data.Models
{
    public class ProductPrice
    {
        [BindRequired]
        public virtual int Id { get; set; }
        public virtual int QuantityFrom { get; set; } = 0;
        public virtual int QuantityTo { get; set; } = int.MaxValue;
        public virtual decimal Price { get; set; }

        // Denna skulle höra hemma i en viewmodel i ett riktigt projekt
        public virtual bool Delete { get; set; }
    }
}