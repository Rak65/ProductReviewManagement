using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Welcome to Product Review Management.");
            ProductManagement  productManagement = new ProductManagement();
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 3.5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 2, UserID = 2, Rating = 4.5, Review = "fine", IsLike = true },
                new ProductReview() { ProductID = 3, UserID = 3, Rating = 2.5, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 4, UserID = 4, Rating = 3.0, Review = "excellent", IsLike = true },
                new ProductReview() { ProductID = 5, UserID = 5, Rating = 3.8, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 6, UserID = 6, Rating = 3.9, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 7, UserID = 7, Rating = 4.2, Review = "fine", IsLike = true },
                new ProductReview() { ProductID = 8, UserID = 8, Rating = 2.1, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 9, UserID = 9, Rating = 2.9, Review = "Awesome", IsLike = true },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 1.1, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 11, UserID = 11, Rating = 5.5, Review = "fine", IsLike = true },
                new ProductReview() { ProductID = 12, UserID = 12, Rating = 5.1, Review = "Good", IsLike = true },
            };
            do {
                Console.WriteLine("Choose your option : ");
                Console.WriteLine("1. Show Product Details.");
                Console.WriteLine("2. Retrieve top 3 records whose Rating is high.");
                Console.WriteLine("3. Retrieve all records where rating is greater than 3 " +
                    "and ProductID is 1 or 4 or 9.");
                Console.WriteLine("4. Retrieve Count of review present for each Product ID.");
                Console.WriteLine("5. Retrieve only ProductId and Review from the list.");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        foreach (var data in productReviews)
                        {
                            Console.WriteLine("ProductID:-" + data.ProductID + " " + "UserID:- " + data.UserID + 
                                " Rating:-" + data.Rating + " Review:-" + data.Review + " IsLike:-" + data.IsLike);
                        }
                        break;
                    case 2:
                        productManagement.TopRecords(productReviews);
                        break;
                    case 3:
                        productManagement.RatingProductId(productReviews);
                        break;
                    case 4:
                        productManagement.CountProductIdReview(productReviews);
                        break;
                    case 5:
                        productManagement.RetriveProductIdAndReview(productReviews);
                        break;
                    default:
                        Console.WriteLine("Enter valid option :");
                        break;
                }
                Console.WriteLine("Do you want to continue (1.Continue 0.Exit)");
                option = Convert.ToInt32(Console.ReadLine());
            } while (option != 0);
            Console.ReadKey();
        }
    }
}
