namespace Calculator
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zeroButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.negationButton = new System.Windows.Forms.Button();
            this.CEbutton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.userInputText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(-8, 39);
            this.resultLabel.MinimumSize = new System.Drawing.Size(300, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(300, 21);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.zeroButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dotButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.oneButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.plusButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.minusButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.mulButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.twoButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.threeButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.sixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.fiveButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fourButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sevenButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nineButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.eightButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.divButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.equalsButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.negationButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CEbutton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cbutton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.delButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 274);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // zeroButton
            // 
            this.zeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zeroButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zeroButton.Location = new System.Drawing.Point(70, 219);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(61, 52);
            this.zeroButton.TabIndex = 0;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dotButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dotButton.Location = new System.Drawing.Point(3, 219);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(61, 52);
            this.dotButton.TabIndex = 0;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oneButton.Location = new System.Drawing.Point(3, 165);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(61, 48);
            this.oneButton.TabIndex = 0;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plusButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plusButton.Location = new System.Drawing.Point(204, 165);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(63, 48);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minusButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minusButton.Location = new System.Drawing.Point(204, 111);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(63, 48);
            this.minusButton.TabIndex = 0;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mulButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mulButton.Location = new System.Drawing.Point(204, 57);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(63, 48);
            this.mulButton.TabIndex = 0;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twoButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twoButton.Location = new System.Drawing.Point(70, 165);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(61, 48);
            this.twoButton.TabIndex = 0;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threeButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.threeButton.Location = new System.Drawing.Point(137, 165);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(61, 48);
            this.threeButton.TabIndex = 0;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sixButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sixButton.Location = new System.Drawing.Point(137, 111);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(61, 48);
            this.sixButton.TabIndex = 0;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fiveButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fiveButton.Location = new System.Drawing.Point(70, 111);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(61, 48);
            this.fiveButton.TabIndex = 0;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fourButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fourButton.Location = new System.Drawing.Point(3, 111);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(61, 48);
            this.fourButton.TabIndex = 0;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sevenButton.Location = new System.Drawing.Point(3, 57);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(61, 48);
            this.sevenButton.TabIndex = 0;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nineButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nineButton.Location = new System.Drawing.Point(137, 57);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(61, 48);
            this.nineButton.TabIndex = 0;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eightButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eightButton.Location = new System.Drawing.Point(70, 57);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(61, 48);
            this.eightButton.TabIndex = 0;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // divButton
            // 
            this.divButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divButton.Location = new System.Drawing.Point(204, 3);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(63, 48);
            this.divButton.TabIndex = 0;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equalsButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equalsButton.Location = new System.Drawing.Point(204, 219);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(63, 52);
            this.equalsButton.TabIndex = 0;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            this.equalsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.equalsButton_Click);
            // 
            // negationButton
            // 
            this.negationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.negationButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.negationButton.Location = new System.Drawing.Point(137, 219);
            this.negationButton.Name = "negationButton";
            this.negationButton.Size = new System.Drawing.Size(61, 52);
            this.negationButton.TabIndex = 0;
            this.negationButton.Text = "+/-";
            this.negationButton.UseVisualStyleBackColor = true;
            this.negationButton.Click += new System.EventHandler(this.negationButton_Click);
            // 
            // CEbutton
            // 
            this.CEbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CEbutton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CEbutton.Location = new System.Drawing.Point(3, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(61, 48);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // Cbutton
            // 
            this.Cbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbutton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cbutton.Location = new System.Drawing.Point(70, 3);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(61, 48);
            this.Cbutton.TabIndex = 0;
            this.Cbutton.Text = "C";
            this.Cbutton.UseVisualStyleBackColor = true;
            this.Cbutton.Click += new System.EventHandler(this.Cbutton_Click);
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delButton.Location = new System.Drawing.Point(137, 3);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(61, 48);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "DEL";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // userInputText
            // 
            this.userInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInputText.Location = new System.Drawing.Point(15, 13);
            this.userInputText.Name = "userInputText";
            this.userInputText.Size = new System.Drawing.Size(277, 23);
            this.userInputText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.equalsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(304, 361);
            this.Controls.Add(this.userInputText);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.resultLabel);
            this.MinimumSize = new System.Drawing.Size(320, 400);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button negationButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.TextBox userInputText;
        private System.Windows.Forms.Button delButton;
    }
}

