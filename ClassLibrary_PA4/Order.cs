/*
 * @Author: Gilad Touboul
 * @Assignment: PA4
 * @Date: Due Nov 26th (Received 1 day extension for life circumstances)
 * 
 * Purpose: Organize order details into an order containing 1:multiple details
 * Contents: All classes, methods, and class data from UML diagram
 *           Contents within methods and local variables do not have to be defined for PA4
 * Invariants: Can only store specified data types. Cant manipulate data
 */

namespace ClassLibrary_PA4;


public class Order
{ 
    
    //implementation of variabls
    public string customerName;
    public int customerPhone;
    public int orderNumber;
    public string dateTime;
    private int subTotalAmount; //total of all detailed items pre tax
    public int taxAmount;
    private int taxModifier = 10;   //10% tax
    private int tarrifAmount = 5;   //5% Trump Tarrif Tax for electronics (ELECT)
    public int totalAmount;
    
    //constructor
    //Preconditions: called upon
    //Postconditions: object made
    public Order()
    {
     //implementation for constructor
    }
    
    //to add an order
    //stores as an output data object and calls the factory
    //Preconditions: OrderDetail passed in
    //Postconditions: object made
    public void AddNewOrder(Order_Detail order)
    {
        //implementation
    }
    
}