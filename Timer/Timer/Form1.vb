﻿Public Class frm_timer

    Private Sub frm_timer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmr_jam.Enabled = True

    End Sub

    Private Sub tmr_jam_Tick(sender As Object, e As EventArgs) Handles tmr_jam.Tick
        Dim jam As Date = Date.Now

        lbl_jam.Text = jam.ToString("hh:mm:ss")
        txt_jam.Text = jam.ToString("hh:mm:ss")
        dtp_jam.Value = jam

    End Sub
End Class
