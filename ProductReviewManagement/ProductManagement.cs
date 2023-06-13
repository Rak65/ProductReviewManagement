using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        public void TopRecords(List<ProductReview> listReview)
        {
            var top3Records=(from productreview  in listReview
                             orderby productreview.Rating descending
                             select productreview).Take(3);
            foreach (var data in top3Records)
            {
                Console.WriteLine("ProductID:-" + data.ProductID + " " + "UserID:- " + data.UserID +
                    " Rating:-" + data.Rating + " Review:-" + data.Review + " IsLike:-" + data.IsLike);
            }
        }
    }
}
