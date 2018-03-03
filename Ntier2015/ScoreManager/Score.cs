using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier2015.ScoreManager
{
     public class Score
    {
        public String courseName,grade;
        public float point;
        public Score(string courseName,float point,string grade)
        {
            this.courseName=courseName;
            this.point=point;
            this.grade =grade;
        }
        public Score()
        {
        }
       
    }
}
