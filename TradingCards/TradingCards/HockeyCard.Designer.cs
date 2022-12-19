namespace TradingCards
{
    partial class HockeyCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Card = new System.Windows.Forms.Panel();
            this.pictureBox_PlayerPicture = new System.Windows.Forms.PictureBox();
            this.lbl_nameNumberDisplay = new System.Windows.Forms.Label();
            this.lbl_goalsScoredDisplay = new System.Windows.Forms.Label();
            this.lbl_heightDisplay = new System.Windows.Forms.Label();
            this.lbl_weightDisplay = new System.Windows.Forms.Label();
            this.lbl_ageDisplay = new System.Windows.Forms.Label();
            this.lbl_GoalsScored = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lbl_TeamNameDisplay = new System.Windows.Forms.Label();
            this.lbl_hometownDisplay = new System.Windows.Forms.Label();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.lbl_positionDisplay = new System.Windows.Forms.Label();
            this.lbl_BirthdayDisplay = new System.Windows.Forms.Label();
            this.panel_Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Card
            // 
            this.panel_Card.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel_Card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Card.Controls.Add(this.lbl_BirthdayDisplay);
            this.panel_Card.Controls.Add(this.lbl_Position);
            this.panel_Card.Controls.Add(this.lbl_positionDisplay);
            this.panel_Card.Controls.Add(this.lbl_hometownDisplay);
            this.panel_Card.Controls.Add(this.lbl_Weight);
            this.panel_Card.Controls.Add(this.lbl_Height);
            this.panel_Card.Controls.Add(this.label1);
            this.panel_Card.Controls.Add(this.lbl_GoalsScored);
            this.panel_Card.Controls.Add(this.lbl_ageDisplay);
            this.panel_Card.Controls.Add(this.lbl_weightDisplay);
            this.panel_Card.Controls.Add(this.lbl_heightDisplay);
            this.panel_Card.Controls.Add(this.lbl_goalsScoredDisplay);
            this.panel_Card.Controls.Add(this.lbl_nameNumberDisplay);
            this.panel_Card.Controls.Add(this.pictureBox_PlayerPicture);
            this.panel_Card.Location = new System.Drawing.Point(17, 61);
            this.panel_Card.Name = "panel_Card";
            this.panel_Card.Size = new System.Drawing.Size(314, 388);
            this.panel_Card.TabIndex = 0;
            // 
            // pictureBox_PlayerPicture
            // 
            this.pictureBox_PlayerPicture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_PlayerPicture.Location = new System.Drawing.Point(72, 38);
            this.pictureBox_PlayerPicture.Name = "pictureBox_PlayerPicture";
            this.pictureBox_PlayerPicture.Size = new System.Drawing.Size(166, 224);
            this.pictureBox_PlayerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlayerPicture.TabIndex = 0;
            this.pictureBox_PlayerPicture.TabStop = false;
            // 
            // lbl_nameNumberDisplay
            // 
            this.lbl_nameNumberDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nameNumberDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameNumberDisplay.Location = new System.Drawing.Point(23, 11);
            this.lbl_nameNumberDisplay.Name = "lbl_nameNumberDisplay";
            this.lbl_nameNumberDisplay.Size = new System.Drawing.Size(254, 24);
            this.lbl_nameNumberDisplay.TabIndex = 1;
            this.lbl_nameNumberDisplay.Text = "Name and number";
            this.lbl_nameNumberDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nameNumberDisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_goalsScoredDisplay
            // 
            this.lbl_goalsScoredDisplay.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_goalsScoredDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_goalsScoredDisplay.Location = new System.Drawing.Point(3, 354);
            this.lbl_goalsScoredDisplay.Name = "lbl_goalsScoredDisplay";
            this.lbl_goalsScoredDisplay.Size = new System.Drawing.Size(50, 25);
            this.lbl_goalsScoredDisplay.TabIndex = 2;
            this.lbl_goalsScoredDisplay.Text = "0";
            this.lbl_goalsScoredDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_heightDisplay
            // 
            this.lbl_heightDisplay.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_heightDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heightDisplay.Location = new System.Drawing.Point(171, 354);
            this.lbl_heightDisplay.Name = "lbl_heightDisplay";
            this.lbl_heightDisplay.Size = new System.Drawing.Size(50, 25);
            this.lbl_heightDisplay.TabIndex = 3;
            this.lbl_heightDisplay.Text = "6.00";
            this.lbl_heightDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_weightDisplay
            // 
            this.lbl_weightDisplay.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_weightDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weightDisplay.Location = new System.Drawing.Point(115, 354);
            this.lbl_weightDisplay.Name = "lbl_weightDisplay";
            this.lbl_weightDisplay.Size = new System.Drawing.Size(50, 25);
            this.lbl_weightDisplay.TabIndex = 4;
            this.lbl_weightDisplay.Text = "200";
            this.lbl_weightDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ageDisplay
            // 
            this.lbl_ageDisplay.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_ageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ageDisplay.Location = new System.Drawing.Point(59, 355);
            this.lbl_ageDisplay.Name = "lbl_ageDisplay";
            this.lbl_ageDisplay.Size = new System.Drawing.Size(50, 25);
            this.lbl_ageDisplay.TabIndex = 5;
            this.lbl_ageDisplay.Text = "33";
            this.lbl_ageDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GoalsScored
            // 
            this.lbl_GoalsScored.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_GoalsScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GoalsScored.Location = new System.Drawing.Point(3, 330);
            this.lbl_GoalsScored.Name = "lbl_GoalsScored";
            this.lbl_GoalsScored.Size = new System.Drawing.Size(50, 25);
            this.lbl_GoalsScored.TabIndex = 6;
            this.lbl_GoalsScored.Text = "Goals:";
            this.lbl_GoalsScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Age:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Height
            // 
            this.lbl_Height.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Height.Location = new System.Drawing.Point(171, 329);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(50, 25);
            this.lbl_Height.TabIndex = 8;
            this.lbl_Height.Text = "Height:";
            this.lbl_Height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weight.Location = new System.Drawing.Point(115, 329);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(50, 25);
            this.lbl_Weight.TabIndex = 9;
            this.lbl_Weight.Text = "Weight:";
            this.lbl_Weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TeamNameDisplay
            // 
            this.lbl_TeamNameDisplay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_TeamNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TeamNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamNameDisplay.Location = new System.Drawing.Point(41, 17);
            this.lbl_TeamNameDisplay.Name = "lbl_TeamNameDisplay";
            this.lbl_TeamNameDisplay.Size = new System.Drawing.Size(254, 24);
            this.lbl_TeamNameDisplay.TabIndex = 10;
            this.lbl_TeamNameDisplay.Text = "Team Name";
            this.lbl_TeamNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hometownDisplay
            // 
            this.lbl_hometownDisplay.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_hometownDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hometownDisplay.Location = new System.Drawing.Point(44, 265);
            this.lbl_hometownDisplay.Name = "lbl_hometownDisplay";
            this.lbl_hometownDisplay.Size = new System.Drawing.Size(217, 25);
            this.lbl_hometownDisplay.TabIndex = 10;
            this.lbl_hometownDisplay.Text = "Hometown: Calgary, ALTA";
            this.lbl_hometownDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Position
            // 
            this.lbl_Position.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.Location = new System.Drawing.Point(227, 329);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(82, 25);
            this.lbl_Position.TabIndex = 12;
            this.lbl_Position.Text = "Position:";
            this.lbl_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_positionDisplay
            // 
            this.lbl_positionDisplay.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_positionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_positionDisplay.Location = new System.Drawing.Point(227, 354);
            this.lbl_positionDisplay.Name = "lbl_positionDisplay";
            this.lbl_positionDisplay.Size = new System.Drawing.Size(82, 25);
            this.lbl_positionDisplay.TabIndex = 11;
            this.lbl_positionDisplay.Text = "Right Wing";
            this.lbl_positionDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BirthdayDisplay
            // 
            this.lbl_BirthdayDisplay.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_BirthdayDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BirthdayDisplay.Location = new System.Drawing.Point(43, 297);
            this.lbl_BirthdayDisplay.Name = "lbl_BirthdayDisplay";
            this.lbl_BirthdayDisplay.Size = new System.Drawing.Size(217, 25);
            this.lbl_BirthdayDisplay.TabIndex = 13;
            this.lbl_BirthdayDisplay.Text = "Birthday: 1996-02-02";
            this.lbl_BirthdayDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HockeyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_TeamNameDisplay);
            this.Controls.Add(this.panel_Card);
            this.Name = "HockeyCard";
            this.Size = new System.Drawing.Size(351, 468);
            this.panel_Card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Card;
        private System.Windows.Forms.PictureBox pictureBox_PlayerPicture;
        private System.Windows.Forms.Label lbl_nameNumberDisplay;
        private System.Windows.Forms.Label lbl_goalsScoredDisplay;
        private System.Windows.Forms.Label lbl_weightDisplay;
        private System.Windows.Forms.Label lbl_heightDisplay;
        private System.Windows.Forms.Label lbl_ageDisplay;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_GoalsScored;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lbl_TeamNameDisplay;
        private System.Windows.Forms.Label lbl_BirthdayDisplay;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.Label lbl_positionDisplay;
        private System.Windows.Forms.Label lbl_hometownDisplay;
    }
}
