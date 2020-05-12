namespace PP_Z5_WinForms_
{
    partial class Praktika_5
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Zadanie_1 = new System.Windows.Forms.GroupBox();
            this.start_a = new System.Windows.Forms.Label();
            this.the_end_b = new System.Windows.Forms.Label();
            this.step_h = new System.Windows.Forms.Label();
            this.enter_a = new System.Windows.Forms.TextBox();
            this.enter_b = new System.Windows.Forms.TextBox();
            this.enter_h = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.RichTextBox();
            this.primer = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.Button();
            this.Zadanie_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primer)).BeginInit();
            this.SuspendLayout();
            // 
            // Zadanie_1
            // 
            this.Zadanie_1.Controls.Add(this.Result);
            this.Zadanie_1.Controls.Add(this.primer);
            this.Zadanie_1.Controls.Add(this.rez);
            this.Zadanie_1.Controls.Add(this.enter_h);
            this.Zadanie_1.Controls.Add(this.enter_b);
            this.Zadanie_1.Controls.Add(this.enter_a);
            this.Zadanie_1.Controls.Add(this.step_h);
            this.Zadanie_1.Controls.Add(this.the_end_b);
            this.Zadanie_1.Controls.Add(this.start_a);
            this.Zadanie_1.Location = new System.Drawing.Point(0, 0);
            this.Zadanie_1.Name = "Zadanie_1";
            this.Zadanie_1.Size = new System.Drawing.Size(575, 447);
            this.Zadanie_1.TabIndex = 0;
            this.Zadanie_1.TabStop = false;
            this.Zadanie_1.Text = "Задание 1";
            // 
            // start_a
            // 
            this.start_a.AutoSize = true;
            this.start_a.Location = new System.Drawing.Point(3, 28);
            this.start_a.Name = "start_a";
            this.start_a.Size = new System.Drawing.Size(227, 17);
            this.start_a.TabIndex = 0;
            this.start_a.Text = "Введите начало интревала ( a ): ";
            // 
            // the_end_b
            // 
            this.the_end_b.AutoSize = true;
            this.the_end_b.Location = new System.Drawing.Point(3, 59);
            this.the_end_b.Name = "the_end_b";
            this.the_end_b.Size = new System.Drawing.Size(218, 17);
            this.the_end_b.TabIndex = 1;
            this.the_end_b.Text = "Введите конец интервала ( b ): ";
            // 
            // step_h
            // 
            this.step_h.AutoSize = true;
            this.step_h.Location = new System.Drawing.Point(3, 92);
            this.step_h.Name = "step_h";
            this.step_h.Size = new System.Drawing.Size(129, 17);
            this.step_h.TabIndex = 2;
            this.step_h.Text = "Введите шаг ( h ): ";
            // 
            // enter_a
            // 
            this.enter_a.Location = new System.Drawing.Point(227, 25);
            this.enter_a.Name = "enter_a";
            this.enter_a.Size = new System.Drawing.Size(100, 22);
            this.enter_a.TabIndex = 3;
            // 
            // enter_b
            // 
            this.enter_b.Location = new System.Drawing.Point(227, 56);
            this.enter_b.Name = "enter_b";
            this.enter_b.Size = new System.Drawing.Size(100, 22);
            this.enter_b.TabIndex = 4;
            // 
            // enter_h
            // 
            this.enter_h.Location = new System.Drawing.Point(227, 89);
            this.enter_h.Name = "enter_h";
            this.enter_h.Size = new System.Drawing.Size(100, 22);
            this.enter_h.TabIndex = 5;
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(333, 15);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(236, 286);
            this.rez.TabIndex = 6;
            this.rez.Text = "";
            // 
            // primer
            // 
            this.primer.BackgroundImage = global::PP_Z5_WinForms_.Properties.Resources._14;
            this.primer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.primer.Location = new System.Drawing.Point(6, 127);
            this.primer.Name = "primer";
            this.primer.Size = new System.Drawing.Size(321, 99);
            this.primer.TabIndex = 7;
            this.primer.TabStop = false;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(52, 238);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(230, 54);
            this.Result.TabIndex = 8;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Praktika_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 312);
            this.Controls.Add(this.Zadanie_1);
            this.Name = "Praktika_5";
            this.Text = "Практика 5";
            this.Zadanie_1.ResumeLayout(false);
            this.Zadanie_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zadanie_1;
        private System.Windows.Forms.PictureBox primer;
        private System.Windows.Forms.RichTextBox rez;
        private System.Windows.Forms.TextBox enter_h;
        private System.Windows.Forms.TextBox enter_b;
        private System.Windows.Forms.TextBox enter_a;
        private System.Windows.Forms.Label step_h;
        private System.Windows.Forms.Label the_end_b;
        private System.Windows.Forms.Label start_a;
        private System.Windows.Forms.Button Result;
    }
}

