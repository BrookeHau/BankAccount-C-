﻿'------------------------------------------------------------------------------
'  <auto-generated>
'      This code was generated by coded UI test builder.
'      Version: 15.0.0.0
'
'      Changes to this file may cause incorrect behavior and will be lost if
'      the code is regenerated.
'  </auto-generated>
' ------------------------------------------------------------------------------

Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Input
Imports Microsoft.VisualStudio.TestTools.UITest.Extension
Imports Microsoft.VisualStudio.TestTools.UITesting
Imports Microsoft.VisualStudio.TestTools.UITesting.WinControls
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard
Imports Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse
Imports MouseButtons = System.Windows.Forms.MouseButtons

Namespace CodedUITest
    
    <GeneratedCode("Coded UITest Builder", "15.0.26208.0")>  _
    Partial Public Class UIMap
        
        '''<summary>
        '''GetBankBalance - Use 'GetBankBalanceParams' to pass parameters into this method.
        '''</summary>
        Public Sub GetBankBalance()
            Dim uIWithdrawalTextBoxWindow As WinWindow = Me.UIForm1Window.UIForm1Client.UIWithdrawalTextBoxWindow
            Dim uIWithdrawalTextBoxEdit As WinEdit = Me.UIForm1Window.UIWithdrawalTextBoxWindow.UIWithdrawalTextBoxEdit
            Dim uIDepositTextBoxWindow As WinWindow = Me.UIForm1Window.UIForm1Client.UIDepositTextBoxWindow
            Dim uIDepositTextBoxEdit As WinEdit = Me.UIForm1Window.UIDepositTextBoxWindow.UIDepositTextBoxEdit
            Dim uIGetBalanceWindow As WinWindow = Me.UIForm1Window.UIForm1Client.UIGetBalanceWindow
            Dim uIForm1Window As WinWindow = Me.UIForm1Window

            'Click 'withdrawalTextBox' window
            Mouse.Click(uIWithdrawalTextBoxWindow, New Point(201, 119))

            'Type '25' in 'withdrawalTextBox' text box
            uIWithdrawalTextBoxEdit.Text = Me.GetBankBalanceParams.UIWithdrawalTextBoxEditText

            'Click 'depositTextBox' window
            Mouse.Click(uIDepositTextBoxWindow, New Point(196, 129))

            'Type '5' in 'depositTextBox' text box
            uIDepositTextBoxEdit.Text = Me.GetBankBalanceParams.UIDepositTextBoxEditText

            'Click 'Get Balance' window
            Mouse.Click(uIGetBalanceWindow, New Point(156, 193))

            'Click 'Form1' window
            Mouse.Click(uIForm1Window, New Point(826, 82))
        End Sub
        
        #Region "Properties"
        Public Overridable ReadOnly Property GetBankBalanceParams() As GetBankBalanceParams
            Get
                If (Me.mGetBankBalanceParams Is Nothing) Then
                    Me.mGetBankBalanceParams = New GetBankBalanceParams()
                End If
                Return Me.mGetBankBalanceParams
            End Get
        End Property
        
        Public ReadOnly Property UIForm1Window() As UIForm1Window
            Get
                If (Me.mUIForm1Window Is Nothing) Then
                    Me.mUIForm1Window = New UIForm1Window()
                End If
                Return Me.mUIForm1Window
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mGetBankBalanceParams As GetBankBalanceParams
        
        Private mUIForm1Window As UIForm1Window
        #End Region
    End Class
    
    '''<summary>
    '''Parameters to be passed into 'GetBankBalance'
    '''</summary>
    <GeneratedCode("Coded UITest Builder", "15.0.26208.0")>  _
    Public Class GetBankBalanceParams
        
        #Region "Fields"
        '''<summary>
        '''Type '25' in 'withdrawalTextBox' text box
        '''</summary>
        Public UIWithdrawalTextBoxEditText As String = "25"
        
        '''<summary>
        '''Type '5' in 'depositTextBox' text box
        '''</summary>
        Public UIDepositTextBoxEditText As String = "5"
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "15.0.26208.0")>  _
    Public Class UIForm1Window
        Inherits WinWindow
        
        Public Sub New()
            MyBase.New
            Me.SearchProperties(WinWindow.PropertyNames.Name) = "Form1"
            Me.SearchProperties.Add(New PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains))
            Me.WindowTitles.Add("Form1")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UIForm1Client() As UIForm1Client
            Get
                If (Me.mUIForm1Client Is Nothing) Then
                    Me.mUIForm1Client = New UIForm1Client(Me)
                End If
                Return Me.mUIForm1Client
            End Get
        End Property
        
        Public ReadOnly Property UIWithdrawalTextBoxWindow() As UIWithdrawalTextBoxWindow
            Get
                If (Me.mUIWithdrawalTextBoxWindow Is Nothing) Then
                    Me.mUIWithdrawalTextBoxWindow = New UIWithdrawalTextBoxWindow(Me)
                End If
                Return Me.mUIWithdrawalTextBoxWindow
            End Get
        End Property
        
        Public ReadOnly Property UIDepositTextBoxWindow() As UIDepositTextBoxWindow
            Get
                If (Me.mUIDepositTextBoxWindow Is Nothing) Then
                    Me.mUIDepositTextBoxWindow = New UIDepositTextBoxWindow(Me)
                End If
                Return Me.mUIDepositTextBoxWindow
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUIForm1Client As UIForm1Client
        
        Private mUIWithdrawalTextBoxWindow As UIWithdrawalTextBoxWindow
        
        Private mUIDepositTextBoxWindow As UIDepositTextBoxWindow
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "15.0.26208.0")>  _
    Public Class UIForm1Client
        Inherits WinClient
        
        Public Sub New(ByVal searchLimitContainer As UITestControl)
            MyBase.New(searchLimitContainer)
            Me.SearchProperties(WinControl.PropertyNames.Name) = "Form1"
            Me.WindowTitles.Add("Form1")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UIWithdrawalTextBoxWindow() As WinWindow
            Get
                If (Me.mUIWithdrawalTextBoxWindow Is Nothing) Then
                    Me.mUIWithdrawalTextBoxWindow = New WinWindow(Me)
                    Me.mUIWithdrawalTextBoxWindow.SearchProperties.Add(New PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains))
                    Me.mUIWithdrawalTextBoxWindow.SearchProperties(WinWindow.PropertyNames.Instance) = "2"
                    Me.mUIWithdrawalTextBoxWindow.WindowTitles.Add("Form1")
                End If
                Return Me.mUIWithdrawalTextBoxWindow
            End Get
        End Property
        
        Public ReadOnly Property UIDepositTextBoxWindow() As WinWindow
            Get
                If (Me.mUIDepositTextBoxWindow Is Nothing) Then
                    Me.mUIDepositTextBoxWindow = New WinWindow(Me)
                    Me.mUIDepositTextBoxWindow.SearchProperties(WinWindow.PropertyNames.AccessibleName) = "Deposit amount:"
                    Me.mUIDepositTextBoxWindow.SearchProperties.Add(New PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains))
                    Me.mUIDepositTextBoxWindow.WindowTitles.Add("Form1")
                End If
                Return Me.mUIDepositTextBoxWindow
            End Get
        End Property
        
        Public ReadOnly Property UIGetBalanceWindow() As WinWindow
            Get
                If (Me.mUIGetBalanceWindow Is Nothing) Then
                    Me.mUIGetBalanceWindow = New WinWindow(Me)
                    Me.mUIGetBalanceWindow.SearchProperties(WinWindow.PropertyNames.Name) = "Get Balance"
                    Me.mUIGetBalanceWindow.SearchProperties.Add(New PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.BUTTON", PropertyExpressionOperator.Contains))
                    Me.mUIGetBalanceWindow.WindowTitles.Add("Form1")
                End If
                Return Me.mUIGetBalanceWindow
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUIWithdrawalTextBoxWindow As WinWindow
        
        Private mUIDepositTextBoxWindow As WinWindow
        
        Private mUIGetBalanceWindow As WinWindow
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "15.0.26208.0")>  _
    Public Class UIWithdrawalTextBoxWindow
        Inherits WinWindow
        
        Public Sub New(ByVal searchLimitContainer As UITestControl)
            MyBase.New(searchLimitContainer)
            Me.SearchProperties(WinWindow.PropertyNames.ControlName) = "withdrawalTextBox"
            Me.WindowTitles.Add("Form1")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UIWithdrawalTextBoxEdit() As WinEdit
            Get
                If (Me.mUIWithdrawalTextBoxEdit Is Nothing) Then
                    Me.mUIWithdrawalTextBoxEdit = New WinEdit(Me)
                    Me.mUIWithdrawalTextBoxEdit.WindowTitles.Add("Form1")
                End If
                Return Me.mUIWithdrawalTextBoxEdit
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUIWithdrawalTextBoxEdit As WinEdit
        #End Region
    End Class
    
    <GeneratedCode("Coded UITest Builder", "15.0.26208.0")>  _
    Public Class UIDepositTextBoxWindow
        Inherits WinWindow
        
        Public Sub New(ByVal searchLimitContainer As UITestControl)
            MyBase.New(searchLimitContainer)
            Me.SearchProperties(WinWindow.PropertyNames.ControlName) = "depositTextBox"
            Me.WindowTitles.Add("Form1")
        End Sub
        
        #Region "Properties"
        Public ReadOnly Property UIDepositTextBoxEdit() As WinEdit
            Get
                If (Me.mUIDepositTextBoxEdit Is Nothing) Then
                    Me.mUIDepositTextBoxEdit = New WinEdit(Me)
                    Me.mUIDepositTextBoxEdit.SearchProperties(WinEdit.PropertyNames.Name) = "Deposit amount:"
                    Me.mUIDepositTextBoxEdit.WindowTitles.Add("Form1")
                End If
                Return Me.mUIDepositTextBoxEdit
            End Get
        End Property
        #End Region
        
        #Region "Fields"
        Private mUIDepositTextBoxEdit As WinEdit
        #End Region
    End Class
End Namespace
