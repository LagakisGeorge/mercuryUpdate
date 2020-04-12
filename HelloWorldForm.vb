Imports Microsoft.InteropFormTools

<InteropForm()> _
Public Class HelloWorldForm

#Region "Public Constructors"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    <InteropFormInitializer()> _
    Public Sub New(ByVal helloText As String)
        Me.New()

        lblHelloText.Text = helloText

    End Sub

    <InteropFormInitializer()> _
    Public Sub New(ByVal helloText As String, ByVal repeatTimes As Int32)
        Me.New()

        lblHelloText.Text = String.Empty

        For i As Int32 = 0 To repeatTimes - 1
            lblHelloText.Text += helloText + vbNewLine
        Next
    End Sub

#End Region

#Region "Public Methods"

    ''' <summary>
    ''' Swaps the background colors of the Label and Form
    ''' </summary>
    ''' <remarks>This is a trivial method showing the use of the InteropFormMethod attribute</remarks>
    <InteropFormMethod()> _
    Public Sub ReverseBackgroundColors()

        Dim lblOldBackColor As Color = Me.lblHelloText.BackColor
        lblHelloText.BackColor = Me.BackColor
        Me.BackColor = lblOldBackColor

    End Sub

#End Region

#Region "Public Properties"

    ''' <summary>
    ''' Gets/Sets the hello text in the form
    ''' </summary>
    ''' <remarks>This is a trivial method showing the use of the InteropFormProperty attribute</remarks>
    <InteropFormProperty()> _
    Public Property HelloText() As String
        Get
            Return lblHelloText.Text
        End Get
        Set(ByVal value As String)
            lblHelloText.Text = value
        End Set
    End Property

#End Region

#Region "Public Events"

    <InteropFormEvent()> _
    Public Event SampleEvent As SampleEventHandler

    Public Delegate Sub SampleEventHandler(ByVal sampleEventText As String)

#End Region

#Region "Private Methods"

    ''' <summary>
    ''' Event handler for link label click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lnkRaiseEvent_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRaiseEvent.LinkClicked
        'displays "Current Form Text is """ + lblHelloText.Text & """"
        RaiseEvent SampleEvent(String.Format(My.Resources.SampleEventText, lblHelloText.Text))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As New Form1
        s.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim s As New Form2
        s.Show()
    End Sub

    Private Sub HelloWorldForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If lblHelloText.Text = "1" Then
        '    lblHelloText.Text = "11"
        '    Me.Hide()
        '        Dim s As New Form1
        '        s.ShowDialog()
        '        Me.Close()




        '    End If


        'If lblHelloText.Text = "2" Then
        '    lblHelloText.Text = "22"

        '    Me.Hide()
        '    Dim s As New Form2
        '    s.ShowDialog()
        '    Me.Close()

        'End If





    End Sub

    Private Sub HelloWorldForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If lblHelloText.Text = "1" Then
            lblHelloText.Text = "121"
            Me.Hide()
            Dim s As New Form1
            s.ShowDialog()
            Me.Close()




        End If


        If lblHelloText.Text = "2" Then
            lblHelloText.Text = "222"

            Me.Hide()
            Dim s As New Form2
            s.ShowDialog()
            Me.Close()

        End If
    End Sub

    Private Sub HelloWorldForm_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        'If lblHelloText.Text = "1" Then
        '    lblHelloText.Text = "113"
        '    '  Me.Hide()
        '    Dim s As New Form1
        '    '  s.ShowDialog()
        '    ' Me.Close()




        'End If


        'If lblHelloText.Text = "2" Then
        '    lblHelloText.Text = "223"

        '    '  Me.Hide()
        '    Dim s As New Form2
        '    '  s.ShowDialog()
        '    '  Me.Close()

        'End If
    End Sub


#End Region


End Class
