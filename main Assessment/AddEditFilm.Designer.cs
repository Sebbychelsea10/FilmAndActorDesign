namespace main_Assessment
{
    partial class AddEditFilm
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
            txtTitle = new TextBox();
            txtActor = new TextBox();
            lblTitle = new Label();
            lblActor = new Label();
            txtDirector = new TextBox();
            lblLabel = new Label();
            btnAddFilm = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(111, 56);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(156, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtActor
            // 
            txtActor.Location = new Point(111, 123);
            txtActor.Multiline = true;
            txtActor.Name = "txtActor";
            txtActor.Size = new Size(156, 81);
            txtActor.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 59);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title:";
            // 
            // lblActor
            // 
            lblActor.AutoSize = true;
            lblActor.Location = new Point(8, 150);
            lblActor.Name = "lblActor";
            lblActor.Size = new Size(45, 20);
            lblActor.TabIndex = 4;
            lblActor.Text = "Actor";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(111, 261);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(156, 27);
            txtDirector.TabIndex = 5;
            // 
            // lblLabel
            // 
            lblLabel.AutoSize = true;
            lblLabel.Location = new Point(12, 268);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(63, 20);
            lblLabel.TabIndex = 6;
            lblLabel.Text = "Director";
            // 
            // btnAddFilm
            // 
            btnAddFilm.Location = new Point(139, 312);
            btnAddFilm.Name = "btnAddFilm";
            btnAddFilm.Size = new Size(94, 29);
            btnAddFilm.TabIndex = 7;
            btnAddFilm.Text = "Add Film";
            btnAddFilm.UseVisualStyleBackColor = true;
            btnAddFilm.Click += btnAddFilm_Click;
            // 
            // AddEditFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 344);
            Controls.Add(btnAddFilm);
            Controls.Add(lblLabel);
            Controls.Add(txtDirector);
            Controls.Add(lblActor);
            Controls.Add(lblTitle);
            Controls.Add(txtActor);
            Controls.Add(txtTitle);
            Name = "AddEditFilm";
            Text = "AddEditFilm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtActor;
        private Label lblTitle;
        private Label lblActor;
        private TextBox txtDirector;
        private Label lblLabel;
        private Button btnAddFilm;
    }
}