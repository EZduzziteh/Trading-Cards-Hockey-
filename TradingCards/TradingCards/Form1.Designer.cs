namespace TradingCards
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
            this.CardListView = new System.Windows.Forms.ListView();
            this.Column_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.hockeyCard1 = new TradingCards.HockeyCard();
            this.SuspendLayout();
            // 
            // CardListView
            // 
            this.CardListView.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CardListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_Name});
            this.CardListView.ForeColor = System.Drawing.SystemColors.Window;
            this.CardListView.GridLines = true;
            this.CardListView.HideSelection = false;
            this.CardListView.Location = new System.Drawing.Point(215, 122);
            this.CardListView.Name = "CardListView";
            this.CardListView.Size = new System.Drawing.Size(118, 431);
            this.CardListView.TabIndex = 1;
            this.CardListView.UseCompatibleStateImageBehavior = false;
            this.CardListView.View = System.Windows.Forms.View.Details;
            this.CardListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CardListView_MouseClick);
            // 
            // Column_Name
            // 
            this.Column_Name.Text = "Cards: ";
            this.Column_Name.Width = 115;
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.BackColor = System.Drawing.Color.Silver;
            this.lbl_Instructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instructions.Location = new System.Drawing.Point(354, 40);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(419, 28);
            this.lbl_Instructions.TabIndex = 3;
            this.lbl_Instructions.Text = "Select a card on the left to view its details!";
            // 
            // hockeyCard1
            // 
            this.hockeyCard1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hockeyCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hockeyCard1.Location = new System.Drawing.Point(566, 109);
            this.hockeyCard1.Name = "hockeyCard1";
            this.hockeyCard1.Size = new System.Drawing.Size(351, 468);
            this.hockeyCard1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1078, 732);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.hockeyCard1);
            this.Controls.Add(this.CardListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView CardListView;
        private System.Windows.Forms.ColumnHeader Column_Name;
        private HockeyCard hockeyCard1;
        private System.Windows.Forms.Label lbl_Instructions;
    }
}

