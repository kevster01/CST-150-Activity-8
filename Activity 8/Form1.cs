using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

         private void Calculate_btn_Click(object sender, EventArgs e)
        {
            int f = FatCalories (int.Parse(FatGrams_txt.Text));
            int c =CarbCalories(int.Parse(CarbGrams_txt.Text));

            NumCalFat_txt.Text = f.ToString();
            NumCalCarbs_txt.Text = c.ToString();
            


        }

        public static int FatCalories ( int fat)
        {
            return fat * 9;
        }

        public static int CarbCalories(int carbs)
        {
            return carbs * 4;
        }
    }
}
