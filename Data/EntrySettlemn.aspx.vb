Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Imports System.IO
Public Class EntrySettlemn
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
    Dim Tno2, pflag As String
    Dim count1, Count2, I, K As Integer
    Dim StrEmpno, StrEmpCom, StrEmpNam, strEmpIdno, strEmpAdd, StrEmpDoA As String
    Dim TT, body, ss1 As String
    Dim oStream As New MemoryStream
    Protected WithEvents TxtRefno As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstBnk As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtDes As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtHScd As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstPay As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstInc As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstCncy As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents LstSup As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents btt1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents BtnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents LstFlg3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstFlg4 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents labelStatus As System.Web.UI.WebControls.Label
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtMsg1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstMsg1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents Lstmsg2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtMsg2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstLNam As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Lstcncy1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtERate As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtCrdDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCrdAmt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtNodys As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label21 As System.Web.UI.WebControls.Label
    Protected WithEvents Label22 As System.Web.UI.WebControls.Label
    Protected WithEvents Label23 As System.Web.UI.WebControls.Label
    Protected WithEvents Label24 As System.Web.UI.WebControls.Label
    Protected WithEvents Label25 As System.Web.UI.WebControls.Label
    Protected WithEvents Label28 As System.Web.UI.WebControls.Label
    Protected WithEvents Label29 As System.Web.UI.WebControls.Label
    Protected WithEvents Label30 As System.Web.UI.WebControls.Label
    Protected WithEvents Label31 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtIndentnO As System.Web.UI.WebControls.TextBox
    Protected WithEvents LblDbtInv As System.Web.UI.WebControls.Label
    Protected WithEvents LblDbtDt As System.Web.UI.WebControls.Label
    Protected WithEvents Label26 As System.Web.UI.WebControls.Label
    Protected WithEvents LstBName As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LblCncy As System.Web.UI.WebControls.Label
    Protected WithEvents LblERate As System.Web.UI.WebControls.Label
    Protected WithEvents Label32 As System.Web.UI.WebControls.Label
    Protected WithEvents Label33 As System.Web.UI.WebControls.Label
    Protected WithEvents Label34 As System.Web.UI.WebControls.Label
    Protected WithEvents Label35 As System.Web.UI.WebControls.Label
    Protected WithEvents Label36 As System.Web.UI.WebControls.Label
    Protected WithEvents Label37 As System.Web.UI.WebControls.Label
    Protected WithEvents lbl1 As System.Web.UI.WebControls.Label
    Protected WithEvents LblNoDys As System.Web.UI.WebControls.Label
    Protected WithEvents LblCrdDt As System.Web.UI.WebControls.Label
    Protected WithEvents LblInt As System.Web.UI.WebControls.Label
    Protected WithEvents LblRate As System.Web.UI.WebControls.Label
    Protected WithEvents Lbltot As System.Web.UI.WebControls.Label
    Protected WithEvents Label27 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtRtg As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label39 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtFndVal As System.Web.UI.WebControls.TextBox
    Protected WithEvents LblDVal As System.Web.UI.WebControls.Label
    Protected WithEvents LblRtgsVal As System.Web.UI.WebControls.Label
    Protected WithEvents LblFudTra As System.Web.UI.WebControls.Label
    Protected WithEvents LblRval As System.Web.UI.WebControls.Label
    Protected WithEvents LblFVal As System.Web.UI.WebControls.Label
    Protected WithEvents LblDbTax As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents val1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents val2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Val3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents val4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtFlg1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Datagrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents l1 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtIntRate As System.Web.UI.WebControls.TextBox
    Protected WithEvents Datagrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents TxtDtVal As System.Web.UI.WebControls.TextBox
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Image2 As System.Web.UI.WebControls.Image
    Protected WithEvents TxtPrLno As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label38 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtRef As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents BtnCreInv As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents BtnDbtInv As System.Web.UI.WebControls.Button
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label40 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtVal As System.Web.UI.WebControls.TextBox

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
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
        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        l1.Text = USER11




        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=TreasuryDb; user id=sa;password=tstc123")

        CON.Open()


        pflag = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        count1 = DS.Tables("UsdMaster").Rows.Count


        If count1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")


                Count2 = drt2("User_lvl")
                ' psec = drt2("User_sec")


            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If





        If Count2 = "1" Then
            pflag = "Y"

        Else

            If Count2 = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HthEmployeeMaster.aspx' and Form_level2='1'", CON)

            Else
                If Count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HthEmployeeMaster.aspx' and Form_level3='1'", CON)

                Else
                    If Count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HthEmployeeMaster.aspx' and Form_level4='1'", CON)
                    Else
                        If Count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HthEmployeeMaster.aspx' and Form_level5='1'", CON)

                        Else
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                        End If

                    End If
                End If

            End If
            'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                pflag = "Y"
            End While

            DR.Close()

        End If


        If pflag = "Y" Then
            Response.AddHeader("Refresh", 1800)
        Else

            Response.Redirect("POSDispaly11.aspx")
        End If






        If Not IsPostBack Then
            LstFlg3.AutoPostBack = False
            ' TxtIndentNo.ReadOnly = True

            Calendar1.Visible = False
            CMD = New SqlCommand("SELECT Flag from yesNo order by id", CON)

            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(0)
                'LstFlg1.Items.Add(TT)
                'LstFlg2.Items.Add(TT)
                LstFlg3.Items.Add(TT)
                LstFlg4.Items.Add(TT)
            End While
            DR.Close()



            'BindTheGrid()


            TxtCrdDt.Text = Format(Today(), "dd/MM/yyyy")
            LblDbtDt.Text = Format(Today(), "dd/MM/yyyy")

            CMD = New SqlCommand("SELECT Lecode,LeName From Lender order by Lename", CON)

            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(1) + "-" + DR.GetValue(0)
                LstLNam.Items.Add(TT)
            End While
            DR.Close()

            CMD = New SqlCommand("SELECT BrCode,BrName From Borrower Order by BrName", CON)

            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(1) + "-" + DR.GetValue(0)
                LstBName.Items.Add(TT)
            End While
            DR.Close()

            CMD = New SqlCommand("SELECT CNCY From CUSK ORDER BY ID", CON)

            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(0)
                Lstcncy1.Items.Add(TT)
            End While
            DR.Close()
            LblERate.Text = "1.000"
            LblCncy.Text = "LKR"
            TxtERate.Text = "1.0000"
            TxtRtg.Text = "0.00"
            TxtFndVal.Text = "0.00"
            BtnDbtInv.Visible = False
            BtnCreInv.Visible = False
        End If








    End Sub

    Private Sub btt1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btt1.Click
        Calendar1.Visible = True
        Label15.Visible = False
        'LstFlg2.Visible = False
        LstMsg1.Visible = False
        TxtMsg1.Visible = False
        LstLNam.Visible = False
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TxtCrdDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        LblDbtDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))

        Calendar1.Visible = False
        Label15.Visible = True
        'LstFlg2.Visible = True
        'LstMsg1.Visible = True
        TxtMsg1.Visible = True
        LstLNam.Visible = True
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'LstRefno.Visible = False
        'LstRefno.Enabled = False
        TxtRefno.Visible = True
        TxtRefno.Enabled = True
        TxtRefno.Text = ""
        ' TxtInvDt.Text = " "
        TxtFlg1.Text = "Add"
        TxtPrLno.Text = ""
        TxtRef.Text = "Y"
        labelStatus.Text = ""
        BtnAdd.Enabled = False
        BtnEdit.Enabled = False
        BtnSave.Enabled = True
        LstBName.Enabled = False
        'ADA = New SqlDataAdapter("SELECT * FROM InvoiceNo", CON)
        BtnCreInv.Visible = False
        BtnDbtInv.Visible = False
        TxtRefno.ReadOnly = False
        'TxtIndentNo.ReadOnly = False
        'TxtIndentNo.Text = ""

        TxtMsg1.Text = "We will settle your loan according to above settlement procedure."
        TxtMsg2.Text = ""
        TxtCrdAmt.Text = "0.00"
        TxtNodys.Text = "0"
        TxtIntRate.Text = "0.00"
        TxtRtg.Text = "0.00"
        TxtFndVal.Text = "0.00"
        TxtDtVal.Text = "0.00"
        ADA = New SqlDataAdapter("SELECT * FROM ReFno", CON)

        DS = New DataSet
        ADA.Fill(DS, "ReFno")

        count1 = DS.Tables("ReFno").Rows.Count


        If count1 <> 0 Then

            For Each drt2 In DS.Tables("ReFno").Rows
                '
                Dim q, r, s As String
                Dim p As Double
                s = drt2("refno")
                p = drt2("refno") + 1
                q = Format(p, "0000")

                TxtRefno.Text = drt2("ReFno")
                TxtRefno.Text = "C" + Trim(q)
                LblDbtInv.Text = "D" + Trim(q)
            Next
        Else
            ' Response.Redirect("InsuDept.aspx")

        End If


        If BtnEdit.Enabled = True Then
        Else

            Sinvno = Mid(Trim(TxtRefno.Text), 2, 5)

            Dim Cmd11 As New SqlCommand("UPDATE RefNo SET refno=" & Sinvno & "", CON)
            Cmd11.ExecuteNonQuery()
        End If



    End Sub

    Private Sub Datagrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Sub DataGrid1_UpdateCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)

        Dim cmdCustomers As SqlCommand


        Dim stritmNo As String = e.Item.Cells(2).Text
        Dim strdes As String = e.Item.Cells(3).Text
        Dim strpr As String = e.Item.Cells(4).Text
        Dim StrQty As String = e.Item.Cells(5).Text
        Dim strval As String = e.Item.Cells(6).Text


        Dim StrSql As String


        StrSql = "UPDATE InlTemp SET Inv_Qty=" & StrQty & " WHERE Inv_Itmno='" & stritmNo & "'"
        cmdCustomers = New SqlCommand(StrSql, CON)
        ' objConn.Open()
        'cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        ' Datagrid1.EditItemIndex = -1
        BindTheGrid()
        'Datagrid1.Visible = True

    End Sub
    Sub DataGrid1_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"

        Dim p1 As String
        p1 = e.Item.Cells(2).Text

        Dim DeleteCmd As String = "DELETE from MasterDocs Where id = @Id "
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)


        '' Cmd.Parameters.Add(New SqlParameter("@ID", Datagrid1.DataKeys(CInt(e.Item.ItemIndex))))

        Cmd.ExecuteNonQuery()

        Dim DeleteCmd1 As String = "DELETE from MasMsg Where Mas_refno='" & Trim(p1) & "'"
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd1 As New SqlCommand(DeleteCmd1, CON)

        Cmd1.ExecuteNonQuery()


        CON.Close()
        BindTheGrid()
    End Sub
    Sub DataGrid1_EditCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Datagrid1.EditItemIndex = e.Item.ItemIndex
        BindTheGrid()
    End Sub
    Sub DataGrid1_Cancel(ByVal Source As Object, ByVal E As DataGridCommandEventArgs)
        'Datagrid1.EditItemIndex = -1
        BindTheGrid()
    End Sub




    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        '  Dim DeleteCmd1 As String = "DELETE from InlPur where Inv_no='" & LstInvNo.SelectedValue & "'"
        Dim Cmd As New SqlCommand("SELECT * FROM LoanIssue", CON)
        Cmd.ExecuteNonQuery()
        BtnCreInv.Visible = True
        BtnDbtInv.Visible = True
        ' TxtIndentNo.ReadOnly = True
        If TxtFlg1.Text = "Edit" Then
            Cmd.Connection = CON

            'ss = "UPDATE LoanIssue SET LiNo='" & Trim(LstRefno.SelectedValue) & "',LiDate='" & Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid(TxtCrdDt.Text, 1, 2) + "/" + Mid(TxtCrdDt.Text, 7, 4) & "',LiBrCode= '" & Mid(Trim(LstBName.SelectedValue), 1, 5) & "',LiCur= '" & Trim(Lstcncy1.SelectedValue) & "',LiLKR=" & Trim(TxtERate.Text) & ",LiAmt=" & Trim(TxtCrdAmt.Text) & ",LiIntRate=" & Trim(TxtIntRate.Text) & ",LiPeriod=" & Trim(TxtNodys.Text) & ",LiStatus='No',LiRemark='" & Trim(TxtMsg1.Text) & "',LiIntAmt=" & Trim(val1.Text) & ",LiIntDays=" & Trim(TxtNodys.Text) & ",LiIntPmt=" & Trim(val1.Text) & ",LiCaptpmt=" & Trim(TxtCrdAmt.Text) & ",LiActNo='-',LiChq='-',LiBdate='" & Mid(Label35.Text, 4, 2) + "/" + Mid(Label35.Text, 1, 2) + "/" + Mid(Label35.Text, 7, 4) & "',liLeCode='" & Mid(Trim(LstLNam.SelectedValue), 1, 5) & "',LiDebTax=" & Trim(Val3.Text) & ",LiFndVal=" & Trim(TxtFndVal.Text) & " WHERE LiNo='" & Trim(LstRefno.SelectedValue) & "'"

            'Cmd.CommandText = ("UPDATE LoanIssue SET LiNo='" & Trim(LstRefno.SelectedValue) & "',LiDate='" & Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid(TxtCrdDt.Text, 1, 2) + "/" + Mid(TxtCrdDt.Text, 7, 4) & "',LiBrCode= '" & Right(Trim(LstBName.SelectedValue), 5) & "',LiCur= '" & Trim(Lstcncy1.SelectedValue) & "',LiLKR=" & Trim(TxtERate.Text) & ",LiAmt=" & Trim(TxtCrdAmt.Text) & ",LiIntRate=" & Trim(TxtIntRate.Text) & ",LiPeriod=" & Trim(TxtNodys.Text) & ",LiStatus='No',LiRemark='" & Trim(TxtMsg1.Text) & "',LiIntAmt=" & Trim(val1.Text) & ",LiIntDays=" & Trim(TxtNodys.Text) & ",LiIntPmt=" & Trim(val1.Text) & ",LiCaptpmt=" & Trim(TxtCrdAmt.Text) & ",LiActNo='-',LiChq='-',LiBdate='" & Mid(Label35.Text, 4, 2) + "/" + Mid(Label35.Text, 1, 2) + "/" + Mid(Label35.Text, 7, 4) & "',liLeCode='" & Right(Trim(LstLNam.SelectedValue), 5) & "',LiDebTax=" & Trim(Val3.Text) & ",LiFndVal=" & Trim(TxtDtVal.Text) & ",Ent_Time1='" & FormatDateTime(TimeOfDay) & "',Ent_Date1='" & Format(DateValue(Today()), "MM/dd/yyyy") & "' WHERE LiNo='" & Trim(LstRefno.SelectedValue) & "'")
            Cmd.ExecuteNonQuery()

            ' Sinvno = LstRefno.SelectedValue

        Else
            ss = Format(Today(), "MM/dd/yyyy")

            Cmd.Connection = CON
            Cmd.CommandText = ("INSERT INTO LoanIssue (LiNo,LiDate,LiBrCode,LiCur,LiLKR,LiAmt,LiIntRate,LiPeriod,LiStatus,LiRemark,LiIntAmt,LiIntDays,LiIntPmt,LiCaptpmt,LiActNo,LiChq,LiBdate,liLeCode,LiDebTax,LiFndVal,Ent_code,Ent_Time,Ent_date) VALUES ('" & Trim(TxtRefno.Text) & "','" & Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid(TxtCrdDt.Text, 1, 2) + "/" + Mid(TxtCrdDt.Text, 7, 4) & "','" & Right(Trim(LstBName.SelectedValue), 5) & "','" & Trim(Lstcncy1.SelectedValue) & "'," & Trim(TxtERate.Text) & "," & Trim(TxtCrdAmt.Text) & "," & Trim(TxtIntRate.Text) & "," & Trim(TxtNodys.Text) & ",'No','" & Trim(TxtMsg1.Text) & "'," & Trim(val1.Text) & "," & Trim(TxtNodys.Text) & "," & Trim(val1.Text) & "," & Trim(TxtCrdAmt.Text) & ",'-','-','" & Mid(Label35.Text, 4, 2) + "/" + Mid(Label35.Text, 1, 2) + "/" + Mid(Label35.Text, 7, 4) & "','" & Right(Trim(LstLNam.SelectedValue), 5) & "'," & Trim(Val3.Text) & "," & Trim(TxtDtVal.Text) & ",'" & Trim(l1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')")
            Cmd.ExecuteNonQuery()
            Sinvno = TxtRefno.Text

        End If

        If TxtFlg1.Text = "Edit" Then
            Cmd.Connection = CON
            ' ss = "UPDATE LoanReceive SET LrNo='" & Trim(LstRefno.SelectedValue) & "',LrDate='" & Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid(TxtCrdDt.Text, 1, 2) + "/" + Mid(TxtCrdDt.Text, 7, 4) & "',LrBrCode= '" & Trim(LblDbtInv.Text) & "',LrCur= '" & Trim(Lstcncy1.SelectedValue) & "',LrLKR=" & Trim(TxtERate.Text) & ",LrAmt=" & Trim(TxtCrdAmt.Text) & ",LrIntRate=" & Trim(TxtIntRate.Text) & ",LrPeriod=" & Trim(TxtNodys.Text) & ",LrStatus='No',LrRemark='" & Trim(TxtMsg2.Text) & "',LrIntAmt=" & Trim(val1.Text) & ",LrIntDays=" & Trim(TxtNodys.Text) & ",LrIntPmt=" & Trim(val1.Text) & ",LrCaptpmt=" & Trim(TxtCrdAmt.Text) & ",LrActNo='-',LrChq='-',LrBdate='" & Mid(Label35.Text, 4, 2) + "/" + Mid(Label35.Text, 1, 2) + "/" + Mid(Label35.Text, 7, 4) & "',lrLeCode='" & Mid(Trim(LstLNam.SelectedValue), 1, 5) & "',LrDebTax=" & Trim(Val3.Text) & ",LrFndVal=" & Trim(TxtFndVal.Text) & " WHERE LrNo='" & Trim(LstRefno.SelectedValue) & "'"
            'Cmd.CommandText = ("UPDATE LoanReceive SET LrNo='" & Trim(LstRefno.SelectedValue) & "',LrDate='" & Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid(TxtCrdDt.Text, 1, 2) + "/" + Mid(TxtCrdDt.Text, 7, 4) & "',LrBrCode= '" & Trim(LblDbtInv.Text) & "',LrCur= '" & Trim(Lstcncy1.SelectedValue) & "',LrLKR=" & Trim(TxtERate.Text) & ",LrAmt=" & Trim(TxtCrdAmt.Text) & ",LrIntRate=" & Trim(TxtIntRate.Text) & ",LrPeriod=" & Trim(TxtNodys.Text) & ",LrStatus='No',LrRemark='" & Trim(TxtMsg2.Text) & "',LrIntAmt=" & Trim(val1.Text) & ",LrIntDays=" & Trim(TxtNodys.Text) & ",LrIntPmt=" & Trim(val1.Text) & ",LrCaptpmt=" & Trim(TxtCrdAmt.Text) & ",LrChq='-',LrBdate='" & Mid(Label35.Text, 4, 2) + "/" + Mid(Label35.Text, 1, 2) + "/" + Mid(Label35.Text, 7, 4) & "',lrLeCode='" & Right(Trim(LstLNam.SelectedValue), 5) & "',LrDebTax=" & Trim(Val3.Text) & ",LrFndVal=" & Trim(TxtDtVal.Text) & " WHERE LrNo='" & Trim(LstRefno.SelectedValue) & "'")
            Cmd.ExecuteNonQuery()

            '  Sinvno = LstRefno.SelectedValue
        Else
            ss = Format(Today(), "MM/dd/yyyy")

            Cmd.Connection = CON
            Cmd.CommandText = ("INSERT INTO LoanReceive (LrNo,LrDate,LrBrCode,LrCur,LrLKR,LrAmt,LrIntRate,LrPeriod,LrStatus,LrRemark,LrIntAmt,LrIntDays,LrIntPmt,LrCaptpmt,LrChq,LrBdate,lrLeCode,LrDebTax,LrFndVal) VALUES ('" & Trim(LblDbtInv.Text) & "','" & Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid(TxtCrdDt.Text, 1, 2) + "/" + Mid(TxtCrdDt.Text, 7, 4) & "','" & Right(Trim(LstBName.SelectedValue), 5) & "','" & Trim(Lstcncy1.SelectedValue) & "'," & Trim(TxtERate.Text) & "," & Trim(TxtCrdAmt.Text) & "," & Trim(TxtIntRate.Text) & "," & Trim(TxtNodys.Text) & ",'No','" & Trim(TxtMsg2.Text) & "'," & Trim(val1.Text) & "," & Trim(TxtNodys.Text) & "," & Trim(val1.Text) & "," & Trim(TxtCrdAmt.Text) & ",'-','" & Mid(Label35.Text, 4, 2) + "/" + Mid(Label35.Text, 1, 2) + "/" + Mid(Label35.Text, 7, 4) & "','" & Right(Trim(LstLNam.SelectedValue), 5) & "'," & Trim(Val3.Text) & "," & Trim(TxtDtVal.Text) & ")")
            Cmd.ExecuteNonQuery()
            Sinvno = TxtRefno.Text

        End If


        BtnAdd.Enabled = True
        BtnEdit.Enabled = True
        BtnSave.Enabled = False




    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        BtnDbtInv.Visible = True
        CMD = New SqlCommand("SELECT liNo FROM LoanIssue where LiDate='" & Format(CDate(Today()), "MM/dd/yyyy") & "' and Ent_Code='" & Trim(l1.Text) & "' and LiStatus='No '", CON)

        ss = "SELECT liNo FROM LoanIssue where LiDate='" & Format(CDate(Today()), "MM/dd/yyyy") & "'"
        BtnAdd.Enabled = False
        TxtRefno.Visible = False
        ' LstRefno.Visible = True
        ' LstRefno.Enabled = True
        TxtIndentnO.ReadOnly = False
        DR = CMD.ExecuteReader
        labelStatus.Text = " "
        '   LstRefno.Items.Clear()
        BtnSave.Enabled = True
        TxtFlg1.Text = "Edit"

        While DR.Read
            TT = DR.GetValue(0)
            '  LstRefno.Items.Add(TT)

        End While
        DR.Close()





    End Sub

    Private Sub LstRefno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindTheGrid()
        'ADA = New SqlDataAdapter("SELECT * FROM LoanIssue where lino='" & Trim(LstRefno.SelectedValue) & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "LoanIssue")

        count1 = DS.Tables("LoanIssue").Rows.Count

        BtnCreInv.Visible = True
        If count1 <> 0 Then

            For Each drt2 In DS.Tables("LoanIssue").Rows

                TxtRefno.Text = Trim(drt2("LiNo"))
                ' TxtCrdDt.Text = Mid(drt2("lidate"), 4, 2) + "/" + Mid(drt2("lidate"), 1, 2) + "/" + Mid(drt2("lidate"), 7, 4)
                'LblDbtDt.Text = Mid(drt2("lidate"), 4, 2) + "/" + Mid(drt2("lidate"), 1, 2) + "/" + Mid(drt2("lidate"), 7, 4)
                TxtCrdDt.Text = Format(drt2("lidate"), "dd/MM/yyyy")
                LblDbtDt.Text = Format(drt2("lidate"), "dd/MM/yyyy")
                ' TxtCrdDt.Text = ss
                ss = Mid(drt2("LiLeCode"), 1, 5)
                ADA1 = New SqlDataAdapter("SELECT * FROM Lender where lecode='" & ss & "'", CON)

                DS1 = New DataSet
                ADA1.Fill(DS1, "Lender")

                Count2 = DS1.Tables("Lender").Rows.Count
                If Count2 <> 0 Then
                    For Each drt3 In DS1.Tables("Lender").Rows
                        LstLNam.SelectedValue = ss + "-" + drt3("LeName")
                    Next
                End If

                ss = Mid(drt2("LiBrCode"), 1, 5)

                ADA1 = New SqlDataAdapter("SELECT * FROM Borrower where Brcode='" & ss & "'", CON)

                DS1 = New DataSet
                ADA1.Fill(DS1, "Borrower")

                Count2 = DS1.Tables("Borrower").Rows.Count

                If Count2 <> 0 Then

                    For Each drt3 In DS1.Tables("Borrower").Rows
                        LstBName.SelectedValue = ss + "-" + drt3("BrName")
                    Next
                End If

                Lstcncy1.SelectedValue = drt2("Licur")
                LblCncy.Text = drt2("Licur")

                TxtERate.Text = drt2("LiLKR")
                LblERate.Text = drt2("LiLKR")

                TxtCrdAmt.Text = Right((Space(50) + Format(drt2("LiAmt"), "#########.00")), 15)

                TxtNodys.Text = drt2("LiPeriod")
                LblNoDys.Text = drt2("LiPeriod")

                TxtIntRate.Text = drt2("LiIntRate")
                LblRate.Text = drt2("LiIntRate")

                Label35.Text = Format(drt2("liBdate"), "dd/MM/yyyy")
                LblCrdDt.Text = Format(drt2("liBdate"), "dd/MM/yyyy")

                LblDVal.Text = Right((Space(50) + Format(drt2("LiDebtax"), "###,###,###.00")), 15)
                '' ss = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)

                Val3.Text = drt2("LiDebtax")

                ss = Trim(LblDVal.Text)
                If ss <> ".00" Then
                    LstFlg3.SelectedValue = "Yes"

                Else
                    LstFlg3.SelectedValue = "No "
                    LblDVal.Text = ""
                End If

                TxtFndVal.Text = drt2("LiFndVal")
                LblFVal.Text = Right((Space(50) + Format(drt2("LiFndVal"), "###,###,###.00")), 15)

                LblInt.Text = Right((Space(50) + Format(drt2("LiIntAmt"), "###,###,###.00")), 15)
                Label36.Text = Right((Space(50) + Format(drt2("LiIntAmt"), "###,###,###.00")), 15)
                val1.Text = drt2("LiIntAmt")
                Lbltot.Text = Right((Space(50) + Format(drt2("LiCaptPmt"), "###,###,###.00")), 15)
                Label37.Text = Right((Space(50) + Format(drt2("LiCaptPmt"), "###,###,###.00")), 15)
                val2.Text = drt2("LiCaptPmt")
                TxtMsg1.Text = drt2("LiRemark")

                LblDbtInv.Text = "D" + Mid(Trim(TxtRefno.Text), 2, 5)
                LblDbtInv.Text = Trim(LblDbtInv.Text)

                ADA = New SqlDataAdapter("SELECT * FROM LoanReceive where LrNo='" & Trim(LblDbtInv.Text) & "'", CON)

                DS = New DataSet
                ADA.Fill(DS, "LoanIssue")

                count1 = DS.Tables("LoanIssue").Rows.Count

                If count1 <> 0 Then

                    For Each drt3 In DS.Tables("LoanIssue").Rows
                        TxtMsg2.Text = Trim(drt3("LrRemark"))
                    Next
                End If

            Next
        End If

    End Sub

    Private Sub LstMsg1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstMsg1.SelectedIndexChanged
        TxtMsg1.Text = Trim(TxtMsg1.Text)
    End Sub

    Private Sub Lstmsg2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lstmsg2.SelectedIndexChanged
        TxtMsg2.Text = Trim(TxtMsg2.Text)
    End Sub

    Private Sub TxtCrdDt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCrdDt.TextChanged

    End Sub

    Private Sub Lstcncy1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lstcncy1.SelectedIndexChanged
        CMD = New SqlCommand("SELECT CNCY,Exg From CUSK where cncy='" & Mid(Trim(Lstcncy1.SelectedValue), 1, 3) & "'", CON)

        DR = CMD.ExecuteReader


        While DR.Read
            'TT = DR.GetValue(0)
            'Lstcncy1.Items.Add(TT)
            TxtERate.Text = Format(DR.GetValue(1), "####.0000")
            LblERate.Text = Format(DR.GetValue(1), "####.0000")
            LblCncy.Text = DR.GetValue(0)
        End While
    End Sub

    Private Sub TxtERate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtERate.TextChanged
        LblERate.Text = TxtERate.Text
    End Sub



    Private Sub TxtCrdAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCrdAmt.TextChanged

        LstBName.Enabled = True

        If TxtNodys.Text = "0" Or TxtIntRate.Text = "0.00" Then
            Label36.Text = "0.00"
        Else
            Label36.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100), "###,###,###.00")), 15)
            Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
            LblInt.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100), "###,###,###.00")), 15)
            Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
            val1.Text = Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)
            val2.Text = (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))

        End If
        If TxtNodys.Text = "0" Then
            Label35.Text = " "
        Else
            'ss = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4))))
            ss = DateAdd(DateInterval.Day, Val(TxtNodys.Text), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
            ss = Format(CDate(ss), "dd/MM/yyyy")
            Label35.Text = ss
            LblNoDys.Text = TxtNodys.Text
            LblCrdDt.Text = ss
            LblRate.Text = TxtIntRate.Text
        End If


        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If

            Else

                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If





            End If



        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""


                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            Else
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)

                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))

                Else
                    Val3.Text = "0"

                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            End If


        End If


        BindTheGrid()

        K = Len(Trim(LstBName.SelectedValue))
        I = Len(Trim(LstLNam.SelectedValue))

        'TxtMsg1.Text = "We will settle your loan according to above settlement procedure." + " " + Trim(Mid(LstBName.SelectedValue, 1, I - 6))
        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, I - 6)) + "will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."

        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")
        '''  ss2=CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss1 = DateAdd(DateInterval.Day, -8, CDate(Mid(Trim(Label35.Text), 4, 2) + "/" + Mid(Trim(Label35.Text), 1, 2) + "/" + Mid(Trim(Label35.Text), 7, 4)))

        ss1 = Format(CDate(ss1), "dd/MM/yyyy")



        If TxtRef.Text = "N" Then

            If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    Else
                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If

                Else

                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + +Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If

                End If
            Else
                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If

                Else
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If


                End If

            End If






        Else

            If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."
                    Else
                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                    End If

                Else

                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + +Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                    End If

                End If
            Else
                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                    End If

                Else
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                    End If


                End If

            End If
        End If

    End Sub


    Private Sub TxtNodys_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNodys.TextChanged
        If TxtCrdAmt.Text = "0.00" Or TxtIntRate.Text = "0.00" Then
            Label36.Text = "0.00"
            Label37.Text = "0.00"
        Else
            Label36.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100), "###,###,###.00")), 15)
            Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
            LblInt.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100), "###,###,###.00")), 15)
            val1.Text = Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)

            Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
            val2.Text = Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)
        End If
        If TxtNodys.Text = "0" Then
            Label35.Text = " "
        Else
            'ss = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4))))
            ss = DateAdd(DateInterval.Day, Val(TxtNodys.Text), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
            ss = Format(CDate(ss), "dd/MM/yyyy")
            Label35.Text = ss
            LblNoDys.Text = TxtNodys.Text
            LblCrdDt.Text = ss
            LblRate.Text = TxtIntRate.Text
        End If

        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If

            Else

                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If





            End If



        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""


                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            Else
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)

                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))

                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            End If


        End If

        BindTheGrid()

        K = Len(Trim(LstBName.SelectedValue))
        I = Len(Trim(LstLNam.SelectedValue))

        'TxtMsg1.Text = "We will settle your loan according to above settlement procedure." + " " + Trim(Mid(LstBName.SelectedValue, 1, I - 6))
        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, I - 6)) + "will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."

        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")
        '''  ss2=CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss1 = DateAdd(DateInterval.Day, -8, CDate(Mid(Trim(Label35.Text), 4, 2) + "/" + Mid(Trim(Label35.Text), 1, 2) + "/" + Mid(Trim(Label35.Text), 7, 4)))

        ss1 = Format(CDate(ss1), "dd/MM/yyyy")
        If TxtRef.Text = "N" Then

            If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    Else
                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If

                Else

                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + +Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If

                End If
            Else
                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If

                Else
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If


                End If

            End If






        Else
            If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."
                    Else
                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                    End If

                Else

                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + +Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                    End If

                End If
            Else
                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                    End If

                Else
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                    End If


                End If

            End If
        End If
    End Sub


    Private Sub TxtIntRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIntRate.TextChanged
        LstBName.Enabled = True
        LstFlg3.AutoPostBack = False
        If TxtCrdAmt.Text = "0.00" Or TxtNodys.Text = "0" Then
            Label36.Text = "0.00"
            Label37.Text = "0.00"
        Else
            Label36.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100), "###,###,###.00")), 15)
            Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
            LblInt.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100), "###,###,###.00")), 15)
            val1.Text = Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)
            Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
            val2.Text = (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
        End If
        If TxtNodys.Text = "0" Then
            Label35.Text = " "
        Else
            'ss = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4))))
            ss = DateAdd(DateInterval.Day, Val(TxtNodys.Text), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
            ss = Format(CDate(ss), "dd/MM/yyyy")
            Label35.Text = ss
            LblNoDys.Text = TxtNodys.Text
            LblCrdDt.Text = ss
            LblRate.Text = TxtIntRate.Text
        End If

        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"

                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If

            Else

                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If





            End If



        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Val3.Text = "0"

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            Else
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)

                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    'Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            End If


        End If


        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")
        BindTheGrid()

        K = Len(Trim(LstBName.SelectedValue))
        I = Len(Trim(LstLNam.SelectedValue))
        TxtMsg1.Text = "We will settle your loan according to above settlement procedure." + " " + Trim(Mid(LstBName.SelectedValue, 1, I - 6))
        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")
        '''  ss2=CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss1 = DateAdd(DateInterval.Day, -8, CDate(Mid(Trim(TxtCrdDt.Text), 4, 2) + "/" + Mid((Trim(TxtCrdDt.Text)), 1, 2) + "/" + Mid((Trim(TxtCrdDt.Text)), 7, 4)))

        ss1 = Format(CDate(ss1), "dd/MM/yyyy")
        I = Len(Trim(LstLNam.SelectedValue))


        If TxtRef.Text = "N" Then

            If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    Else
                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If

                Else

                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + +Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If

                End If
            Else
                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If

                Else
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    End If


                End If

            End If






        Else
            If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."

                    End If

                Else

                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."

                    End If

                End If
            Else
                If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                    End If

                Else
                    If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                    Else
                        TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                    End If


                End If

            End If

        End If
    End Sub


    Private Sub LstBName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstBName.SelectedIndexChanged
        'If Not IsPostBack Then

        BindTheGrid()

        K = Len(Trim(LstBName.SelectedValue))
        I = Len(Trim(LstLNam.SelectedValue))

        'TxtMsg1.Text = "We will settle your loan according to above settlement procedure." + " " + Trim(Mid(LstBName.SelectedValue, 1, I - 6))
        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, I - 6)) + "will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."

        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")
        '''  ss2=CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss1 = DateAdd(DateInterval.Day, -8, CDate(Mid(Trim(Label35.Text), 4, 2) + "/" + Mid(Trim(Label35.Text), 1, 2) + "/" + Mid(Trim(Label35.Text), 7, 4)))

        ss1 = Format(CDate(ss1), "dd/MM/yyyy")

        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                    TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."
                Else
                    TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                End If

            Else

                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                Else
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + +Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                End If

            End If
        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                Else
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                End If

            Else
                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                Else
                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                End If


            End If

        End If

        ' TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(LblInt.Text) + " in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"
        'End If
    End Sub

    Private Sub LstFlg3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstFlg3.SelectedIndexChanged
        LstBName.Enabled = True

        If LstFlg3.SelectedValue = "Yes" Then
            LblDbTax.Text = "Debit Tax"
            LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
            Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
            Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)



        Else
            LblDbTax.Text = ""
            LblDVal.Text = ""
            Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
            Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)

        End If

        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"

                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If

            Else

                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else

                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If





            End If



        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""


                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            Else
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)

                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))

                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    'Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            End If


        End If

        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")


        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If LstFlg3.SelectedValue = "Yes" Then

                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + ""

                Else
                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + ""

                End If

            Else

                If LstFlg3.SelectedValue = "Yes" Then
                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + ""
                Else
                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + ""
                End If

            End If
        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If LstFlg3.SelectedValue = "Yes" Then

                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + ""

                Else
                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + ""
                End If

            Else
                If LstFlg3.SelectedValue = "Yes" Then

                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + ""

                Else
                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + ""
                End If


            End If

        End If

        ' TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(LblInt.Text) + " in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"

        LstFlg3.AutoPostBack = False
    End Sub


    Private Sub TxtRtg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRtg.TextChanged
        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"

                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If

            Else

                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If





            End If



        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Val3.Text = "0"

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            Else
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)

                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))

                Else
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    'Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            End If


        End If



        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")


        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If LstFlg3.SelectedValue = "Yes" Then

                    TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(Lbltot.Text) + " (With Interst+Debit Tax) in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"

                Else
                    TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(Lbltot.Text) + " (With Interst) in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"

                End If

            Else

                If LstFlg3.SelectedValue = "Yes" Then
                    TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(Lbltot.Text) + " (With Interst+Debit Tax+Fund Transfers) in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"
                Else
                    TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(Lbltot.Text) + " (With Interst+Fund Transfers) in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"
                End If

            End If
        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If LstFlg3.SelectedValue = "Yes" Then

                    TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(Lbltot.Text) + " (With Interst+Debit Tax+Rtgs Tax) in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"

                Else
                    TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(Lbltot.Text) + " (With Interst+Rtgs Tax) in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"
                End If

            Else
                If LstFlg3.SelectedValue = "Yes" Then

                    TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(Lbltot.Text) + " (With Interst+Debit Tax+Rtgs Tax+Fund Transfers) in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"

                Else
                    TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(Lbltot.Text) + " (With Interst+Rtgs Tax+Fund Transfers) in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"
                End If


            End If

        End If

        ' TxtMsg2.Text = "Please send us a INTETREST (" + ss + ") Cheque For Rs." + Trim(LblInt.Text) + " in favour of '" + Trim(Mid(LstLNam.SelectedValue, 7, 100)) + "'"

    End Sub



    Private Sub TxtFndVal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFndVal.TextChanged
        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If

            Else

                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfer Chargers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    Val3.Text = "0"
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = ""
                    LblRval.Text = ""
                    LblFudTra.Text = "Fund Transfer Chargers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If





            End If



        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtCrdAmt.Text) + (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))


                Else
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = ""
                    LblFVal.Text = ""
                    Val3.Text = "0"

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            Else
                If LstFlg3.SelectedValue = "Yes" Then
                    LblDbTax.Text = "Debit Tax"
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfer Chargers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)

                    Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100

                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)

                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))

                Else
                    LblDbTax.Text = ""
                    LblDVal.Text = ""
                    LblDVal.Text = Right((Space(50) + Format(Val(TxtCrdAmt.Text) * 0.1 / 100, "###,###,###.00")), 15)
                    'Val3.Text = Val(TxtCrdAmt.Text) * 0.1 / 100
                    LblRtgsVal.Text = "Rtgs Value"
                    LblRval.Text = Right((Space(50) + Format(Val(TxtRtg.Text), "###,###,###.00")), 15)
                    LblFudTra.Text = "Fund Transfers"
                    LblFVal.Text = Right((Space(50) + Format(Val(TxtFndVal.Text), "###,###,###.00")), 15)
                    Val3.Text = "0"
                    Lbltot.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    Label37.Text = Right((Space(50) + Format((Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)
                    val2.Text = (Val(TxtRtg.Text) + Val(TxtFndVal.Text) + Val(TxtCrdAmt.Text) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100))
                End If


            End If


        End If

        BindTheGrid()

        K = Len(Trim(LstBName.SelectedValue))
        I = Len(Trim(LstLNam.SelectedValue))

        'TxtMsg1.Text = "We will settle your loan according to above settlement procedure." + " " + Trim(Mid(LstBName.SelectedValue, 1, I - 6))
        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, I - 6)) + "will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."

        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")
        '''  ss2=CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss1 = DateAdd(DateInterval.Day, -8, CDate(Mid(Trim(Label35.Text), 4, 2) + "/" + Mid(Trim(Label35.Text), 1, 2) + "/" + Mid(Trim(Label35.Text), 7, 4)))

        ss1 = Format(CDate(ss1), "dd/MM/yyyy")

        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                    TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."
                Else
                    TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                End If

            Else

                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                Else
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + +Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                End If

            End If
        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                Else
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                End If

            Else
                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                Else
                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                End If


            End If

        End If

    End Sub

    Public Sub BindTheGrid()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=TreasuryDb; user id=sa;password=tstc123")

        CON.Open()


        ss = "Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster where trim(emp_No)='" & Trim(TempEmpno) & "' and Emp_Com='" & TempCom & "'"

        '' Dim cmdCustomers As SqlCommand = New SqlCommand("Select LoanIssue.[Lidate] as Lidate,LoanIssue.[lino] as lino,LoanIssue.[LiCur] as LiCur ,convert(decimal(8,2),LoanIssue.[LiAmt],2) as LiAmt,Borrower.[BrName] as BrName from LoanIssue,Borrower where LoanIssue.[LiBrCode]=Borrower.[BrCode] and LoanIssue.[LiStatus]='No ' and LoanIssue.[Liamt]=" & Val(TxtCrdAmt.Text) & " order by LoanIssue.[Lidate]", CON)
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select convert(varchar(10),LoanIssue.[Lidate],103) as Lidate,LoanIssue.[lino] as lino,LoanIssue.[LiCur] as LiCur ,convert(decimal(15,2),LoanIssue.[LiAmt],2) as LiAmt,Borrower.[BrName] as BrName from LoanIssue,Borrower where LoanIssue.[LiBrCode]=Borrower.[BrCode] and LoanIssue.[LiStatus]='No ' and LoanIssue.[LiBrCode]='" & Mid(Trim(LstBName.SelectedValue), 1, 5) & "' and LoanIssue.[LiLeCode]='" & Mid(Trim(LstLNam.SelectedValue), 1, 5) & "' order by LoanIssue.[Id] desc", CON)

        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_ChqNo,Emp_Cno,Emp_Typ,convert(decimal(8,2),Emp_Amt,2) AS Emp_Amt,convert(decimal(8,2),Emp_DecAmt,2) AS Emp_DecAmt, convert(varchar(10),Emp_PayDt,103) as Emp_Paydt from HltMaster1 where (Emp_No='" & Trim(TxtTEmpNo.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo.Text) & "') and Emp_Com='" & Trim(TempCom) & "' and emp_accyr='" & Trim(TxtYr.Text) & "' ORDER BY ID", CON)
        cmdCustomers.CommandType = CommandType.Text

        Datagrid1.DataSource = cmdCustomers.ExecuteReader()
        Datagrid1.DataBind()

        Datagrid1.Visible = True
        CON.Close()

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub LstLNam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstLNam.SelectedIndexChanged
        BindTheGrid()

        K = Len(Trim(LstBName.SelectedValue))
        I = Len(Trim(LstLNam.SelectedValue))

        'TxtMsg1.Text = "We will settle your loan according to above settlement procedure." + " " + Trim(Mid(LstBName.SelectedValue, 1, I - 6))
        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, I - 6)) + "will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."

        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")
        '''  ss2=CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss1 = DateAdd(DateInterval.Day, -8, CDate(Mid(Trim(Label35.Text), 4, 2) + "/" + Mid(Trim(Label35.Text), 1, 2) + "/" + Mid(Trim(Label35.Text), 7, 4)))

        ss1 = Format(CDate(ss1), "dd/MM/yyyy")

        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                    TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."
                Else
                    TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                End If

            Else

                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                Else
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + +Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                End If

            End If
        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                Else
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                End If

            Else
                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                Else
                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                End If


            End If

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Overloads Sub BtnCreInv_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)

    End Sub





    Private Sub TxtDtVal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDtVal.TextChanged
        BindTheGrid()

        K = Len(Trim(LstBName.SelectedValue))
        I = Len(Trim(LstLNam.SelectedValue))

        'TxtMsg1.Text = "We will settle your loan according to above settlement procedure." + " " + Trim(Mid(LstBName.SelectedValue, 1, I - 6))
        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, I - 6)) + "will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."

        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")
        '''  ss2=CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss1 = DateAdd(DateInterval.Day, -8, CDate(Mid(Trim(Label35.Text), 4, 2) + "/" + Mid(Trim(Label35.Text), 1, 2) + "/" + Mid(Trim(Label35.Text), 7, 4)))

        ss1 = Format(CDate(ss1), "dd/MM/yyyy")

        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                    TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."
                Else
                    TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                End If

            Else

                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                Else
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + "."
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + +Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + "."
                End If

            End If
        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                Else
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                End If

            Else
                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."

                Else
                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + "."
                End If


            End If

        End If

    End Sub

    Private Sub TxtPrLno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPrLno.TextChanged
        ' BindTheGrid()
        ADA = New SqlDataAdapter("SELECT * FROM LoanIssue where lino='C" & Trim(TxtPrLno.Text) & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "LoanIssue")

        count1 = DS.Tables("LoanIssue").Rows.Count

        BtnCreInv.Visible = False
        If count1 <> 0 Then
            TxtRef.Text = "N"
            For Each drt2 In DS.Tables("LoanIssue").Rows

                'TxtRefno.Text = Trim(drt2("LiNo"))
                ' TxtCrdDt.Text = Mid(drt2("lidate"), 4, 2) + "/" + Mid(drt2("lidate"), 1, 2) + "/" + Mid(drt2("lidate"), 7, 4)
                'LblDbtDt.Text = Mid(drt2("lidate"), 4, 2) + "/" + Mid(drt2("lidate"), 1, 2) + "/" + Mid(drt2("lidate"), 7, 4)
                TxtCrdDt.Text = Format(drt2("lidate"), "dd/MM/yyyy")
                LblDbtDt.Text = Format(drt2("lidate"), "dd/MM/yyyy")
                ' TxtCrdDt.Text = ss
                ss = Mid(drt2("LiLeCode"), 1, 5)
                ADA1 = New SqlDataAdapter("SELECT * FROM Lender where lecode='" & ss & "'", CON)

                DS1 = New DataSet
                ADA1.Fill(DS1, "Lender")

                Count2 = DS1.Tables("Lender").Rows.Count
                If Count2 <> 0 Then
                    For Each drt3 In DS1.Tables("Lender").Rows
                        LstLNam.SelectedValue = drt3("LeName") + "-" + ss
                    Next
                End If

                ss = Mid(drt2("LiBrCode"), 1, 5)

                ADA1 = New SqlDataAdapter("SELECT * FROM Borrower where Brcode='" & ss & "'", CON)

                DS1 = New DataSet
                ADA1.Fill(DS1, "Borrower")

                Count2 = DS1.Tables("Borrower").Rows.Count

                If Count2 <> 0 Then

                    For Each drt3 In DS1.Tables("Borrower").Rows
                        LstBName.SelectedValue = drt3("BrName") + "-" + ss
                    Next
                End If

                Lstcncy1.SelectedValue = drt2("Licur")
                LblCncy.Text = drt2("Licur")

                TxtERate.Text = drt2("LiLKR")
                LblERate.Text = drt2("LiLKR")

                TxtCrdAmt.Text = Right((Space(50) + Format(drt2("LiAmt"), "#########.00")), 15)

                TxtNodys.Text = drt2("LiPeriod")
                LblNoDys.Text = drt2("LiPeriod")
                'TxtRNodys.Text = drt2("LiPeriod")
                TxtIntRate.Text = drt2("LiIntRate")
                LblRate.Text = drt2("LiIntRate")


                TxtRefno.Text = drt2("LiPrLNo")


                Label35.Text = Format(drt2("liBdate"), "dd/MM/yyyy")
                LblCrdDt.Text = Format(drt2("liBdate"), "dd/MM/yyyy")

                LblDVal.Text = Right((Space(50) + Format(drt2("LiDebtax"), "###,###,###.00")), 15)
                '' ss = Right((Space(50) + Format(Val(TxtFndVal.Text) + (Val(TxtCrdAmt.Text) + (Val(TxtCrdAmt.Text) * 0.1 / 100) + Val(TxtCrdAmt.Text) * Val(TxtNodys.Text) * Val(TxtIntRate.Text) / (365 * 100)), "###,###,###.00")), 15)

                Val3.Text = drt2("LiDebtax")

                ss = Trim(LblDVal.Text)
                If ss <> ".00" Then
                    LstFlg3.SelectedValue = "Yes"

                Else
                    LstFlg3.SelectedValue = "No "
                    LblDVal.Text = ""
                End If

                TxtFndVal.Text = drt2("LiFndVal")
                LblFVal.Text = Right((Space(50) + Format(drt2("LiFndVal"), "###,###,###.00")), 15)

                LblInt.Text = Right((Space(50) + Format(drt2("LiIntAmt"), "###,###,###.00")), 15)
                Label36.Text = Right((Space(50) + Format(drt2("LiIntAmt"), "###,###,###.00")), 15)
                val1.Text = drt2("LiIntAmt")
                Lbltot.Text = Right((Space(50) + Format(drt2("LiCaptPmt"), "###,###,###.00")), 15)
                Label37.Text = Right((Space(50) + Format(drt2("LiCaptPmt"), "###,###,###.00")), 15)
                val2.Text = drt2("LiCaptPmt")
                TxtMsg1.Text = drt2("LiRemark")

                LblDbtInv.Text = "D" + Mid(Trim(TxtRefno.Text), 2, 5)
                LblDbtInv.Text = Trim(LblDbtInv.Text)
                TxtDtVal.Text = "0"
                TxtFndVal.Text = "0"
                ' ADA = New SqlDataAdapter("SELECT * FROM LoanReceive where LrNo='" & Trim(LblDbtInv.Text) & "'", CON)

                '  DS = New DataSet
                ' ADA.Fill(DS, "LoanIssue")

                ' count1 = DS.Tables("LoanIssue").Rows.Count

                'If count1 <> 0 Then

                ' For' Each drt3 In DS.Tables("LoanIssue").Rows
                ' TxtMsg2.Text = Trim(drt3("LrRemark"))
                ' TxtRMsg2.Text = Trim(drt3("LrRemark"))
                'Next
                'End If










            Next
        End If

        K = Len(Trim(LstBName.SelectedValue))
        I = Len(Trim(LstLNam.SelectedValue))

        'TxtMsg1.Text = "We will settle your loan according to above settlement procedure." + " " + Trim(Mid(LstBName.SelectedValue, 1, I - 6))
        TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, I - 6)) + "will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + "."

        ss = DateAdd(DateInterval.Day, (Val(TxtNodys.Text) - 6), CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss = Format(CDate(ss), "dd/MM/yyyy")
        '''  ss2=CDate(Mid(TxtCrdDt.Text, 4, 2) + "/" + Mid((TxtCrdDt.Text), 1, 2) + "/" + Mid((TxtCrdDt.Text), 7, 4)))
        ss1 = DateAdd(DateInterval.Day, -8, CDate(Mid(Trim(Label35.Text), 4, 2) + "/" + Mid(Trim(Label35.Text), 1, 2) + "/" + Mid(Trim(Label35.Text), 7, 4)))

        ss1 = Format(CDate(ss1), "dd/MM/yyyy")

        If TxtRtg.Text = "0.00" Or TxtRtg.Text = "0" Or TxtRtg.Text = "" Then

            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then


                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                    TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + "in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                Else
                    TxtMsg2.Text = "Please send us a Cheque for  " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                End If

            Else

                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                Else
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before. " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                    TxtMsg1.Text = Trim(Mid(LstBName.SelectedValue, 1, K - 6)) + " will deposit " + +Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text) + Val(TxtDtVal.Text)), "###,###,###.00") + " ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + " + FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + " + DT chargers " + Trim(LblCncy.Text) + " " + TxtDtVal.Text + ") in your A\C on " + Trim(Label35.Text) + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                End If

            End If
        Else
            If TxtFndVal.Text = "0.00" Or TxtFndVal.Text = "0" Or TxtFndVal.Text = "" Then
                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" = "Yes" Then

                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + +" ( Int Amt " + Trim(LblCncy.Text) + " " + Format(Val(val1.Text), "######.00") + "+FT chargers " + Trim(LblCncy.Text) + " " + TxtFndVal.Text + ") in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"

                Else
                    TxtMsg2.Text = "Please send us a Cheque for " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                End If

            Else
                If TxtDtVal.Text = "0.00" Or TxtDtVal.Text = "0" Or TxtDtVal.Text = "" Then

                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"

                Else
                    TxtMsg2.Text = "Please send us a Cheque for the Interest Amount " + Trim(LblCncy.Text) + " " + Format((Val(val1.Text) + Val(Val3.Text) + Val(TxtFndVal.Text)), "###,###,###.00") + " in favour of " + Trim(Mid(LstLNam.SelectedValue, 1, I - 6)) + " on or before " + ss1 + ". (Previous Loan Ref " + Trim(TxtPrLno.Text) + ")"
                End If


            End If

        End If
        BtnSave.Enabled = True

    End Sub

    Private Overloads Sub BtnCreInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreInv.Click
        Dim DSS As CrdInvoice = New CrdInvoice
        ss = Trim(TxtRefno.Text)

        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        ' DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Invno", "" & ss & "")
        CrystalReportViewer1.SeparatePages = True
        CrystalReportViewer1.ReportSource = DSS
        CrystalReportViewer1.HasRefreshButton = True
        CrystalReportViewer1.HasZoomFactorList = True
        CrystalReportViewer1.HasPageNavigationButtons = True
        CrystalReportViewer1.HasDrillUpButton = True
        'CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.DataBind()
        '--------------
        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=CreditInvoice.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "CreditInvoice/pdf"
        Response.BinaryWrite(oStream.ToArray())
        Response.End()

    End Sub

    Private Overloads Sub BtnDbtInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDbtInv.Click
        Dim DSS1 As DbtInvoice1 = New DbtInvoice1
        ss = "C" + Mid(Trim(TxtRefno.Text), 2, 5)

        DSS1.SetDatabaseLogon("sa", "tstc123")
        DSS1.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        DSS1.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        ' DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS1.SetParameterValue("Invno", "" & ss & "")
        CrystalReportViewer1.SeparatePages = True
        CrystalReportViewer1.ReportSource = DSS1
        CrystalReportViewer1.HasRefreshButton = True
        CrystalReportViewer1.HasZoomFactorList = True
        CrystalReportViewer1.HasPageNavigationButtons = True
        CrystalReportViewer1.HasDrillUpButton = True
        'CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.DataBind()
        '--------------
        oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=DebitInvoice.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "DebitInvoice/pdf"
        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub

    Private Sub Setteled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
