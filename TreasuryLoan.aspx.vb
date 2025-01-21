Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class SgcsImp

    Inherits System.Web.UI.Page
    Dim V, V1, V2, V3, V4, V5, V6 As String
    Dim M As Integer
    Dim _refreshState, _isRefresh As Boolean
    Dim Body As String

    Dim COUNT, COUNT1, COUNT2 As Integer

    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA, ADA1, ADA2 As SqlDataAdapter
    Dim CMD, CMD1, CMD2, CMD3 As SqlCommand
    'Dim DR, DR1, dr2, dr3 As SqlDataReader
    Dim DS, DS1, ds2, DS3 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean

    Dim RE As SqlDataReader
    Dim RE1, RE2, RE3 As SqlDataReader
    Public ss As String
    Public PVehno As String
    Dim dr1, dr2, DR3, DR4, DR5, DR6, DR7 As DataRow
    Dim pppp As String
    Dim Todt As String
    Dim Empno, EmpCom, EmpAmt, EmpPayDt, EmpTyp, EmpDecAmt, EmpChqNo, EmpCno As String
    Dim ans1, ans2 As String
    Dim totamt As Double
    Dim sCOM, sEPFNO, SCNam, STEmail, SChqNo, SrefNo, Smsg As String
    Dim sp1, sp2, sp3, sp4, sp6 As String
    Dim MasRefbo, MasIndRcdt, MasIndNos, MasDes, MasCmpnyCode, MasPyTrm, MasIntrm, MasCncy, MasAmt As String

    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Image4 As System.Web.UI.WebControls.Image
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents TEXTAREA1 As System.Web.UI.HtmlControls.HtmlTextArea
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents LinkButton7 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton9 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents LinkButton11 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton12 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton13 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton14 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents LinkButton16 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents LinkButton17 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton15 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtId As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Btt1 As System.Web.UI.WebControls.Button
    Protected WithEvents TxtPwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel9 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If Not IsPostBack Then
            M = 1
        End If

        Global.PwFlag = "N"


    End Sub

    Private Sub TEXTAREA1_ServerChange(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtId.TextChanged
        Global.PUserId = TxtId.Text
        ss = TxtId.Text
        ss = Global.PUserId
        Dim uid As String
        uid = TxtId.Text
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=TreasuryDb; user id=sa;password=tstc123")

        CON.Open()
        'Response.Redirect("ABC.aspx?UID=" & TxtId.Text & "")
        'ADA = New SqlDataAdapter("SELECT * FROM ADMIN WHERE AD_USER = '" & Global.PUserId & "'", CON)
        'DS = New DataSet
        'ADA.Fill(DS, "ADMIN")

        'COUNT = DS.Tables("ADMIN").Rows.Count


        'If COUNT <> 0 Then
        'For Each dr1 In DS.Tables("ADMIN").Rows

        ' Global.PNam = dr1("AD_NAM")
        ' Global.Ppwd = dr1("AD_PWD")
        ' Global.PEmail = dr1("AD_NAM")
        ' Global.PwLevel = dr1("AD_Level")
        ' TxtNam.Text = Global.PNam

        ' Next
        '  End If

        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & Global.PUserId & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        COUNT = DS.Tables("UsdMaster").Rows.Count


        If COUNT <> 0 Then

            For Each dr1 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")

                Global.PNam = dr1("User_name")
                Global.Ppwd = dr1("User_pwd")
                'Global.PEmail = dr1("AD_NAM")
                Global.PwLevel = dr1("User_lvl")
                TxtNam.Text = Global.PNam
                Global.PSec = dr1("User_sec")
                Global.LOGTIME = Date.Today
                Global.Ldate = dr1("User_Ldate")
                Global.Ltime = dr1("User_Time")

            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If
    End Sub

    Private Sub Btt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt1.Click



        Global.PUserId = TxtId.Text
        ss = TxtId.Text
        ss = Global.PUserId
        ' CON.Open()
        'PUserId1 = TxtId.Text

        If TxtPwd.Text = Global.Ppwd Then
            CON = New SqlConnection
            CON.ConnectionString = ("data source=(local);initial catalog=TreasuryDb; user id=sa;password=tstc123")

            CON.Open()

            Global.PwFlag = "Y"

            Dim Cmd As New SqlCommand
            Cmd.Connection = CON

            ss = "UPDATE UsdMaster SET User_Ldate='" & Format(DateValue(Today()), "dd/MM/yyyy") & "',User_Time='" & FormatDateTime(TimeOfDay) & "' WHERE User_id='" & Global.PUserId & "'"
            Cmd.CommandText = ("UPDATE UsdMaster SET User_Ldate='" & Format(DateValue(Today()), "dd/MM/yyyy") & "',User_Time='" & FormatDateTime(TimeOfDay) & "' WHERE User_Code='" & Global.PUserId & "'")
            Cmd.ExecuteNonQuery()



            Dim ss2 As String = Format(Today(), ("MM/dd/yyyy"))
            Dim ss1 As String = Mid(ss, 4, 2) + "/" + Mid(ss, 1, 2) + "/" + Mid(ss, 7, 4)

            ss = (CDate(ss2)).DayOfWeek

            If (CDate(ss2)).DayOfWeek = "1" Then
                ADA = New SqlDataAdapter("SELECT * FROM RepFlag WHERE Rep_Date='" & Trim(ss2) & "'", CON)
                'ADA = New SqlDataAdapter("SELECT * FROM RepFlag ", CON)
                DS1 = New DataSet
                ADA.Fill(DS1, "RepFlag")

                COUNT = DS1.Tables("RepFlag").Rows.Count

            Else

                COUNT = 1
            End If




            If COUNT <> 0 Then
                'Response.Redirect("Dispaly1.aspx")

                'Response.Redirect("Dispaly1.aspx?UID=" & TxtId.Text & "")
                Response.Redirect("DsiTreasury.aspx?UID=" & TxtId.Text & "")
            Else
                Dim Cmd1 As New SqlCommand
                Cmd1.Connection = CON
                Cmd1.CommandText = ("INSERT INTO repflag (Rep_Flag,Rep_EFlg1,Rep_Eflg2,Rep_date) VALUES ('Yes','Yes','Yes','" & ss2 & "')")
                Cmd1.ExecuteNonQuery()


                Dim strfg As String

                Dim cmdCustomers As SqlCommand
                Dim strInvNo As String
                Dim dr1, dr2 As DataRow
                Dim strSql As String
                Dim Count1 As Integer
                Dim strnos As String
                Dim str_no As String
                Dim str_name As String
                Dim str_mail As String
                Dim StrInvcom, Strdt, strtotval, strtotqty, StrInvCode As String

                Todt = Format(Today, "dd/MM/yyyy")

                ADA = New SqlDataAdapter("Select * FROM MasMsg where Mas_flag='No' Order by Mas_com,Mas_Refno", CON)
                DS = New DataSet
                ADA.Fill(DS, "MasMsg")

                Count1 = DS.Tables("MasMsg").Rows.Count

                Dim emailMessage As MailMessage
                emailMessage = New MailMessage

                emailMessage.From = "imports@samsoncorporates.com"

                emailMessage.To = "palithan@samsoncorporates.com"
                emailMessage.Subject = "Pending Indents Documents " + Todt


                emailMessage.Body += "Pending Indents Documents " & vbCrLf
                emailMessage.Body += " " & vbCrLf
                ans2 = "Yes"
                If Count1 <> 0 Then

                    ans1 = "Yes"

                    For Each dr2 In DS.Tables("MasMsg").Rows

                        If ans1 = "Yes" Then
                            SrefNo = Trim(dr2("Mas_Refno"))
                            ans1 = "No"
                            Smsg = Trim(dr2("Mas_msg1"))
                            sCOM = Trim(dr2("Mas_Com"))

                            ADA1 = New SqlDataAdapter("Select * from  MasterDocs where Mas_refno='" & SrefNo & "'", CON)
                            DS1 = New DataSet
                            ADA1.Fill(DS1, "MasterDocs")

                            COUNT2 = DS1.Tables("MasterDocs").Rows.Count
                            For Each DR3 In DS1.Tables("MasterDocs").Rows

                                MasRefbo = Trim(DR3("Mas_Refno"))
                                MasIndRcdt = Format(CDate(DR3("Mas_IndRcDt")), "dd/MM/yyyy")
                                MasIndNos = Trim(DR3("Mas_IndNos"))
                                MasDes = Trim(DR3("Mas_des"))
                                MasCmpnyCode = Trim(DR3("Mas_CmpnyCode"))

                                MasPyTrm = Trim(DR3("Mas_PyTrm"))
                                MasIntrm = Trim(DR3("Mas_InTrm"))
                                MasAmt = Trim(DR3("Mas_Amt"))
                                MasCncy = Trim(DR3("Mas_Cncy"))
                            Next

                            ADA1 = New SqlDataAdapter("Select * From  Email where E_no='" & sCOM & "'", CON)
                            DS1 = New DataSet
                            ADA1.Fill(DS1, "Email")

                            COUNT2 = DS1.Tables("Email").Rows.Count
                            For Each DR4 In DS1.Tables("Email").Rows
                                emailMessage.From = Trim(DR4("E_Fmail"))
                                emailMessage.To = Trim(DR4("E_Tmail"))
                            Next

                            ADA1 = New SqlDataAdapter("Select * FROM CusF where Fno='" & sCOM & "'", CON)
                            DS1 = New DataSet
                            ADA1.Fill(DS1, "Email")

                            COUNT2 = DS1.Tables("Email").Rows.Count
                            For Each DR5 In DS1.Tables("Email").Rows
                                SCNam = Trim(DR5("CoName"))
                            Next


                            emailMessage.Body = "Company :" + "" + SCNam & vbCrLf
                            emailMessage.Body += "=================================================================================================================" & vbCrLf
                            emailMessage.Body += "Rec Date     :-" + MasIndRcdt + "     Our Ref No:-" + MasRefbo & vbCrLf
                            emailMessage.Body += "Description  :-" + MasDes & vbCrLf
                            emailMessage.Body += "Indent Nos(s):-" + MasIndNos & vbCrLf
                            emailMessage.Body += "Payment Term :-" + MasPyTrm + " Inco Term:-" + MasIntrm + " Currency:-" + MasCncy + " Value : " + MasAmt & vbCrLf
                            emailMessage.Body += "-----------------------------------------------------------------------------------------------------------------" & vbCrLf
                            emailMessage.Body += "Massage      :-" + Smsg & vbCrLf
                            emailMessage.Body += "-----------------------------------------------------------------------------------------------------------------" & vbCrLf

                            ' sCOM = Mid(MasIndNos, 1, 3)




                        Else



                            If sCOM = Trim(dr2("Mas_Com")) Then

                                '  EmpCom = Trim(DR3("Mas_CmpnyCode"))


                                sCOM = Trim(dr2("Mas_Com"))
                                SrefNo = Trim(dr2("Mas_Refno"))
                                ans1 = "No"
                                Smsg = Trim(dr2("Mas_msg1"))
                                ADA1 = New SqlDataAdapter("Select * from  MasterDocs where Mas_refno='" & SrefNo & "'", CON)
                                DS1 = New DataSet
                                ADA1.Fill(DS1, "MasterDocs")

                                COUNT2 = DS1.Tables("MasterDocs").Rows.Count
                                For Each DR3 In DS1.Tables("MasterDocs").Rows

                                    MasRefbo = Trim(DR3("Mas_Refno"))
                                    MasIndRcdt = Format(CDate(DR3("Mas_IndRcDt")), "dd/MM/yyyy")
                                    MasIndNos = Trim(DR3("Mas_IndNos"))
                                    MasDes = Trim(DR3("Mas_des"))
                                    MasCmpnyCode = Trim(DR3("Mas_CmpnyCode"))

                                    MasPyTrm = Trim(DR3("Mas_PyTrm"))
                                    MasIntrm = Trim(DR3("Mas_InTrm"))
                                    MasAmt = Trim(DR3("Mas_Amt"))
                                    MasCncy = Trim(DR3("Mas_Cncy"))
                                Next



                                If sCOM = Trim(dr2("Mas_Com")) Then
                                    emailMessage.Body += "=================================================================================================================" & vbCrLf
                                    emailMessage.Body += "Rec Date     :-" + MasIndRcdt + "     Our Ref No:-" + MasRefbo & vbCrLf
                                    emailMessage.Body += "Description  :-" + MasDes & vbCrLf
                                    emailMessage.Body += "Indent Nos(s):-" + MasIndNos & vbCrLf
                                    emailMessage.Body += "Payment Term :-" + MasPyTrm + " Inco Term:-" + MasIntrm + " Currency:-" + MasCncy + " Value : " + MasAmt & vbCrLf
                                    emailMessage.Body += "-----------------------------------------------------------------------------------------------------------------" & vbCrLf
                                    emailMessage.Body += "Massage      :-" + Smsg & vbCrLf
                                    emailMessage.Body += "-----------------------------------------------------------------------------------------------------------------" & vbCrLf

                                Else


                                End If

                                'sCOM = Mid(MasIndNos, 1, 3)

                            Else

                                SmtpMail.SmtpServer = "192.168.40.3"
                                Try
                                    SmtpMail.Send(emailMessage)
                                    'labelStatus.Text = "Message sent!"
                                    'Button1.Enabled = False
                                    ans2 = "No"
                                Catch ex As Exception
                                    'labelStatus.Text = "Unable to send the e-mail message"
                                    ' labelStatus.Text = ex.ToString
                                End Try

                                SrefNo = Trim(dr2("Mas_Refno"))


                                sCOM = Trim(dr2("Mas_Com"))
                                Smsg = Trim(dr2("Mas_msg1"))
                                ADA1 = New SqlDataAdapter("Select * from  MasterDocs where Mas_refno='" & SrefNo & "'", CON)
                                DS1 = New DataSet
                                ADA1.Fill(DS1, "MasterDocs")

                                COUNT2 = DS1.Tables("MasterDocs").Rows.Count
                                For Each DR3 In DS1.Tables("MasterDocs").Rows

                                    MasRefbo = Trim(DR3("Mas_Refno"))
                                    MasIndRcdt = Format(CDate(DR3("Mas_IndRcDt")), "dd/MM/yyyy")
                                    ' MasIndRcdt = Mid(Trim(DR3("Mas_IndRcDt")), 4, 2) + "/" + Mid(Trim(DR3("Mas_IndRcDt")), 1, 2) + "/" + Mid(Trim(DR3("Mas_IndRcDt")), 7, 4)

                                    MasIndNos = Trim(DR3("Mas_IndNos"))
                                    MasDes = Trim(DR3("Mas_des"))
                                    MasCmpnyCode = Trim(DR3("Mas_CmpnyCode"))

                                    MasPyTrm = Trim(DR3("Mas_PyTrm"))
                                    MasIntrm = Trim(DR3("Mas_InTrm"))
                                    MasAmt = Trim(DR3("Mas_Amt"))
                                    MasCncy = Trim(DR3("Mas_Cncy"))


                                Next



                                ADA1 = New SqlDataAdapter("Select * From  Email where E_no='" & sCOM & "'", CON)
                                DS1 = New DataSet
                                ADA1.Fill(DS1, "Email")

                                COUNT2 = DS1.Tables("Email").Rows.Count
                                For Each DR4 In DS1.Tables("Email").Rows
                                    emailMessage.From = Trim(DR4("E_Fmail"))
                                    emailMessage.To = Trim(DR4("E_Tmail"))
                                Next

                                ADA1 = New SqlDataAdapter("Select * FROM CusF where Fno='" & sCOM & "'", CON)
                                DS1 = New DataSet
                                ADA1.Fill(DS1, "Email")

                                COUNT2 = DS1.Tables("Email").Rows.Count
                                For Each DR5 In DS1.Tables("Email").Rows
                                    SCNam = Trim(DR5("CoName"))
                                Next

                                'emailMessage.Body = " " & vbCrLf
                                emailMessage.Body = "Company :" + SCNam & vbCrLf
                                emailMessage.Body += "=================================================================================================================" & vbCrLf
                                emailMessage.Body += "Rec Date     :-" + MasIndRcdt + "     Our Ref No:-" + MasRefbo & vbCrLf
                                emailMessage.Body += "Description  :-" + MasDes & vbCrLf
                                emailMessage.Body += "Indent Nos(s):-" + MasIndNos & vbCrLf
                                emailMessage.Body += "Payment Term :-" + MasPyTrm + " Inco Term:-" + MasIntrm + " Currency:-" + MasCncy + " Value : " + MasAmt & vbCrLf
                                emailMessage.Body += "-----------------------------------------------------------------------------------------------------------------" & vbCrLf
                                emailMessage.Body += "Massage      :-" + Smsg & vbCrLf
                                emailMessage.Body += "-----------------------------------------------------------------------------------------------------------------" & vbCrLf
                                sCOM = Trim(dr2("Mas_Com"))
                                ans2 = "Yes"
                            End If

                        End If


                    Next

                End If

                If ans2 = "Yes" Then

                    SmtpMail.SmtpServer = "192.168.40.3"
                    Try
                        SmtpMail.Send(emailMessage)
                        'labelStatus.Text = "Message sent!"
                        'Button1.Enabled = False
                    Catch ex As Exception
                        'labelStatus.Text="Unable to send the e-mail message"
                        ' labelStatus.Text = ex.ToString
                    End Try

                End If






                '    '---------------------------------------------------------------------------------------------------'
                '    Cmd1.Connection = CON
                '    'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
                '    Cmd1.CommandText = "UPDATE HltMaster1 SET Emp_Eflg1='No' Where Emp_DecFlg='Yes' and Emp_EFlg1='Yes'"
                '    Cmd1.ExecuteNonQuery()
                '    '---------------------------------------------------------------------------------------------------'

                'End If

                'ADA = New SqlDataAdapter("Select HltMaster1.Emp_No as Emp_No ,HthMaster.EmployeeName as EmployeeName,HltMaster1.Emp_Com as Emp_Com,HltMaster1.Emp_Amt as Emp_Amt,convert(varchar(10),HltMaster1.Emp_Recdt,103) as Emp_Recdt,HltMaster1.Emp_Typ as Emp_Typ,HltMaster1.Emp_DecAmt as Emp_DecAmt ,HltMaster1.Emp_ChqNo as Emp_ChqNo,HltMaster1.Emp_CNo from HltMaster1 ,HthMaster where (HltMaster1.Emp_No=HthMaster.Epfno AND HltMaster1.Emp_Com=HthMaster.Com) and  HltMaster1.Emp_DecFlg='No' and HltMaster1.Emp_Eflg2='Yes' Order by HltMaster1.Emp_Com,HltMaster1.Emp_No,HltMaster1.Emp_Chqno", CON)
                'DS = New DataSet
                'ADA.Fill(DS, "HltMaster11")

                'Count1 = DS.Tables("HltMaster11").Rows.Count

                '' Dim emailMessage As MailMessage
                'emailMessage = New MailMessage

                'emailMessage.From = "insurance@samsoncorporates.com"


                'totamt = 0
                'If Count1 <> 0 Then


                '    ans1 = "Yes"
                '    ans2 = "111"
                '    For Each dr2 In DS.Tables("HltMaster11").Rows

                '        If ans1 = "Yes" Then
                '            sCOM = dr2("Emp_com")
                '            ans1 = "No"
                '            ans2 = "No"
                '            ADA1 = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & sCOM & "'", CON)
                '            DS1 = New DataSet
                '            ADA1.Fill(DS1, "Company")
                '            totamt = 0
                '            COUNT2 = DS1.Tables("Company").Rows.Count
                '            For Each DR3 In DS1.Tables("Company").Rows

                '                SCNam = DR3("Com_Nam")
                '                STEmail = DR3("Com_TEmail")
                '            Next

                '            EmpChqNo = dr2("Emp_ChqNo")

                '            emailMessage.Body = "SHE Claims Recieved " & vbCrLf
                '            emailMessage.Body += " " & vbCrLf

                '            emailMessage.Body += "Company :" + "" + SCNam & vbCrLf
                '            emailMessage.Body += "Cheque No :" + "" + EmpChqNo & vbCrLf


                '            emailMessage.Body += "Recieved Date  Epf No       Name                  Submit Amount    Claim Amount" & vbCrLf
                '            emailMessage.Body += "-------------------------------------------------------------------------------" & vbCrLf

                '            EmpCom = dr2("Emp_com")

                '            Empno = dr2("Emp_no")

                '            EmpAmt = dr2("Emp_DecAmt")
                '            EmpPayDt = dr2("Emp_RecDt")
                '            SChqNo = EmpChqNo
                '            ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and Com='" & EmpCom & "'", CON)
                '            DS3 = New DataSet
                '            ss = "SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and com='" & EmpCom & "'"
                '            ADA2.Fill(DS3, "HthMaster")

                '            COUNT2 = DS3.Tables("HthMaster").Rows.Count

                '            If COUNT2 <> 0 Then

                '                For Each DR3 In DS3.Tables("HthMaster").Rows
                '                    SCNam = DR3("EMPLOYEENAME")
                '                Next
                '            End If

                '            EmpAmt = dr2("Emp_DecAmt")
                '            EmpPayDt = dr2("Emp_RecDt")

                '            sp1 = Space(20)
                '            sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                '            sp1 = Right(sp1, 8)

                '            sp2 = Space(6)
                '            sp2 = sp2 + Format(Val(Empno), "#####")
                '            sp2 = Right(sp2, 5)

                '            sp3 = Space(30)
                '            sp3 = SCNam + sp3
                '            sp3 = Left(sp3, 34)
                '            sp4 = Space(20)
                '            sp4 = sp4 + Format(Val(EmpDecAmt), "###,###.00")
                '            sp4 = Right(sp4, 8)



                '            emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp4 + "    " + sp1 + " " & vbCrLf
                '            sCOM = EmpCom
                '            ans2 = "No"

                '            totamt = totamt + Val(EmpAmt)
                '        Else



                '            If sCOM = dr2("Emp_com") Then


                '                If SChqNo <> dr2("Emp_ChqNo") Then
                '                    ' sp1 = Space(20)
                '                    ' sp1 = sp1 + Format(Totamt, "###,###.00")
                '                    ' sp1 = Right(sp1, 8)
                '                    ' emailMessage.Body += "Total Amount                               :" + "" + sp1 & vbCrLf

                '                    ' totamt = 0
                '                    ' SChqNo = dr2("Emp_ChqNo")
                '                    ' emailMessage.Body += "Cheque No :" + "" + EmpChqNo & vbCrLf

                '                Else



                '                    totamt = totamt + Val(dr2("Emp_Amt"))

                '                End If




                '                EmpCom = dr2("Emp_com")
                '                Empno = dr2("Emp_no")
                '                ans2 = "Yes"
                '                ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and Com='" & EmpCom & "'", CON)
                '                DS3 = New DataSet
                '                ss = "SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and com='" & EmpCom & "'"
                '                ADA2.Fill(DS3, "HthMaster")

                '                COUNT2 = DS3.Tables("HthMaster").Rows.Count

                '                If COUNT2 <> 0 Then

                '                    For Each DR3 In DS3.Tables("HthMaster").Rows
                '                        SCNam = DR3("EMPLOYEENAME")

                '                    Next
                '                End If
                '                EmpDecAmt = dr2("Emp_DecAmt")
                '                EmpAmt = dr2("Emp_Amt")
                '                EmpPayDt = dr2("Emp_RecDt")
                '                sp1 = Space(20)
                '                sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                '                sp1 = Right(sp1, 8)

                '                sp2 = Space(6)
                '                sp2 = sp2 + Format(Val(Empno), "#####")
                '                sp2 = Right(sp2, 5)

                '                sp3 = Space(30)
                '                sp3 = SCNam + sp3
                '                sp3 = Left(sp3, 34)

                '                sp4 = Space(20)
                '                sp4 = sp4 + Format(Val(EmpDecAmt), "###,###.00")
                '                sp4 = Right(sp4, 8)



                '                emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp4 + "    " + sp1 + " " & vbCrLf

                '                sCOM = EmpCom







                '            Else


                '                If ans2 = "No" Then
                '                    ADA1 = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & sCOM & "'", CON)
                '                    DS1 = New DataSet
                '                    ADA1.Fill(DS1, "Company")

                '                    COUNT2 = DS1.Tables("Company").Rows.Count
                '                    For Each DR3 In DS1.Tables("Company").Rows

                '                        SCNam = DR3("Com_Nam")
                '                        STEmail = DR3("Com_TEmail")
                '                    Next

                '                    EmpChqNo = dr2("Emp_ChqNo")
                '                    totamt = 0
                '                    emailMessage.Body = "SHE Claims Recieved " & vbCrLf
                '                    emailMessage.Body += " " & vbCrLf

                '                    emailMessage.Body += "Company :" + "" + SCNam & vbCrLf

                '                    emailMessage.Body += "Cheque No :" + "" + EmpChqNo & vbCrLf


                '                    emailMessage.Body += "Submit Date  Epf No       Name                    Submit Amount    Claim Amount" & vbCrLf
                '                    emailMessage.Body += "-------------------------------------------------------------------------------" & vbCrLf

                '                    EmpCom = dr2("Emp_com")

                '                    Empno = dr2("Emp_no")

                '                    EmpAmt = dr2("Emp_DecAmt")
                '                    EmpPayDt = dr2("Emp_RecDt")

                '                    ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and Com='" & EmpCom & "'", CON)
                '                    DS3 = New DataSet
                '                    ss = "SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and com='" & EmpCom & "'"
                '                    ADA2.Fill(DS3, "HthMaster")

                '                    COUNT2 = DS3.Tables("HthMaster").Rows.Count

                '                    If COUNT2 <> 0 Then

                '                        For Each DR3 In DS3.Tables("HthMaster").Rows
                '                            SCNam = DR3("EMPLOYEENAME")

                '                        Next
                '                    End If

                '                    EmpAmt = dr2("Emp_DecAmt")
                '                    EmpPayDt = dr2("Emp_RecDt")

                '                    sp1 = Space(20)
                '                    sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                '                    sp1 = Right(sp1, 8)

                '                    sp2 = Space(6)
                '                    sp2 = sp2 + Format(Val(Empno), "#####")
                '                    sp2 = Right(sp2, 5)

                '                    sp3 = Space(30)
                '                    sp3 = SCNam + sp3
                '                    sp3 = Left(sp3, 34)
                '                    sp4 = Space(20)
                '                    sp4 = sp4 + Format(Val(EmpDecAmt), "###,###.00")
                '                    sp4 = Right(sp4, 8)



                '                    emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp4 + "    " + sp1 + " " & vbCrLf
                '                    sCOM = EmpCom
                '                    ans2 = "Yes"
                '                    totamt = totamt + Val(EmpAmt)
                '                End If

                '                emailMessage.To = Trim(STEmail)
                '                emailMessage.Subject = "SHE Claims Recieved " + Todt


                '                SmtpMail.SmtpServer = "192.168.40.3"
                '                Try
                '                    SmtpMail.Send(emailMessage)
                '                    'labelStatus.Text = "Message sent!"
                '                    'Button1.Enabled = False
                '                Catch ex As Exception
                '                    'labelStatus.Text="Unable to send the e-mail message"
                '                    ' labelStatus.Text = ex.ToString
                '                End Try





                '                emailMessage.Body += " " & vbCrLf

                '                sCOM = dr2("Emp_com")

                '                ADA1 = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & sCOM & "'", CON)
                '                DS1 = New DataSet
                '                ADA1.Fill(DS1, "Company")

                '                COUNT2 = DS1.Tables("Company").Rows.Count
                '                For Each DR3 In DS1.Tables("Company").Rows

                '                    SCNam = DR3("Com_Nam")
                '                    STEmail = DR3("Com_TEmail")
                '                Next

                '                EmpChqNo = dr2("Emp_ChqNo")
                '                emailMessage.Body = "SHE Claims Recieved " & vbCrLf
                '                emailMessage.Body += " " & vbCrLf
                '                emailMessage.Body += "Company :" + "" + SCNam & vbCrLf
                '                emailMessage.Body += "Cheque No :" + "" + EmpChqNo & vbCrLf

                '                totamt = 0
                '                emailMessage.Body += "Submit Date  Epf No       Name                    Submit Amount  Claim Amount" & vbCrLf
                '                emailMessage.Body += "-----------------------------------------------------------------------------" & vbCrLf



                '                EmpCom = dr2("Emp_com")

                '                Empno = dr2("Emp_no")

                '                EmpAmt = dr2("Emp_DecAmt")
                '                EmpPayDt = dr2("Emp_RecDt")

                '                ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and Com='" & EmpCom & "'", CON)
                '                DS3 = New DataSet
                '                ss = "SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and com='" & EmpCom & "'"
                '                ADA2.Fill(DS3, "HthMaster")

                '                COUNT2 = DS3.Tables("HthMaster").Rows.Count

                '                If COUNT2 <> 0 Then

                '                    For Each DR3 In DS3.Tables("HthMaster").Rows
                '                        SCNam = DR3("EMPLOYEENAME")

                '                    Next
                '                End If

                '                EmpAmt = dr2("Emp_DecAmt")
                '                EmpPayDt = dr2("Emp_RecDt")

                '                sp1 = Space(20)
                '                sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                '                sp1 = Right(sp1, 8)

                '                sp2 = Space(6)
                '                sp2 = sp2 + Format(Val(Empno), "#####")
                '                sp2 = Right(sp2, 5)

                '                sp3 = Space(30)
                '                sp3 = SCNam + sp3
                '                sp3 = Left(sp3, 34)
                '                sp4 = Space(20)
                '                sp4 = sp4 + Format(Val(EmpDecAmt), "###,###.00")
                '                sp4 = Right(sp4, 8)



                '                emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp4 + "    " + sp1 + " " & vbCrLf
                '                sCOM = EmpCom
                '                totamt = totamt + Val(EmpAmt)

                '            End If

                '        End If

                '    Next



                '    '---------------------------------------------------------------------------------------------------'
                '    Cmd1.Connection = CON
                '    'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
                '    Cmd1.CommandText = "UPDATE HltMaster1 SET Emp_Eflg2='No' Where Emp_DecFlg='No' and Emp_EFlg2='Yes'"
                '    Cmd1.ExecuteNonQuery()
                '    '---------------------------------------------------------------------------------------------------'


                Response.Redirect("sgcsSHE1.aspx?UID=" & TxtId.Text & "")

                'Response.Redirect("Dispaly1.aspx")




            End If



        End If



            ' End If






    End Sub
End Class
