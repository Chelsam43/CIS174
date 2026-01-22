/*
 * Name: Chelsa Mortenson
 * Date: 01/20/2026
 * CIS 174
 * OS: Windows 11 home
 * Visual Studio 2022
 * Assignment:
 * Write a Responsive Web App named FirstResponsiveWebAppLastName and does the following:
    Has a label and input for a user's name
    Has a label and input for year of birth
    Has a submit and clear button
    Model
    Attributes: Name, BirthYear
    Method: AgeThisYear()
    No Magic Numbers (HINT: Use a global constant) 
    Validate user input
    On submit, displays their name and what their age will be Dec 31st of this year. 
    Extra credit: Get user's birthday and display their name and what age they are today. (2 points extra)
*Discription: ASP.NET COre MVC app that the user inputs name nad the year of birth, the app validates the input, and outputs a resut that has the input  name, calculated age based on the BirthYear input minus the current year.
*Bootstrap is used for responsive design layout and it uses both client and server side validation.
*/





using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppMortenson.Models;




namespace FirstResponsiveWebAppMortenson.Controllers
{
    //handler for hompage request
    public class HomeController : Controller
    {
        //Shows in input form
        public IActionResult Index()
        {
            return View();
        }

        //Handle submission and validation of input
        [HttpPost]
        public IActionResult Index(UserModel user)
        {

            //stop/prevention of invalid input
            if(!ModelState.IsValid)
            { 
                
                return View();
        }

            //shows valid input result
            return View("Result", user);
        
    }

        //clear form and back to index page
    public IActionResult Clear()
        {
            return RedirectToAction("Index");
        }
    }
}
