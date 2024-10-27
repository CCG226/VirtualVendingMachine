

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
            CanBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Title).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutputBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CanBox).BeginInit();
            SuspendLayout();
            // 
            // OutputText
            // 
            OutputText.AutoSize = true;
            OutputText.Location = new Point(580, 293);
            OutputText.Name = "OutputText";
            OutputText.Size = new Size(0, 20);
            OutputText.TabIndex = 5;
            OutputText.TextAlign = ContentAlignment.MiddleCenter;
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
            CreamBtn.Click += BuyClick;
            CreamBtn.MouseHover += PriceHover;
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(323, 375);
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
            GrapeBtn.Click += BuyClick;
            GrapeBtn.MouseHover += PriceHover;
            // 
            // LemonLimeBtn
            // 
            LemonLimeBtn.Location = new Point(580, 149);
            LemonLimeBtn.Name = "LemonLimeBtn";
            LemonLimeBtn.Size = new Size(254, 81);
            LemonLimeBtn.TabIndex = 13;
            LemonLimeBtn.UseVisualStyleBackColor = true;
            LemonLimeBtn.Click += BuyClick;
            LemonLimeBtn.MouseHover += PriceHover;
            // 
            // RootBeerBtn
            // 
            RootBeerBtn.Location = new Point(295, 149);
            RootBeerBtn.Name = "RootBeerBtn";
            RootBeerBtn.Size = new Size(254, 81);
            RootBeerBtn.TabIndex = 14;
            RootBeerBtn.UseVisualStyleBackColor = true;
            RootBeerBtn.Click += BuyClick;
            RootBeerBtn.MouseHover += PriceHover;
            // 
            // PepsiBtn
            // 
            PepsiBtn.Location = new Point(12, 149);
            PepsiBtn.Name = "PepsiBtn";
            PepsiBtn.Size = new Size(254, 81);
            PepsiBtn.TabIndex = 15;
            PepsiBtn.UseVisualStyleBackColor = true;
            PepsiBtn.Click += BuyClick;
            PepsiBtn.MouseHover += PriceHover;
            // 
            // CanBox
            // 
            CanBox.BackColor = Color.Transparent;     
            CanBox.Name = "CanBox";
            CanBox.Size = new Size(79, 82);
            CanBox.Location = new Point(400, 391);
            CanBox.Visible = false;
            CanBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CanBox.TabIndex = 16;
            CanBox.TabStop = false;
            // 
            // VirtualVendingMachine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 51, 153);
            ClientSize = new Size(846, 473);
            Controls.Add(CanBox);
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
            ((System.ComponentModel.ISupportInitialize)CanBox).EndInit();
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
        private PictureBox CanBox;
    }
}
