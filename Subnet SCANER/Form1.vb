Imports System.Net.NetworkInformation

Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
        Button1.Enabled = True
        Button3.Enabled = False
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Dim jk As String
        jk = TextBox1.Text + "." + TextBox3.Text + "." + TextBox4.Text + "." + TextBox2.Text
        If My.Computer.Network.Ping(jk) Then
            ListBox1.Items.Add(jk + "   Online")
            TextBox2.Text = Val(TextBox2.Text) + 1
        Else
            ListBox1.Items.Add(jk + "   Offline")
            TextBox2.Text = Val(TextBox2.Text) + 1
        End If
        Button1.Enabled = False
        Button3.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim range = TextBox1.Text
        Dim fip = Val(TextBox2.Text)
        Dim ip = TextBox1.Text + TextBox2.Text
        ip = TextBox1.Text + "." + TextBox3.Text + "." + TextBox4.Text + "." + TextBox2.Text
        If My.Computer.Network.Ping(ip) Then
            ListBox1.Items.Add(ip + "   Online")
            TextBox2.Text = fip + 1
        Else
            ListBox1.Items.Add(ip + "   Offline")
            TextBox2.Text = fip + 1
        End If
        If TextBox2.Text = 255 Then
            Timer1.Stop()
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            Button1.Enabled = True
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub


End Class
