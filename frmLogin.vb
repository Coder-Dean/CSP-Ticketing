Imports System.IO

Public Class frmLogin

    Public Sub frmLogin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        txtUsername.Text = ""
        txtPassword.Text = ""

    End Sub

    Public Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim i As Integer = 0
            Dim tmp_str As String

            password_privilege = PRIVILEGE_NONE
            passwordOk = False
            cancel_clicked = False
            tmp_str = txtPassword.Text
            user_name = txtUsername.Text

            If tmp_str = "" Then    'clicked ok without typing
                Me.Close()
            Else
                While passwordOk = False And i < 4
                    If UserLogin(i) = tmp_str Then
                        password_privilege = PRIVILEGE_USER
                        passwordOk = True
                    ElseIf AdminLogin(i) = tmp_str Then
                        password_privilege = PRIVILEGE_ADMIN
                        passwordOk = True
                    ElseIf PrivilegedLogin(i) = tmp_str Then
                        password_privilege = PRIVILEGE_SUPERUSER
                        passwordOk = True
                    End If
                    i = i + 1
                End While
                If passwordOk = False Then  'tell user error and wait for new password
                    MsgBox("Password not found.", MsgBoxStyle.OkOnly, "Password Error")
                ElseIf passwordOk = True Then   'found password so quit
                    Me.Close()
                End If
            End If

        Catch err As Exception
            MsgBox(err.Message, MsgBoxStyle.OkOnly, "Login Error")
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        passwordOk = False
        cancel_clicked = True
        Me.Close()
    End Sub

End Class
