﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileDataAccessDemoGUI
{
    public class Person
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }
        public string url { get; set; }
        public string DisplayInfo => $"{firstName}, {lastName}, {url}";

    }
}
