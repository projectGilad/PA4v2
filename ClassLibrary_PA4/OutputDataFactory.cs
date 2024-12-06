/*
 * @Author: Gilad Touboul
 * @Assignment: PA4
 * @Date: Due Nov 26th (Received 1 day extension for life circumstances)
 *
 * Purpose: Decides if the appropriate output is JSON or MYSQL. Then creates an appropriate object to output to the
 *          selected output method.
 * Contents: Constructor, CreateOutputData, formatJSON, outputJSON, formatDB, outputDB
 * Invariants: Either connects data to DB or to JSON file. No other outputs. Uses boolean logic to decide. Data not
 *              changed, but is passed along in an appropriate output
 */


namespace ClassLibrary_PA4
{
    public class OutputDataFactory
    {
        // Variable to indicate if the database is online
        public bool dbOnline;

        // Constructor
        //Preconditions: called upon
        //Postconditions:  obj made
        public OutputDataFactory()
        {
            dbOnline = true;  // Example initialization, can be changed as per requirements
        }

        // CreateOutputData
        //Preconditions: called upon, string passed in
        //Postconditions:  outputData returned
        public OutputData CreateOutputData(string output)
        {
            // Ensure OutputData is properly initialized
            OutputData outputData = new OutputData(output);
            return outputData;
        }
        
        //formatJSON
        //Preconditions: called upon, outputData passed in
        //Postconditions:  correctly formatted outputData returned
        protected void formatJSON(OutputData outputData)
        {
            // will implement for later assignment
        }

        //outputJSON
        //Preconditions: called upon
        //Postconditions:  data output to a JSON file
        public bool outputJSON()
        {
            return true;
        }

        //formatDB
        //Preconditions: called upon, outputData passed in
        //Postconditions:  correctly formatted outputData returned
        protected void formatDB(OutputData outputData)
        {
            // will implement for later assignment
        }
        
        //outputdb
        //Preconditions: called upon
        //Postconditions:  data output to a database, and true is returned
        public bool outputDB()
        {
            return true;
        }
        
    }
}


