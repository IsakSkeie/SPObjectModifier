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
        }

        public void WinFormSet()
        {
            AttributeType.Text = "Attribute";
            
            

            foreach (string opt in initVar.GeneralArea)
            {
                AttributeType.Items.Add(opt);
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
            ObjectI = Attribute.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ObjectI += ":" + AtributeI + "->" + NewAtbr + "\r\n";

            input.Objects.Add(ObjectI);
            UserInput.Text = input.Display();


        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            NewAtbr = textBox2.Text;
        }
    }
    
}
