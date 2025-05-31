<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        lstTask = New ListBox()
        Label1 = New Label()
        txtTask = New TextBox()
        btnAdd = New Button()
        btnRemove = New Button()
        btnSave = New Button()
        Button1 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' lstTask
        ' 
        lstTask.BackColor = Color.Silver
        lstTask.Font = New Font("Britannic Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstTask.FormattingEnabled = True
        lstTask.ItemHeight = 16
        lstTask.Location = New Point(66, 66)
        lstTask.Name = "lstTask"
        lstTask.Size = New Size(150, 244)
        lstTask.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label1.Font = New Font("Britannic Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(259, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 16)
        Label1.TabIndex = 1
        Label1.Text = "Insert Task"
        ' 
        ' txtTask
        ' 
        txtTask.Location = New Point(355, 80)
        txtTask.Name = "txtTask"
        txtTask.Size = New Size(300, 27)
        txtTask.TabIndex = 2
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.LawnGreen
        btnAdd.Font = New Font("Britannic Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(619, 125)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(171, 29)
        btnAdd.TabIndex = 3
        btnAdd.Text = "ADD TASK"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.Red
        btnRemove.Font = New Font("Britannic Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRemove.ForeColor = Color.White
        btnRemove.Location = New Point(619, 189)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(171, 29)
        btnRemove.TabIndex = 4
        btnRemove.Text = "REMOVE SELECTED"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnSave.Font = New Font("Britannic Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(241, 357)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(171, 29)
        btnSave.TabIndex = 5
        btnSave.Text = "SAVE TASK"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gray
        Button1.Font = New Font("Britannic Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(498, 357)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 29)
        Button1.TabIndex = 6
        Button1.Text = "LOAD TASK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Label2.Font = New Font("Cooper Black", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(308, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 17)
        Label2.TabIndex = 7
        Label2.Text = " My To-Do List"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(830, 459)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(btnSave)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(txtTask)
        Controls.Add(Label1)
        Controls.Add(lstTask)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstTask As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTask As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
