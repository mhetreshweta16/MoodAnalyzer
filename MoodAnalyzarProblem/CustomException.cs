﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzarProblem
{
   public class CustomException:Exception
    {
        public ExceptionType type;

        /// <summary>
        /// enum is user-defined value type used to represent a list of named interger constants
        /// here it is used for exception type list and is is constant
        /// </summary>
        public enum ExceptionType
        { 
             NUll_Type_Exception,
                Empty_Type_Exception,
                Class_Not_Found
              
        }

        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    
    }
}