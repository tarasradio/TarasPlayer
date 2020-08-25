namespace TarasPlayer
{
    partial class SpectrumControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.vBar32 = new TarasPlayer.VerticalBar();
            this.vBar64 = new TarasPlayer.VerticalBar();
            this.vBar125 = new TarasPlayer.VerticalBar();
            this.vBar250 = new TarasPlayer.VerticalBar();
            this.vBar500 = new TarasPlayer.VerticalBar();
            this.vBar1000 = new TarasPlayer.VerticalBar();
            this.vBar2000 = new TarasPlayer.VerticalBar();
            this.vBar4000 = new TarasPlayer.VerticalBar();
            this.SuspendLayout();
            // 
            // vBar32
            // 
            this.vBar32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vBar32.Location = new System.Drawing.Point(3, 3);
            this.vBar32.Name = "vBar32";
            this.vBar32.Size = new System.Drawing.Size(20, 53);
            this.vBar32.TabIndex = 7;
            // 
            // vBar64
            // 
            this.vBar64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vBar64.Location = new System.Drawing.Point(29, 3);
            this.vBar64.Name = "vBar64";
            this.vBar64.Size = new System.Drawing.Size(20, 53);
            this.vBar64.TabIndex = 8;
            // 
            // vBar125
            // 
            this.vBar125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vBar125.Location = new System.Drawing.Point(55, 3);
            this.vBar125.Name = "vBar125";
            this.vBar125.Size = new System.Drawing.Size(20, 53);
            this.vBar125.TabIndex = 9;
            // 
            // vBar250
            // 
            this.vBar250.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vBar250.Location = new System.Drawing.Point(81, 3);
            this.vBar250.Name = "vBar250";
            this.vBar250.Size = new System.Drawing.Size(20, 53);
            this.vBar250.TabIndex = 10;
            // 
            // vBar500
            // 
            this.vBar500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vBar500.Location = new System.Drawing.Point(107, 3);
            this.vBar500.Name = "vBar500";
            this.vBar500.Size = new System.Drawing.Size(20, 53);
            this.vBar500.TabIndex = 11;
            // 
            // vBar1000
            // 
            this.vBar1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vBar1000.Location = new System.Drawing.Point(133, 3);
            this.vBar1000.Name = "vBar1000";
            this.vBar1000.Size = new System.Drawing.Size(20, 53);
            this.vBar1000.TabIndex = 12;
            // 
            // vBar2000
            // 
            this.vBar2000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vBar2000.Location = new System.Drawing.Point(159, 3);
            this.vBar2000.Name = "vBar2000";
            this.vBar2000.Size = new System.Drawing.Size(20, 53);
            this.vBar2000.TabIndex = 13;
            // 
            // vBar4000
            // 
            this.vBar4000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vBar4000.Location = new System.Drawing.Point(185, 3);
            this.vBar4000.Name = "vBar4000";
            this.vBar4000.Size = new System.Drawing.Size(20, 53);
            this.vBar4000.TabIndex = 14;
            // 
            // SpectrumControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vBar4000);
            this.Controls.Add(this.vBar2000);
            this.Controls.Add(this.vBar1000);
            this.Controls.Add(this.vBar500);
            this.Controls.Add(this.vBar250);
            this.Controls.Add(this.vBar125);
            this.Controls.Add(this.vBar64);
            this.Controls.Add(this.vBar32);
            this.Name = "SpectrumControl";
            this.Size = new System.Drawing.Size(209, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private VerticalBar vBar32;
        private VerticalBar vBar64;
        private VerticalBar vBar125;
        private VerticalBar vBar250;
        private VerticalBar vBar500;
        private VerticalBar vBar1000;
        private VerticalBar vBar2000;
        private VerticalBar vBar4000;
    }
}
