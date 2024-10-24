using System.Windows.Forms;

namespace VirtualVendingMachine
{
    partial class VirtualVendingMachine
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
        //  Title.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"logo.png");
        //   OutputBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"pickUp.png");
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OutputText = new Label();
            Title = new PictureBox();
            CreamBtn = new Button();
            OutputBox = new PictureBox();
            GrapeBtn = new Button();
            LemonLimeBtn = new Button();
            RootBeerBtn = new Button();
            PepsiBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Title).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutputBox).BeginInit();
            SuspendLayout();
            // 
            // OutputText
            // 
            OutputText.AutoSize = true;
            OutputText.Location = new Point(659, 293);
            OutputText.Name = "OutputText";
            OutputText.Size = new Size(52, 20);
            OutputText.TabIndex = 5;
            OutputText.Text = "Peposi";
            // 
            // Title
            // 
            Title.Location = new Point(196, 12);
            Title.Name = "Title";
            Title.Size = new Size(442, 123);
            Title.SizeMode = PictureBoxSizeMode.StretchImage;
            Title.TabIndex = 6;
            Title.TabStop = false;
            // 
            // CreamBtn
            // 
            CreamBtn.Location = new Point(295, 263);
            CreamBtn.Name = "CreamBtn";
            CreamBtn.Size = new Size(254, 81);
            CreamBtn.TabIndex = 10;
            CreamBtn.UseVisualStyleBackColor = true;
            CreamBtn.MouseHover += PriceHover;
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(332, 375);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(195, 76);
            OutputBox.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputBox.TabIndex = 11;
            OutputBox.TabStop = false;
            // 
            // GrapeBtn
            // 
            GrapeBtn.Location = new Point(12, 263);
            GrapeBtn.Name = "GrapeBtn";
            GrapeBtn.Size = new Size(254, 81);
            GrapeBtn.TabIndex = 12;
            GrapeBtn.UseVisualStyleBackColor = true;
            GrapeBtn.MouseHover += PriceHover;
            // 
            // LemonLimeBtn
            // 
            LemonLimeBtn.Location = new Point(580, 149);
            LemonLimeBtn.Name = "LemonLimeBtn";
            LemonLimeBtn.Size = new Size(254, 81);
            LemonLimeBtn.TabIndex = 13;
            LemonLimeBtn.UseVisualStyleBackColor = true;
            LemonLimeBtn.MouseHover += PriceHover;
            // 
            // RootBeerBtn
            // 
            RootBeerBtn.Location = new Point(295, 149);
            RootBeerBtn.Name = "RootBeerBtn";
            RootBeerBtn.Size = new Size(254, 81);
            RootBeerBtn.TabIndex = 14;
            RootBeerBtn.UseVisualStyleBackColor = true;
            RootBeerBtn.MouseHover += PriceHover;
            // 
            // PepsiBtn
            // 
            PepsiBtn.Location = new Point(12, 149);
            PepsiBtn.Name = "PepsiBtn";
            PepsiBtn.Size = new Size(254, 81);
            PepsiBtn.TabIndex = 15;
            PepsiBtn.UseVisualStyleBackColor = true;
            PepsiBtn.MouseHover += PriceHover;
            PepsiBtn.Click += BuyClick; 
            // 
            // VirtualVendingMachine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 51, 153);
            ClientSize = new Size(846, 473);
            Controls.Add(PepsiBtn);
            Controls.Add(RootBeerBtn);
            Controls.Add(LemonLimeBtn);
            Controls.Add(GrapeBtn);
            Controls.Add(OutputBox);
            Controls.Add(CreamBtn);
            Controls.Add(Title);
            Controls.Add(OutputText);
            Name = "VirtualVendingMachine";
            Text = "VirtualVendingMachine";
            ((System.ComponentModel.ISupportInitialize)Title).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutputBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label OutputText;
        private PictureBox Title;
        private Button CreamBtn;
        private PictureBox OutputBox;
        private Button GrapeBtn;
        private Button LemonLimeBtn;
        private Button RootBeerBtn;
        private Button PepsiBtn;
    }
}
