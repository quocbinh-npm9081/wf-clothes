using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyQuanAo
{
    class student
    {
        private string name, code;
        private int age;

        //property
        public string nameStudent
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string codeStudent
        {
            get
            {
                return this.code;
            }
            set
            {
                this.code = value;
            }
        }
        public int ageStudent
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        //methodd( init Object)

        public student()
        {
            this.name = "";
            this.code = "";
            this.age = 0;
        }

        public student(string name, string code, int age)
        {
            this.name = name;
            this.code =code;
            this.age = age;
        }

    }
}
