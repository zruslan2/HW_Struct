using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Students
{
    public enum gender { Male, Female }
    public enum studyType { Ochnoe, Zaochnoe }
    public enum studentFamily { Full, NotFull }
    public struct Student
    {
        public string StudentName { get; set; }
        public int Group { get; set; }
        public int Mark { get; set; }
        public int FamilyIncome { get; set; }
        public studentFamily StudentFamily { get; set; }
        public gender Gender { get; set; }
        public studyType StudyType { get; set; }
        public Student(string name, int group, int mark, int income, studentFamily family, gender gen, studyType t)
        {
            this.StudentName = name;
            this.Group = group;
            this.Mark = mark;
            this.FamilyIncome = income;
            this.StudentFamily = family;
            this.Gender = gen;
            this.StudyType = t;
        }
    }
}
