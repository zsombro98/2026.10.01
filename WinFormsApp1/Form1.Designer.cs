namespace WinFormsApp1
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
            lblHelloWorld = new Label();
            btnKek = new Button();
            btnWhiteBg = new Button();
            btnDelete = new Button();
            btnMiddleLeft = new Button();
            btnMiddleCenter = new Button();
            btnMiddleRight = new Button();
            btnUppercase = new Button();
            btnBiggerFont = new Button();
            btnSmallerFont = new Button();
            btnReset = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.Location = new Point(22, 25);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(179, 119);
            lblHelloWorld.TabIndex = 0;
            lblHelloWorld.Text = "hello world";
            // 
            // btnKek
            // 
            btnKek.Location = new Point(12, 112);
            btnKek.Name = "btnKek";
            btnKek.Size = new Size(75, 23);
            btnKek.TabIndex = 1;
            btnKek.Text = "blue text";
            btnKek.UseVisualStyleBackColor = true;
            // 
            // btnWhiteBg
            // 
            btnWhiteBg.Location = new Point(105, 112);
            btnWhiteBg.Name = "btnWhiteBg";
            btnWhiteBg.Size = new Size(75, 23);
            btnWhiteBg.TabIndex = 2;
            btnWhiteBg.Text = "white bg";
            btnWhiteBg.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(198, 112);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnMiddleLeft
            // 
            btnMiddleLeft.Location = new Point(12, 161);
            btnMiddleLeft.Name = "btnMiddleLeft";
            btnMiddleLeft.Size = new Size(75, 23);
            btnMiddleLeft.TabIndex = 4;
            btnMiddleLeft.Text = "MiddleLeft";
            btnMiddleLeft.UseVisualStyleBackColor = true;
            // 
            // btnMiddleCenter
            // 
            btnMiddleCenter.Location = new Point(105, 161);
            btnMiddleCenter.Name = "btnMiddleCenter";
            btnMiddleCenter.Size = new Size(75, 23);
            btnMiddleCenter.TabIndex = 5;
            btnMiddleCenter.Text = "middle-center";
            btnMiddleCenter.UseVisualStyleBackColor = true;
            // 
            // btnMiddleRight
            // 
            btnMiddleRight.Location = new Point(198, 161);
            btnMiddleRight.Name = "btnMiddleRight";
            btnMiddleRight.Size = new Size(75, 23);
            btnMiddleRight.TabIndex = 6;
            btnMiddleRight.Text = "MiddleRight";
            btnMiddleRight.UseVisualStyleBackColor = true;
            // 
            // btnUppercase
            // 
            btnUppercase.Location = new Point(12, 214);
            btnUppercase.Name = "btnUppercase";
            btnUppercase.Size = new Size(75, 23);
            btnUppercase.TabIndex = 7;
            btnUppercase.Text = "Uppercase";
            btnUppercase.UseVisualStyleBackColor = true;
            // 
            // btnBiggerFont
            // 
            btnBiggerFont.Location = new Point(105, 214);
            btnBiggerFont.Name = "btnBiggerFont";
            btnBiggerFont.Size = new Size(75, 23);
            btnBiggerFont.TabIndex = 8;
            btnBiggerFont.Text = "font size +";
            btnBiggerFont.UseVisualStyleBackColor = true;
            // 
            // btnSmallerFont
            // 
            btnSmallerFont.Location = new Point(198, 214);
            btnSmallerFont.Name = "btnSmallerFont";
            btnSmallerFont.Size = new Size(75, 23);
            btnSmallerFont.TabIndex = 9;
            btnSmallerFont.Text = "font size -";
            btnSmallerFont.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(12, 268);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(198, 268);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnSmallerFont);
            Controls.Add(btnBiggerFont);
            Controls.Add(btnUppercase);
            Controls.Add(btnMiddleRight);
            Controls.Add(btnMiddleCenter);
            Controls.Add(btnMiddleLeft);
            Controls.Add(btnDelete);
            Controls.Add(btnWhiteBg);
            Controls.Add(btnKek);
            Controls.Add(lblHelloWorld);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblHelloWorld;
        private Button btnKek;
        private Button btnWhiteBg;
        private Button btnDelete;
        private Button btnMiddleLeft;
        private Button btnMiddleCenter;
        private Button btnMiddleRight;
        private Button btnUppercase;
        private Button btnBiggerFont;
        private Button btnSmallerFont;
        private Button btnReset;
        private Button btnExit;
    }
}
