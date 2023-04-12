﻿using H1ERPSystem2023.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace H1_ERP_System_2023.Screens
{
    public class CustomerListScreen
    {


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
            public override string Title { get; set; } = "Customer List";
            protected override void Draw()
            {
                do
                {
                    //Clear(this); //Clean the screen
                    //Gonna draw a list page here
                    ListPage<CustomerModel> listPage = new ListPage<CustomerModel>();
                    listPage.AddColumn("personId", "PersonId");
                    listPage.AddColumn("FirstName", "FirstName");
                    listPage.AddColumn("LastName", "LastName");
                    listPage.AddColumn("PhoneNumber", "phoneNumber");
                    listPage.AddColumn("EmailAddress", "emailAddress");


                    CustomerModel selected = listPage.Select();
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
}