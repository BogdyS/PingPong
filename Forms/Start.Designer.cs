
namespace PingPong
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.quickbutton = new System.Windows.Forms.Button();
            this.slowbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(233, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1071, 103);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите скорость мяча";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(367, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(803, 173);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игра PingPong";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.quickbutton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.slowbutton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(285, 551);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // quickbutton
            // 
            this.quickbutton.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quickbutton.ForeColor = System.Drawing.Color.Blue;
            this.quickbutton.Location = new System.Drawing.Point(486, 3);
            this.quickbutton.Name = "quickbutton";
            this.quickbutton.Size = new System.Drawing.Size(478, 94);
            this.quickbutton.TabIndex = 1;
            this.quickbutton.Text = "Быстро";
            this.quickbutton.UseVisualStyleBackColor = true;
            this.quickbutton.Click += new System.EventHandler(this.quickbutton_Click);
            // 
            // slowbutton
            // 
            this.slowbutton.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slowbutton.ForeColor = System.Drawing.Color.Blue;
            this.slowbutton.Location = new System.Drawing.Point(3, 3);
            this.slowbutton.Name = "slowbutton";
            this.slowbutton.Size = new System.Drawing.Size(477, 94);
            this.slowbutton.TabIndex = 0;
            this.slowbutton.Text = "Медленно";
            this.slowbutton.UseVisualStyleBackColor = true;
            this.slowbutton.Click += new System.EventHandler(this.slowbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1386, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Start
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.Text = "Start";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Start_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button quickbutton;
        private System.Windows.Forms.Button slowbutton;
        private System.Windows.Forms.Button button1;
    }
}