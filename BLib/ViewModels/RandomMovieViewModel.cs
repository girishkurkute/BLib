using BLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLib.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
        public List<Customer> Customers { get; internal set; }
    }
}