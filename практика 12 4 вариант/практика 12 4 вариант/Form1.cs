using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика_12_4_вариант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room room1 = new Room();
            room1.l =(double)numericUpDown1.Value;
            room1.sh = (double)numericUpDown2.Value;
            room1.H= (double)numericUpDown3.Value;
            room1.kolv_windows= (int)numericUpDown4.Value;
            MessageBox.Show(String.Format("информация о комнате\nДлина {0}\nШирина {1}\nВысота потолков {2}\nКол-во окон {3}\nПлощадь комнаты {4}\nОбъем комнаты {5}", room1.l, room1.sh, room1.H, room1.kolv_windows,room1.Get_S(),room1.Get_V()), "информация про комнату");
        }   
    }
}
