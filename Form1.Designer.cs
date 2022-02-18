
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ObjectType = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Attribute = new System.Windows.Forms.TextBox();
            this.ModelArea = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UserInput = new System.Windows.Forms.TextBox();
            this.AttributeEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttributeEdit
            // 
            this.AttributeEdit.Controls.Add(this.label4);
            this.AttributeEdit.Controls.Add(this.label3);
            this.AttributeEdit.Controls.Add(this.label2);
            this.AttributeEdit.Controls.Add(this.label1);
            this.AttributeEdit.Controls.Add(this.ObjectType);
            this.AttributeEdit.Controls.Add(this.textBox2);
            this.AttributeEdit.Controls.Add(this.button1);
            this.AttributeEdit.Controls.Add(this.Attribute);
            this.AttributeEdit.Controls.Add(this.ModelArea);
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
            this.label4.Location = new System.Drawing.Point(11, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Update Atrb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
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
            // ObjectType
            // 
            this.ObjectType.FormattingEnabled = true;
            this.ObjectType.Location = new System.Drawing.Point(89, 52);
            this.ObjectType.Name = "ObjectType";
            this.ObjectType.Size = new System.Drawing.Size(100, 23);
            this.ObjectType.TabIndex = 4;
            this.ObjectType.SelectedIndexChanged += new System.EventHandler(this.ObjectType_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "New Attribute";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
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
            this.Attribute.Text = "Object";
            this.Attribute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Attribute.TextChanged += new System.EventHandler(this.Attribute_TextChanged);
            // 
            // ModelArea
            // 
            this.ModelArea.AllowDrop = true;
            this.ModelArea.FormattingEnabled = true;
            this.ModelArea.Location = new System.Drawing.Point(89, 81);
            this.ModelArea.Name = "ModelArea";
            this.ModelArea.Size = new System.Drawing.Size(100, 23);
            this.ModelArea.TabIndex = 0;
            this.ModelArea.SelectedIndexChanged += new System.EventHandler(this.ModelArea_SelectedIndexChanged);
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
            this.UserInput.Location = new System.Drawing.Point(262, 35);
            this.UserInput.Multiline = true;
            this.UserInput.Name = "UserInput";
            this.UserInput.ReadOnly = true;
            this.UserInput.Size = new System.Drawing.Size(145, 139);
            this.UserInput.TabIndex = 2;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // Area
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 284);
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
        public System.Windows.Forms.ComboBox ModelArea;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Attribute;
        private System.Windows.Forms.ComboBox ObjectType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserInput;
    }
}

