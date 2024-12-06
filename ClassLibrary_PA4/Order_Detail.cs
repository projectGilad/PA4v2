/*
 * @Author: Gilad Touboul
 * @Assignment: PA4
 * @Date: Due Nov 26th (Received 1 day extension for life circumstances)
 *
 * Purpose: Output order details to a JSON file
 * Contents: Constructor, Open, Close, and Export
 * Invariants: Can only store specified data types. Cant manipulate data. Files cant be edited, be can be created
 */

namespace ClassLibrary_PA4;

public class Order_Detail
{
    //variables, more implementation later
    public int orderNumber;
    public int detailNumber;
    public string stock_id;
    public string stock_name;
    public int stock_price;
    public int quantity;
    
    //constructor
    //Preconditions: none
    //Postconditions: detailNumber incremented, and Order_Detail object created
    public Order_Detail()
    {
        //implementation
        detailNumber++;
    }
}