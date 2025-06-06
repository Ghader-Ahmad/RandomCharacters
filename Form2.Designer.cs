namespace RandomCharacters
{
    partial class Form2
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
            this.Copy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smallLettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalLettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.rbLetter = new System.Windows.Forms.RadioButton();
            this.rbSymbol = new System.Windows.Forms.RadioButton();
            this.rbNumber = new System.Windows.Forms.RadioButton();
            this.rbMix = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Copy.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallLettersToolStripMenuItem,
            this.capitalLettersToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 48);
            // 
            // smallLettersToolStripMenuItem
            // 
            this.smallLettersToolStripMenuItem.Name = "smallLettersToolStripMenuItem";
            this.smallLettersToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.smallLettersToolStripMenuItem.Text = "Small Letter";
            this.smallLettersToolStripMenuItem.Click += new System.EventHandler(this.smallLettersToolStripMenuItem_Click);
            // 
            // capitalLettersToolStripMenuItem
            // 
            this.capitalLettersToolStripMenuItem.Name = "capitalLettersToolStripMenuItem";
            this.capitalLettersToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.capitalLettersToolStripMenuItem.Text = "Capital Letter";
            this.capitalLettersToolStripMenuItem.Click += new System.EventHandler(this.capitalLettersToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtResult.ContextMenuStrip = this.Copy;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Gold;
            this.txtResult.Location = new System.Drawing.Point(193, 113);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(679, 148);
            this.txtResult.TabIndex = 0;
            this.txtResult.Visible = false;
            // 
            // btnOptions
            // 
            this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnOptions.FlatAppearance.BorderSize = 2;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(43, 220);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(104, 41);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnGenerate.FlatAppearance.BorderSize = 2;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(448, 401);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(104, 41);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
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
            this.btnExist.Location = new System.Drawing.Point(851, 469);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(104, 41);
            this.btnExist.TabIndex = 3;
            this.btnExist.Text = "Exist";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(448, 469);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 41);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Digits: ";
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
            // rbLetter
            // 
            this.rbLetter.AutoSize = true;
            this.rbLetter.ContextMenuStrip = this.contextMenuStrip1;
            this.rbLetter.Enabled = false;
            this.rbLetter.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLetter.ForeColor = System.Drawing.Color.Yellow;
            this.rbLetter.Location = new System.Drawing.Point(23, 82);
            this.rbLetter.Name = "rbLetter";
            this.rbLetter.Size = new System.Drawing.Size(96, 32);
            this.rbLetter.TabIndex = 10;
            this.rbLetter.Text = "Letters";
            this.rbLetter.UseVisualStyleBackColor = true;
            // 
            // rbSymbol
            // 
            this.rbSymbol.AutoSize = true;
            this.rbSymbol.Enabled = false;
            this.rbSymbol.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSymbol.ForeColor = System.Drawing.Color.Yellow;
            this.rbSymbol.Location = new System.Drawing.Point(23, 163);
            this.rbSymbol.Name = "rbSymbol";
            this.rbSymbol.Size = new System.Drawing.Size(108, 32);
            this.rbSymbol.TabIndex = 11;
            this.rbSymbol.TabStop = true;
            this.rbSymbol.Text = "Symbols";
            this.rbSymbol.UseVisualStyleBackColor = true;
            // 
            // rbNumber
            // 
            this.rbNumber.AutoSize = true;
            this.rbNumber.Checked = true;
            this.rbNumber.Enabled = false;
            this.rbNumber.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNumber.ForeColor = System.Drawing.Color.Yellow;
            this.rbNumber.Location = new System.Drawing.Point(189, 82);
            this.rbNumber.Name = "rbNumber";
            this.rbNumber.Size = new System.Drawing.Size(116, 32);
            this.rbNumber.TabIndex = 12;
            this.rbNumber.TabStop = true;
            this.rbNumber.Text = "Numbers";
            this.rbNumber.UseVisualStyleBackColor = true;
            // 
            // rbMix
            // 
            this.rbMix.AutoSize = true;
            this.rbMix.Enabled = false;
            this.rbMix.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMix.ForeColor = System.Drawing.Color.Yellow;
            this.rbMix.Location = new System.Drawing.Point(189, 163);
            this.rbMix.Name = "rbMix";
            this.rbMix.Size = new System.Drawing.Size(64, 32);
            this.rbMix.TabIndex = 13;
            this.rbMix.TabStop = true;
            this.rbMix.Text = "Mix";
            this.rbMix.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbMix);
            this.panel1.Controls.Add(this.rbNumber);
            this.panel1.Controls.Add(this.rbSymbol);
            this.panel1.Controls.Add(this.rbLetter);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 228);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 62);
            this.label2.TabIndex = 6;
            this.label2.Text = "RANDOM CHARACTERS\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(37, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "RESULT IS : ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(967, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.txtResult);
            this.Name = "Form2";
            this.Text = "Random Character";
            this.Copy.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smallLettersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitalLettersToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip Copy;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMix;
        private System.Windows.Forms.RadioButton rbNumber;
        private System.Windows.Forms.RadioButton rbSymbol;
        private System.Windows.Forms.RadioButton rbLetter;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.TextBox txtResult;
    }
}