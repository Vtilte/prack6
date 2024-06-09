namespace ArithmeticExpressionApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtX1;
        private TextBox txtX2;
        private Label lblX1;
        private Label lblX2;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

           
            this.txtX1.Location = new System.Drawing.Point(100, 20);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 22);
            this.txtX1.TabIndex = 0;
            
            this.txtX2.Location = new System.Drawing.Point(100, 60);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 22);
            this.txtX2.TabIndex = 1;
           
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(20, 20);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(58, 17);
            this.lblX1.TabIndex = 2;
            this.lblX1.Text = "Enter x1:";
           
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(20, 60);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(58, 17);
            this.lblX2.TabIndex = 3;
            this.lblX2.Text = "Enter x2:";
          
            this.btnCalculate.Location = new System.Drawing.Point(20, 100);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(180, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
          
            this.btnClear.Location = new System.Drawing.Point(20, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
           
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 140);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result:";
          
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Name = "Form1";
            this.Text = "Arithmetic Expression Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}