namespace RandomCharacters
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMix = new System.Windows.Forms.RadioButton();
            this.rbCapitalLetter = new System.Windows.Forms.RadioButton();
            this.rbSmallLetter = new System.Windows.Forms.RadioButton();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.Copy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.Copy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "RESULT IS : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 62);
            this.label2.TabIndex = 14;
            this.label2.Text = "GENERATE KEYS\r\n";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbMix);
            this.panel1.Controls.Add(this.rbCapitalLetter);
            this.panel1.Controls.Add(this.rbSmallLetter);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 228);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // rbMix
            // 
            this.rbMix.AutoSize = true;
            this.rbMix.Enabled = false;
            this.rbMix.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMix.ForeColor = System.Drawing.Color.Yellow;
            this.rbMix.Location = new System.Drawing.Point(149, 162);
            this.rbMix.Name = "rbMix";
            this.rbMix.Size = new System.Drawing.Size(64, 32);
            this.rbMix.TabIndex = 13;
            this.rbMix.TabStop = true;
            this.rbMix.Text = "Mix";
            this.rbMix.UseVisualStyleBackColor = true;
            // 
            // rbCapitalLetter
            // 
            this.rbCapitalLetter.AutoSize = true;
            this.rbCapitalLetter.Checked = true;
            this.rbCapitalLetter.Enabled = false;
            this.rbCapitalLetter.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCapitalLetter.ForeColor = System.Drawing.Color.Yellow;
            this.rbCapitalLetter.Location = new System.Drawing.Point(189, 82);
            this.rbCapitalLetter.Name = "rbCapitalLetter";
            this.rbCapitalLetter.Size = new System.Drawing.Size(160, 32);
            this.rbCapitalLetter.TabIndex = 12;
            this.rbCapitalLetter.TabStop = true;
            this.rbCapitalLetter.Text = "Capital Letter";
            this.rbCapitalLetter.UseVisualStyleBackColor = true;
            // 
            // rbSmallLetter
            // 
            this.rbSmallLetter.AutoSize = true;
            this.rbSmallLetter.Enabled = false;
            this.rbSmallLetter.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmallLetter.ForeColor = System.Drawing.Color.Yellow;
            this.rbSmallLetter.Location = new System.Drawing.Point(23, 82);
            this.rbSmallLetter.Name = "rbSmallLetter";
            this.rbSmallLetter.Size = new System.Drawing.Size(145, 32);
            this.rbSmallLetter.TabIndex = 10;
            this.rbSmallLetter.Text = "Small Letter";
            this.rbSmallLetter.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNumber.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(251, 28);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(110, 30);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumber_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Keys: ";
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(435, 469);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 41);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.Black;
            this.btnExist.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExist.FlatAppearance.BorderSize = 3;
            this.btnExist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.ForeColor = System.Drawing.Color.Red;
            this.btnExist.Location = new System.Drawing.Point(838, 469);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(104, 41);
            this.btnExist.TabIndex = 11;
            this.btnExist.Text = "Exist";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnGenerate.FlatAppearance.BorderSize = 2;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(435, 401);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(104, 41);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnOptions.FlatAppearance.BorderSize = 2;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(30, 220);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(104, 41);
            this.btnOptions.TabIndex = 9;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtResult.ContextMenuStrip = this.Copy;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Gold;
            this.txtResult.Location = new System.Drawing.Point(180, 113);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(679, 148);
            this.txtResult.TabIndex = 8;
            this.txtResult.Visible = false;
            // 
            // Copy
            // 
            this.Copy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(978, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Generate Keys";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Copy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMix;
        private System.Windows.Forms.RadioButton rbCapitalLetter;
        private System.Windows.Forms.RadioButton rbSmallLetter;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip Copy;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}