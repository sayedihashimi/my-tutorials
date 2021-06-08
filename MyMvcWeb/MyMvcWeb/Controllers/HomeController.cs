using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcWeb.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View(GetContacts());
        }

        public List<Contact> GetContacts() {
            var result = new List<Contact> {
                new Contact {
                    Firstname = "Sayed",
                    Lastname = "Hashimi"
                },
                new Contact { Firstname = "Colin", Lastname="Miller" },
                new Contact { Firstname = "Jane", Lastname="Reid" },
                new Contact { Firstname = "Ruth", Lastname="Stewart" },
                new Contact { Firstname = "Jessica", Lastname="Mathis" },
                new Contact { Firstname = "Evan", Lastname="James" },
                new Contact { Firstname = "Karen", Lastname="Berry" },
                new Contact { Firstname = "Stewart", Lastname="Paige" },
                new Contact { Firstname = "Natalie", Lastname="Dickens" },
                new Contact { Firstname = "Adrian", Lastname="Kerr" },
                new Contact { Firstname = "Paul", Lastname="Lambert" },
                new Contact { Firstname = "Steven", Lastname="Churchill" },
                new Contact { Firstname = "Joe", Lastname="Henderson" },
                new Contact { Firstname = "Warren", Lastname="Hart" },
                new Contact { Firstname = "Jan", Lastname="Hamilton" },
                new Contact { Firstname = "Anthony", Lastname="Watson" },
                new Contact { Firstname = "Abigail", Lastname="Duncan" },
                new Contact { Firstname = "Abigail", Lastname="Blake" },
                new Contact { Firstname = "Alison", Lastname="Graham" },
                new Contact { Firstname = "Yvonne", Lastname="Gibson" },
                new Contact { Firstname = "Isaac", Lastname="Bower" },
                new Contact { Firstname = "Piers", Lastname="Hardacre" },
                new Contact { Firstname = "Heather", Lastname="Vance" },
                new Contact { Firstname = "Paul", Lastname="Langdon" },
                new Contact { Firstname = "Theresa", Lastname="May" },
                new Contact { Firstname = "Sebastian", Lastname="Butler" },
                new Contact { Firstname = "Ava", Lastname="Lee" },
                new Contact { Firstname = "Nicola", Lastname="Scott" },
                new Contact { Firstname = "Isaac", Lastname="Turner" },
                new Contact { Firstname = "Theresa", Lastname="Sharp" },
                new Contact { Firstname = "Dominic", Lastname="Brown" },
                new Contact { Firstname = "Diane", Lastname="Mitchell" },
                new Contact { Firstname = "Heather", Lastname="Allan" },
                new Contact { Firstname = "Andrea", Lastname="Ferguson" },
                new Contact { Firstname = "Diana", Lastname="Campbell" },
                new Contact { Firstname = "Vanessa", Lastname="Hill" },
                new Contact { Firstname = "Sophie", Lastname="Clark" },
                new Contact { Firstname = "Trevor", Lastname="Buckland" },
                new Contact { Firstname = "Wanda", Lastname="Pullman" },
                new Contact { Firstname = "Ruth", Lastname="Lambert" },
                new Contact { Firstname = "Leonard", Lastname="James" },
                new Contact { Firstname = "Frank", Lastname="Peters" },
                new Contact { Firstname = "Felicity", Lastname="Randall" },
                new Contact { Firstname = "Anthony", Lastname="Tucker" },
                new Contact { Firstname = "Ryan", Lastname="Young" },
                new Contact { Firstname = "Lucas", Lastname="Rutherford" },
                new Contact { Firstname = "Una", Lastname="Sharp" },
                new Contact { Firstname = "Wanda", Lastname="Hemmings" },
                new Contact { Firstname = "Virginia", Lastname="Brown" },
                new Contact { Firstname = "Cameron", Lastname="Skinner" },
                new Contact { Firstname = "Peter", Lastname="Powell" },


            };
            return result;
        }
    }

    public class Contact {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public override string ToString() {
            return $"{Firstname} {Lastname}";
        }
    }
}