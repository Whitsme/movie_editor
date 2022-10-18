
namespace GUIAssignment2
{
    partial class MovieEditor
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxRuntime = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.el = new System.Windows.Forms.Label();
            this.labelGeneration = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.pictureBoxMovie = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxMovies = new System.Windows.Forms.ComboBox();
            this.panelMovie = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).BeginInit();
            this.panelMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTitle.Location = new System.Drawing.Point(91, 68);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(175, 23);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxYear.Location = new System.Drawing.Point(91, 97);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(175, 23);
            this.textBoxYear.TabIndex = 3;
            // 
            // textBoxRuntime
            // 
            this.textBoxRuntime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRuntime.Location = new System.Drawing.Point(91, 126);
            this.textBoxRuntime.Name = "textBoxRuntime";
            this.textBoxRuntime.Size = new System.Drawing.Size(175, 23);
            this.textBoxRuntime.TabIndex = 4;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGenre.Location = new System.Drawing.Point(91, 155);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(175, 23);
            this.textBoxGenre.TabIndex = 5;
            // 
            // labelBrand
            // 
            this.labelBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(28, 71);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(32, 15);
            this.labelBrand.TabIndex = 7;
            this.labelBrand.Text = "Title:";
            // 
            // el
            // 
            this.el.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.el.AutoSize = true;
            this.el.Location = new System.Drawing.Point(28, 100);
            this.el.Name = "el";
            this.el.Size = new System.Drawing.Size(32, 15);
            this.el.TabIndex = 8;
            this.el.Text = "Year:";
            // 
            // labelGeneration
            // 
            this.labelGeneration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.Location = new System.Drawing.Point(28, 129);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(55, 15);
            this.labelGeneration.TabIndex = 9;
            this.labelGeneration.Text = "Runtime:";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(28, 158);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(41, 15);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "Genre:";
            // 
            // pictureBoxMovie
            // 
            this.pictureBoxMovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMovie.Location = new System.Drawing.Point(272, 34);
            this.pictureBoxMovie.Name = "pictureBoxMovie";
            this.pictureBoxMovie.Size = new System.Drawing.Size(169, 254);
            this.pictureBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMovie.TabIndex = 14;
            this.pictureBoxMovie.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave.Location = new System.Drawing.Point(28, 184);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(238, 104);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxMovies
            // 
            this.comboBoxMovies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxMovies.FormattingEnabled = true;
            this.comboBoxMovies.Location = new System.Drawing.Point(27, 34);
            this.comboBoxMovies.Name = "comboBoxMovies";
            this.comboBoxMovies.Size = new System.Drawing.Size(239, 23);
            this.comboBoxMovies.TabIndex = 1;
            this.comboBoxMovies.Text = "                Please select a movie here:";
            this.comboBoxMovies.SelectedIndexChanged += new System.EventHandler(this.comboBoxMovies_SelectedIndexChanged);
            // 
            // panelMovie
            // 
            this.panelMovie.Controls.Add(this.comboBoxMovies);
            this.panelMovie.Controls.Add(this.buttonSave);
            this.panelMovie.Controls.Add(this.pictureBoxMovie);
            this.panelMovie.Controls.Add(this.labelYear);
            this.panelMovie.Controls.Add(this.labelGeneration);
            this.panelMovie.Controls.Add(this.el);
            this.panelMovie.Controls.Add(this.labelBrand);
            this.panelMovie.Controls.Add(this.textBoxGenre);
            this.panelMovie.Controls.Add(this.textBoxRuntime);
            this.panelMovie.Controls.Add(this.textBoxYear);
            this.panelMovie.Controls.Add(this.textBoxTitle);
            this.panelMovie.Location = new System.Drawing.Point(2, 0);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(468, 322);
            this.panelMovie.TabIndex = 15;
            // 
            // MovieEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 321);
            this.Controls.Add(this.panelMovie);
            this.Name = "MovieEditor";
            this.Text = "MovieEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).EndInit();
            this.panelMovie.ResumeLayout(false);
            this.panelMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxRuntime;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label el;
        private System.Windows.Forms.Label labelGeneration;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.PictureBox pictureBoxMovie;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxMovies;
        private System.Windows.Forms.Panel panelMovie;
    }
}