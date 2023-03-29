using H1ERPSystem2023.Domain_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace H1_ERP_System_2023.Databasefiles
{
    public partial class CustomerDatabase
    {
        private List<Customer> Customers = new List<Customer>();

        void _addCompanies()
        {
            Customers.Add(new Customer(1, "FirstName", "LastName", null, "12345678", "Email@Email.com", "1", null));
        }

        public CustomerDatabase()
        {

            _addCompanies();
        }
    }


    public class MyFirstScreen : Screen
    {
        public override string Title { get; set; } = "My first screen";
        protected override void Draw()
        {
            Clear(this);
            Console.WriteLine("My first screen!");
        }
   }
    public class Todo
    {
        public enum TodoState { Todo, Started, Done }
        public string Title { get; set; } = "";
        public int Priority { get; set; }
        public TodoState State { get; set; }
        public Todo(string title, int priority = 1)
        {
            Title = title;
            Priority = priority;
        }
    }
    public class TodoListScreen : Screen
    {
        public override string Title { get; set; } = "List of tasks to do";
        protected override void Draw()
        {
            do
            {
                //Clear(this); //Clean the screen
                             //Gonna draw a list page here
                ListPage<Todo> listPage = new ListPage<Todo>();
                listPage.Add(new Todo("Kundeliste", 1));
                listPage.Add(new Todo("Beep boop", 2));
                listPage.Add(new Todo("Extra", 3));

                listPage.AddColumn("Todo", "Title");

                Todo selected = listPage.Select();
                if (selected != null)
                {
                    Screen.Display(new TodoListScreen());
                        }
                else
                {
                    Quit();
                    return;

                }
            } while (Show);
        }
    }
}