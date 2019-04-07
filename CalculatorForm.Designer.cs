namespace Calculator {
    partial class Calculator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.resultText = new System.Windows.Forms.TextBox();
            this.negativeButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.rootButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.recipricolButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.Location = new System.Drawing.Point(12, 12);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(258, 43);
            this.resultText.TabIndex = 0;
            this.resultText.TabStop = false;
            this.resultText.Text = "0";
            this.resultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // negativeButton
            // 
            this.negativeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negativeButton.Location = new System.Drawing.Point(12, 341);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(60, 50);
            this.negativeButton.TabIndex = 1;
            this.negativeButton.TabStop = false;
            this.negativeButton.Text = "+-";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.negativeButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(78, 341);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(60, 50);
            this.zeroButton.TabIndex = 2;
            this.zeroButton.TabStop = false;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(144, 341);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(60, 50);
            this.decimalButton.TabIndex = 3;
            this.decimalButton.TabStop = false;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(210, 341);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(60, 50);
            this.equalButton.TabIndex = 4;
            this.equalButton.TabStop = false;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(12, 285);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(60, 50);
            this.oneButton.TabIndex = 5;
            this.oneButton.TabStop = false;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(78, 285);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(60, 50);
            this.twoButton.TabIndex = 6;
            this.twoButton.TabStop = false;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(144, 285);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(60, 50);
            this.threeButton.TabIndex = 7;
            this.threeButton.TabStop = false;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(210, 285);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(60, 50);
            this.plusButton.TabIndex = 8;
            this.plusButton.TabStop = false;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(12, 229);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(60, 50);
            this.fourButton.TabIndex = 9;
            this.fourButton.TabStop = false;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(78, 229);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(60, 50);
            this.fiveButton.TabIndex = 10;
            this.fiveButton.TabStop = false;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(144, 229);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(60, 50);
            this.sixButton.TabIndex = 11;
            this.sixButton.TabStop = false;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(210, 229);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(60, 50);
            this.minusButton.TabIndex = 12;
            this.minusButton.TabStop = false;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(12, 173);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(60, 50);
            this.sevenButton.TabIndex = 13;
            this.sevenButton.TabStop = false;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(78, 173);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(60, 50);
            this.eightButton.TabIndex = 14;
            this.eightButton.TabStop = false;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(144, 173);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(60, 50);
            this.nineButton.TabIndex = 15;
            this.nineButton.TabStop = false;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(210, 173);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(60, 50);
            this.multiplyButton.TabIndex = 16;
            this.multiplyButton.TabStop = false;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            // 
            // CEButton
            // 
            this.CEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.Location = new System.Drawing.Point(12, 117);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(60, 50);
            this.CEButton.TabIndex = 17;
            this.CEButton.TabStop = false;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // CButton
            // 
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.Location = new System.Drawing.Point(78, 117);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(60, 50);
            this.CButton.TabIndex = 18;
            this.CButton.TabStop = false;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(144, 117);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 50);
            this.backButton.TabIndex = 19;
            this.backButton.TabStop = false;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(210, 117);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(60, 50);
            this.divideButton.TabIndex = 20;
            this.divideButton.TabStop = false;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // percentButton
            // 
            this.percentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentButton.Location = new System.Drawing.Point(12, 61);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(60, 50);
            this.percentButton.TabIndex = 21;
            this.percentButton.TabStop = false;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = true;
            // 
            // rootButton
            // 
            this.rootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootButton.Location = new System.Drawing.Point(78, 61);
            this.rootButton.Name = "rootButton";
            this.rootButton.Size = new System.Drawing.Size(60, 50);
            this.rootButton.TabIndex = 22;
            this.rootButton.TabStop = false;
            this.rootButton.Text = "√";
            this.rootButton.UseVisualStyleBackColor = true;
            // 
            // squareButton
            // 
            this.squareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareButton.Location = new System.Drawing.Point(144, 61);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(60, 50);
            this.squareButton.TabIndex = 23;
            this.squareButton.TabStop = false;
            this.squareButton.Text = "x²";
            this.squareButton.UseVisualStyleBackColor = true;
            // 
            // recipricolButton
            // 
            this.recipricolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipricolButton.Location = new System.Drawing.Point(210, 61);
            this.recipricolButton.Name = "recipricolButton";
            this.recipricolButton.Size = new System.Drawing.Size(60, 50);
            this.recipricolButton.TabIndex = 24;
            this.recipricolButton.TabStop = false;
            this.recipricolButton.Text = "1/x";
            this.recipricolButton.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 403);
            this.Controls.Add(this.recipricolButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.rootButton);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.CEButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.resultText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button negativeButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button rootButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button recipricolButton;
    }
}

