namespace ContactList;

public partial class AddContactForm : Form
{
    public AddContactForm()
    {
        InitializeComponent();
    }
}

partial class AddContactForm
{
    private System.ComponentModel.IContainer components = null;

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
        txtEmail = new TextBox();
        lblEmail = new Label();
        SuspendLayout();
        
        // lblEmail
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(12, 15);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(46, 20);
        lblEmail.TabIndex = 0;
        lblEmail.Text = "Email:";
        
        // txtEmail
        txtEmail.Location = new Point(70, 12);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(250, 27);
        txtEmail.TabIndex = 1;
        
        // AddContactForm
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(342, 213);
        Controls.Add(txtEmail);
        Controls.Add(lblEmail);
        Name = "AddContactForm";
        Text = "Thêm liên hệ";
        ResumeLayout(false);
        PerformLayout();
    }

    private TextBox txtEmail;
    private Label lblEmail;
}
