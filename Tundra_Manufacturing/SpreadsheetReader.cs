using System;
using System.Linq;
using LinqToExcel;

namespace Tundra_Manufacturing
{
    public class SpreadsheetReader
    {
        public void ReadSpreadsheet()
        {
            // Set up the path to the spreadsheet to be read
            var excelQueryFactory = new ExcelQueryFactory("C:/users/mlukatchik/desktop/Tundra_Manufacturing.xlsx");

            // Define column mappings
            excelQueryFactory.AddMapping<Product>(x => x.ProductDescription, "Product");
            excelQueryFactory.AddMapping<Product>(x => x.InventoryCode, "Inventory Code");
            excelQueryFactory.AddMapping<Product>(x => x.DateAvailable, "Date Available");
            excelQueryFactory.AddMapping<Product>(x => x.CostPerUnit, "Cost Per Unit");
            excelQueryFactory.AddMapping<Product>(x => x.Quantity, "Quantity");
            excelQueryFactory.AddMapping<Product>(x => x.Comments, "Comments");

            // Read the data
            var lineItems = from oli in excelQueryFactory.Worksheet<Product>("Sheet1") select oli;

            // Do something with the data
            foreach (var lineItem in lineItems)
            {
                //Note that you have access to each property on the object
                Console.WriteLine(lineItem.Comments);
            }

        }
    }
}
