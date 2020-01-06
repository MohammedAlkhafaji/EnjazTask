using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Enjaz_StackOverFlow.Models
{
    public class Question_History
    {
        public int Id { get; set; }
        public int Qustion_Id { get; set; }
        [ForeignKey(nameof(Qustion_Id))]
        public Question Question { get; set; }
        public string Before_Edit { get; set; }
        public string After_Edit { get; set; }
        public DateTime Edit_DateTime { get; set; }


         
    }
}
