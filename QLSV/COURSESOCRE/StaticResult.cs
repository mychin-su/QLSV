using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.COURSESOCRE
{
    public partial class StaticResult : Form
    {
        public StaticResult()
        {
            InitializeComponent();
        }
        Score score = new Score();
        private void StaticResult_Load(object sender, EventArgs e)
        {
            var resultCounts =   score.GetStudentResultsCount();
            int totalStudent = 0;
            int goodCount;

            if (resultCounts.TryGetValue("Good", out goodCount))
            {
                totalStudent += goodCount;
               
            }
            else
            {
                // Handle the case where the key is missing
                labelGood.Text = "Good: 0%"; // Showing default zero count in UI
            }


            int ratherCount;
            if (resultCounts.TryGetValue("Rather", out ratherCount))
            {
                totalStudent += ratherCount;    
            }
            else
            {
                // Handle the case where the key is missing
                labelRather.Text = "Rather: 0%"; // Showing default zero count in UI
            }


            int mediumCount;
            if (resultCounts.TryGetValue("Medium", out mediumCount))
            {
                totalStudent += mediumCount;
            }
            else
            {
                // Handle the case where the key is missing
                labelMedium.Text = "Medium: 0%"; // Showing default zero count in UI
            }

            int weakCount;
            if (resultCounts.TryGetValue("Weak", out weakCount))
            {
                totalStudent += weakCount;
            }
            else
            {
                // Handle the case where the key is missing
                labelWeak.Text = "Weak: 0%"; // Showing default zero count in UI
            }

            // Update UI or perform calculations with goodCount
            double goodScorePercentage = goodCount * (100 / totalStudent);
            double ratherScorePercentage = ratherCount * (100 / totalStudent);
            double mediumScorePercentage = mediumCount * (100 / totalStudent);
            double weakScorePercentage = weakCount * (100 / (totalStudent));
            if(goodScorePercentage > 0)
            {
                labelGood.Text = ("Good:      " + goodScorePercentage.ToString("0.00") + "%");
            }
            if(ratherScorePercentage > 0)
            {
                labelRather.Text = ("Rather:    " +  ratherScorePercentage.ToString("0.00") + "%");
            }
            
            if(mediumScorePercentage > 0)
            {
                labelMedium.Text = ("Medium:   " + mediumScorePercentage.ToString("0.00") + "%");
            }

            if(weakScorePercentage > 0)
            {
                labelWeak.Text = ("Weak:      " + weakScorePercentage.ToString("0.00") + "%");
            }


            var resultsScore = score.getAvgScoreCourse();
            double C;
            if(resultsScore.TryGetValue("C#", out C))
            {
                labelC.Text = $"C#: {C.ToString("0.00")}";
            } else
            {
                labelC.Text = "C: 0";
            }

            double DSA;
            if (resultsScore.TryGetValue("DSA", out DSA))
            {
                labelDSA.Text = $"DSA: {DSA.ToString("0.00")}";
            }
            else
            {
                labelDSA.Text = "DSA: 0";
            }


            double Java;
            if (resultsScore.TryGetValue("Java", out Java))
            {
                labelJava.Text = $"Java: {Java.ToString("0.00")}";
            }
            else
            {
                labelJava.Text = "Java: 0";
            }


            double OOP;
            if (resultsScore.TryGetValue("OOP", out OOP))
            {
                labelOOP.Text = $"OOP: {OOP.ToString("0.00")}";
            }
            else
            {
                labelOOP.Text = "OOP: 0";
            }

        }
    }
}
