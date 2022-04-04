
namespace Praktikum_Week_7
{
    partial class FormQuizPanda
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
            this.labelInputKalimat = new System.Windows.Forms.Label();
            this.labelInputHuruf = new System.Windows.Forms.Label();
            this.textBoxInputKal = new System.Windows.Forms.TextBox();
            this.textBoxInputHur = new System.Windows.Forms.TextBox();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.textBoxInputMenjadi = new System.Windows.Forms.TextBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInputKalimat
            // 
            this.labelInputKalimat.AutoSize = true;
            this.labelInputKalimat.Location = new System.Drawing.Point(27, 32);
            this.labelInputKalimat.Name = "labelInputKalimat";
            this.labelInputKalimat.Size = new System.Drawing.Size(129, 20);
            this.labelInputKalimat.TabIndex = 0;
            this.labelInputKalimat.Text = "Masukkan Kalimat";
            // 
            // labelInputHuruf
            // 
            this.labelInputHuruf.AutoSize = true;
            this.labelInputHuruf.Location = new System.Drawing.Point(27, 96);
            this.labelInputHuruf.Name = "labelInputHuruf";
            this.labelInputHuruf.Size = new System.Drawing.Size(115, 20);
            this.labelInputHuruf.TabIndex = 1;
            this.labelInputHuruf.Text = "Masukkan Huruf";
            // 
            // textBoxInputKal
            // 
            this.textBoxInputKal.Location = new System.Drawing.Point(169, 32);
            this.textBoxInputKal.Name = "textBoxInputKal";
            this.textBoxInputKal.Size = new System.Drawing.Size(401, 27);
            this.textBoxInputKal.TabIndex = 2;
            // 
            // textBoxInputHur
            // 
            this.textBoxInputHur.Location = new System.Drawing.Point(169, 96);
            this.textBoxInputHur.Name = "textBoxInputHur";
            this.textBoxInputHur.Size = new System.Drawing.Size(125, 27);
            this.textBoxInputHur.TabIndex = 3;
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(363, 99);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(63, 20);
            this.labelMenjadi.TabIndex = 4;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(27, 271);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(53, 20);
            this.labelHasil.TabIndex = 5;
            this.labelHasil.Text = "Hasil : ";
            // 
            // textBoxInputMenjadi
            // 
            this.textBoxInputMenjadi.Location = new System.Drawing.Point(445, 96);
            this.textBoxInputMenjadi.Name = "textBoxInputMenjadi";
            this.textBoxInputMenjadi.Size = new System.Drawing.Size(125, 27);
            this.textBoxInputMenjadi.TabIndex = 6;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(169, 198);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(401, 29);
            this.buttonKonversi.TabIndex = 7;
            this.buttonKonversi.Text = "Konversi!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutput.Location = new System.Drawing.Point(169, 262);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(34, 31);
            this.labelOutput.TabIndex = 8;
            this.labelOutput.Text = "....";
            // 
            // FormQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.textBoxInputMenjadi);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.textBoxInputHur);
            this.Controls.Add(this.textBoxInputKal);
            this.Controls.Add(this.labelInputHuruf);
            this.Controls.Add(this.labelInputKalimat);
            this.Name = "FormQuizPanda";
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputKalimat;
        private System.Windows.Forms.Label labelInputHuruf;
        private System.Windows.Forms.TextBox textBoxInputKal;
        private System.Windows.Forms.TextBox textBoxInputHur;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.TextBox textBoxInputMenjadi;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.Label labelOutput;
    }
}

