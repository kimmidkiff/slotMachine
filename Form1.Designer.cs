namespace Slot_Machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fruitImageList = new System.Windows.Forms.ImageList(this.components);
            this.fruitPicture3 = new System.Windows.Forms.PictureBox();
            this.fruitPicture2 = new System.Windows.Forms.PictureBox();
            this.fruitPicture1 = new System.Windows.Forms.PictureBox();
            this.insertedLabel = new System.Windows.Forms.Label();
            this.amountInsertedTextBox = new System.Windows.Forms.TextBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // fruitImageList
            // 
            this.fruitImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitImageList.ImageStream")));
            this.fruitImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitImageList.Images.SetKeyName(0, "Orange.bmp");
            this.fruitImageList.Images.SetKeyName(1, "Pear.bmp");
            this.fruitImageList.Images.SetKeyName(2, "Watermelon.bmp");
            // 
            // fruitPicture3
            // 
            this.fruitPicture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fruitPicture3.Location = new System.Drawing.Point(286, 12);
            this.fruitPicture3.Name = "fruitPicture3";
            this.fruitPicture3.Size = new System.Drawing.Size(131, 131);
            this.fruitPicture3.TabIndex = 2;
            this.fruitPicture3.TabStop = false;
            // 
            // fruitPicture2
            // 
            this.fruitPicture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fruitPicture2.Location = new System.Drawing.Point(149, 12);
            this.fruitPicture2.Name = "fruitPicture2";
            this.fruitPicture2.Size = new System.Drawing.Size(131, 131);
            this.fruitPicture2.TabIndex = 1;
            this.fruitPicture2.TabStop = false;
            // 
            // fruitPicture1
            // 
            this.fruitPicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fruitPicture1.Location = new System.Drawing.Point(12, 12);
            this.fruitPicture1.Name = "fruitPicture1";
            this.fruitPicture1.Size = new System.Drawing.Size(131, 131);
            this.fruitPicture1.TabIndex = 0;
            this.fruitPicture1.TabStop = false;
            // 
            // insertedLabel
            // 
            this.insertedLabel.AutoSize = true;
            this.insertedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertedLabel.Location = new System.Drawing.Point(76, 155);
            this.insertedLabel.Name = "insertedLabel";
            this.insertedLabel.Size = new System.Drawing.Size(135, 18);
            this.insertedLabel.TabIndex = 3;
            this.insertedLabel.Text = "Amount Inserted : $";
            // 
            // amountInsertedTextBox
            // 
            this.amountInsertedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountInsertedTextBox.Location = new System.Drawing.Point(217, 157);
            this.amountInsertedTextBox.Name = "amountInsertedTextBox";
            this.amountInsertedTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountInsertedTextBox.TabIndex = 4;
            // 
            // spinButton
            // 
            this.spinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spinButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spinButton.Location = new System.Drawing.Point(127, 192);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(75, 23);
            this.spinButton.TabIndex = 7;
            this.spinButton.Text = "Spin!";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(217, 192);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 240);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.amountInsertedTextBox);
            this.Controls.Add(this.insertedLabel);
            this.Controls.Add(this.fruitPicture3);
            this.Controls.Add(this.fruitPicture2);
            this.Controls.Add(this.fruitPicture1);
            this.Name = "Form1";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fruitPicture1;
        private System.Windows.Forms.PictureBox fruitPicture2;
        private System.Windows.Forms.PictureBox fruitPicture3;
        private System.Windows.Forms.ImageList fruitImageList;
        private System.Windows.Forms.Label insertedLabel;
        private System.Windows.Forms.TextBox amountInsertedTextBox;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button exitButton;
    }
}

