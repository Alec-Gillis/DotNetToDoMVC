using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetToDoMVC.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string TodoName { get; set; }
        public bool TodoComplete { get; set; }

        // Constructor
        public Todo()
        {

        }
    }
}
