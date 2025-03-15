﻿namespace MedCenter_API_CSharp.Data.Models
{
    public class Promocode
    {        

        public Guid Id { get; set; }
        public int SalePercentage { get; set; }
        public bool IsRedeemed { get; set; }


        public Promocode(Guid id, int salePercentage, bool isRedeemed)
        {
            Id = id;
            SalePercentage = salePercentage;
            IsRedeemed = isRedeemed;
        }

    }
}
