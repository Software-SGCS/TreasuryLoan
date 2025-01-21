
Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Public Class Entry10
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
    Protected WithEvents TxtDes As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtHScd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
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
    Protected WithEvents LstFlg1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstFlg2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstFlg3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents labelStatus As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtBnk As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtSup As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Imagebutton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents txtCncy As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtPay As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtRecDate As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtAppDate As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInc As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel8 As System.Web.UI.WebControls.Panel
    Protected WithEvents LsRefno As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents ImageButton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents TxtIn As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtAdv As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtExpDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents Imagebutton3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Calendar3 As System.Web.UI.WebControls.Calendar
    Protected WithEvents LstDraft As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label21 As System.Web.UI.WebControls.Label
    Protected WithEvents Label22 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtLcNo As System.Web.UI.WebControls.TextBox
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
            TxtIndentNo.ReadOnly = True

            Calendar1.Visible = False
            Calendar2.Visible = False
            Calendar3.Visible = False
            CMD = New SqlCommand("SELECT Mas_Refno FROM MasterDocs Where Mas_InTrm='LC'", CON)
            'ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where Mas_RefNo='" & Trim(TxtRefno.Text) & "'", CON)
            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(0)

                LsRefno.Items.Add(TT)
            End While
            DR.Close()

            CMD = New SqlCommand("SELECT LcType from LcType", CON)
            'ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where Mas_RefNo='" & Trim(TxtRefno.Text) & "'", CON)
            DR = CMD.ExecuteReader

            LstDraft.Items.Clear()
            While DR.Read
                TT = DR.GetValue(0)

                LstDraft.Items.Add(TT)
            End While
            DR.Close()





            ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where Mas_RefNo='" & Trim(LsRefno.SelectedValue) & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "MasterDocs")
            BtnSave.Enabled = True
            count1 = DS.Tables("MasterDocs").Rows.Count

            If count1 <> 0 Then

                For Each drt2 In DS.Tables("MasterDocs").Rows

                    TxtRefno.Text = drt2("Mas_ReFno")
                    TxtIndentNo.Text = drt2("Mas_IndNos")
                    ss = Format(drt2("Mas_IndRcDt"), "dd/MM/yyyy")
                    TxtRecDt.Text = ss
                    ' ss = IIf(IsDBNull(drt2("Mas_Des")) = True, "", Trim(drt2("Mas_Des")))
                    'ss = drt2("Mas_HsCode")
                    'ss = drt2("Mas_Amt")
                    ' LstFlg1.SelectedValue = drt2("Mas_flag1")
                    LstFlg1.Text = Trim(drt2("Mas_flag1"))
                    LstFlg2.Text = Trim(drt2("Mas_flag2"))
                    LstFlg3.Text = Trim(drt2("Mas_flag3"))

                    TxtDes.Text = IIf(Trim(drt2("Mas_Des")) = "*", "", Trim(drt2("Mas_Des")))
                    TxtHScd.Text = IIf(Trim(drt2("Mas_HsCode")) = "*", "", Trim(drt2("Mas_HsCode")))
                    TxtVal.Text = IIf(Trim(drt2("Mas_Amt")) = "0", "", Trim(drt2("Mas_Amt")))
                    TxtPay.Text = IIf(Trim(drt2("Mas_PyTrm")) = "*", "", Trim(drt2("Mas_PyTrm")))
                    txtCncy.Text = IIf(Trim(drt2("Mas_cncy")) = "*", "", Trim(drt2("Mas_cncy")))
                    txtInc.Text = IIf(Trim(drt2("Mas_InTrm")) = "*", "", Trim(drt2("Mas_InTrm")))



                    If Trim(drt2("Mas_flag1")) = "Yes" Then
                        ' TxtSup.Visible = False
                        'TxtBnk.Visible = False
                        'TxtDes.ReadOnly = True
                        'TxtHScd.ReadOnly = True
                        'txtInc.Visible = False
                        ' TxtPay.Visible = False
                        'txtCncy.Visible = False
                        'TxtVal.ReadOnly = True
                        ' BtnSave.Enabled = False


                    Else
                        'TxtSup.Visible = True
                        'TxtBnk.Visible = True
                        'TxtDes.ReadOnly = False
                        'TxtHScd.ReadOnly = False
                        'txtInc.Visible = True
                        'TxtPay.Visible = True
                        'txtCncy.Visible = True
                        ' TxtVal.ReadOnly = False
                        'BtnSave.Enabled = True

                    End If



                    ADA1 = New SqlDataAdapter("SELECT * FROM CUSF Where FNO='" & Mid(Trim(TxtIndentNo.Text), 1, 3) & "'", CON)

                    DS = New DataSet
                    ADA1.Fill(DS, "CUSF")

                    count1 = DS.Tables("CUSF").Rows.Count

                    For Each drt3 In DS.Tables("CUSF").Rows

                        TxtComNam.Text = Trim(drt3("Coname"))


                    Next


                    CMD = New SqlCommand("SELECT Bnk_Code,Bnk_Nam From Bank where bnk_code='" & drt2("Mas_BnkCode") & "'", CON)

                    DR = CMD.ExecuteReader


                    While DR.Read
                        TxtBnk.Text = DR.GetValue(1)
                        'LstBnk.Items.Add(TT)
                    End While


                    DR.Close()

                    txtCncy.Text = drt2("Mas_cncy")

                    CMD = New SqlCommand("SELECT EXNO,CNAME,CMADE FROM Supplier where exno='" & drt2("Mas_SupCode") & "'", CON)

                    DR = CMD.ExecuteReader


                    While DR.Read

                        TxtSup.Text = DR.GetValue(1)
                    End While
                    DR.Close()

                    Calendar1.Visible = False
                    Calendar2.Visible = False
                    Calendar3.Visible = False
                    ADA1 = New SqlDataAdapter("SELECT * FROM LCMas Where Mas_refno='" & Trim(TxtRefno.Text) & "'", CON)

                    DS = New DataSet
                    ADA1.Fill(DS, "LCMas")

                    count1 = DS.Tables("LCMas").Rows.Count

                    If count1 <> 0 Then

                        For Each drt3 In DS.Tables("LCMas").Rows
                            TxtAdv.Text = Trim(drt3("Mas_Adbk"))
                            TxtAppDate.Text = Format(CDate(Trim(drt3("Mas_Appdt"))), "dd/MM/yyyy")
                            TxtRecDate.Text = Format(CDate(Trim(drt3("Mas_Recdt"))), "dd/MM/yyyy")
                            TxtExpDt.Text = Format(CDate(Trim(drt3("Mas_ExpDt"))), "dd/MM/yyyy")
                            TxtLcNo.Text = Trim(drt3("Mas_LcNo"))
                            ' LstDraft.SelectedItem.Text = Trim(drt3("Mas_LcType"))
                        Next
                    Else
                        TxtAdv.Text = ""
                        TxtAppDate.Text = ""
                        TxtRecDate.Text = ""
                        TxtExpDt.Text = ""
                        TxtLcNo.Text = ""
                    End If
                Next
            End If

        End If


    End Sub

    Private Sub btt1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btt1.Click
        Calendar1.Visible = True
        'LstBnk.Visible = False
        TxtAdv.Visible = False
        TxtLcNo.Visible = False

    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TxtAppDate.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar1.Visible = False
        'LstBnk.Visible = True
        TxtAdv.Visible = True
        TxtLcNo.Visible = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        LsRefno.Visible = True
        TxtRefno.Visible = False

        '  Dim DeleteCmd1 As String = "DELETE from InlPur where Inv_no='" & LstInvNo.SelectedValue & "'"

        Dim Cmd As New SqlCommand("SELECT * FROM LcMas", CON)
        Cmd.ExecuteNonQuery()

        ADA = New SqlDataAdapter("SELECT * FROM LcMas Where Mas_RefNo='" & Trim(TxtRefno.Text) & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "LcMas")

        count1 = DS.Tables("LcMas").Rows.Count

        If count1 <> 0 Then
            ss = Format(Today(), "MM/dd/yyyy")
            ss = "UPDATE LcMas SET Mas_des='" & Trim(TxtAdv.Text) & "',Mas_Appdt='" & Format(CDate(Trim(TxtAppDate.Text)), "MM/dd/yyyy") & "',Mas_Recdt='" & Format(CDate(Trim(TxtRecDate.Text)), "MM/dd/yyyy") & "' WHERE Mas_Refno='" & Trim(TxtRefno.Text) & "'"
            Cmd.CommandText = ("UPDATE LcMas SET Mas_adbk='" & Trim(TxtAdv.Text) & "',Mas_Appdt='" & Mid(Trim(TxtAppDate.Text), 4, 2) + "/" + Mid(Trim(TxtAppDate.Text), 1, 2) + "/" + Mid(Trim(TxtAppDate.Text), 7, 4) & "',Mas_Recdt='" & Mid(Trim(TxtRecDate.Text), 4, 2) + "/" + Mid(Trim(TxtRecDate.Text), 1, 2) + "/" + Mid(Trim(TxtRecDate.Text), 7, 4) & "',Mas_Expdt='" & Mid(Trim(TxtExpDt.Text), 4, 2) + "/" + Mid(Trim(TxtExpDt.Text), 1, 2) + "/" + Mid(Trim(TxtExpDt.Text), 7, 4) & "',Mas_Lcno='" & Trim(TxtLcNo.Text) & "',Mas_LcType='" & Trim(LstDraft.SelectedValue) & "' WHERE Mas_Refno='" & Trim(TxtRefno.Text) & "'")
            Cmd.ExecuteNonQuery()
        Else
            ss = "INSERT INTO AppMas(Mas_Refno,Mas_des,Mas_Appdt,Mas_Recdt) VALUES ('" & Trim(TxtRefno.Text) & "','" & Trim(TxtAdv.Text) & "','" & Mid(Trim(TxtAppDate.Text), 4, 2) + "/" + Mid(Trim(TxtAppDate.Text), 1, 2) + "/" + Mid(Trim(TxtAppDate.Text), 7, 4) & "','" & Mid(Trim(TxtRecDate.Text), 4, 2) + "/" + Mid(Trim(TxtRecDate.Text), 1, 2) + "/" + Mid(Trim(TxtRecDate.Text), 7, 4) & "')"
            Cmd.CommandText = ("INSERT INTO LcMas(Mas_Refno,Mas_Adbk,Mas_AppDt,Mas_RecDt,Mas_ExpDt,Mas_Lctype,Mas_Lcno) VALUES ('" & Trim(TxtRefno.Text) & "','" & Trim(TxtAdv.Text) & "','" & Mid(Trim(TxtAppDate.Text), 4, 2) + "/" + Mid(Trim(TxtAppDate.Text), 1, 2) + "/" + Mid(Trim(TxtAppDate.Text), 7, 4) & "','" & Mid(Trim(TxtRecDate.Text), 4, 2) + "/" + Mid(Trim(TxtRecDate.Text), 1, 2) + "/" + Mid(Trim(TxtRecDate.Text), 7, 4) & "','" & Mid(Trim(TxtExpDt.Text), 4, 2) + "/" + Mid(Trim(TxtExpDt.Text), 1, 2) + "/" + Mid(Trim(TxtExpDt.Text), 7, 4) & "','" & Trim(LstDraft.SelectedValue) & "','" & Trim(Trim(TxtLcNo.Text)) & "')")
            Cmd.ExecuteNonQuery()
            ss = Format(Today(), "MM/dd/yyyy")
            Cmd.CommandText = ("UPDATE MasterDocs SET Mas_Entry6='Ok',Mas_Entry6Dt='" & ss & "' WHERE Mas_Refno='" & Trim(TxtRefno.Text) & "'")
            Cmd.ExecuteNonQuery()

        End If


        BtnSave.Enabled = False


    End Sub

    Private Sub LstPay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtRefno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRefno.TextChanged

    End Sub

    Private Sub TxtRecDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRecDate.TextChanged
        Calendar2.Visible = True
        'LstBnk.Visible = False
        TxtAdv.Visible = False
    End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        TxtRecDate.Text = Format((Calendar2.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar2.Visible = False
        'LstBnk.Visible = True
        TxtAdv.Visible = True
    End Sub

    Private Sub Imagebutton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton1.Click
        Calendar2.Visible = True
        'LstBnk.Visible = False
        TxtAdv.Visible = False
    End Sub


    Private Sub LsRefno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LsRefno.SelectedIndexChanged
        ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where Mas_RefNo='" & Trim(LsRefno.SelectedValue) & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "MasterDocs")
        BtnSave.Enabled = True
        count1 = DS.Tables("MasterDocs").Rows.Count


        If count1 <> 0 Then

            For Each drt2 In DS.Tables("MasterDocs").Rows

                TxtRefno.Text = drt2("Mas_ReFno")
                TxtIndentNo.Text = drt2("Mas_IndNos")
                ss = Format(drt2("Mas_IndRcDt"), "dd/MM/yyyy")
                TxtRecDt.Text = ss
                ' ss = IIf(IsDBNull(drt2("Mas_Des")) = True, "", Trim(drt2("Mas_Des")))
                'ss = drt2("Mas_HsCode")
                'ss = drt2("Mas_Amt")
                ' LstFlg1.SelectedValue = drt2("Mas_flag1")
                LstFlg1.Text = Trim(drt2("Mas_flag1"))
                LstFlg2.Text = Trim(drt2("Mas_flag2"))
                LstFlg3.Text = Trim(drt2("Mas_flag3"))

                TxtDes.Text = IIf(Trim(drt2("Mas_Des")) = "*", "", Trim(drt2("Mas_Des")))
                TxtHScd.Text = IIf(Trim(drt2("Mas_HsCode")) = "*", "", Trim(drt2("Mas_HsCode")))
                TxtVal.Text = IIf(Trim(drt2("Mas_Amt")) = "0", "", Trim(drt2("Mas_Amt")))
                TxtPay.Text = IIf(Trim(drt2("Mas_PyTrm")) = "*", "", Trim(drt2("Mas_PyTrm")))
                txtCncy.Text = IIf(Trim(drt2("Mas_cncy")) = "*", "", Trim(drt2("Mas_cncy")))
                txtInc.Text = IIf(Trim(drt2("Mas_InTrm")) = "*", "", Trim(drt2("Mas_InTrm")))



                If Trim(drt2("Mas_flag1")) = "Yes" Then
                    ' TxtSup.Visible = False
                    'TxtBnk.Visible = False
                    'TxtDes.ReadOnly = True
                    'TxtHScd.ReadOnly = True
                    'txtInc.Visible = False
                    ' TxtPay.Visible = False
                    'txtCncy.Visible = False
                    'TxtVal.ReadOnly = True
                    ' BtnSave.Enabled = False


                Else
                    'TxtSup.Visible = True
                    'TxtBnk.Visible = True
                    'TxtDes.ReadOnly = False
                    'TxtHScd.ReadOnly = False
                    'txtInc.Visible = True
                    'TxtPay.Visible = True
                    'txtCncy.Visible = True
                    ' TxtVal.ReadOnly = False
                    'BtnSave.Enabled = True

                End If



                ADA1 = New SqlDataAdapter("SELECT * FROM CUSF Where FNO='" & Mid(Trim(TxtIndentNo.Text), 1, 3) & "'", CON)

                DS = New DataSet
                ADA1.Fill(DS, "CUSF")

                count1 = DS.Tables("CUSF").Rows.Count

                For Each drt3 In DS.Tables("CUSF").Rows

                    TxtComNam.Text = Trim(drt3("Coname"))


                Next


                CMD = New SqlCommand("SELECT Bnk_Code,Bnk_Nam From Bank where bnk_code='" & drt2("Mas_BnkCode") & "'", CON)

                DR = CMD.ExecuteReader


                While DR.Read
                    TxtBnk.Text = DR.GetValue(1)
                    'LstBnk.Items.Add(TT)
                End While


                DR.Close()

                txtCncy.Text = drt2("Mas_cncy")

                CMD = New SqlCommand("SELECT EXNO,CNAME,CMADE FROM Supplier where exno='" & drt2("Mas_SupCode") & "'", CON)

                DR = CMD.ExecuteReader


                While DR.Read

                    TxtSup.Text = DR.GetValue(1)
                End While
                DR.Close()

                Calendar1.Visible = False
                Calendar2.Visible = False
                Calendar3.Visible = False
                ADA1 = New SqlDataAdapter("SELECT * FROM LCMas Where Mas_refno='" & Trim(TxtRefno.Text) & "'", CON)

                DS = New DataSet
                ADA1.Fill(DS, "LCMas")

                count1 = DS.Tables("LCMas").Rows.Count

                If count1 <> 0 Then

                    For Each drt3 In DS.Tables("LCMas").Rows
                        TxtAdv.Text = Trim(drt3("Mas_Adbk"))
                        TxtAppDate.Text = Format(CDate(Trim(drt3("Mas_Appdt"))), "dd/MM/yyyy")
                        TxtRecDate.Text = Format(CDate(Trim(drt3("Mas_Recdt"))), "dd/MM/yyyy")
                        TxtExpDt.Text = Format(CDate(Trim(drt3("Mas_ExpDt"))), "dd/MM/yyyy")
                        TxtLcNo.Text = Trim(drt3("Mas_LcNo"))
                        ' LstDraft.SelectedItem.Text = Trim(drt3("Mas_LcType"))
                    Next
                Else
                    TxtAdv.Text = ""
                    TxtAppDate.Text = ""
                    TxtRecDate.Text = ""
                    TxtExpDt.Text = ""
                    TxtLcNo.Text = ""
                End If


            Next
        End If

    End Sub

    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        count1 = Len(Trim(TxtIn.Text))
        ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where substring(Mas_IndNos,1," & count1 & ")='" & Trim(TxtIn.Text) & "' AND Mas_InTrm='LC'", CON)
        DS = New DataSet
        ADA.Fill(DS, "MasterDocs")
        BtnSave.Enabled = True
        count1 = DS.Tables("MasterDocs").Rows.Count
        LsRefno.Visible = False
        TxtRefno.Visible = True


        If count1 <> 0 Then

            For Each drt2 In DS.Tables("MasterDocs").Rows

                TxtRefno.Text = drt2("Mas_ReFno")
                TxtIndentNo.Text = drt2("Mas_IndNos")
                ss = Format(drt2("Mas_IndRcDt"), "dd/MM/yyyy")
                TxtRecDt.Text = ss
                ' ss = IIf(IsDBNull(drt2("Mas_Des")) = True, "", Trim(drt2("Mas_Des")))
                'ss = drt2("Mas_HsCode")
                'ss = drt2("Mas_Amt")
                ' LstFlg1.SelectedValue = drt2("Mas_flag1")
                LstFlg1.Text = Trim(drt2("Mas_flag1"))
                LstFlg2.Text = Trim(drt2("Mas_flag2"))
                LstFlg3.Text = Trim(drt2("Mas_flag3"))

                TxtDes.Text = IIf(Trim(drt2("Mas_Des")) = "*", "", Trim(drt2("Mas_Des")))
                TxtHScd.Text = IIf(Trim(drt2("Mas_HsCode")) = "*", "", Trim(drt2("Mas_HsCode")))
                TxtVal.Text = IIf(Trim(drt2("Mas_Amt")) = "0", "", Trim(drt2("Mas_Amt")))
                TxtPay.Text = IIf(Trim(drt2("Mas_PyTrm")) = "*", "", Trim(drt2("Mas_PyTrm")))
                txtCncy.Text = IIf(Trim(drt2("Mas_cncy")) = "*", "", Trim(drt2("Mas_cncy")))
                txtInc.Text = IIf(Trim(drt2("Mas_InTrm")) = "*", "", Trim(drt2("Mas_InTrm")))



                If Trim(drt2("Mas_flag1")) = "Yes" Then
                    ' TxtSup.Visible = False
                    'TxtBnk.Visible = False
                    'TxtDes.ReadOnly = True
                    'TxtHScd.ReadOnly = True
                    'txtInc.Visible = False
                    ' TxtPay.Visible = False
                    'txtCncy.Visible = False
                    'TxtVal.ReadOnly = True
                    ' BtnSave.Enabled = False


                Else
                    'TxtSup.Visible = True
                    'TxtBnk.Visible = True
                    'TxtDes.ReadOnly = False
                    'TxtHScd.ReadOnly = False
                    'txtInc.Visible = True
                    'TxtPay.Visible = True
                    'txtCncy.Visible = True
                    ' TxtVal.ReadOnly = False
                    'BtnSave.Enabled = True

                End If



                ADA1 = New SqlDataAdapter("SELECT * FROM CUSF Where FNO='" & Mid(Trim(TxtIndentNo.Text), 1, 3) & "'", CON)

                DS = New DataSet
                ADA1.Fill(DS, "CUSF")

                count1 = DS.Tables("CUSF").Rows.Count

                For Each drt3 In DS.Tables("CUSF").Rows

                    TxtComNam.Text = Trim(drt3("Coname"))


                Next


                CMD = New SqlCommand("SELECT Bnk_Code,Bnk_Nam From Bank where bnk_code='" & drt2("Mas_BnkCode") & "'", CON)

                DR = CMD.ExecuteReader


                While DR.Read
                    TxtBnk.Text = DR.GetValue(1)
                    'LstBnk.Items.Add(TT)
                End While


                DR.Close()

                txtCncy.Text = drt2("Mas_cncy")

                CMD = New SqlCommand("SELECT EXNO,CNAME,CMADE FROM Supplier where exno='" & drt2("Mas_SupCode") & "'", CON)

                DR = CMD.ExecuteReader


                While DR.Read

                    TxtSup.Text = DR.GetValue(1)
                End While
                DR.Close()

                Calendar1.Visible = False
                Calendar2.Visible = False

                ADA1 = New SqlDataAdapter("SELECT * FROM LCMas Where Mas_refno='" & Trim(TxtRefno.Text) & "'", CON)

                DS = New DataSet
                ADA1.Fill(DS, "LCMas")

                count1 = DS.Tables("LCMas").Rows.Count

                If count1 <> 0 Then

                    For Each drt3 In DS.Tables("LCMas").Rows
                        TxtAdv.Text = Trim(drt3("Mas_des"))
                        TxtAppDate.Text = Format(CDate(Trim(drt3("Mas_Appdt"))), "dd/MM/yyyy")
                        TxtRecDate.Text = Format(CDate(Trim(drt3("Mas_Recdt"))), "dd/MM/yyyy")
                        TxtExpDt.Text = Format(CDate(Trim(drt3("Mas_ExpDt"))), "dd/MM/yyyy")
                        TxtLcNo.Text = Trim(drt3("Mas_LcNo"))
                        'LstDraft.SelectedItem.Selected = Trim(drt3("Mas_LcType"))
                    Next
                Else
                    TxtAdv.Text = ""
                    TxtAppDate.Text = ""
                    TxtRecDate.Text = ""
                    TxtExpDt.Text = ""
                    TxtLcNo.Text = ""
                End If

            Next
        End If


    End Sub

    Private Sub TxtIn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIn.TextChanged

    End Sub

    Private Sub Imagebutton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton3.Click
        Calendar3.Visible = True
        'LstBnk.Visible = False
        'TxtAdv.Visible = False
        LstDraft.Visible = False
    End Sub

    Private Sub Calendar3_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar3.SelectionChanged
        LstDraft.Visible = True
        TxtExpDt.Text = Format((Calendar3.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar3.Visible = False
        'LstBnk.Visible = True

    End Sub

    Private Sub LstDraft_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstDraft.SelectedIndexChanged

    End Sub
End Class
