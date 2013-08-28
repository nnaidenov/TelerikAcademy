using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetNameAndDescriptions
{
    class Program
    {
        static string CONNECTION_STRING = "Server=.; Database=NORTHWND; Integrated Security=true";

        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(CONNECTION_STRING);
            Dictionary<int, string> myCategories = new Dictionary<int, string>();
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand selectSomeDataFromNorth = new SqlCommand(
                   "SELECT CategoryName, CategoryID FROM Categories", dbCon);
                SqlDataReader result = selectSomeDataFromNorth.ExecuteReader();

                using (result)
                {
                    while (result.Read())
                    {
                        string name = (string)result["CategoryName"];
                        int categoryID = (int)result["CategoryID"];
                        if (!myCategories.ContainsKey(categoryID))
                        {
                            myCategories.Add(categoryID, name);
                        }
                    }
                }
            }

            dbCon = new SqlConnection(CONNECTION_STRING);
            Dictionary<string, int> myProducts = new Dictionary<string, int>();
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand selectSomeDataFromNorth = new SqlCommand(
                   "SELECT ProductName, CategoryID FROM Products", dbCon);
                SqlDataReader result = selectSomeDataFromNorth.ExecuteReader();

                using (result)
                {
                    while (result.Read())
                    {
                        string name = (string)result["ProductName"];
                        int categoryID = (int)result["CategoryID"];
                        if (!myProducts.ContainsKey(name))
                        {
                            myProducts.Add(name, categoryID);
                        }
                    }
                }
            }
            foreach (var myCategory in myCategories)
            {
                foreach (var myProduct in myProducts)
                {
                    if (myProduct.Value == myCategory.Key)
                    {
                        Console.WriteLine("{0} -> {1}", myProduct.Key, myCategory.Value);
                    }
                }
            }
        }
    }
}
