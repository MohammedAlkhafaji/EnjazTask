﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enjaz_StackOverFlow.Models
{
    public class Comment
    {


        public int Id { get; set; }
        public string Description { get; set; }
        public int User_Id { get; set; }
        public int Question_Id { get; set; }
        public DateTime Comment_Date { get; set; }
        public int Evaluation { get; set; }

 
 


    }
}
