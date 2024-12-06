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

public class JSON
{
    //properties/variables placeholder
    private string data;
    
    //Constructor
    //Preconditions: called upon, string passed in
    //Postconditions: object made
    public JSON(string data)
    {
        //Implementation to make a JSON file
    }
    
    //openFile
    //Preconditions: called upon, string passed in
    //Postconditions: file opened
    public void OpenFile(string filepath)
    {
        //Method to open a JSON file
    }
    
    //exportFile
    //Preconditions: called upon, string passed in
    //Postconditions: file exported
    public bool ExportFile(string exportPath)
    {
        return true;    //if file succesfully exported
    }
    
    //closeFile
    //Preconditions: called upon
    //Postconditions: file closed
    public void CloseFile()
    {
        //method to close the JSON file
    }
}