<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorldForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelloWorldForm))
        Me.lblHelloText = New System.Windows.Forms.Label()
        Me.lnkRaiseEvent = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHelloText
        '
        resources.ApplyResources(Me.lblHelloText, "lblHelloText")
        Me.lblHelloText.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblHelloText.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblHelloText.Name = "lblHelloText"
        '
        'lnkRaiseEvent
        '
        Me.lnkRaiseEvent.ActiveLinkColor = System.Drawing.Color.DarkBlue
        resources.ApplyResources(Me.lnkRaiseEvent, "lnkRaiseEvent")
        Me.lnkRaiseEvent.BackColor = System.Drawing.Color.Transparent
        Me.lnkRaiseEvent.DisabledLinkColor = System.Drawing.Color.DarkBlue
        Me.lnkRaiseEvent.ForeColor = System.Drawing.Color.DarkBlue
        Me.lnkRaiseEvent.Name = "lnkRaiseEvent"
        Me.lnkRaiseEvent.TabStop = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HelloWorldForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lnkRaiseEvent)
        Me.Controls.Add(Me.lblHelloText)
        Me.Name = "HelloWorldForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHelloText As System.Windows.Forms.Label
    Friend WithEvents lnkRaiseEvent As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As Button
End Class
