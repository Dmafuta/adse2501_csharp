using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace sess01_introduction
{
    internal delegate char GenderGetter();
    /// <summary>
    /// Represents an Employee with and ID, name and binary gender
    /// </summary>
    public class SampleEmployeeXMLDocumentation
    {
        /// <summary>
        /// An unssigned integer denoting the employee'sunique ID
        /// </summary>
        private uint _empID;
        /// <summary>
        /// String field to hold the employee's name
        /// </summary>
        private string _empName;
        /// <summary>
        /// Character field to hold the employee's binary gender
        /// </summary>
        /// <remarks> The gender is 'M' or 'm' for male and 'F' or 'f' for female</remarks> ///
        private char _gender;
        /// <summary>
        /// Initialises a new instance of the <see cref="SampleEmployeeXMLDocumentation"/>
        /// This constructor sets default values for the employee's id, name and gender
        /// </summary>
        public SampleEmployeeXMLDocumentation()
        {
            this._empID = 0;
            this._empName = string.Empty; // this._empName = "";
            this._gender = 'M'; // Default to male
        }
        /// <summary>
        /// Initialises a new instance of the <see cref="SampleEmployeeXMLDocumentation"/> with 
        /// the specified employee id, name and gender
        /// This constructor sets default values for the employee's id, name and gender
        /// </summary>
        /// <param name="_empID">The employee's unique ID number</param>
        /// <param name="_empName">The employee's name</param>
        /// <param name="_gender">The employee's gender( 'M' or 'm' for male and 'F' or 'f' for female) </param>
        public SampleEmployeeXMLDocumentation(uint _empID, string _empName, char _gender)
        {
            this._empID = _empID;
            this._empName = _empName; 
            this._gender = _gender; 
        }
        /// <summary>
        /// Retieves the employee ID
        /// </summary>
        /// <returns>The employee's ID</returns>
        public uint GetID() { return this._empID; }
        /// <summary>
        /// Assigns/Sets the employee's ID
        /// </summary>
        /// <param name="_empID"></param>
        public void SetID(uint _empID) { this._empID = _empID; }
        /// <summary>
        /// Retrieves the employee's name
        /// </summary>
        /// <returns>The employee's name</returns>
        public string GetName() { return this._empName; }
        /// <summary>
        /// Assigns the employee's name
        /// </summary>
        /// <param name="_empName">The employee's name</param>
        public void SetName (string _empName) { this._empName = _empName;}
        /// <summary>
        /// Retrieves the employee's gender
        /// </summary>
        /// <returns></returns>
        public char GetGender() { return this._gender;}
        /// <summary>
        /// Assigns the employee's gender
        /// </summary>
        /// <param name="_gender"></param>
        public void SetGender (char _gender) { this._gender = _gender;}
        /// <summary>
        /// Returns a string representation of the employee's details
        /// </summary>
        /// <returns>A string containing the employee's id, name and gender</returns>
        public override string ToString()
        {
            return $"Employee Details" +
                $"\n------------------------------------"+
                $"\nID: {this.GetID()}" +
                $"\nName: {this.GetName()}" +
                $"\nGender: {(this.GetGender() == 'M' || this.GetGender() == 'm' ? "Male" : "Female")}" +
                $"\n------------------------------------";
        }

        static void Main(string[] args)
        {
            SampleEmployeeXMLDocumentation data = new SampleEmployeeXMLDocumentation();
            Func<char> gender = data.GetGender;
            char gender2 = data.GetGender();
            Console.WriteLine($"{0}\n{1}", gender,gender2);

            /**
             * Using delegate to access method reference
             */
            GenderGetter getter = data.GetGender;
            char gender3 = getter();
            Console.WriteLine(gender3);

            /**
             * Passing a method to another method
             */
            PrintGender(data.GetGender);

            /**
             * Callback
             */
            ProcessEmployee(data.GetGender);

            /**
             * Events
             * Here the method reference is OnEmployeeProcessed and not data.GetGender;
             */
            var info = new SampleEmployeeXMLDocumentation();
            var processor = new EmployeeProcessor();

            processor.EmployeeProcessed += OnEmployeeProccesed;
        }

        private static void OnEmployeeProccesed(char gender)
        {
            try
            {
                Console.WriteLine($"Employee processed with gender: {gender}");
            }catch(NotImplementedException nie)
            {
                Console.WriteLine($"Error Message: {nie.Message}");
                throw;
                //throw new NotImplementedException();
            }  
        }

        private static void PrintGender(GenderGetter genderGetter)
        {
            SampleEmployeeXMLDocumentation data = new SampleEmployeeXMLDocumentation();
            GenderGetter getter = data.GetGender; // From the delegates
            char gender = getter(); // Invokes GetGender();
            Console.WriteLine($"Gender is: {gender}");
        }

        private static void ProcessEmployee(GenderGetter genderCallback)
        {
            char gender = genderCallback();
            Console.WriteLine($"Callback says: {gender}");
        }
    }
}
