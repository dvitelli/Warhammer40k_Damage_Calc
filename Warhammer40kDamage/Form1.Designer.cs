namespace Warhammer40kDamage
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
            this.weaponNameTextBox = new System.Windows.Forms.TextBox();
            this.weaponNameLabel = new System.Windows.Forms.Label();
            this.WeaponTypeLabel = new System.Windows.Forms.Label();
            this.runCalcButton = new System.Windows.Forms.Button();
            this.weaponTypeComboBox = new System.Windows.Forms.ComboBox();
            this.strengthTextBox = new System.Windows.Forms.TextBox();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.weaponSkillLabel = new System.Windows.Forms.Label();
            this.weaponSkillTextBox = new System.Windows.Forms.TextBox();
            this.attacksLabel = new System.Windows.Forms.Label();
            this.attacksTextBox = new System.Windows.Forms.TextBox();
            this.apLabel = new System.Windows.Forms.Label();
            this.apTextbox = new System.Windows.Forms.TextBox();
            this.damageLabel = new System.Windows.Forms.Label();
            this.damageTextBox = new System.Windows.Forms.TextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.enemySheetListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // weaponNameTextBox
            // 
            this.weaponNameTextBox.Location = new System.Drawing.Point(16, 50);
            this.weaponNameTextBox.Name = "weaponNameTextBox";
            this.weaponNameTextBox.Size = new System.Drawing.Size(305, 20);
            this.weaponNameTextBox.TabIndex = 0;
            // 
            // weaponNameLabel
            // 
            this.weaponNameLabel.AutoSize = true;
            this.weaponNameLabel.Location = new System.Drawing.Point(13, 34);
            this.weaponNameLabel.Name = "weaponNameLabel";
            this.weaponNameLabel.Size = new System.Drawing.Size(79, 13);
            this.weaponNameLabel.TabIndex = 1;
            this.weaponNameLabel.Text = "Weapon Name";
            // 
            // WeaponTypeLabel
            // 
            this.WeaponTypeLabel.AutoSize = true;
            this.WeaponTypeLabel.Location = new System.Drawing.Point(12, 73);
            this.WeaponTypeLabel.Name = "WeaponTypeLabel";
            this.WeaponTypeLabel.Size = new System.Drawing.Size(75, 13);
            this.WeaponTypeLabel.TabIndex = 3;
            this.WeaponTypeLabel.Text = "Weapon Type";
            // 
            // runCalcButton
            // 
            this.runCalcButton.Location = new System.Drawing.Point(242, 348);
            this.runCalcButton.Name = "runCalcButton";
            this.runCalcButton.Size = new System.Drawing.Size(75, 23);
            this.runCalcButton.TabIndex = 4;
            this.runCalcButton.Text = "Run Calc";
            this.runCalcButton.UseVisualStyleBackColor = true;
            this.runCalcButton.Click += new System.EventHandler(this.runCalcButton_Click);
            // 
            // weaponTypeComboBox
            // 
            this.weaponTypeComboBox.FormattingEnabled = true;
            this.weaponTypeComboBox.Items.AddRange(new object[] {
            "Rapid Fire",
            "Assault",
            "Heavy",
            "Pistol",
            "Grenade"});
            this.weaponTypeComboBox.Location = new System.Drawing.Point(16, 90);
            this.weaponTypeComboBox.Name = "weaponTypeComboBox";
            this.weaponTypeComboBox.Size = new System.Drawing.Size(301, 21);
            this.weaponTypeComboBox.TabIndex = 5;
            // 
            // strengthTextBox
            // 
            this.strengthTextBox.Location = new System.Drawing.Point(16, 142);
            this.strengthTextBox.Name = "strengthTextBox";
            this.strengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.strengthTextBox.TabIndex = 6;
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(13, 126);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(47, 13);
            this.strengthLabel.TabIndex = 7;
            this.strengthLabel.Text = "Strength";
            // 
            // weaponSkillLabel
            // 
            this.weaponSkillLabel.AutoSize = true;
            this.weaponSkillLabel.Location = new System.Drawing.Point(13, 165);
            this.weaponSkillLabel.Name = "weaponSkillLabel";
            this.weaponSkillLabel.Size = new System.Drawing.Size(70, 13);
            this.weaponSkillLabel.TabIndex = 9;
            this.weaponSkillLabel.Text = "Weapon Skill";
            // 
            // weaponSkillTextBox
            // 
            this.weaponSkillTextBox.Location = new System.Drawing.Point(16, 184);
            this.weaponSkillTextBox.Name = "weaponSkillTextBox";
            this.weaponSkillTextBox.Size = new System.Drawing.Size(100, 20);
            this.weaponSkillTextBox.TabIndex = 8;
            // 
            // attacksLabel
            // 
            this.attacksLabel.AutoSize = true;
            this.attacksLabel.Location = new System.Drawing.Point(13, 207);
            this.attacksLabel.Name = "attacksLabel";
            this.attacksLabel.Size = new System.Drawing.Size(43, 13);
            this.attacksLabel.TabIndex = 11;
            this.attacksLabel.Text = "Attacks";
            // 
            // attacksTextBox
            // 
            this.attacksTextBox.Location = new System.Drawing.Point(16, 226);
            this.attacksTextBox.Name = "attacksTextBox";
            this.attacksTextBox.Size = new System.Drawing.Size(100, 20);
            this.attacksTextBox.TabIndex = 10;
            // 
            // apLabel
            // 
            this.apLabel.AllowDrop = true;
            this.apLabel.AutoSize = true;
            this.apLabel.Location = new System.Drawing.Point(16, 249);
            this.apLabel.Name = "apLabel";
            this.apLabel.Size = new System.Drawing.Size(21, 13);
            this.apLabel.TabIndex = 13;
            this.apLabel.Text = "AP";
            // 
            // apTextbox
            // 
            this.apTextbox.Location = new System.Drawing.Point(16, 268);
            this.apTextbox.Name = "apTextbox";
            this.apTextbox.Size = new System.Drawing.Size(100, 20);
            this.apTextbox.TabIndex = 12;
            // 
            // damageLabel
            // 
            this.damageLabel.AutoSize = true;
            this.damageLabel.Location = new System.Drawing.Point(12, 291);
            this.damageLabel.Name = "damageLabel";
            this.damageLabel.Size = new System.Drawing.Size(47, 13);
            this.damageLabel.TabIndex = 15;
            this.damageLabel.Text = "Damage";
            // 
            // damageTextBox
            // 
            this.damageTextBox.Location = new System.Drawing.Point(16, 310);
            this.damageTextBox.Name = "damageTextBox";
            this.damageTextBox.Size = new System.Drawing.Size(100, 20);
            this.damageTextBox.TabIndex = 14;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // enemySheetListBox
            // 
            this.enemySheetListBox.FormattingEnabled = true;
            this.enemySheetListBox.Items.AddRange(new object[] {
            "Space Marine"});
            this.enemySheetListBox.Location = new System.Drawing.Point(144, 142);
            this.enemySheetListBox.Name = "enemySheetListBox";
            this.enemySheetListBox.Size = new System.Drawing.Size(172, 186);
            this.enemySheetListBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 389);
            this.Controls.Add(this.enemySheetListBox);
            this.Controls.Add(this.damageLabel);
            this.Controls.Add(this.damageTextBox);
            this.Controls.Add(this.apLabel);
            this.Controls.Add(this.apTextbox);
            this.Controls.Add(this.attacksLabel);
            this.Controls.Add(this.attacksTextBox);
            this.Controls.Add(this.weaponSkillLabel);
            this.Controls.Add(this.weaponSkillTextBox);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.strengthTextBox);
            this.Controls.Add(this.weaponTypeComboBox);
            this.Controls.Add(this.runCalcButton);
            this.Controls.Add(this.WeaponTypeLabel);
            this.Controls.Add(this.weaponNameLabel);
            this.Controls.Add(this.weaponNameTextBox);
            this.Name = "Form1";
            this.Text = "Warhammer Damage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weaponNameTextBox;
        private System.Windows.Forms.Label weaponNameLabel;
        private System.Windows.Forms.Label WeaponTypeLabel;
        private System.Windows.Forms.Button runCalcButton;
        private System.Windows.Forms.ComboBox weaponTypeComboBox;
        private System.Windows.Forms.TextBox strengthTextBox;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label weaponSkillLabel;
        private System.Windows.Forms.TextBox weaponSkillTextBox;
        private System.Windows.Forms.Label attacksLabel;
        private System.Windows.Forms.TextBox attacksTextBox;
        private System.Windows.Forms.Label apLabel;
        private System.Windows.Forms.TextBox apTextbox;
        private System.Windows.Forms.Label damageLabel;
        private System.Windows.Forms.TextBox damageTextBox;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ListBox enemySheetListBox;
    }
}

