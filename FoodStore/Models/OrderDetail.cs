﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class OrderDetail
    {
        [DisplayName("Mã đơn hàng")]
        public int OrderId { get; set; }
        [DisplayName("Mã sản phẩm")]
        public int ProductId { get; set; }
        [DisplayName("Giá tiền")]
        public Nullable<decimal> Price { get; set; }
        [DisplayName("Số lượng")]
        public Nullable<int> Quantity { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
