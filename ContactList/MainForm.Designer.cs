namespace ContactList;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    
    // ...existing code...

    private void InitializeComponent()
    {
        label1 = new Label();
        button1 = new Button();
        SuspendLayout();
        
        // Label
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(120, 20);
        label1.TabIndex = 0;
        label1.Text = "Danh sách liên hệ";
        
        // Button
        button1.Location = new Point(12, 40);
        button1.Name = "button1";
        button1.Size = new Size(120, 29);
        button1.TabIndex = 1;
        button1.Text = "Thêm liên hệ";
        button1.UseVisualStyleBackColor = true;
        
        // MainForm
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(label1);
        Name = "MainForm";
        Text = "MainForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #region Windows Form Designer generated code
    private Label label1;
    private Button button1;
    #endregion
}
