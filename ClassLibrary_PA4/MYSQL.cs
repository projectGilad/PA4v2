/*
 * @Author: Gilad Touboul
 * @Assignment: PA4
 * @Date: Due Nov 26th (Received 1 day extension for life circumstances)
 *
 * Purpose: Output order details to a mySQL database
 * Contents: Constructor, connect, querry, insert, new file
 * Invariants: Can only store specified data types. Cant manipulate data. Database cant be edited, but can be added to
 */


namespace ClassLibrary_PA4;

public class MYSQL
{
    //properties/variables placeholder
    
    //Constructor
    //Preconditions: called upon
    //Postconditions: object made
    public MYSQL()
    {
        //implementation to make a mysql file with data
    }

    //Preconditions: called upon
    //Postconditions: object made
    public bool connectDB()
    {
        return true;    //if database is connected
    }

    //Preconditions: called upon
    //Postconditions: object made
    public void querryInsertData(string data)
    {
        //implementation to insert data
    }

    //Preconditions: called upon
    //Postconditions: object made
    public bool insertData(string data)
    {
        return true;    //if data succesfully inserted
    }

    //Preconditions: called upon
    //Postconditions: object made
    public void newFile(string MYSQLpath)
    {
        //implementation to create a newFile   
    }
}