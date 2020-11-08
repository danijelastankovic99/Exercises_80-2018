namespace Exercises_80_2018
{
    partial class ExerciseResult
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
            this.listBoxExerciseResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxExerciseResults
            // 
            this.listBoxExerciseResults.FormattingEnabled = true;
            this.listBoxExerciseResults.ItemHeight = 15;
            this.listBoxExerciseResults.Location = new System.Drawing.Point(86, 30);
            this.listBoxExerciseResults.Name = "listBoxExerciseResults";
            this.listBoxExerciseResults.Size = new System.Drawing.Size(399, 229);
            this.listBoxExerciseResults.TabIndex = 0;
            // 
            // ExerciseResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 349);
            this.Controls.Add(this.listBoxExerciseResults);
            this.Name = "ExerciseResult";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.ExerciseResult_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExerciseResults;
    }
}

