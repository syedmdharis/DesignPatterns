using System.Runtime.InteropServices;
using System.Security.Principal;

namespace OpenClosed
{

    public class Demo
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicant = new List<IApplicantModel>
            {
                new ManagerModel {FirstName = "Syed", LastName = "Hyderali" },
                new PersonModel {FirstName = "Jana", LastName = "Mohan" },
                new PersonModel {FirstName = "Mustak", LastName = "Akbar" },
                new PersonModel {FirstName = "AbdulQuaiyum", LastName = "Khaleel" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicant)
            {
                employees.Add(person.accountProcessor.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"First Name: { employee.FirstName }" + Environment.NewLine + 
                                  $"Last Name: {employee.LastName}" + Environment.NewLine +
                                  $"IsManager: {employee.IsManager}" + Environment.NewLine +
                                  $"Email : {employee.Email}" + Environment.NewLine);
            }
        }
    }
}