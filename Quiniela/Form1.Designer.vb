<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudNumero = New System.Windows.Forms.NumericUpDown()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lboxApostados = New System.Windows.Forms.ListBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.lbxSorteados = New System.Windows.Forms.ListBox()
        Me.btnSortear = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. Apostar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "N° Apostados:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "N° Sorteados:"
        '
        'nudNumero
        '
        Me.nudNumero.Location = New System.Drawing.Point(87, 19)
        Me.nudNumero.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudNumero.Name = "nudNumero"
        Me.nudNumero.Size = New System.Drawing.Size(48, 20)
        Me.nudNumero.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(141, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lboxApostados
        '
        Me.lboxApostados.FormattingEnabled = True
        Me.lboxApostados.Location = New System.Drawing.Point(15, 85)
        Me.lboxApostados.Name = "lboxApostados"
        Me.lboxApostados.Size = New System.Drawing.Size(120, 290)
        Me.lboxApostados.TabIndex = 5
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(141, 85)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 6
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnVaciar
        '
        Me.btnVaciar.Location = New System.Drawing.Point(141, 114)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(75, 23)
        Me.btnVaciar.TabIndex = 7
        Me.btnVaciar.Text = "Vaciar"
        Me.btnVaciar.UseVisualStyleBackColor = True
        '
        'lbxSorteados
        '
        Me.lbxSorteados.FormattingEnabled = True
        Me.lbxSorteados.Location = New System.Drawing.Point(280, 85)
        Me.lbxSorteados.Name = "lbxSorteados"
        Me.lbxSorteados.Size = New System.Drawing.Size(126, 290)
        Me.lbxSorteados.TabIndex = 8
        '
        'btnSortear
        '
        Me.btnSortear.Location = New System.Drawing.Point(320, 16)
        Me.btnSortear.Name = "btnSortear"
        Me.btnSortear.Size = New System.Drawing.Size(86, 23)
        Me.btnSortear.TabIndex = 9
        Me.btnSortear.Text = "Ver Sorteados"
        Me.btnSortear.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(331, 392)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 418)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSortear)
        Me.Controls.Add(Me.lbxSorteados)
        Me.Controls.Add(Me.btnVaciar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.lboxApostados)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.nudNumero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Quiniela"
        CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudNumero As NumericUpDown
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lboxApostados As ListBox
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents lbxSorteados As ListBox
    Friend WithEvents btnSortear As Button
    Friend WithEvents btnSalir As Button
End Class
