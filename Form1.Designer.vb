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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.tbNum1 = New System.Windows.Forms.TextBox()
        Me.tbNum2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResultados = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(68, 116)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'tbNum1
        '
        Me.tbNum1.Location = New System.Drawing.Point(30, 43)
        Me.tbNum1.Name = "tbNum1"
        Me.tbNum1.Size = New System.Drawing.Size(51, 20)
        Me.tbNum1.TabIndex = 1
        '
        'tbNum2
        '
        Me.tbNum2.Location = New System.Drawing.Point(110, 43)
        Me.tbNum2.Name = "tbNum2"
        Me.tbNum2.Size = New System.Drawing.Size(54, 20)
        Me.tbNum2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "+"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "="
        '
        'lblResultados
        '
        Me.lblResultados.AutoSize = True
        Me.lblResultados.Location = New System.Drawing.Point(206, 48)
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Size = New System.Drawing.Size(60, 13)
        Me.lblResultados.TabIndex = 5
        Me.lblResultados.Text = "Resultados"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 187)
        Me.Controls.Add(Me.lblResultados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNum2)
        Me.Controls.Add(Me.tbNum1)
        Me.Controls.Add(Me.btnCalcular)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora Simples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents tbNum1 As System.Windows.Forms.TextBox
    Friend WithEvents tbNum2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResultados As System.Windows.Forms.Label

End Class
