using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OTS2023_V9.Models;
using OTS2023_V9.Services.Interfaces;

namespace OTS2023_V9.Services.Fake
{
    public class FakeCouponService : ICouponService
    {
        public Guid couponId;
        public Coupon GetCouponById(Guid id)
        {
            Coupon coupon = new Coupon();
            coupon.Id = Guid.Parse("123e4567-e89b-12d3-a456-426614174000");
            coupon.Code = "DISCOUNT10";
            coupon.Amount = 10;
            coupon.ExpirationDate = DateTime.Now.AddDays(30);
            coupon.MinimalRequiredOrderTotal = 50;
            coupon.Used = false;

            return coupon;
        }

        public void UseCoupon(Guid id)
        {
            couponId = id;
        }
    }
}
