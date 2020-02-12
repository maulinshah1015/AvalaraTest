﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvalaraTest.Model;

namespace AvalaraTest.IO
{
    public class OutputData
    {
        public IEnumerable<Slide> Slides { get; }

        public OutputData(IEnumerable<Slide> slides)
        {
            Slides = slides;
        }
    }
}
