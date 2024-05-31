namespace Elinesoft_test_task
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
            Binance = new Label();
            Bybit = new Label();
            Kucoin = new Label();
            Bitget = new Label();
            lblBinancePrice = new Label();
            lblBybitPrice = new Label();
            lblKucoinPrice = new Label();
            lblBitgetPrice = new Label();
            label1 = new Label();
            cmbCryptoPairs = new ComboBox();
            SuspendLayout();
            // 
            // Binance
            // 
            Binance.AutoSize = true;
            Binance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Binance.Location = new Point(51, 86);
            Binance.Name = "Binance";
            Binance.Size = new Size(82, 25);
            Binance.TabIndex = 0;
            Binance.Text = "Binance";
            // 
            // Bybit
            // 
            Bybit.AutoSize = true;
            Bybit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Bybit.Location = new Point(167, 88);
            Bybit.Name = "Bybit";
            Bybit.Size = new Size(58, 25);
            Bybit.TabIndex = 1;
            Bybit.Text = "Bybit";
            // 
            // Kucoin
            // 
            Kucoin.AutoSize = true;
            Kucoin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Kucoin.Location = new Point(281, 88);
            Kucoin.Name = "Kucoin";
            Kucoin.Size = new Size(74, 25);
            Kucoin.TabIndex = 2;
            Kucoin.Text = "Kucoin";
            // 
            // Bitget
            // 
            Bitget.AutoSize = true;
            Bitget.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Bitget.Location = new Point(386, 86);
            Bitget.Name = "Bitget";
            Bitget.Size = new Size(65, 25);
            Bitget.TabIndex = 3;
            Bitget.Text = "Bitget";
            // 
            // lblBinancePrice
            // 
            lblBinancePrice.AutoSize = true;
            lblBinancePrice.Location = new Point(53, 128);
            lblBinancePrice.Name = "lblBinancePrice";
            lblBinancePrice.Size = new Size(38, 15);
            lblBinancePrice.TabIndex = 4;
            lblBinancePrice.Text = "label1";
            // 
            // lblBybitPrice
            // 
            lblBybitPrice.AutoSize = true;
            lblBybitPrice.Location = new Point(167, 128);
            lblBybitPrice.Name = "lblBybitPrice";
            lblBybitPrice.Size = new Size(38, 15);
            lblBybitPrice.TabIndex = 5;
            lblBybitPrice.Text = "label1";
            // 
            // lblKucoinPrice
            // 
            lblKucoinPrice.AutoSize = true;
            lblKucoinPrice.Location = new Point(284, 129);
            lblKucoinPrice.Name = "lblKucoinPrice";
            lblKucoinPrice.Size = new Size(38, 15);
            lblKucoinPrice.TabIndex = 6;
            lblKucoinPrice.Text = "label1";
            // 
            // lblBitgetPrice
            // 
            lblBitgetPrice.AutoSize = true;
            lblBitgetPrice.Location = new Point(388, 132);
            lblBitgetPrice.Name = "lblBitgetPrice";
            lblBitgetPrice.Size = new Size(38, 15);
            lblBitgetPrice.TabIndex = 7;
            lblBitgetPrice.Text = "label1";
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(153, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 30);
            label1.TabIndex = 8;
            label1.Text = "Crypto Price Viewer";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbCryptoPairs
            // 
            cmbCryptoPairs.FormattingEnabled = true;
            cmbCryptoPairs.Items.AddRange(new object[] { "Пара1 Binance Bybit", "Пара2 Binance Kucoin", "Пара3 Binance Bitget", "Пара4 Bybit Kucoin", "Пара5 Bybit Bitget", "Пара6 Kucoin Bitget" });
            cmbCryptoPairs.Location = new Point(51, 193);
            cmbCryptoPairs.Name = "cmbCryptoPairs";
            cmbCryptoPairs.Size = new Size(121, 23);
            cmbCryptoPairs.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 348);
            Controls.Add(cmbCryptoPairs);
            Controls.Add(label1);
            Controls.Add(lblBitgetPrice);
            Controls.Add(lblKucoinPrice);
            Controls.Add(lblBybitPrice);
            Controls.Add(lblBinancePrice);
            Controls.Add(Bitget);
            Controls.Add(Kucoin);
            Controls.Add(Bybit);
            Controls.Add(Binance);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Binance;
        private Label Bybit;
        private Label Kucoin;
        private Label Bitget;
        private Label lblBinancePrice;
        private Label lblBybitPrice;
        private Label lblKucoinPrice;
        private Label lblBitgetPrice;
        private Label label1;
        private ComboBox cmbCryptoPairs;
    }
}
