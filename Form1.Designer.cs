
namespace CurrencyConverterApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.fromcombo1 = new System.Windows.Forms.ComboBox();
            this.tocombo2 = new System.Windows.Forms.ComboBox();
            this.display_txt = new System.Windows.Forms.Label();
            this.conv_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convert From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convert To";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(159, 90);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(151, 27);
            this.amount_txt.TabIndex = 3;
            // 
            // fromcombo1
            // 
            this.fromcombo1.FormattingEnabled = true;
            this.fromcombo1.Items.AddRange(new object[] {
            "Rupees",
            "Dollar",
            "Euro"});
            this.fromcombo1.Location = new System.Drawing.Point(159, 150);
            this.fromcombo1.Name = "fromcombo1";
            this.fromcombo1.Size = new System.Drawing.Size(151, 28);
            this.fromcombo1.TabIndex = 4;
            // 
            // tocombo2
            // 
            this.tocombo2.FormattingEnabled = true;
            this.tocombo2.Items.AddRange(new object[] {
            "Rupees",
            "Dollar",
            "Euro"});
            this.tocombo2.Location = new System.Drawing.Point(159, 207);
            this.tocombo2.Name = "tocombo2";
            this.tocombo2.Size = new System.Drawing.Size(151, 28);
            this.tocombo2.TabIndex = 5;
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Location = new System.Drawing.Point(53, 316);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(145, 20);
            this.display_txt.TabIndex = 6;
            this.display_txt.Text = "Converted Amount : ";
            // 
            // conv_btn
            // 
            this.conv_btn.Location = new System.Drawing.Point(182, 268);
            this.conv_btn.Name = "conv_btn";
            this.conv_btn.Size = new System.Drawing.Size(94, 29);
            this.conv_btn.TabIndex = 7;
            this.conv_btn.Text = "Convert";
            this.conv_btn.UseVisualStyleBackColor = true;
            this.conv_btn.Click += new System.EventHandler(this.conv_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 442);
            this.Controls.Add(this.conv_btn);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.tocombo2);
            this.Controls.Add(this.fromcombo1);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.ComboBox fromcombo1;
        private System.Windows.Forms.ComboBox tocombo2;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.Button conv_btn;
    }
}

