namespace DSPC {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.currentSpeed = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.networkAdapters = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// currentSpeed
			// 
			this.currentSpeed.AutoSize = true;
			this.currentSpeed.Location = new System.Drawing.Point(18, 15);
			this.currentSpeed.Name = "currentSpeed";
			this.currentSpeed.Size = new System.Drawing.Size(137, 13);
			this.currentSpeed.TabIndex = 0;
			this.currentSpeed.Text = "Текущая скорость: 0kbps";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Скорость для выключения";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(133, 65);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Старт";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(206, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(122, 20);
			this.textBox1.TabIndex = 3;
			// 
			// networkAdapters
			// 
			this.networkAdapters.FormattingEnabled = true;
			this.networkAdapters.Location = new System.Drawing.Point(206, 12);
			this.networkAdapters.Name = "networkAdapters";
			this.networkAdapters.Size = new System.Drawing.Size(122, 21);
			this.networkAdapters.TabIndex = 4;
			this.networkAdapters.SelectedIndexChanged += new System.EventHandler(this.NetworkAdapters_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 97);
			this.Controls.Add(this.networkAdapters);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.currentSpeed);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label currentSpeed;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox networkAdapters;
	}
}

