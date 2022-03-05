using SPOT;
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
        public UserIO input = new UserIO();
        public string ObjectI;
        public string AtributeI;
        public int AtributeIndex;
        public string NewAtbr;
    

        public Area()
        {
            InitializeComponent();
            WinFormSet();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
           
        }

        private void AttributeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtributeI = AttributeType.Text;
            AtributeIndex = AttributeType.SelectedIndex;
            
        }

        public void WinFormSet()
        {
            AttributeType.Text = "Attribute";
            
            
            //setting comboboxes
            foreach (string opt in initVar.GeneralArea)
            {
                AttributeType.Items.Add(opt);
            }

            //foreach(string obj in )
            
        }

        private void ObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Attribute_TextChanged(object sender, EventArgs e)
        {
            ObjectI = Attribute.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input.Objects.Add(ObjectI);
            UserInput.Text = input.Display();

            //Adds input to list of csv string
            input.ObjectInput(ObjectI, AtributeIndex, NewAtbr);
            ObjectI += ":" + AtributeI + "->" + NewAtbr + "\r\n";
            


        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            NewAtbr = textBox2.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GenerateCSV_Click(object sender, EventArgs e)
        {
            input.CSVCreate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ObjecType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
