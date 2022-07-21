using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Project
{
    class ClassStudent
    {
        // => (lambda)
        // store 2 strings; one variable name and one variable program
        private string vName, vProgram;
        
        private Single vAverage;

        public string Name { get => vName; set => vName = value; }
        public string Program { get => vProgram; set => vProgram = value; }
        public float Average { get => vAverage; set => vAverage = value; }

        public ClassStudent(string name, string program, float average)
        {
            this.vName = name;
            this.vProgram = program;
            this.vAverage = average;
        }
    }
}
