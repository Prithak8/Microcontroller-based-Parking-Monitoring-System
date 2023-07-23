<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parking_Lot_Status
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox_4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkp2slot3 = New System.Windows.Forms.CheckBox()
        Me.chkp2slot2 = New System.Windows.Forms.CheckBox()
        Me.chkp2slot1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkp1slot3 = New System.Windows.Forms.CheckBox()
        Me.chkp1slot2 = New System.Windows.Forms.CheckBox()
        Me.chkp1slot1 = New System.Windows.Forms.CheckBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(492, 38)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(728, 132)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1468, 209)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(329, 74)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(1468, 323)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(329, 68)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox_4
        '
        Me.TextBox_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_4.Location = New System.Drawing.Point(1468, 438)
        Me.TextBox_4.Multiline = True
        Me.TextBox_4.Name = "TextBox_4"
        Me.TextBox_4.Size = New System.Drawing.Size(329, 70)
        Me.TextBox_4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1468, 566)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(329, 72)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1468, 703)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(329, 75)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(1468, 839)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(329, 77)
        Me.TextBox7.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkp2slot3)
        Me.GroupBox1.Controls.Add(Me.chkp2slot2)
        Me.GroupBox1.Controls.Add(Me.chkp2slot1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(719, 285)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 580)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parking 2"
        '
        'chkp2slot3
        '
        Me.chkp2slot3.AutoSize = True
        Me.chkp2slot3.Location = New System.Drawing.Point(125, 436)
        Me.chkp2slot3.Name = "chkp2slot3"
        Me.chkp2slot3.Size = New System.Drawing.Size(268, 95)
        Me.chkp2slot3.TabIndex = 5
        Me.chkp2slot3.Text = "Slot 3"
        Me.chkp2slot3.UseVisualStyleBackColor = True
        '
        'chkp2slot2
        '
        Me.chkp2slot2.AutoSize = True
        Me.chkp2slot2.Location = New System.Drawing.Point(125, 292)
        Me.chkp2slot2.Name = "chkp2slot2"
        Me.chkp2slot2.Size = New System.Drawing.Size(268, 95)
        Me.chkp2slot2.TabIndex = 4
        Me.chkp2slot2.Text = "Slot 2"
        Me.chkp2slot2.UseVisualStyleBackColor = True
        '
        'chkp2slot1
        '
        Me.chkp2slot1.AutoSize = True
        Me.chkp2slot1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkp2slot1.Location = New System.Drawing.Point(125, 153)
        Me.chkp2slot1.Name = "chkp2slot1"
        Me.chkp2slot1.Size = New System.Drawing.Size(268, 95)
        Me.chkp2slot1.TabIndex = 3
        Me.chkp2slot1.Text = "Slot 1"
        Me.chkp2slot1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkp1slot3)
        Me.GroupBox2.Controls.Add(Me.chkp1slot2)
        Me.GroupBox2.Controls.Add(Me.chkp1slot1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 285)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(608, 580)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parking 1"
        '
        'chkp1slot3
        '
        Me.chkp1slot3.AutoSize = True
        Me.chkp1slot3.Location = New System.Drawing.Point(83, 436)
        Me.chkp1slot3.Name = "chkp1slot3"
        Me.chkp1slot3.Size = New System.Drawing.Size(268, 95)
        Me.chkp1slot3.TabIndex = 2
        Me.chkp1slot3.Text = "Slot 3"
        Me.chkp1slot3.UseVisualStyleBackColor = True
        '
        'chkp1slot2
        '
        Me.chkp1slot2.AutoSize = True
        Me.chkp1slot2.Location = New System.Drawing.Point(83, 292)
        Me.chkp1slot2.Name = "chkp1slot2"
        Me.chkp1slot2.Size = New System.Drawing.Size(268, 95)
        Me.chkp1slot2.TabIndex = 1
        Me.chkp1slot2.Text = "Slot 2"
        Me.chkp1slot2.UseVisualStyleBackColor = True
        '
        'chkp1slot1
        '
        Me.chkp1slot1.AutoSize = True
        Me.chkp1slot1.Location = New System.Drawing.Point(83, 153)
        Me.chkp1slot1.Name = "chkp1slot1"
        Me.chkp1slot1.Size = New System.Drawing.Size(268, 95)
        Me.chkp1slot1.TabIndex = 0
        Me.chkp1slot1.Text = "Slot 1"
        Me.chkp1slot1.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1341, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 36)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Slot 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1341, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 36)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Slot 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1341, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 36)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Slot 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1341, 596)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 36)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Slot 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1341, 732)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 36)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Slot 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1341, 865)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 36)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Slot 3"
        '
        'Parking_Lot_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox_4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Parking_Lot_Status"
        Me.Text = "Parking Lot Status"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox_4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox_4.TextChanged

    End Sub
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Friend WithEvents chkp2slot3 As CheckBox
    Friend WithEvents chkp2slot2 As CheckBox
    Friend WithEvents chkp2slot1 As CheckBox
    Friend WithEvents chkp1slot3 As CheckBox
    Friend WithEvents chkp1slot2 As CheckBox
    Friend WithEvents chkp1slot1 As CheckBox
End Class
