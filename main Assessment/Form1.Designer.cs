namespace main_Assessment
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
            btnFilm = new Button();
            lblFilms = new ListBox();
            btnDelete = new Button();
            lblActors = new ListBox();
            lblDirectors = new ListBox();
            SuspendLayout();
            // 
            // btnFilm
            // 
            btnFilm.Location = new Point(18, 39);
            btnFilm.Name = "btnFilm";
            btnFilm.Size = new Size(123, 114);
            btnFilm.TabIndex = 1;
            btnFilm.Text = "Add Film";
            btnFilm.UseVisualStyleBackColor = true;
            btnFilm.Click += btnAddFilms;
            // 
            // lblFilms
            // 
            lblFilms.FormattingEnabled = true;
            lblFilms.ItemHeight = 20;
            lblFilms.Location = new Point(196, 39);
            lblFilms.Name = "lblFilms";
            lblFilms.Size = new Size(184, 164);
            lblFilms.TabIndex = 2;
            lblFilms.SelectedIndexChanged += lblFilms_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteClick;
            // 
            // lblActors
            // 
            lblActors.FormattingEnabled = true;
            lblActors.ItemHeight = 20;
            lblActors.Location = new Point(408, 39);
            lblActors.Name = "lblActors";
            lblActors.Size = new Size(187, 164);
            lblActors.TabIndex = 4;
            // 
            // lblDirectors
            // 
            lblDirectors.FormattingEnabled = true;
            lblDirectors.ItemHeight = 20;
            lblDirectors.Location = new Point(642, 100);
            lblDirectors.Name = "lblDirectors";
            lblDirectors.Size = new Size(104, 64);
            lblDirectors.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 289);
            Controls.Add(lblDirectors);
            Controls.Add(lblActors);
            Controls.Add(btnDelete);
            Controls.Add(lblFilms);
            Controls.Add(btnFilm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnFilm;
        private ListBox lblFilms;
        private Button btnDelete;
        private ListBox lblActors;
        private ListBox lblDirectors;
    }
}