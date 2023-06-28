namespace Lab2
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
            this.update_btn = new System.Windows.Forms.Button();
            this.teams_gridview = new System.Windows.Forms.DataGridView();
            this.Teams_label = new System.Windows.Forms.Label();
            this.Players_label = new System.Windows.Forms.Label();
            this.palyers_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.teams_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palyers_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(505, 392);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(181, 75);
            this.update_btn.TabIndex = 0;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // teams_gridview
            // 
            this.teams_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teams_gridview.Location = new System.Drawing.Point(33, 57);
            this.teams_gridview.Name = "teams_gridview";
            this.teams_gridview.Size = new System.Drawing.Size(540, 307);
            this.teams_gridview.TabIndex = 1;
            // 
            // Teams_label
            // 
            this.Teams_label.AutoSize = true;
            this.Teams_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teams_label.Location = new System.Drawing.Point(29, 30);
            this.Teams_label.Name = "Teams_label";
            this.Teams_label.Size = new System.Drawing.Size(73, 24);
            this.Teams_label.TabIndex = 3;
            this.Teams_label.Text = "Teams";
            // 
            // Players_label
            // 
            this.Players_label.AutoSize = true;
            this.Players_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Players_label.Location = new System.Drawing.Point(619, 30);
            this.Players_label.Name = "Players_label";
            this.Players_label.Size = new System.Drawing.Size(78, 24);
            this.Players_label.TabIndex = 5;
            this.Players_label.Text = "Players";
            // 
            // palyers_gridview
            // 
            this.palyers_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.palyers_gridview.Location = new System.Drawing.Point(623, 57);
            this.palyers_gridview.Name = "palyers_gridview";
            this.palyers_gridview.Size = new System.Drawing.Size(540, 307);
            this.palyers_gridview.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 566);
            this.Controls.Add(this.palyers_gridview);
            this.Controls.Add(this.Players_label);
            this.Controls.Add(this.Teams_label);
            this.Controls.Add(this.teams_gridview);
            this.Controls.Add(this.update_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teams_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palyers_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.DataGridView teams_gridview;
        private System.Windows.Forms.Label Teams_label;
        private System.Windows.Forms.Label Players_label;
        private System.Windows.Forms.DataGridView palyers_gridview;
    }
}

