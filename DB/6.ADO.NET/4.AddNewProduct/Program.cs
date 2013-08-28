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
            AddNewProduct("Kiselo mlqko na Baba", 2, 4, "10x5 kofichki", 2.50m, 25, 58, 63, 0);
        }

        private static void AddNewProduct(string productName, int supplierID, int categoryID,
                                            string quantityPerUnit, decimal unitPrice, int unitsInStock,
                                            int unitsOnOrder, int reorderLevel, int discontinued)
        {
            SqlConnection dbCon = new SqlConnection(CONNECTION_STRING);
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand insertNewProduct = new SqlCommand(
                   "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock," +
                                        "UnitsOnOrder, ReorderLevel, Discontinued)" +
                                        "VALUES(@productName, @supplierID, @categoryID, @quantityPerUnit, @unitPrice, @unitsInStock," +
                                        "@unitsOnOrder, @reorderLevel, @discontinued)"
                                        , dbCon);

                insertNewProduct.Parameters.AddWithValue("@productName", productName);
                insertNewProduct.Parameters.AddWithValue("@supplierID", supplierID);
                insertNewProduct.Parameters.AddWithValue("@categoryID", categoryID);
                insertNewProduct.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
                insertNewProduct.Parameters.AddWithValue("@unitPrice", unitPrice);
                insertNewProduct.Parameters.AddWithValue("@unitsInStock", unitsInStock);
                insertNewProduct.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
                insertNewProduct.Parameters.AddWithValue("@reorderLevel", reorderLevel);
                insertNewProduct.Parameters.AddWithValue("@discontinued", discontinued);

                insertNewProduct.ExecuteNonQuery();
            }
        }
    }
}
