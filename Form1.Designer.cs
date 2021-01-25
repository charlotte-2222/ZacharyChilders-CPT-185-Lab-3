using System;

namespace ZacharyChilders_CPT_185_Lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ticRevC = new System.Windows.Forms.TextBox();
            this.ticRevB = new System.Windows.Forms.TextBox();
            this.ticRevA = new System.Windows.Forms.TextBox();
            this.totals = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.ext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ticketA = new System.Windows.Forms.TextBox();
            this.ticketB = new System.Windows.Forms.TextBox();
            this.ticketC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticRevC
            // 
            this.ticRevC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ticRevC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticRevC.Location = new System.Drawing.Point(94, 133);
            this.ticRevC.Name = "ticRevC";
            this.ticRevC.ReadOnly = true;
            this.ticRevC.Size = new System.Drawing.Size(131, 25);
            this.ticRevC.TabIndex = 6;
            this.ticRevC.TabStop = false;
            this.toolTip1.SetToolTip(this.ticRevC, "Amt. Sold for class Amt. Sold for class B");
 
            // 
            // ticRevB
            // 
            this.ticRevB.Cursor = System.Windows.Forms.Cursors.Default;
            this.ticRevB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticRevB.Location = new System.Drawing.Point(94, 91);
            this.ticRevB.Name = "ticRevB";
            this.ticRevB.ReadOnly = true;
            this.ticRevB.Size = new System.Drawing.Size(131, 25);
            this.ticRevB.TabIndex = 3;
            this.ticRevB.TabStop = false;
            this.toolTip1.SetToolTip(this.ticRevB, "Amt. Sold for class B");

            // 
            // ticRevA
            // 
            this.ticRevA.Cursor = System.Windows.Forms.Cursors.Default;
            this.ticRevA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticRevA.Location = new System.Drawing.Point(94, 50);
            this.ticRevA.Name = "ticRevA";
            this.ticRevA.ReadOnly = true;
            this.ticRevA.Size = new System.Drawing.Size(131, 25);
            this.ticRevA.TabIndex = 4;
            this.ticRevA.TabStop = false;
            this.toolTip1.SetToolTip(this.ticRevA, "Amt. Sold for class A");

            // 
            // totals
            // 
            this.totals.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.totals.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totals.Location = new System.Drawing.Point(94, 173);
            this.totals.Name = "totals";
            this.totals.ReadOnly = true;
            this.totals.Size = new System.Drawing.Size(131, 25);
            this.totals.TabIndex = 2;
            this.totals.TabStop = false;
            this.toolTip1.SetToolTip(this.totals, "Total Amt. Sold");

            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.Color.MintCream;
            this.calc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.Location = new System.Drawing.Point(177, 305);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(85, 48);
            this.calc.TabIndex = 0;
            this.calc.Text = "Calculate Revenue";
            this.toolTip1.SetToolTip(this.calc, "Click to reveal revenue sales");
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // clr
            // 
            this.clr.BackColor = System.Drawing.Color.MintCream;
            this.clr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr.Location = new System.Drawing.Point(287, 305);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(85, 48);
            this.clr.TabIndex = 1;
            this.clr.Text = "Clear";
            this.toolTip1.SetToolTip(this.clr, "Clears user input / data");
            this.clr.UseVisualStyleBackColor = false;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // ext
            // 
            this.ext.BackColor = System.Drawing.Color.MintCream;
            this.ext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ext.Location = new System.Drawing.Point(397, 305);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(85, 48);
            this.ext.TabIndex = 2;
            this.ext.Text = "Exit";
            this.toolTip1.SetToolTip(this.ext, "Exit the program");
            this.ext.UseVisualStyleBackColor = false;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Class C:";

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Class B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Class A:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.totals);
            this.groupBox2.Controls.Add(this.ticRevC);
            this.groupBox2.Controls.Add(this.ticRevB);
            this.groupBox2.Controls.Add(this.ticRevA);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(349, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 245);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // ticketA
            // 
            this.ticketA.BackColor = System.Drawing.Color.White;
            this.ticketA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketA.Location = new System.Drawing.Point(87, 78);
            this.ticketA.Name = "ticketA";
            this.ticketA.Size = new System.Drawing.Size(131, 25);
            this.ticketA.TabIndex = 0;
            this.toolTip1.SetToolTip(this.ticketA, "$15/seat");
            // 
            // ticketB
            // 
            this.ticketB.BackColor = System.Drawing.Color.White;
            this.ticketB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketB.Location = new System.Drawing.Point(87, 118);
            this.ticketB.Name = "ticketB";
            this.ticketB.Size = new System.Drawing.Size(131, 25);
            this.ticketB.TabIndex = 1;
            this.toolTip1.SetToolTip(this.ticketB, "$12/seat");
            // 
            // ticketC
            // 
            this.ticketC.BackColor = System.Drawing.Color.White;
            this.ticketC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketC.Location = new System.Drawing.Point(87, 159);
            this.ticketC.Name = "ticketC";
            this.ticketC.Size = new System.Drawing.Size(131, 25);
            this.ticketC.TabIndex = 2;
            this.toolTip1.SetToolTip(this.ticketC, "$9/seat");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Class A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Class C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Class B:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ticketC);
            this.groupBox1.Controls.Add(this.ticketB);
            this.groupBox1.Controls.Add(this.ticketA);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(19, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "sold for each class of seats.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Enter the number of tickets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(658, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.calc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stadium Seating";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ticRevC;
        private System.Windows.Forms.TextBox ticRevB;
        private System.Windows.Forms.TextBox ticRevA;
        private System.Windows.Forms.TextBox totals;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button ext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ticketA;
        private System.Windows.Forms.TextBox ticketB;
        private System.Windows.Forms.TextBox ticketC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

