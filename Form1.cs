using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPIT
{
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
            WinFormSet();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
           
        }

        private void ModelArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WinFormSet()
        {
            ModelArea.Text = "Attribute";
            ObjectType.Text = "Object";

            foreach (string opt in initVar.GeneralArea)
            {
                ModelArea.Items.Add(opt);
            }
            
            foreach(string opt in initVar.ObjectType)
            {
                ObjectType.Items.Add(opt);
            }
        }

        private void ObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Attribute_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

   
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
