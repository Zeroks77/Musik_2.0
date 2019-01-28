using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabel.Rows.Clear();
            int a;
            List<string> note = new List<string>();
            int.TryParse(Durchläufe.SelectedItem.ToString(), out a);
            enablecolumm(a);
            for (int i = 0; i < a; i++)
            {
                note = notes();
                ausgabe(note, i);
                note.Clear();
            }
        }
        private void ausgabe(List<string> note, int a)
        {
                int i = 0; 
                foreach (var item in note)
                {
                    tabel[a,i].Value = item;
                    i++;
                }    
        }
        private void enablecolumm(int a)
        {
            if (a > 1)
            {
                Column2.Visible = true;
            }
            if (a > 2)
            {
                Column3.Visible = true;
                
            }
            if (a > 3)
            {
                Column4.Visible = true;
            }
            if (a > 4)
            {
                Column5.Visible = true;
            }
            if (a > 5)
            {
                Column6.Visible = true;
            }
            if (a > 6)
            {
                Column7.Visible = true;
            }
            if (a > 7)
            {
                Column8.Visible = true;
            }
            if (a > 8)
            {
                Column9.Visible = true;
            }
            if (a > 9)
            {
                Column10.Visible = true;
            }
            for (int i = 0; i < 12; i++)
            {
                tabel.Rows.Add();
            }
        }
        private List<string> notes()
        {
            int[] first = new int[13];
            List<string> note = new List<string>();
            note.Clear();
            for (int x = 0; x < first.Length; x++)
            {
                first[x] = x + 1;
            }
            var mixedarry = mix(first);
            for(int x = 0; x < mixedarry.Length; x++)
            { 
                switch (first[x])
                {
                    case 1:
                        note.Add("C");
                        continue;
                    case 2:
                        note.Add("D");
                        continue;
                    case 3:
                        note.Add("E");
                        continue;
                    case 4:
                        note.Add("F");
                        continue;
                    case 5:
                        note.Add("G");
                        continue;
                    case 6:
                        note.Add("A");
                        continue;
                    case 7:
                        note.Add("H");
                        continue;
                    case 8:
                        note.Add("CIS");
                        continue;
                    case 9:
                        note.Add("DIS");
                        continue;
                    case 10:
                        note.Add("FIS");
                        continue;
                    case 11:
                        note.Add("GIS");
                        continue;
                    case 12:
                        note.Add("AIS");
                        continue;
                    case 13:
                        note.Add("Pause");
                        continue;
                    default:
                        continue;
                }
            }
            return note;
        }
       private int[] mix(int[] array)
        {
            int helpme, helpme2;
            int i = 12;
            Random ran = new Random();
            while (i > 0)
            {
                int random = ran.Next(0, 12);
                helpme = array[random];
                helpme2 = array[i];
                array[i] = helpme;
                array[random] = helpme2;
                i--;
            }
            return array;
        }
    }
}
