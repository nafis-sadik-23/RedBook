﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Inventory.Domain.Entities
{
    public partial class PurchasePaymentRecord
    {
        public int Id { get; set; }
        public string ChalanNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }

        public virtual Purchase ChalanNumberNavigation { get; set; }
    }
}
