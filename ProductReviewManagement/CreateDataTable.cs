using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class CreateDataTable
    {
        DataTable dataTable = new DataTable("ProductReviews");

        public void AddColumns()
        {
            // Add columns to the DataTable
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));

            dataTable.Rows.Add(1, 111, 5.5, "Good", true);
            dataTable.Rows.Add(2, 112, 4.1, "very good", true);
            dataTable.Rows.Add(7, 113, 2.2, "Not satisfied ", false);
            dataTable.Rows.Add(3, 114, 3.3, "Average product!", true);
            dataTable.Rows.Add(2, 115, 4.2, "Good", false);
            dataTable.Rows.Add(2, 116, 3.9, "Good product.", true);
            dataTable.Rows.Add(1, 117, 1.5, "Bad product!", false);
            dataTable.Rows.Add(2, 118, 3.5, "Good Product .", true);
            dataTable.Rows.Add(1, 119, 3.0, "Can do better.", false);
            dataTable.Rows.Add(2, 120, 4.5, "Great product!", true);
            dataTable.Rows.Add(2, 121, 4.0, "Bad.", true);
            dataTable.Rows.Add(3, 122, 2.3, "Not satisfied.", false);

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("ProductID : " + row[0] + " UserID " + row[1] + " Rating " + row[2] + " Review "
                    + row[3] + " IsLike " + row[4]);
            }
        }
    }
}
