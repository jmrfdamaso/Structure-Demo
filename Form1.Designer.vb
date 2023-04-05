<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LblFirstName = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.LblLastName = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.BtnTest = New System.Windows.Forms.Button()
        Me.LstCustomers = New System.Windows.Forms.ListBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(12, 186)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(35, 13)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "Name"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(72, 183)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(289, 20)
        Me.TxtName.TabIndex = 1
        '
        'LblFirstName
        '
        Me.LblFirstName.AutoSize = True
        Me.LblFirstName.Location = New System.Drawing.Point(12, 234)
        Me.LblFirstName.Name = "LblFirstName"
        Me.LblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.LblFirstName.TabIndex = 2
        Me.LblFirstName.Text = "First Name"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(72, 231)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(289, 20)
        Me.TxtFirstName.TabIndex = 3
        '
        'LblLastName
        '
        Me.LblLastName.AutoSize = True
        Me.LblLastName.Location = New System.Drawing.Point(13, 282)
        Me.LblLastName.Name = "LblLastName"
        Me.LblLastName.Size = New System.Drawing.Size(58, 13)
        Me.LblLastName.TabIndex = 4
        Me.LblLastName.Text = "Last Name"
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(72, 279)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(289, 20)
        Me.TxtLastName.TabIndex = 5
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(12, 330)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(35, 13)
        Me.LblEmail.TabIndex = 6
        Me.LblEmail.Text = "E-mail"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(72, 327)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(289, 20)
        Me.TxtEmail.TabIndex = 7
        '
        'BtnTest
        '
        Me.BtnTest.Location = New System.Drawing.Point(97, 365)
        Me.BtnTest.Name = "BtnTest"
        Me.BtnTest.Size = New System.Drawing.Size(75, 23)
        Me.BtnTest.TabIndex = 8
        Me.BtnTest.Text = "Test"
        Me.BtnTest.UseVisualStyleBackColor = True
        '
        'LstCustomers
        '
        Me.LstCustomers.FormattingEnabled = True
        Me.LstCustomers.IntegralHeight = False
        Me.LstCustomers.Location = New System.Drawing.Point(16, 12)
        Me.LstCustomers.Name = "LstCustomers"
        Me.LstCustomers.Size = New System.Drawing.Size(345, 147)
        Me.LstCustomers.TabIndex = 9
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(246, 365)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 410)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.LstCustomers)
        Me.Controls.Add(Me.BtnTest)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.TxtLastName)
        Me.Controls.Add(Me.LblLastName)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.LblFirstName)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblName As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblFirstName As Label
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents LblLastName As Label
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnTest As Button
    Friend WithEvents LstCustomers As ListBox
    Friend WithEvents BtnDelete As Button
End Class
