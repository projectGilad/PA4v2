/*
 * @Author: Gilad Touboul
 * @Assignment: PA4
 * @Date: Due Nov 26th (Received 1 day extension for life circumstances)
 *
 * Purpose: This will likely be transfered to the driver class, but is in the class library for more full coverage on PA4
 * Contents: Constructor, Connect, Write, Close
 * Invariants: Can only output specified data. Cant manipulate data, some methods have boolean return types
 */

using System.Data;

namespace ClassLibrary_PA4;

public class OutputData
{
    //Constructor
    //Preconditions: called upon, string parameter
    //Postconditions: OutputData object made
    public OutputData(string output)
    {
        // No implementation for now
    }

    //Connect
    //Preconditions: called upon
    //Postconditions: connection to database made and true is returned, or false returned if not connected
    public bool Connect()
    {
        // No implementation for now
        return true;  // Return a default value
    }

    //Write
    //Preconditions: none
    //Postconditions: writes out the data that is needed
    public void Write()
    {
        // No implementation for now
    }

    //Close
    //Preconditions: none
    //Postconditions: Connection closed
    public bool Close()
    {
        // No implementation for now
        return true;  // Return a default value
    }
}
