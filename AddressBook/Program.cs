using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AddressBook Ado.net ");
            PersonRepo repo = new PersonRepo();
            PersonModel employee = new PersonModel();
            employee.FirstName = "Raghu";
            employee.LastName = "hk";
            employee.Address = "House no 22";
            employee.PhoneNumber = "6302907678";
            employee.zip = 894523;
            employee.City = "Tsk";
            employee.State = "Tripura";
            employee.Email = "raghu@gmail.com";
            employee.AddressBookName = "book4";
            employee.Type = "Family";

            repo.AddEmployee(employee);
        }
    }
}
