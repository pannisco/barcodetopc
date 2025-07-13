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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblConn = New System.Windows.Forms.Label()
        Me.lblRicevuto = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbSchede = New System.Windows.Forms.ComboBox()
        Me.btnAvvia = New System.Windows.Forms.Button()
        Me.chkKeyboard = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(3, 9)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(58, 37)
        Me.lblIP.TabIndex = 0
        Me.lblIP.Text = "IP:"
        '
        'lblConn
        '
        Me.lblConn.AutoSize = True
        Me.lblConn.Location = New System.Drawing.Point(7, 46)
        Me.lblConn.Name = "lblConn"
        Me.lblConn.Size = New System.Drawing.Size(131, 13)
        Me.lblConn.TabIndex = 1
        Me.lblConn.Text = "In attesa di connessione..."
        '
        'lblRicevuto
        '
        Me.lblRicevuto.AutoSize = True
        Me.lblRicevuto.Location = New System.Drawing.Point(7, 97)
        Me.lblRicevuto.Name = "lblRicevuto"
        Me.lblRicevuto.Size = New System.Drawing.Size(0, 13)
        Me.lblRicevuto.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cmbSchede
        '
        Me.cmbSchede.FormattingEnabled = True
        Me.cmbSchede.Location = New System.Drawing.Point(6, 17)
        Me.cmbSchede.Name = "cmbSchede"
        Me.cmbSchede.Size = New System.Drawing.Size(109, 21)
        Me.cmbSchede.TabIndex = 3
        '
        'btnAvvia
        '
        Me.btnAvvia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvvia.Location = New System.Drawing.Point(160, 63)
        Me.btnAvvia.Name = "btnAvvia"
        Me.btnAvvia.Size = New System.Drawing.Size(117, 52)
        Me.btnAvvia.TabIndex = 4
        Me.btnAvvia.Text = "AVVIA"
        Me.btnAvvia.UseVisualStyleBackColor = True
        '
        'chkKeyboard
        '
        Me.chkKeyboard.AutoSize = True
        Me.chkKeyboard.Checked = True
        Me.chkKeyboard.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKeyboard.Location = New System.Drawing.Point(6, 44)
        Me.chkKeyboard.Name = "chkKeyboard"
        Me.chkKeyboard.Size = New System.Drawing.Size(94, 17)
        Me.chkKeyboard.TabIndex = 5
        Me.chkKeyboard.Text = "Simula tastiera"
        Me.chkKeyboard.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 66)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "A capo automatico"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 89)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Log CSV"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(7, 110)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(140, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Made by Pannisco Software"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.chkKeyboard)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.cmbSchede)
        Me.GroupBox1.Location = New System.Drawing.Point(283, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 114)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impostazioni"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 125)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnAvvia)
        Me.Controls.Add(Me.lblRicevuto)
        Me.Controls.Add(Me.lblConn)
        Me.Controls.Add(Me.lblIP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Barcode To PC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIP As Label
    Friend WithEvents lblConn As Label
    Friend WithEvents lblRicevuto As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmbSchede As ComboBox
    Friend WithEvents btnAvvia As Button
    Friend WithEvents chkKeyboard As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
End Class
