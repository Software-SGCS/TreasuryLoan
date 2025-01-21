
Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Public Class Entry9
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS, DS1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim drt2, drt3 As DataRow
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim CRI1, CRI2, CRI3 As String
    Dim str1, str2 As String
    Dim Sinvno As String
    Dim TempEmpno, TempCom As String
    Dim ss As String
    Dim Tno As String
    Dim Tno1 As String
    Dim Tno2 As String
    Dim count1, Count2 As Integer
    Dim StrEmpno, StrEmpCom, StrEmpNam, strEmpIdno, strEmpAdd, StrEmpDoA, BODY, SS1 As String
    Dim TT As String
    Protected WithEvents TxtRefno As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtIndentNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtComNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstBnk As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtDes As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtHScd As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstPay As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstInc As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstCncy As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtRecDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents LstSup As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents btt1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents LstFlg1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstFlg2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstFlg3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents labelStatus As System.Web.UI.WebControls.Label
    Protected WithEvents Panel9 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents LstRefno As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtVal As System.Web.UI.WebControls.TextBox

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label

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
        'Put user code to initialize the page here
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")

        CON.Open()
        If Not IsPostBack Then


            If Not IsPostBack Then
                ' TxtRefno.Text = HttpContext.Current.Request.QueryString("Type").ToString()

                'InvNo11 = "T-00445"

                '-------------------
                TxtIndentNo.ReadOnly = True

                Calendar1.Visible = False
                'Calendar2.Visible = False

                CMD = New SqlCommand("SELECT Mas_Refno FROM MasterDocs Where Mas_Entry1='Yes'", CON)
                'ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where Mas_RefNo='" & Trim(TxtRefno.Text) & "'", CON)
                DR = CMD.ExecuteReader


                While DR.Read
                    TT = DR.GetValue(0)

                    LstRefno.Items.Add(TT)
                End While
                DR.Close()

                ADA = New SqlDataAdapter("SELECT Mas_ReFno,Mas_IndNos,Mas_IndRcDt,Mas_flag1,Mas_flag2,Mas_flag3,Mas_Des,Mas_HsCode,Mas_Amt,Mas_Entry1 FROM MasterDocs Where Mas_RefNo='" & Trim(LstRefno.SelectedValue) & "'", CON)

                DS = New DataSet
                ADA.Fill(DS, "MasterDocs")

                count1 = DS.Tables("MasterDocs").Rows.Count


                If count1 <> 0 Then

                    For Each drt2 In DS.Tables("MasterDocs").Rows

                        TxtRefno.Text = drt2("Mas_ReFno")
                        TxtIndentNo.Text = drt2("Mas_IndNos")
                        ss = Format(drt2("Mas_IndRcDt"), "dd/MM/yyyy")
                        TxtRecDt.Text = ss
                        ss = IIf(IsDBNull(drt2("Mas_Des")) = True, "", Trim(drt2("Mas_Des")))
                        'ss = drt2("Mas_HsCode")
                        'ss = drt2("Mas_Amt")
                        ' LstFlg1.SelectedValue = drt2("Mas_flag1")
                        LstFlg1.Text = Trim(drt2("Mas_flag1"))
                        LstFlg2.Text = Trim(drt2("Mas_flag2"))
                        LstFlg3.Text = Trim(drt2("Mas_flag3"))

                        TxtDes.Text = IIf(Trim(drt2("Mas_Des")) = "*", "", Trim(drt2("Mas_Des")))
                        TxtHScd.Text = IIf(Trim(drt2("Mas_HsCode")) = "*", "", Trim(drt2("Mas_HsCode")))
                        TxtVal.Text = IIf(Trim(drt2("Mas_Amt")) = "0", "", Trim(drt2("Mas_Amt")))
                        If Trim(drt2("Mas_Entry1")) = "Ok" Then
                            LstSup.Visible = False
                            LstBnk.Visible = False
                            TxtDes.ReadOnly = True
                            TxtHScd.ReadOnly = True
                            LstInc.Visible = False
                            LstPay.Visible = False
                            LstCncy.Visible = False
                            TxtVal.ReadOnly = True
                            BtnSave.Enabled = False


                        Else
                            LstSup.Visible = True
                            LstBnk.Visible = True
                            TxtDes.ReadOnly = False
                            TxtHScd.ReadOnly = False
                            LstInc.Visible = True
                            LstPay.Visible = True
                            LstCncy.Visible = True
                            TxtVal.ReadOnly = False
                            BtnSave.Enabled = True

                        End If



                        ADA1 = New SqlDataAdapter("SELECT * FROM CUSF Where FNO='" & Mid(Trim(TxtIndentNo.Text), 1, 3) & "'", CON)

                        DS = New DataSet
                        ADA1.Fill(DS, "CUSF")

                        count1 = DS.Tables("CUSF").Rows.Count

                        For Each drt3 In DS.Tables("CUSF").Rows

                            TxtComNam.Text = Trim(drt3("Coname"))


                        Next
                    Next
                End If

            End If


            CMD = New SqlCommand("SELECT Bnk_Code,Bnk_Nam From Bank", CON)

            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                LstBnk.Items.Add(TT)
            End While


            DR.Close()
        End If
        If Not IsPostBack Then
            CMD = New SqlCommand("SELECT Cncy From cusk", CON)

            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(0)
                LstCncy.Items.Add(TT)
            End While
            DR.Close()
        End If

        If Not IsPostBack Then
            CMD = New SqlCommand("SELECT Pay_Code,Pay_Des From PaymentTerm", CON)

            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                LstPay.Items.Add(TT)
            End While
            DR.Close()
        End If

        If Not IsPostBack Then
            CMD = New SqlCommand("SELECT * FROM IncoTerm", CON)

            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(0)
                LstInc.Items.Add(TT)
            End While
            DR.Close()
        End If

        If Not IsPostBack Then
            CMD = New SqlCommand("SELECT EXNO,CNAME,CMADE FROM Supplier", CON)

            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(0) + "-" + DR.GetValue(1) + "-" + DR.GetValue(2)
                LstSup.Items.Add(TT)
            End While
            DR.Close()

            Calendar1.Visible = False






        End If








    End Sub

    Private Sub btt1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btt1.Click
        Calendar1.Visible = True
        LstBnk.Visible = False
        LstSup.Visible = False
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TxtRecDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar1.Visible = False
        LstBnk.Visible = True
        LstSup.Visible = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        '  Dim DeleteCmd1 As String = "DELETE from InlPur where Inv_no='" & LstInvNo.SelectedValue & "'"

        Dim Cmd As New SqlCommand("SELECT * FROM MasterDocs", CON)
        Cmd.ExecuteNonQuery()
        ss = Format(Today(), "MM/dd/yyyy")
        'Cmd.Connection = CON

        SS1 = "UPDATE MasterDocs SET Mas_Entry1='Ok',Mas_Entry2='Yes',Mas_Entry2Dt='" & ss & "',Mas_CompnyCode='" & Mid(Trim(TxtIndentNo.Text), 1, 3) & "',Mas_SupCode='" & Mid(Trim(LstSup.SelectedValue), 1, 3) & "',Mas_BnkCode='" & Mid(Trim(LstBnk.SelectedValue), 1, 3) & "',Mas_Des='" & Trim(TxtDes.Text) & "',Mas_HsCode='" & Trim(TxtHScd.Text) & "',Mas_PyTrm='" & Mid(Trim(LstInc.SelectedValue), 1, 3) & "',Mas_InTrm='" & Mid(Trim(LstPay.SelectedValue), 1, 3) & "',Mas_cncy='" & Mid(Trim(LstCncy.SelectedValue), 1, 3) & "',Mas_Amt=" & TxtVal.Text & " WHERE Mas_Refno='" & Trim(TxtRefno.Text) & "'"
        ',Mas_CompnyCode='" & Mid(Trim(TxtIndentNo.Text), 1, 3) & "',Mas_SupCode='" & Mid(Trim(LstSup.SelectedValue), 1, 3) & "',Mas_BnkCode='" & Mid(Trim(LstBnk.SelectedValue), 1, 3) & "',Mas_Des='" & Trim(TxtDes.Text) & "',Mas_HsCode='" & Trim(TxtHScd.Text) & "',Mas_PyTrm='" & Mid(Trim(LstInc.SelectedValue), 1, 3) & "',Mas_InTrm='" & Mid(Trim(LstPay.SelectedValue), 1, 3) & "',Mas_cncy='" & Mid(Trim(LstCncy.SelectedValue), 1, 3) & "',Mas_Amt='" & TxtVal.Text & "' WHERE Mas_Refno='" & Trim(TxtRefno.Text) & "'"

        ' Cmd.CommandText = ("UPDATE MasterDocs SET Mas_Entry1='Ok',Mas_Entry2='Yes',Mas_Entry2Dt='" & ss & "',Mas_CompnyCode='" & Mid(Trim(TxtIndentNo.Text), 1, 3) & "',Mas_SupCode='" & Mid(Trim(LstSup.SelectedValue), 1, 3) & "',Mas_BnkCode='" & Mid(Trim(LstBnk.SelectedValue), 1, 3) & "',Mas_Des='" & Trim(TxtDes.Text) & "',Mas_HsCode='" & Trim(TxtHScd.Text) & "',Mas_PyTrm='" & Mid(Trim(LstInc.SelectedValue), 1, 3) & "',Mas_InTrm='" & Mid(Trim(LstPay.SelectedValue), 1, 3) & "',Mas_cncy='" & Mid(Trim(LstCncy.SelectedValue), 1, 3) & "',Mas_Amt=" & TxtVal.Text & " WHERE Mas_Refno='" & Trim(TxtRefno.Text) & "'")

        Cmd.CommandText = ("UPDATE MasterDocs SET Mas_Entry1='Ok',Mas_Entry2='Yes',Mas_Entry2Dt='" & ss & "',Mas_SupCode='" & Mid(Trim(LstSup.SelectedValue), 1, 3) & "',Mas_CmpnyCode='" & Mid(Trim(TxtIndentNo.Text), 1, 3) & "',Mas_BnkCode='" & Mid(Trim(LstBnk.SelectedValue), 1, 3) & "',Mas_Des='" & Trim(TxtDes.Text) & "',Mas_HsCode='" & Trim(TxtHScd.Text) & "',Mas_PyTrm='" & Mid(Trim(LstInc.SelectedValue), 1, 3) & "',Mas_InTrm='" & Mid(Trim(LstPay.SelectedValue), 1, 3) & "',Mas_cncy='" & Mid(Trim(LstCncy.SelectedValue), 1, 3) & "',Mas_Amt=" & TxtVal.Text & " WHERE Mas_Refno='" & Trim(TxtRefno.Text) & "'")
        Cmd.ExecuteNonQuery()
        BtnSave.Enabled = False

        If LstFlg1.Text = "Yes" Or LstFlg2.Text = "Yes" Or LstFlg3.Text = "Yes" Then
            '----------------
            BODY += "<table width='1000' border='0'>"
            BODY += "<tr>"
            BODY += "<td width='10' height='40'><form id='form3' name='form3' method='post' action=''>"
            BODY += "<label></label>"
            BODY += "<label></label>"
            BODY += "<label></label>"
            BODY += "<label>"
            BODY += "<input type='image' name='imageField3' src='http://192.168.12.165\SgcsImp\Menu\rotate3.GIF' />"
            BODY += "</label>"
            BODY += "</form>    </td>"
            BODY += "<td width='750'><form id='form2' name='form2' method='post' action=''>"
            BODY += "<label></label>"
            BODY += "<label></label>"
            BODY += "<label></label>"
            BODY += "<input type='image' name='imageField' src='http://192.168.12.165\SgcsImp\Menu\banner.jpg' />"
            BODY += "</form>    </td>"

            BODY += "<td width='100'>&nbsp;</td>"
            BODY += "</tr>"
            BODY += "<tr>"
            BODY += "<td height='174'><form id='form4' name='form4' method='post' action=''>"
            BODY += "<label>"
            BODY += "<input type='image' name='imageField2' src='http://192.168.12.165\SgcsImp\Menu\Audit.gif' />"
            BODY += "</label>"
            BODY += "</form>    </td>"
            BODY += "<td><form id='form1' name='form1' method='post' action=''>"
            BODY += "<table width='525' height='126' border='0'>"
            BODY += "<tr>"
            BODY += "<td height='33'><label>Reference No</label></td>"
            BODY += "<td>" & TxtRefno.Text & "</td>"
            BODY += "<td>&nbsp;</td>"
            BODY += "</tr>"
            BODY += "<tr>"
            BODY += "<td width='155' height='30'><label>Indent No(s):</label></td>"
            BODY += "<td width='169'>" & Trim(TxtIndentNo.Text) & "</td>"
            BODY += "<td width='187'>&nbsp;</td>"
            BODY += "</tr>"

            BODY += "<tr>"
            BODY += "<td width='155' height='30'><label>Company</label></td>"
            BODY += "<td width='169'>" & Mid(Trim(TxtIndentNo.Text), 1, 3) & "</td>"
            BODY += "<td width='187'>&nbsp;</td>"
            BODY += "</tr>"
            BODY += "<tr>"
            BODY += "<td height='25'><label>Received Date</label></td>"
            BODY += "<td>" & TxtRecDt.Text & "</td>"
            BODY += "<td>&nbsp;</td>"
            BODY += "</tr>"
           


            BODY += "</table>"
            BODY += "<label></label>"
            BODY += "<label></label>"
            BODY += "</form>    </td>"
            BODY += "<td>&nbsp;</td>"
            BODY += "</tr>"
            BODY += " <tr><td align='left' colSpan='2'><table width='200' border='0'>"
            If LstFlg1.Text = "Yes" Then

                BODY += "<tr>"
                BODY += "<td><form method='post' action=http://192.168.12.165/SgcsImp/Entry3.aspx?TYPE=" & Trim(TxtRefno.Text) & " name='frm1'><input name='sbb1' type='image' src='http://192.168.12.165\SgcsImp\Menu\insuranceIcon.jpg' width='100' height='30'> </form></td>"
                'BODY += "</tr>"
            End If

            If LstFlg2.Text = "Yes" Then
                ' BODY += " <tr><td align='left' colSpan='2'><table width='200' border='0'>"
                BODY += "<tr>"
                BODY += "<td><form method='post' action=http://192.168.12.165/SgcsImp/Entry4.aspx?TYPE=" & Trim(TxtRefno.Text) & " name='frm1'><input name='sbb1' type='image' src='http://192.168.12.165\SgcsImp\Menu\LicenseIcon.jpg' width='100' height='30'> </form></td>"
                'BODY += "</tr>"
            End If

            If LstFlg3.Text = "Yes" Then
                'BODY += " <tr><td align='left' colSpan='2'><table width='200' border='0'>"
                BODY += "<tr>"
                BODY += "<td><form method='post' action=http://192.168.12.165/SgcsImp/Entry5.aspx?TYPE=" & Trim(TxtRefno.Text) & " name='frm1'><input name='sbb1' type='image' src='http://192.168.12.165\SgcsImp\Menu\ApprvalIcon.jpg' width='100' height='30'> </form></td>"

            End If
            BODY += "</tr>"

            BODY += "</table>"

            BODY += "</td>"


            BODY += "<td align='left' colSpan='2'>&nbsp;</td>"


            BODY += "<td width='163' colSpan='3' align='left'>&nbsp;</td>"
            BODY += "<td></td>"
            BODY += "</tr>"

            BODY += "</table>"

            Dim emailMessage1 As MailMessage
            emailMessage1 = New MailMessage

            ' emailMessage1.To = "palithan@samsoncorporates.com"
            ADA = New SqlDataAdapter("SELECT * FROM Email WHERE E_No='3'", CON)
            DS = New DataSet
            ADA.Fill(DS, "Email")

            count1 = DS.Tables("Email").Rows.Count


            If count1 <> 0 Then
                For Each drt2 In DS.Tables("Email").Rows

                    emailMessage1.From = Trim(drt2("E_Fmail"))

                    emailMessage1.To = Trim(drt2("E_Tmail"))

                Next
            End If




            emailMessage1.Subject = "Indent No(s): " + Trim(TxtIndentNo.Text) + " " + " Receveid Date :" + Trim(TxtRecDt.Text) + " For your Attention"
            emailMessage1.Body = BODY
            emailMessage1.BodyFormat = MailFormat.Html




            SmtpMail.SmtpServer = "192.168.40.3"

            Try
                SmtpMail.Send(emailMessage1)
                labelStatus.Text = "Message sent!"
                'Button1.Enabled = False
            Catch ex As Exception
                'labelStatus.Text="Unable to send the e-mail message"
                labelStatus.Text = ex.ToString
            End Try

            '---------------
        End If

    End Sub

    Private Sub LstPay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstPay.SelectedIndexChanged

    End Sub

    Private Sub LstRefno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstRefno.SelectedIndexChanged
        ADA = New SqlDataAdapter("SELECT Mas_ReFno,Mas_IndNos,Mas_IndRcDt,Mas_flag1,Mas_flag2,Mas_flag3,Mas_Des,Mas_HsCode,Mas_Amt,Mas_Entry1 FROM MasterDocs Where Mas_RefNo='" & Trim(LstRefno.SelectedValue) & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "MasterDocs")

        count1 = DS.Tables("MasterDocs").Rows.Count


        If count1 <> 0 Then

            For Each drt2 In DS.Tables("MasterDocs").Rows

                TxtRefno.Text = drt2("Mas_ReFno")
                TxtIndentNo.Text = drt2("Mas_IndNos")
                ss = Format(drt2("Mas_IndRcDt"), "dd/MM/yyyy")
                TxtRecDt.Text = ss
                ss = IIf(IsDBNull(drt2("Mas_Des")) = True, "", Trim(drt2("Mas_Des")))
                'ss = drt2("Mas_HsCode")
                'ss = drt2("Mas_Amt")
                ' LstFlg1.SelectedValue = drt2("Mas_flag1")
                LstFlg1.Text = Trim(drt2("Mas_flag1"))
                LstFlg2.Text = Trim(drt2("Mas_flag2"))
                LstFlg3.Text = Trim(drt2("Mas_flag3"))

                TxtDes.Text = IIf(Trim(drt2("Mas_Des")) = "*", "", Trim(drt2("Mas_Des")))
                TxtHScd.Text = IIf(Trim(drt2("Mas_HsCode")) = "*", "", Trim(drt2("Mas_HsCode")))
                TxtVal.Text = IIf(Trim(drt2("Mas_Amt")) = "0", "", Trim(drt2("Mas_Amt")))
                If Trim(drt2("Mas_Entry1")) = "Ok" Then
                    LstSup.Visible = False
                    LstBnk.Visible = False
                    TxtDes.ReadOnly = True
                    TxtHScd.ReadOnly = True
                    LstInc.Visible = False
                    LstPay.Visible = False
                    LstCncy.Visible = False
                    TxtVal.ReadOnly = True
                    BtnSave.Enabled = False


                Else
                    LstSup.Visible = True
                    LstBnk.Visible = True
                    TxtDes.ReadOnly = False
                    TxtHScd.ReadOnly = False
                    LstInc.Visible = True
                    LstPay.Visible = True
                    LstCncy.Visible = True
                    TxtVal.ReadOnly = False
                    BtnSave.Enabled = True

                End If



                ADA1 = New SqlDataAdapter("SELECT * FROM CUSF Where FNO='" & Mid(Trim(TxtIndentNo.Text), 1, 3) & "'", CON)

                DS = New DataSet
                ADA1.Fill(DS, "CUSF")

                count1 = DS.Tables("CUSF").Rows.Count

                For Each drt3 In DS.Tables("CUSF").Rows

                    TxtComNam.Text = Trim(drt3("Coname"))


                Next
            Next
        End If





    End Sub
End Class
