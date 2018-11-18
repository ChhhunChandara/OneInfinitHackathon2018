using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthHack
{
    public static class Resource
    {
        public static string[] SystemMessage = { "Good Afternoon! I'm is Jane, and I am glad to be your personal assistence. " + Environment.NewLine + " Would you mind telling me your name please?",
                                                  "Are you Male or Femal?",
                                                  "Would you like to set your profile picture? Send us your picture or simply reply No",
                                                  "Your profile picture is now set. Could we know more about your your weight (kg) and height (cm)",
                                                  "May I know your date of birth mm/dd/yyyy?         ",
                                                  "What is your marital status?",
                                                  "How many children you have?",
                                                  "We're almost there.     Kindly Review our term and condition with below link https://lifehack.com/termcondition " + Environment.NewLine +"Replay \"Yes\" to agree" + Environment.NewLine +"Replay \"No\" to disagree",
                                                  "Many thanks for your anwser! Your profile detail now is created base above information"
                                                };

        public static string[] SystemMessageAnswer = { "Randy",
                                                  "Male",
                                                  "",
                                                  "78 , 168",
                                                  "03/03/1983         ",
                                                  "Married",
                                                  "3 Childrens",
                                                  "Yes",
                                                  "Many thanks for your anwser! Your profile detail now is created base above information"
                                                };
    }
}
