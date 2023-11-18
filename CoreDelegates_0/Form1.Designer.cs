namespace CoreDelegates_0
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
            btnInvoke = new Button();
            SuspendLayout();
            // 
            // btnInvoke
            // 
            btnInvoke.Location = new Point(51, 84);
            btnInvoke.Name = "btnInvoke";
            btnInvoke.Size = new Size(139, 29);
            btnInvoke.TabIndex = 0;
            btnInvoke.Text = "Delege calıstır";
            btnInvoke.UseVisualStyleBackColor = true;
            btnInvoke.Click += btnInvoke_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInvoke);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnInvoke;
    }
}
