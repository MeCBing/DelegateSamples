using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {

        Dictionary<string, Func<double, double, double>> dictionary = new Dictionary<string, Func<double, double, double>>();
        string s = "";
        public Form1()
        {
            InitializeComponent();
            dictionary.Add("+", (x, y) => x + y);
            dictionary.Add("-", (x, y) => x - y);
            dictionary.Add("*", (x, y) => x * y);
            dictionary.Add("/", (x, y) => x / y);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            var d = dictionary.FirstOrDefault((x) => s.Contains(x.Key));
            string[] w = s.Split(char.Parse(d.Key));
            double a = double.Parse(w[0]);
            double b = double.Parse(w[1]);
            label1.Text = d.Value(a, b).ToString("0.00");
        }
    }

    public class MyCalss
    {
        public int DoWhere( Func<int, int> predicate,int a)
        {
            return predicate.Invoke(a); ;
        }
    }
}
