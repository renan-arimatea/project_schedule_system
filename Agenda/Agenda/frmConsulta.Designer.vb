<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComplemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFone1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFone2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCEP)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtra por"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(527, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CEP:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(73, 40)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(432, 23)
        Me.txtNome.TabIndex = 1
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(564, 40)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(155, 23)
        Me.txtCEP.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvDados)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 346)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colNome, Me.colCep, Me.colUF, Me.colEndereco, Me.colBairro, Me.colNumero, Me.colComplemento, Me.colFone1, Me.colFone2})
        Me.dgvDados.Location = New System.Drawing.Point(12, 12)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.RowTemplate.Height = 25
        Me.dgvDados.Size = New System.Drawing.Size(719, 328)
        Me.dgvDados.TabIndex = 2
        '
        'colCodigo
        '
        Me.colCodigo.DataPropertyName = "CODIGO"
        Me.colCodigo.HeaderText = "Código"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        '
        'colNome
        '
        Me.colNome.DataPropertyName = "NOME"
        Me.colNome.HeaderText = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.ReadOnly = True
        '
        'colCep
        '
        Me.colCep.DataPropertyName = "CEP"
        Me.colCep.HeaderText = "CEP"
        Me.colCep.Name = "colCep"
        Me.colCep.ReadOnly = True
        '
        'colUF
        '
        Me.colUF.DataPropertyName = "UF"
        Me.colUF.HeaderText = "UF"
        Me.colUF.Name = "colUF"
        Me.colUF.ReadOnly = True
        '
        'colEndereco
        '
        Me.colEndereco.DataPropertyName = "ENDERECO"
        Me.colEndereco.HeaderText = "Endereço"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.ReadOnly = True
        '
        'colBairro
        '
        Me.colBairro.DataPropertyName = "BAIRRO"
        Me.colBairro.HeaderText = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.ReadOnly = True
        '
        'colNumero
        '
        Me.colNumero.DataPropertyName = "NUMERO"
        Me.colNumero.HeaderText = "Número"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.ReadOnly = True
        '
        'colComplemento
        '
        Me.colComplemento.DataPropertyName = "COMPLEMENTO"
        Me.colComplemento.HeaderText = "Complemento"
        Me.colComplemento.Name = "colComplemento"
        Me.colComplemento.ReadOnly = True
        '
        'colFone1
        '
        Me.colFone1.DataPropertyName = "FONE1"
        Me.colFone1.HeaderText = "Fone"
        Me.colFone1.Name = "colFone1"
        Me.colFone1.ReadOnly = True
        '
        'colFone2
        '
        Me.colFone2.DataPropertyName = "FONE2"
        Me.colFone2.HeaderText = "Fone"
        Me.colFone2.Name = "colFone2"
        Me.colFone2.ReadOnly = True
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents colCodigo As DataGridViewTextBoxColumn
    Friend WithEvents colNome As DataGridViewTextBoxColumn
    Friend WithEvents colCep As DataGridViewTextBoxColumn
    Friend WithEvents colUF As DataGridViewTextBoxColumn
    Friend WithEvents colEndereco As DataGridViewTextBoxColumn
    Friend WithEvents colBairro As DataGridViewTextBoxColumn
    Friend WithEvents colNumero As DataGridViewTextBoxColumn
    Friend WithEvents colComplemento As DataGridViewTextBoxColumn
    Friend WithEvents colFone1 As DataGridViewTextBoxColumn
    Friend WithEvents colFone2 As DataGridViewTextBoxColumn
End Class
