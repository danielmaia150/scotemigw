using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTestProject.Models
{
    public class Person
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string SurNAME { get; set; }
        public int old { get; set; }
        public int Id { get; internal set; }
    }
}