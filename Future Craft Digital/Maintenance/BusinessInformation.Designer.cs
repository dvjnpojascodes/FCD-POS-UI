
using System.Windows.Forms;

namespace Future_Craft_Digital.FCDForms
{
    partial class BusinessInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessInfoForm));
            prodListIcon = new PictureBox();
            prodListingDesc = new Label();
            prodListingLabel = new Label();
            infoGrpBox = new GroupBox();
            webTxt = new TextBox();
            label7 = new Label();
            emailTxt = new TextBox();
            label8 = new Label();
            vatTxt = new TextBox();
            label6 = new Label();
            tinTxt = new TextBox();
            label4 = new Label();
            telTxt = new TextBox();
            label5 = new Label();
            businessAddTxt = new TextBox();
            label3 = new Label();
            businessNameTxt = new TextBox();
            label2 = new Label();
            businesIDTxt = new TextBox();
            label1 = new Label();
            userAddBtn = new Button();
            businessInfoCloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)prodListIcon).BeginInit();
            infoGrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // prodListIcon
            // 
            prodListIcon.Image = (Image)resources.GetObject("prodListIcon.Image");
            prodListIcon.Location = new Point(8, 14);
            prodListIcon.Margin = new Padding(3, 4, 3, 4);
            prodListIcon.Name = "prodListIcon";
            prodListIcon.Size = new Size(78, 90);
            prodListIcon.SizeMode = PictureBoxSizeMode.Zoom;
            prodListIcon.TabIndex = 12;
            prodListIcon.TabStop = false;
            // 
            // prodListingDesc
            // 
            prodListingDesc.AutoSize = true;
            prodListingDesc.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            prodListingDesc.Location = new Point(92, 69);
            prodListingDesc.Name = "prodListingDesc";
            prodListingDesc.Size = new Size(202, 18);
            prodListingDesc.TabIndex = 11;
            prodListingDesc.Text = "Display details of the business";
            // 
            // prodListingLabel
            // 
            prodListingLabel.AutoSize = true;
            prodListingLabel.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            prodListingLabel.ForeColor = SystemColors.InfoText;
            prodListingLabel.Location = new Point(88, 28);
            prodListingLabel.Name = "prodListingLabel";
            prodListingLabel.Size = new Size(316, 34);
            prodListingLabel.TabIndex = 10;
            prodListingLabel.Text = "Business Information";
            // 
            // infoGrpBox
            // 
            infoGrpBox.Controls.Add(webTxt);
            infoGrpBox.Controls.Add(label7);
            infoGrpBox.Controls.Add(emailTxt);
            infoGrpBox.Controls.Add(label8);
            infoGrpBox.Controls.Add(vatTxt);
            infoGrpBox.Controls.Add(label6);
            infoGrpBox.Controls.Add(tinTxt);
            infoGrpBox.Controls.Add(label4);
            infoGrpBox.Controls.Add(telTxt);
            infoGrpBox.Controls.Add(label5);
            infoGrpBox.Controls.Add(businessAddTxt);
            infoGrpBox.Controls.Add(label3);
            infoGrpBox.Controls.Add(businessNameTxt);
            infoGrpBox.Controls.Add(label2);
            infoGrpBox.Controls.Add(businesIDTxt);
            infoGrpBox.Controls.Add(label1);
            infoGrpBox.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            infoGrpBox.Location = new Point(8, 104);
            infoGrpBox.Margin = new Padding(3, 4, 3, 4);
            infoGrpBox.Name = "infoGrpBox";
            infoGrpBox.Padding = new Padding(3, 4, 3, 4);
            infoGrpBox.Size = new Size(752, 521);
            infoGrpBox.TabIndex = 13;
            infoGrpBox.TabStop = false;
            // 
            // webTxt
            // 
            webTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            webTxt.Location = new Point(186, 466);
            webTxt.Margin = new Padding(3, 4, 3, 4);
            webTxt.MinimumSize = new Size(282, 36);
            webTxt.Name = "webTxt";
            webTxt.Size = new Size(529, 36);
            webTxt.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(96, 475);
            label7.Name = "label7";
            label7.Size = new Size(78, 18);
            label7.TabIndex = 28;
            label7.Text = "Website :";
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailTxt.Location = new Point(186, 413);
            emailTxt.Margin = new Padding(3, 4, 3, 4);
            emailTxt.MinimumSize = new Size(282, 36);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(529, 36);
            emailTxt.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(52, 424);
            label8.Name = "label8";
            label8.Size = new Size(122, 18);
            label8.TabIndex = 26;
            label8.Text = "Email Address :";
            // 
            // vatTxt
            // 
            vatTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            vatTxt.Location = new Point(186, 357);
            vatTxt.Margin = new Padding(3, 4, 3, 4);
            vatTxt.MinimumSize = new Size(282, 36);
            vatTxt.Name = "vatTxt";
            vatTxt.Size = new Size(529, 36);
            vatTxt.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(106, 367);
            label6.Name = "label6";
            label6.Size = new Size(68, 18);
            label6.TabIndex = 24;
            label6.Text = "VAT % :";
            // 
            // tinTxt
            // 
            tinTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tinTxt.Location = new Point(186, 303);
            tinTxt.Margin = new Padding(3, 4, 3, 4);
            tinTxt.MinimumSize = new Size(282, 36);
            tinTxt.Name = "tinTxt";
            tinTxt.Size = new Size(529, 36);
            tinTxt.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(127, 313);
            label4.Name = "label4";
            label4.Size = new Size(45, 18);
            label4.TabIndex = 22;
            label4.Text = "TIN :";
            // 
            // telTxt
            // 
            telTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            telTxt.Location = new Point(186, 248);
            telTxt.Margin = new Padding(3, 4, 3, 4);
            telTxt.MinimumSize = new Size(282, 36);
            telTxt.Name = "telTxt";
            telTxt.Size = new Size(529, 36);
            telTxt.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(48, 258);
            label5.Name = "label5";
            label5.Size = new Size(124, 18);
            label5.TabIndex = 20;
            label5.Text = "Telephone No. :";
            // 
            // businessAddTxt
            // 
            businessAddTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            businessAddTxt.Location = new Point(186, 141);
            businessAddTxt.Margin = new Padding(3, 4, 3, 4);
            businessAddTxt.MinimumSize = new Size(282, 36);
            businessAddTxt.Multiline = true;
            businessAddTxt.Name = "businessAddTxt";
            businessAddTxt.Size = new Size(529, 89);
            businessAddTxt.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 151);
            label3.Name = "label3";
            label3.Size = new Size(147, 18);
            label3.TabIndex = 18;
            label3.Text = "Business Address :";
            // 
            // businessNameTxt
            // 
            businessNameTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            businessNameTxt.Location = new Point(186, 87);
            businessNameTxt.Margin = new Padding(3, 4, 3, 4);
            businessNameTxt.MinimumSize = new Size(282, 36);
            businessNameTxt.Name = "businessNameTxt";
            businessNameTxt.Size = new Size(529, 36);
            businessNameTxt.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 99);
            label2.Name = "label2";
            label2.Size = new Size(126, 18);
            label2.TabIndex = 16;
            label2.Text = "Business Name:";
            // 
            // businesIDTxt
            // 
            businesIDTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            businesIDTxt.Location = new Point(186, 38);
            businesIDTxt.Margin = new Padding(5, 6, 5, 6);
            businesIDTxt.MinimumSize = new Size(282, 36);
            businesIDTxt.Name = "businesIDTxt";
            businesIDTxt.Size = new Size(529, 36);
            businesIDTxt.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(73, 46);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 14;
            label1.Text = "Business ID:";
            // 
            // userAddBtn
            // 
            userAddBtn.BackColor = SystemColors.MenuHighlight;
            userAddBtn.FlatAppearance.BorderSize = 0;
            userAddBtn.FlatStyle = FlatStyle.Flat;
            userAddBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userAddBtn.ForeColor = SystemColors.HighlightText;
            userAddBtn.Location = new Point(49, 643);
            userAddBtn.Margin = new Padding(3, 4, 3, 4);
            userAddBtn.Name = "userAddBtn";
            userAddBtn.Size = new Size(328, 51);
            userAddBtn.TabIndex = 14;
            userAddBtn.Text = "SAVE";
            userAddBtn.UseVisualStyleBackColor = false;
            // 
            // businessInfoCloseBtn
            // 
            businessInfoCloseBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            businessInfoCloseBtn.Location = new Point(405, 644);
            businessInfoCloseBtn.Margin = new Padding(3, 4, 3, 4);
            businessInfoCloseBtn.Name = "businessInfoCloseBtn";
            businessInfoCloseBtn.Size = new Size(328, 49);
            businessInfoCloseBtn.TabIndex = 15;
            businessInfoCloseBtn.Text = "CANCEL";
            businessInfoCloseBtn.UseVisualStyleBackColor = true;
            businessInfoCloseBtn.Click += businessInfoCloseBtn_Click;
            // 
            // BusinessInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 717);
            ControlBox = false;
            Controls.Add(businessInfoCloseBtn);
            Controls.Add(userAddBtn);
            Controls.Add(infoGrpBox);
            Controls.Add(prodListIcon);
            Controls.Add(prodListingDesc);
            Controls.Add(prodListingLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BusinessInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Business Information";
            Load += BusinessInformation_Load;
            ((System.ComponentModel.ISupportInitialize)prodListIcon).EndInit();
            infoGrpBox.ResumeLayout(false);
            infoGrpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox prodListIcon;
        private Label prodListingDesc;
        private Label prodListingLabel;
        private GroupBox infoGrpBox;
        private Label label2;
        private TextBox businesIDTxt;
        private Label label1;
        private TextBox webTxt;
        private Label label7;
        private TextBox emailTxt;
        private Label label8;
        private TextBox vatTxt;
        private Label label6;
        private TextBox tinTxt;
        private Label label4;
        private TextBox telTxt;
        private Label label5;
        private TextBox businessAddTxt;
        private Label label3;
        private TextBox businessNameTxt;
        private Button userAddBtn;
        private Button businessInfoCloseBtn;
    }
}