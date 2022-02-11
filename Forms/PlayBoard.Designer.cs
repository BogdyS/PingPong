
namespace PingPong
{
    partial class PlayBoard
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayBoard));
            this.RRacket = new System.Windows.Forms.Label();
            this.GRacket = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.Label();
            this.UpWall = new System.Windows.Forms.Label();
            this.DownWall = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.leftscore = new System.Windows.Forms.Label();
            this.rightscore = new System.Windows.Forms.Label();
            this.restarter = new System.Windows.Forms.Timer(this.components);
            this.GOLabel = new System.Windows.Forms.Label();
            this.Exiter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // RRacket
            // 
            this.RRacket.AutoSize = true;
            this.RRacket.Image = ((System.Drawing.Image)(resources.GetObject("RRacket.Image")));
            this.RRacket.Location = new System.Drawing.Point(20, 347);
            this.RRacket.MaximumSize = new System.Drawing.Size(30, 170);
            this.RRacket.MinimumSize = new System.Drawing.Size(30, 170);
            this.RRacket.Name = "RRacket";
            this.RRacket.Size = new System.Drawing.Size(30, 170);
            this.RRacket.TabIndex = 0;
            // 
            // GRacket
            // 
            this.GRacket.AutoSize = true;
            this.GRacket.Image = ((System.Drawing.Image)(resources.GetObject("GRacket.Image")));
            this.GRacket.Location = new System.Drawing.Point(1486, 347);
            this.GRacket.MaximumSize = new System.Drawing.Size(30, 170);
            this.GRacket.MinimumSize = new System.Drawing.Size(30, 170);
            this.GRacket.Name = "GRacket";
            this.GRacket.Size = new System.Drawing.Size(30, 170);
            this.GRacket.TabIndex = 1;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(753, 417);
            this.ball.MaximumSize = new System.Drawing.Size(30, 30);
            this.ball.MinimumSize = new System.Drawing.Size(30, 30);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 2;
            // 
            // UpWall
            // 
            this.UpWall.BackColor = System.Drawing.Color.Blue;
            this.UpWall.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpWall.Location = new System.Drawing.Point(0, 0);
            this.UpWall.Name = "UpWall";
            this.UpWall.Size = new System.Drawing.Size(1536, 15);
            this.UpWall.TabIndex = 3;
            // 
            // DownWall
            // 
            this.DownWall.BackColor = System.Drawing.Color.Blue;
            this.DownWall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownWall.Location = new System.Drawing.Point(0, 849);
            this.DownWall.Name = "DownWall";
            this.DownWall.Size = new System.Drawing.Size(1536, 15);
            this.DownWall.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(763, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 834);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // leftscore
            // 
            this.leftscore.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftscore.Location = new System.Drawing.Point(679, 20);
            this.leftscore.Name = "leftscore";
            this.leftscore.Size = new System.Drawing.Size(78, 68);
            this.leftscore.TabIndex = 6;
            this.leftscore.Text = "0";
            this.leftscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightscore
            // 
            this.rightscore.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightscore.Location = new System.Drawing.Point(779, 20);
            this.rightscore.Name = "rightscore";
            this.rightscore.Size = new System.Drawing.Size(78, 68);
            this.rightscore.TabIndex = 6;
            this.rightscore.Text = "0";
            this.rightscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightscore.Click += new System.EventHandler(this.label3_Click);
            // 
            // restarter
            // 
            this.restarter.Interval = 1;
            this.restarter.Tick += new System.EventHandler(this.restarter_Tick);
            // 
            // GOLabel
            // 
            this.GOLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GOLabel.Location = new System.Drawing.Point(221, 395);
            this.GOLabel.Name = "GOLabel";
            this.GOLabel.Size = new System.Drawing.Size(1095, 74);
            this.GOLabel.TabIndex = 7;
            this.GOLabel.Text = "Игра окончена! Для выхода нажмите ESC";
            this.GOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GOLabel.Visible = false;
            // 
            // Exiter
            // 
            this.Exiter.Interval = 1;
            this.Exiter.Tick += new System.EventHandler(this.Exiter_Tick);
            // 
            // PlayBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.GOLabel);
            this.Controls.Add(this.rightscore);
            this.Controls.Add(this.leftscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownWall);
            this.Controls.Add(this.UpWall);
            this.Controls.Add(this.GRacket);
            this.Controls.Add(this.RRacket);
            this.Controls.Add(this.ball);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayBoard";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RRacket;
        private System.Windows.Forms.Label GRacket;
        private System.Windows.Forms.Label ball;
        private System.Windows.Forms.Label UpWall;
        private System.Windows.Forms.Label DownWall;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leftscore;
        private System.Windows.Forms.Label rightscore;
        private System.Windows.Forms.Timer restarter;
        private System.Windows.Forms.Label GOLabel;
        private System.Windows.Forms.Timer Exiter;
    }
}

