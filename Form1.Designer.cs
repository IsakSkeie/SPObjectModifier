
namespace SPIT
{
    partial class Area
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AttributeEdit = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Attribute = new System.Windows.Forms.TextBox();
            this.AttributeType = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UserInput = new System.Windows.Forms.TextBox();
            this.GenerateCSV = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.AttributeEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttributeEdit
            // 
            this.AttributeEdit.Controls.Add(this.label4);
            this.AttributeEdit.Controls.Add(this.label2);
            this.AttributeEdit.Controls.Add(this.label1);
            this.AttributeEdit.Controls.Add(this.textBox2);
            this.AttributeEdit.Controls.Add(this.button1);
            this.AttributeEdit.Controls.Add(this.Attribute);
            this.AttributeEdit.Controls.Add(this.AttributeType);
            this.AttributeEdit.Location = new System.Drawing.Point(17, 12);
            this.AttributeEdit.Name = "AttributeEdit";
            this.AttributeEdit.Size = new System.Drawing.Size(206, 196);
            this.AttributeEdit.TabIndex = 0;
            this.AttributeEdit.TabStop = false;
            this.AttributeEdit.Text = "AttributeEdit";
            this.AttributeEdit.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Updated Atrb";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attribute";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Object";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Attribute
            // 
            this.Attribute.Location = new System.Drawing.Point(89, 23);
            this.Attribute.Name = "Attribute";
            this.Attribute.Size = new System.Drawing.Size(100, 23);
            this.Attribute.TabIndex = 2;
            this.Attribute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Attribute.TextChanged += new System.EventHandler(this.Attribute_TextChanged);
            // 
            // AttributeType
            // 
            this.AttributeType.AllowDrop = true;
            this.AttributeType.FormattingEnabled = true;
            this.AttributeType.Location = new System.Drawing.Point(89, 54);
            this.AttributeType.Name = "AttributeType";
            this.AttributeType.Size = new System.Drawing.Size(100, 23);
            this.AttributeType.TabIndex = 0;
            this.AttributeType.SelectedIndexChanged += new System.EventHandler(this.AttributeType_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(263, 35);
            this.UserInput.Multiline = true;
            this.UserInput.Name = "UserInput";
            this.UserInput.ReadOnly = true;
            this.UserInput.Size = new System.Drawing.Size(145, 139);
            this.UserInput.TabIndex = 2;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // GenerateCSV
            // 
            this.GenerateCSV.Location = new System.Drawing.Point(263, 180);
            this.GenerateCSV.Name = "GenerateCSV";
            this.GenerateCSV.Size = new System.Drawing.Size(145, 29);
            this.GenerateCSV.TabIndex = 3;
            this.GenerateCSV.Text = "GenerateCSV";
            this.GenerateCSV.UseVisualStyleBackColor = true;
            this.GenerateCSV.Click += new System.EventHandler(this.GenerateCSV_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(263, 12);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(45, 15);
            this.Output.TabIndex = 4;
            this.Output.Text = "Output";
            // 
            // Area
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 284);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.GenerateCSV);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.AttributeEdit);
            this.Name = "Area";
            this.Text = "Form1";
            this.AttributeEdit.ResumeLayout(false);
            this.AttributeEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AttributeEdit;
        public System.Windows.Forms.ComboBox AttributeType;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Attribute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Button GenerateCSV;
        private System.Windows.Forms.Label Output;
    }
}

