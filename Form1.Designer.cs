
namespace CalculateurDeMonnaies
{
    partial class ChangeCalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCalculatorForm));
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.lbl_combienDe = new System.Windows.Forms.Label();
            this.lbl_5cents = new System.Windows.Forms.Label();
            this.lbl_2dollars = new System.Windows.Forms.Label();
            this.lbl_1dollars = new System.Windows.Forms.Label();
            this.lbl_25cents = new System.Windows.Forms.Label();
            this.lbl_10cents = new System.Windows.Forms.Label();
            this.btn_Calculer = new System.Windows.Forms.Button();
            this.numUpDwn_5cents = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_10cents = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_25cents = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_1dollars = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_2dollars = new System.Windows.Forms.NumericUpDown();
            this.lbl_total5cents = new System.Windows.Forms.Label();
            this.lbl_total10cents = new System.Windows.Forms.Label();
            this.lbl_total25cents = new System.Windows.Forms.Label();
            this.lbl_total1dollars = new System.Windows.Forms.Label();
            this.lbl_total2dollars = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.pic_money = new System.Windows.Forms.PictureBox();
            this.pic_moneyDwn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_5cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_10cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_25cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_1dollars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_2dollars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_moneyDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titre.Location = new System.Drawing.Point(48, 135);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(832, 50);
            this.lbl_Titre.TabIndex = 0;
            this.lbl_Titre.Text = "Bienvenue au Calculateur de monnaies";
            this.lbl_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_combienDe
            // 
            this.lbl_combienDe.AutoSize = true;
            this.lbl_combienDe.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_combienDe.Location = new System.Drawing.Point(125, 224);
            this.lbl_combienDe.Name = "lbl_combienDe";
            this.lbl_combienDe.Size = new System.Drawing.Size(314, 30);
            this.lbl_combienDe.TabIndex = 1;
            this.lbl_combienDe.Text = "Combien avez-vous de ...";
            // 
            // lbl_5cents
            // 
            this.lbl_5cents.AutoSize = true;
            this.lbl_5cents.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_5cents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_5cents.Location = new System.Drawing.Point(212, 293);
            this.lbl_5cents.Name = "lbl_5cents";
            this.lbl_5cents.Size = new System.Drawing.Size(133, 30);
            this.lbl_5cents.TabIndex = 1000;
            this.lbl_5cents.Text = "5 cents   x";
            this.lbl_5cents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_2dollars
            // 
            this.lbl_2dollars.AutoSize = true;
            this.lbl_2dollars.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_2dollars.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_2dollars.Location = new System.Drawing.Point(180, 635);
            this.lbl_2dollars.Name = "lbl_2dollars";
            this.lbl_2dollars.Size = new System.Drawing.Size(165, 30);
            this.lbl_2dollars.TabIndex = 7;
            this.lbl_2dollars.Text = "2 dollars   x";
            this.lbl_2dollars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_1dollars
            // 
            this.lbl_1dollars.AutoSize = true;
            this.lbl_1dollars.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_1dollars.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_1dollars.Location = new System.Drawing.Point(181, 550);
            this.lbl_1dollars.Name = "lbl_1dollars";
            this.lbl_1dollars.Size = new System.Drawing.Size(164, 30);
            this.lbl_1dollars.TabIndex = 9;
            this.lbl_1dollars.Text = "1 dollars   x";
            this.lbl_1dollars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_25cents
            // 
            this.lbl_25cents.AutoSize = true;
            this.lbl_25cents.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_25cents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_25cents.Location = new System.Drawing.Point(201, 464);
            this.lbl_25cents.Name = "lbl_25cents";
            this.lbl_25cents.Size = new System.Drawing.Size(144, 30);
            this.lbl_25cents.TabIndex = 11;
            this.lbl_25cents.Text = "25 cents   x";
            this.lbl_25cents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_10cents
            // 
            this.lbl_10cents.AutoSize = true;
            this.lbl_10cents.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_10cents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_10cents.Location = new System.Drawing.Point(200, 377);
            this.lbl_10cents.Name = "lbl_10cents";
            this.lbl_10cents.Size = new System.Drawing.Size(145, 30);
            this.lbl_10cents.TabIndex = 13;
            this.lbl_10cents.Text = "10 cents   x";
            this.lbl_10cents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Calculer
            // 
            this.btn_Calculer.Location = new System.Drawing.Point(212, 726);
            this.btn_Calculer.Name = "btn_Calculer";
            this.btn_Calculer.Size = new System.Drawing.Size(227, 55);
            this.btn_Calculer.TabIndex = 1001;
            this.btn_Calculer.Text = "Calculer";
            this.btn_Calculer.UseVisualStyleBackColor = true;
            this.btn_Calculer.Click += new System.EventHandler(this.btn_Calculer_Click);
            // 
            // numUpDwn_5cents
            // 
            this.numUpDwn_5cents.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDwn_5cents.Location = new System.Drawing.Point(364, 274);
            this.numUpDwn_5cents.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDwn_5cents.Name = "numUpDwn_5cents";
            this.numUpDwn_5cents.Size = new System.Drawing.Size(114, 57);
            this.numUpDwn_5cents.TabIndex = 1;
            this.numUpDwn_5cents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUpDwn_10cents
            // 
            this.numUpDwn_10cents.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDwn_10cents.Location = new System.Drawing.Point(364, 358);
            this.numUpDwn_10cents.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDwn_10cents.Name = "numUpDwn_10cents";
            this.numUpDwn_10cents.Size = new System.Drawing.Size(114, 57);
            this.numUpDwn_10cents.TabIndex = 2;
            this.numUpDwn_10cents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUpDwn_25cents
            // 
            this.numUpDwn_25cents.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDwn_25cents.Location = new System.Drawing.Point(364, 445);
            this.numUpDwn_25cents.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDwn_25cents.Name = "numUpDwn_25cents";
            this.numUpDwn_25cents.Size = new System.Drawing.Size(114, 57);
            this.numUpDwn_25cents.TabIndex = 3;
            this.numUpDwn_25cents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUpDwn_1dollars
            // 
            this.numUpDwn_1dollars.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDwn_1dollars.Location = new System.Drawing.Point(364, 531);
            this.numUpDwn_1dollars.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDwn_1dollars.Name = "numUpDwn_1dollars";
            this.numUpDwn_1dollars.Size = new System.Drawing.Size(114, 57);
            this.numUpDwn_1dollars.TabIndex = 4;
            this.numUpDwn_1dollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUpDwn_2dollars
            // 
            this.numUpDwn_2dollars.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDwn_2dollars.Location = new System.Drawing.Point(364, 616);
            this.numUpDwn_2dollars.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDwn_2dollars.Name = "numUpDwn_2dollars";
            this.numUpDwn_2dollars.Size = new System.Drawing.Size(114, 57);
            this.numUpDwn_2dollars.TabIndex = 5;
            this.numUpDwn_2dollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_total5cents
            // 
            this.lbl_total5cents.AutoSize = true;
            this.lbl_total5cents.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_total5cents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total5cents.Location = new System.Drawing.Point(500, 289);
            this.lbl_total5cents.Name = "lbl_total5cents";
            this.lbl_total5cents.Size = new System.Drawing.Size(266, 35);
            this.lbl_total5cents.TabIndex = 1002;
            this.lbl_total5cents.Text = "not to be shown";
            this.lbl_total5cents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total5cents.Visible = false;
            // 
            // lbl_total10cents
            // 
            this.lbl_total10cents.AutoSize = true;
            this.lbl_total10cents.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_total10cents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total10cents.Location = new System.Drawing.Point(500, 373);
            this.lbl_total10cents.Name = "lbl_total10cents";
            this.lbl_total10cents.Size = new System.Drawing.Size(266, 35);
            this.lbl_total10cents.TabIndex = 1003;
            this.lbl_total10cents.Text = "not to be shown";
            this.lbl_total10cents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total10cents.Visible = false;
            // 
            // lbl_total25cents
            // 
            this.lbl_total25cents.AutoSize = true;
            this.lbl_total25cents.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_total25cents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total25cents.Location = new System.Drawing.Point(500, 460);
            this.lbl_total25cents.Name = "lbl_total25cents";
            this.lbl_total25cents.Size = new System.Drawing.Size(266, 35);
            this.lbl_total25cents.TabIndex = 1004;
            this.lbl_total25cents.Text = "not to be shown";
            this.lbl_total25cents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total25cents.Visible = false;
            // 
            // lbl_total1dollars
            // 
            this.lbl_total1dollars.AutoSize = true;
            this.lbl_total1dollars.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_total1dollars.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total1dollars.Location = new System.Drawing.Point(500, 546);
            this.lbl_total1dollars.Name = "lbl_total1dollars";
            this.lbl_total1dollars.Size = new System.Drawing.Size(266, 35);
            this.lbl_total1dollars.TabIndex = 1005;
            this.lbl_total1dollars.Text = "not to be shown";
            this.lbl_total1dollars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total1dollars.Visible = false;
            // 
            // lbl_total2dollars
            // 
            this.lbl_total2dollars.AutoSize = true;
            this.lbl_total2dollars.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_total2dollars.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total2dollars.Location = new System.Drawing.Point(500, 631);
            this.lbl_total2dollars.Name = "lbl_total2dollars";
            this.lbl_total2dollars.Size = new System.Drawing.Size(266, 35);
            this.lbl_total2dollars.TabIndex = 1006;
            this.lbl_total2dollars.Text = "not to be shown";
            this.lbl_total2dollars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total2dollars.Visible = false;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Total.Location = new System.Drawing.Point(500, 726);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(335, 44);
            this.lbl_Total.TabIndex = 1007;
            this.lbl_Total.Text = "not to be shown";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Total.Visible = false;
            // 
            // pic_money
            // 
            this.pic_money.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_money.Image = ((System.Drawing.Image)(resources.GetObject("pic_money.Image")));
            this.pic_money.Location = new System.Drawing.Point(0, 0);
            this.pic_money.Name = "pic_money";
            this.pic_money.Size = new System.Drawing.Size(965, 132);
            this.pic_money.TabIndex = 1008;
            this.pic_money.TabStop = false;
            // 
            // pic_moneyDwn
            // 
            this.pic_moneyDwn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pic_moneyDwn.Image = ((System.Drawing.Image)(resources.GetObject("pic_moneyDwn.Image")));
            this.pic_moneyDwn.Location = new System.Drawing.Point(0, 804);
            this.pic_moneyDwn.Name = "pic_moneyDwn";
            this.pic_moneyDwn.Size = new System.Drawing.Size(965, 50);
            this.pic_moneyDwn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_moneyDwn.TabIndex = 1009;
            this.pic_moneyDwn.TabStop = false;
            // 
            // ChangeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 854);
            this.Controls.Add(this.pic_moneyDwn);
            this.Controls.Add(this.pic_money);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_total2dollars);
            this.Controls.Add(this.lbl_total1dollars);
            this.Controls.Add(this.lbl_total25cents);
            this.Controls.Add(this.lbl_total10cents);
            this.Controls.Add(this.lbl_total5cents);
            this.Controls.Add(this.numUpDwn_2dollars);
            this.Controls.Add(this.numUpDwn_1dollars);
            this.Controls.Add(this.numUpDwn_25cents);
            this.Controls.Add(this.numUpDwn_10cents);
            this.Controls.Add(this.numUpDwn_5cents);
            this.Controls.Add(this.btn_Calculer);
            this.Controls.Add(this.lbl_10cents);
            this.Controls.Add(this.lbl_25cents);
            this.Controls.Add(this.lbl_1dollars);
            this.Controls.Add(this.lbl_2dollars);
            this.Controls.Add(this.lbl_5cents);
            this.Controls.Add(this.lbl_combienDe);
            this.Controls.Add(this.lbl_Titre);
            this.Name = "ChangeCalculatorForm";
            this.Text = "Calculateur de Monnaies";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_5cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_10cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_25cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_1dollars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_2dollars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_moneyDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Label lbl_combienDe;
        private System.Windows.Forms.Label lbl_5cents;
        private System.Windows.Forms.Label lbl_2dollars;
        private System.Windows.Forms.Label lbl_1dollars;
        private System.Windows.Forms.Label lbl_25cents;
        private System.Windows.Forms.Label lbl_10cents;
        private System.Windows.Forms.Button btn_Calculer;
        private System.Windows.Forms.NumericUpDown numUpDwn_5cents;
        private System.Windows.Forms.NumericUpDown numUpDwn_10cents;
        private System.Windows.Forms.NumericUpDown numUpDwn_25cents;
        private System.Windows.Forms.NumericUpDown numUpDwn_1dollars;
        private System.Windows.Forms.NumericUpDown numUpDwn_2dollars;
        private System.Windows.Forms.Label lbl_total5cents;
        private System.Windows.Forms.Label lbl_total10cents;
        private System.Windows.Forms.Label lbl_total25cents;
        private System.Windows.Forms.Label lbl_total1dollars;
        private System.Windows.Forms.Label lbl_total2dollars;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.PictureBox pic_money;
        private System.Windows.Forms.PictureBox pic_moneyDwn;
    }
}

