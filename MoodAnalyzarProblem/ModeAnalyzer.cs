﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzarProblem
{
    public class ModeAnalyzer
    {
        public string message;

        public ModeAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }
            catch (NullReferenceException ex)
            {
                return "happy";
            }
        }
    }
}
