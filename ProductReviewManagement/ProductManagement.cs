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
        public void RatingProductId(List<ProductReview> listReview)
        {
            var ratingProductId=(from productreview in listReview
                                 where productreview.Rating>3
                                 && (productreview.ProductID == 1 || productreview.ProductID == 4 || productreview.ProductID == 9)
                                 select productreview);
            foreach (var data in ratingProductId)
            {
                Console.WriteLine("ProductID:-" + data.ProductID + " " + "UserID:- " + data.UserID +
                    " Rating:-" + data.Rating + " Review:-" + data.Review + " IsLike:-" + data.IsLike);
            }
        }
        public void CountProductIdReview(List<ProductReview> listReview)
        {
            var result = listReview.GroupBy(a => a.ProductID).Select(a => new { ProductID = a.Key, Count = a.Count() });
            foreach(var data in result)
            {
                Console.WriteLine("Product ID = "+data.ProductID+" Count = "+data.Count);
            }
        }
    }
}