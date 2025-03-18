namespace CryptoTicker
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
            components = new System.ComponentModel.Container();
            btnGetTicker = new Button();
            txtTradingPair = new TextBox();
            lblPrice = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnGetTicker
            // 
            btnGetTicker.Location = new Point(65, 121);
            btnGetTicker.Name = "btnGetTicker";
            btnGetTicker.Size = new Size(94, 29);
            btnGetTicker.TabIndex = 0;
            btnGetTicker.Text = "button1";
            btnGetTicker.UseVisualStyleBackColor = true;
            // 
            // txtTradingPair
            // 
            txtTradingPair.Location = new Point(50, 66);
            txtTradingPair.Name = "txtTradingPair";
            txtTradingPair.Size = new Size(125, 27);
            txtTradingPair.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(76, 171);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrice);
            Controls.Add(txtTradingPair);
            Controls.Add(btnGetTicker);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetTicker;
        private TextBox txtTradingPair;
        private Label lblPrice;
        private System.Windows.Forms.Timer timer1;
    }
}
