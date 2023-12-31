﻿using System;
using System.Collections.Generic;
using System.Data;
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
        public void RetriveProductIdAndReview(List<ProductReview> listReview)
        {
            var result = (from productreview in listReview
                          select productreview);
            foreach (var data in result)
            {
                Console.WriteLine("Product ID = " + data.ProductID + " Review = " + data.Review);
            }
        }
        public void SkipTopFive(List<ProductReview> listReview)
        {
            var result = listReview.Skip(5);

            foreach (var data in result)
            {
                Console.WriteLine("ProductID:-" + data.ProductID + " " + "UserID:- " + data.UserID +
                    " Rating:-" + data.Rating + " Review:-" + data.Review + " IsLike:-" + data.IsLike);
            }
        }
        public void AvgRating(List<ProductReview> listReview)
        {
            var result = (from productreview in listReview
                          select productreview.Rating).Average();
            Console.WriteLine("Average Rating : "+result);
        }
        public void RetrieveAllRecords(List<ProductReview> listReview)
        {
            var result = (from productreview in listReview
                          where productreview.Review.Contains("nice")
                          select productreview);
            foreach (var data in result) {
                Console.WriteLine("ProductID:-" + data.ProductID + " " + "UserID:- " + data.UserID +
                        " Rating:-" + data.Rating + " Review:-" + data.Review + " IsLike:-" + data.IsLike);
            }
        }

        public void RetrieveAllRecordsUser10(List<ProductReview> listReview)
        {
            var result = (from productreview in listReview
                          where productreview.UserID==10
                          orderby productreview.Rating
                          select productreview);
            foreach (var data in result)
            {
                Console.WriteLine("ProductID:-" + data.ProductID + " " + "UserID:- " + data.UserID +
                        " Rating:-" + data.Rating + " Review:-" + data.Review + " IsLike:-" + data.IsLike);
            }
        }

    }
}