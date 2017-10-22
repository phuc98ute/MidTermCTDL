namespace Graphic
{
    partial class SelectionSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionSort));
            this.btnCreat = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.pnBoard = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCreat
            // 
            this.btnCreat.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreat.Location = new System.Drawing.Point(14, 89);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(87, 27);
            this.btnCreat.TabIndex = 0;
            this.btnCreat.Text = "Tạo";
            this.btnCreat.UseVisualStyleBackColor = false;
            this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(11, 11);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(96, 15);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Nhập số phần tử";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(14, 135);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(87, 27);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // pnBoard
            // 
            this.pnBoard.AutoSize = true;
            this.pnBoard.BackColor = System.Drawing.SystemColors.Window;
            this.pnBoard.Location = new System.Drawing.Point(118, 14);
            this.pnBoard.Name = "pnBoard";
            this.pnBoard.Size = new System.Drawing.Size(700, 231);
            this.pnBoard.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // SelectionSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(833, 261);
            this.Controls.Add(this.pnBoard);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnCreat);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectionSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectionSort";
            this.Load += new System.EventHandler(this.SelectionSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel pnBoard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

