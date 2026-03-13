namespace sess01_introduction
{
    public class EmployeeProcessor
    {
        public delegate void EmployeeProcessedHandler(char gender);
        public event EmployeeProcessedHandler? EmployeeProcessed;

        public void Process(SampleEmployeeXMLDocumentation emp)
        {
            char gender = emp.GetGender();
            EmployeeProcessed?.Invoke(gender);
        }
    }
}
