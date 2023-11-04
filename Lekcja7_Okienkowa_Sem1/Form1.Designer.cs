namespace Lekcja7_Okienkowa_Sem1
{
    partial class Zgadywanka
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
            this.lb_Info = new System.Windows.Forms.Label();
            this.txt_PodanaLiczba = new System.Windows.Forms.TextBox();
            this.txt_licznikprob = new System.Windows.Forms.TextBox();
            this.lb_LiczbaProb = new System.Windows.Forms.Label();
            this.lb_prosba = new System.Windows.Forms.Label();
            this.btn_Sprawdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Info.Location = new System.Drawing.Point(117, 50);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(545, 25);
            this.lb_Info.TabIndex = 0;
            this.lb_Info.Text = "Zgadnij liczbę wylosowaną przez komputer (1-1000000)";
            // 
            // txt_PodanaLiczba
            // 
            this.txt_PodanaLiczba.Location = new System.Drawing.Point(425, 105);
            this.txt_PodanaLiczba.Name = "txt_PodanaLiczba";
            this.txt_PodanaLiczba.Size = new System.Drawing.Size(100, 20);
            this.txt_PodanaLiczba.TabIndex = 1;
            // 
            // txt_licznikprob
            // 
            this.txt_licznikprob.Location = new System.Drawing.Point(425, 179);
            this.txt_licznikprob.Name = "txt_licznikprob";
            this.txt_licznikprob.Size = new System.Drawing.Size(100, 20);
            this.txt_licznikprob.TabIndex = 2;
            // 
            // lb_LiczbaProb
            // 
            this.lb_LiczbaProb.AutoSize = true;
            this.lb_LiczbaProb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_LiczbaProb.Location = new System.Drawing.Point(263, 174);
            this.lb_LiczbaProb.Name = "lb_LiczbaProb";
            this.lb_LiczbaProb.Size = new System.Drawing.Size(114, 24);
            this.lb_LiczbaProb.TabIndex = 3;
            this.lb_LiczbaProb.Text = "Liczba Prób:";
            // 
            // lb_prosba
            // 
            this.lb_prosba.AutoSize = true;
            this.lb_prosba.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_prosba.Location = new System.Drawing.Point(257, 101);
            this.lb_prosba.Name = "lb_prosba";
            this.lb_prosba.Size = new System.Drawing.Size(120, 24);
            this.lb_prosba.TabIndex = 4;
            this.lb_prosba.Text = "Wpisz liczbe:";
            // 
            // btn_Sprawdz
            // 
            this.btn_Sprawdz.BackColor = System.Drawing.Color.Red;
            this.btn_Sprawdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Sprawdz.ForeColor = System.Drawing.Color.White;
            this.btn_Sprawdz.Location = new System.Drawing.Point(354, 228);
            this.btn_Sprawdz.Name = "btn_Sprawdz";
            this.btn_Sprawdz.Size = new System.Drawing.Size(108, 38);
            this.btn_Sprawdz.TabIndex = 5;
            this.btn_Sprawdz.Text = "Sprawdź";
            this.btn_Sprawdz.UseVisualStyleBackColor = false;
            this.btn_Sprawdz.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zgadywanka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(759, 400);
            this.Controls.Add(this.btn_Sprawdz);
            this.Controls.Add(this.lb_prosba);
            this.Controls.Add(this.lb_LiczbaProb);
            this.Controls.Add(this.txt_licznikprob);
            this.Controls.Add(this.txt_PodanaLiczba);
            this.Controls.Add(this.lb_Info);
            this.Name = "Zgadywanka";
            this.Text = "Zgadywanka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.TextBox txt_PodanaLiczba;
        private System.Windows.Forms.TextBox txt_licznikprob;
        private System.Windows.Forms.Label lb_LiczbaProb;
        private System.Windows.Forms.Label lb_prosba;
        private System.Windows.Forms.Button btn_Sprawdz;
    }
}

