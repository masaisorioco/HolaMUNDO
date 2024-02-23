namespace HolaMundo
{
    partial class frmHolaMundo
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
            btnHolaMundo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHolaMundo
            // 
            btnHolaMundo.Font = new Font("Maiandra GD", 14F, FontStyle.Bold);
            btnHolaMundo.Location = new Point(202, 76);
            btnHolaMundo.Name = "btnHolaMundo";
            btnHolaMundo.Size = new Size(234, 112);
            btnHolaMundo.TabIndex = 0;
            btnHolaMundo.Text = "SALUDAR";
            btnHolaMundo.UseVisualStyleBackColor = true;
            btnHolaMundo.Click += btnHolaMundo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 14F, FontStyle.Bold);
            label1.Location = new Point(300, 281);
            label1.Name = "label1";
            label1.Size = new Size(90, 34);
            label1.TabIndex = 1;
            label1.Text = "SALIR";
            label1.Click += label1_Click;
            // 
            // frmHolaMundo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnHolaMundo);
            Name = "frmHolaMundo";
            Text = "frmHolaMundo";
            Load += frmHolaMundo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHolaMundo;
        private Label label1;
    }
}