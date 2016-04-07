Public Class frmATDBLOCK

    ''Used global variables to pass between different buttons
    Dim INCNUM, PREVSRC, PREVDST, SRCIP, SRCHST, SRCLOCA, DSTIP, DSTDOM, DSTURL, DSTFILE, VIRUSTOT, URLV, UNAME, RNAME, ROLE, DEPT, CHKTOP, CHKNUQ, SUMMAR, ATDBHNDOVER As String

    Private Sub btnBTC_Click(sender As Object, e As EventArgs) Handles btnBTC.Click

        ''Create text output for handover
        ATDBHNDOVER = INCNUM + " - ATD Block" + vbNewLine + SUMMAR

        ''Just for testing output for handover Should remove and replace with something to pass to handover form
        MessageBox.Show(ATDBHNDOVER)


        ''Close self and return to checklists
        Me.Close()
        frmChecklists.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ''Checkbox for net user query
        If cbNUQA.Checked = True Then
            CHKNUQ = "Attached"
            MessageBox.Show("Remember to attach net user query to incident journal")
        Else
            CHKNUQ = "Not attached"
            MessageBox.Show("Net user query is required")

        End If

        ''Checkbox for top 3 tier
        If cbTOP3.Checked = True Then
            CHKTOP = "Yes"
            MessageBox.Show("Please escelate to L2 due to user being in the top three tiers")
        Else
            CHKTOP = "No"

        End If

        ''Basic info
        INCNUM = txtINCNUM.Text
        PREVSRC = txtPREVSRC.Text
        PREVDST = txtPREVDST.Text

        ''Source info
        SRCIP = txtSRCIP.Text
        SRCHST = txtSRCHOST.Text
        SRCLOCA = txtSCRLOCA.Text

        ''Destination info
        DSTIP = txtDSTIP.Text
        DSTDOM = txtDSTDOM.Text
        DSTURL = txtDSTURL.Text
        DSTFILE = txtFILENAME.Text
        VIRUSTOT = txtVTSCORE.Text
        URLV = txtURLVSCORE.Text

        ''User info
        UNAME = txtUNAME.Text
        RNAME = txtRNAME.Text
        ROLE = txtTITLE.Text
        DEPT = txtDEPT.Text

        ''Summary
        SUMMAR = txtSUMM.Text

        ''Output vomit
        rtbOUTPUT.Text = "Previous Incidents" + vbNewLine + "Previous based on source: " + PREVSRC + vbNewLine + "Previous based on destination: " + PREVDST + vbNewLine + vbNewLine & _
            "User Details" + vbNewLine + "User: " + UNAME + vbNewLine + "Name: " + RNAME + vbNewLine + "Job Title: " + ROLE + vbNewLine + "Department: " + DEPT + vbNewLine & _
            "Is user in top 3 tiers? " + CHKTOP + vbNewLine + "Net user query attached? " + CHKNUQ + vbNewLine + vbNewLine & _
            "Source" + vbNewLine + "IP Address: " + SRCIP + vbNewLine + "Hostname: " + SRCHST + vbNewLine + "Location: " + SRCLOCA + vbNewLine + vbNewLine & _
            "Destination" + vbNewLine + "IP Address: " + DSTIP + vbNewLine + "Domain: " + DSTDOM + vbNewLine + "URL: " + DSTURL + vbNewLine + "File Name: " + DSTFILE + vbNewLine & _
            "VirusTotal: " + VIRUSTOT + vbNewLine + "URLVoid: " + URLV + vbNewLine + vbNewLine + "Summary" + vbNewLine + SUMMAR




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''Open URL form
        frmURLS.Show()
    End Sub
End Class