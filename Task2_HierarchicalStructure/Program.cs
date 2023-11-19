using Task2_HierarchicalStructure.Controller;
using Task2_HierarchicalStructure.Model;
using Task2_HierarchicalStructure.View;

namespace Task2_HierarchicalStructure
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Instantiate the model, controller and the view
            PeopleModel peopleModel = new PeopleModel();
            Relationships relationships = new Relationships();
            PersonView personView = new PersonView();
            PersonController personController = new PersonController(peopleModel, personView);

            


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}