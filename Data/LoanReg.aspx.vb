Imports System.Data.SqlClient
Imports System.Data

Public Class LoanReg
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2 As SqlDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Private theTotal As Double = 0
    Private theTotal1 As Double = 0
    Dim drt2, drt3, drt1, drt4, drt5 As DataRow
    Dim ss, ss1, Sempno, Sdate, SempNam, Sin, Sout, Swk, Ssec, Ssec1, SsecTemp, SsecTemp1, SOT, Shr, Syr, Smt, SAccFlag, incomplete, SOT1, SOT2 As String
    Dim SWK1, Ah, Bh, Xh, Yh As Single
    Dim Ahin, Bhou, Xhin, Yhou, OT As String
    Dim Total1, Total2, Total3, Total4, Total5, Total6, Total7, Total8, Total9, Total10, Total11, Total12 As Double
    Dim Count1, Count2, I, DT1 As Integer
    Dim gridrow As DataGridItem
    Dim Savgmk, STraEmp, STotOT, Sp1, Sp2, Sp3, Spl, Spl1, TotsDate, Totssec, TotWkhrs, TotOthrs, TotItmCode, TotQty, totval1, TotThrs, TotTOT, TotStd As String
    Dim Tno2, pflag As String
    Dim tradate As String
    Dim stryr, strmt, strsec, strmt1 As String

    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Dim PAG As Boolean
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents LstCh11 As System.Web.UI.WebControls.DropDownList
    'Protected WithEvents LstCh111 As multiColDD_List.DropDowns.DropDowns
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents ImageButton3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Datagrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents LstBorrower As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Dim TT As String

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
        'Put user code to initialize the page here
        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        L1.Text = USER11


        '''FDGFDG()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=TreasuryDb; user id=sa;password=tstc123")

        CON.Open()


        pflag = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        Count1 = DS.Tables("UsdMaster").Rows.Count


        If Count1 <> 0 Then


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

            'Response.Redirect("POSDispaly11.aspx")
        End If

        CMD = New SqlCommand("SELECT BrCode,BrName From Borrower", CON)

        DR = CMD.ExecuteReader


        While DR.Read
            TT = DR.GetValue(0) + "-" + DR.GetValue(1)
            LstBorrower.Items.Add(TT)
        End While
        DR.Close()

        ' DR.Close()
        ' CON.Close()



        ' BtnUpdate.Enabled = True

        'CON = New SqlConnection
        'CON.ConnectionString = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=D:\sgcs\sgcs.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
        'CON.Open()


        'CON.Close()

        BindTheGrid1()


    End Sub

    Private Sub BindTheGrid()

        CON.Close()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=TreasuryDb; user id=sa;password=tstc123")
        CON.Open()

        'ss = "Select [LoanIssue].Id as Id,[LoanIssue].LiNo as LiNo,[LoanIssue].LiDate as LiDate,[LoanIssue].LiCur as LiCur,convert(float,[LoanIssue].LiAmt,2) as LiAmt,[LoanIssue].LiBDate as LiBDate,[Borrower].BrName as BrName from LoanIssue ,Borrower where [LoanIssue].LIBrcode=[Borrower].BrCode and [LoanIssue].LiStatus='N' and [LoanIssue].LiLeCode ='" & Trim(Mid(LstLender.SelectedValue, 1, 5)) & "'"

        ss = "Select [LoanIssue].Id as Id,substring([LoanIssue].LiNo,2,5) as LiNo,CONVERT(VARCHAR(10),[LoanIssue].LiDate,103) as LiDate,[LoanIssue].LiCur as LiCur,convert(float,[LoanIssue].LiAmt,2) as LiAmt,convert(float,[LoanIssue].LiIntRate,2) as LiIntRate,convert(float,[LoanIssue].LiIntPmt,2) as LiIntPmt,convert(float,([LoanIssue].LiIntPmt+[LoanIssue].LicaptPmt+[LoanIssue].Lifndval+[LoanIssue].lidebtax),2) as TotAmt,convert(VARCHAR(10),[LoanIssue].LiBDate,103) as LiBDate,[Lender].Lesname as BrName,LoanIssue.SetFg from LoanIssue ,Lender where [LoanIssue].LILecode=[Lender].LeCode and [LoanIssue].LiStatus='No' and [LoanIssue].LiBrCode ='" & Trim(Mid(LstBorrower.SelectedValue, 1, 5)) & "'"
        Datagrid2.Visible = True

        Dim cmdCustomers As SqlCommand

        '' cmdCustomers = New SqlCommand("Select Convert(Varchar(10),Tra_Date,103) as TraDate,convert(float,Val1,0) AS Val1,Dly_qty,AvgMk,TraEmp,TotOT,p1,p3,p2,convert(float,(Val1-(p1+p2+p3)),0) as pl ,convert(float,(Val1-(p1+p2+p3))/((avgmk*pl1)+(TraEmp*pl1)+TotOt),0) as pl1 from Freport where Sec_code='" & Mid(LstSec.SelectedValue, 1, 4) & "' and substring(CONVERT(VARCHAR(10),Tra_date,103),7,4)='" & Syr & "' And substring(CONVERT(VARCHAR(10),Tra_date,103),4,2)='" & Smt & "' Order by Convert(Varchar(10),Tra_Date,103)", CON)
        cmdCustomers = New SqlCommand(ss, CON)

        cmdCustomers.CommandType = CommandType.Text
        Datagrid2.DataSource = cmdCustomers.ExecuteReader()
        Datagrid2.DataBind()
        CON.Close()

    End Sub


    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DataEntry1.aspx.vb" Inherits="Fleet.DataEntry1"%>
        '<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
        '<HTML>


        '  <asp:BoundColumn Visible="False" DataField="Tra_Rno" HeaderText="Rec No"></asp:BoundColumn>
        '<asp:BoundColumn Visible="False" DataField="Tra_Des1" HeaderText="Description"></asp:BoundColumn>
        '<asp:BoundColumn Visible="False" DataField="Tra_Crd" HeaderText="Credit1"></asp:BoundColumn>
        '<asp:BoundColumn Visible="False" DataField="Tra_Dbt" HeaderText="Debit1"></asp:BoundColumn>

    End Sub

    Private Sub LstMth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Data4()
    End Sub

    Private Sub TxtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'BtnUpdate.Enabled = True
        ' Data4()
    End Sub

    Public Function Round(ByVal nValue As Double, ByVal nDigits As Integer) As Double
        Round = Int(nValue * (10 ^ nDigits) + 0.5) / (10 ^ nDigits)
    End Function
    Private Sub BindTheGrid1()

        CON.Close()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=TreasuryDb; user id=sa;password=tstc123")
        CON.Open()

        'ss = "Select [LoanIssue].Id as Id,[LoanIssue].LiNo as LiNo,[LoanIssue].LiDate as LiDate,[LoanIssue].LiCur as LiCur,convert(float,[LoanIssue].LiAmt,2) as LiAmt,[LoanIssue].LiBDate as LiBDate,[Borrower].BrName as BrName from LoanIssue ,Borrower where [LoanIssue].LIBrcode=[Borrower].BrCode and [LoanIssue].LiStatus='N' and [LoanIssue].LiLeCode ='" & Trim(Mid(LstLender.SelectedValue, 1, 5)) & "'"

        ss = "Select [LoanIssue].Id as Id,substring([LoanIssue].LiNo,2,5) as LiNo,LiPrLno,CONVERT(VARCHAR(10),[LoanIssue].LiDate,103) as LiDate,[LoanIssue].LiCur as LiCur,CONVERT(varchar, CAST([LoanIssue].LiAmt AS money), 1) as LiAmt,CONVERT(varchar, CAST([LoanIssue].LiIntRate as money), 1) as LiIntRate,CONVERT(varchar, CAST([LoanIssue].LiIntPmt as money), 1) as LiIntPmt,CONVERT(varchar, CAST(([LoanIssue].LiIntPmt+[LoanIssue].LicaptPmt+[LoanIssue].Lifndval+[LoanIssue].lidebtax) as money), 1) as TotAmt,convert(VARCHAR(10),[LoanIssue].LiBDate,103) as LiBDate,[Lender].Lesname as LeName,[Borrower].Brsname as BrName,LoanIssue.SetFg as SetFg,LoanIssue.LiChqNo as ChqNo,CONVERT(VARCHAR(10),[LoanIssue].Setdt,103) as Sdt,LoanIssue.LiNote as Note from LoanIssue ,Lender, Borrower where [LoanIssue].Lilecode=[Lender].LeCode and [LoanIssue].Librcode=[Borrower].BrCode  ORDER BY substring([LoanIssue].LiNo,2,5)"
        Datagrid2.Visible = True

        Dim cmdCustomers As SqlCommand

        '' cmdCustomers = New SqlCommand("Select Convert(Varchar(10),Tra_Date,103) as TraDate,convert(float,Val1,0) AS Val1,Dly_qty,AvgMk,TraEmp,TotOT,p1,p3,p2,convert(float,(Val1-(p1+p2+p3)),0) as pl ,convert(float,(Val1-(p1+p2+p3))/((avgmk*pl1)+(TraEmp*pl1)+TotOt),0) as pl1 from Freport where Sec_code='" & Mid(LstSec.SelectedValue, 1, 4) & "' and substring(CONVERT(VARCHAR(10),Tra_date,103),7,4)='" & Syr & "' And substring(CONVERT(VARCHAR(10),Tra_date,103),4,2)='" & Smt & "' Order by Convert(Varchar(10),Tra_Date,103)", CON)
        cmdCustomers = New SqlCommand(ss, CON)

        cmdCustomers.CommandType = CommandType.Text
        Datagrid2.DataSource = cmdCustomers.ExecuteReader()
        Datagrid2.DataBind()
        CON.Close()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindTheGrid1()
    End Sub





    Private Sub Datagrid2_ItemDataBound(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles Datagrid2.ItemDataBound
        If e.Item.ItemType = ListItemType.Header Then

            'If (Datagrid1.Attributes("SortExpression") <> String.Empty) Then

            '    Datagrid1.Attributes("SortExpression") = Global.sortExpression

            '    DisplaySortOrderImages(Datagrid1.Attributes("SortExpression"), e.Item)

            'End If

        ElseIf e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            'If IsNumeric(e.Item.Cells(12).Text) Then
            '    Total1 = Total1 + Val(e.Item.Cells(12).Text)
            'End If

            'If IsNumeric(e.Item.Cells(13).Text) Then
            '    Total2 = Total2 + Val(e.Item.Cells(13).Text)
            'End If
            'If IsNumeric(e.Item.Cells(14).Text) Then
            '    Total3 = Total3 + Val(e.Item.Cells(14).Text)
            'End If
            'If IsNumeric(e.Item.Cells(15).Text) Then
            '    Total4 = Total4 + Val(e.Item.Cells(15).Text)
            'End If
            'If IsNumeric(e.Item.Cells(16).Text) Then
            '    Total5 = Total5 + Val(e.Item.Cells(16).Text)
            'End If
            'If IsNumeric(e.Item.Cells(17).Text) Then
            '    Total6 = Total6 + Val(e.Item.Cells(17).Text)
            'End If
            'If IsNumeric(e.Item.Cells(18).Text) Then
            '    Total7 = Total7 + Val(e.Item.Cells(18).Text)
            'End If
            'If IsNumeric(e.Item.Cells(19).Text) Then
            '    Total8 = Total8 + Val(e.Item.Cells(19).Text)
            'End If
            'If IsNumeric(e.Item.Cells(20).Text) Then
            '    Total9 = Total9 + Val(e.Item.Cells(20).Text)
            'End If
            'If IsNumeric(e.Item.Cells(21).Text) Then
            '    Total10 = Total10 + Val(e.Item.Cells(21).Text)
            'End If
            'If IsNumeric(e.Item.Cells(22).Text) Then
            '    Total11 = Total11 + Val(e.Item.Cells(22).Text)
            'End If

            'Total10 = 0
            'Total11 = 0
            ss = Trim(e.Item.Cells(1).Text)
            ss = Trim(e.Item.Cells(2).Text)
            ss = Trim(e.Item.Cells(3).Text)
            ss = Trim(e.Item.Cells(4).Text)
            ss = Trim(e.Item.Cells(5).Text)
            ss = Trim(e.Item.Cells(6).Text)

            ss = Trim(e.Item.Cells(7).Text)

            ss = Trim(e.Item.Cells(8).Text)
            ss = Trim(e.Item.Cells(9).Text)
            ss = Trim(e.Item.Cells(10).Text)
            ss = Trim(e.Item.Cells(11).Text)
            ss = Trim(e.Item.Cells(12).Text)

            ss = Trim(e.Item.Cells(13).Text)

            ss = Trim(e.Item.Cells(14).Text)
            ss = Trim(e.Item.Cells(15).Text)
            ss = Trim(e.Item.Cells(16).Text)
            ss = Trim(e.Item.Cells(17).Text)
            ss = Trim(e.Item.Cells(18).Text)
            ss = Trim(e.Item.Cells(19).Text)
            ss = Trim(e.Item.Cells(20).Text)
            ss = Trim(e.Item.Cells(21).Text)
            ss = Trim(e.Item.Cells(22).Text)
            ss = Trim(e.Item.Cells(23).Text)
            ss = Trim(e.Item.Cells(24).Text)
            ss = Trim(e.Item.Cells(25).Text)
            ss = Trim(e.Item.Cells(26).Text)
           



            If Trim(e.Item.Cells(22).Text) = "N" Then
                e.Item.BackColor = Color.RoyalBlue
                e.Item.ForeColor = Color.Yellow
            Else

                If Mid(Trim(e.Item.Cells(25).Text), 1, 1) = "R" Then
                    e.Item.BackColor = Color.Brown
                    e.Item.ForeColor = Color.White


                Else
                    e.Item.BackColor = Color.Green
                    e.Item.ForeColor = Color.Yellow
                End If

            End If


            e.Item.Cells(1).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            e.Item.Cells(1).Attributes.Add("onclick", "javascript:window.open('NewApp2New8.aspx?TYPE=" & "D" + Trim(e.Item.Cells(12).Text) & "')")

            e.Item.Cells(2).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            e.Item.Cells(2).Attributes.Add("onclick", "javascript:window.open('NewApp2New8.aspx?TYPE=" & "D" + Trim(e.Item.Cells(21).Text) & "')")

            'e.Item.Cells(3).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            'e.Item.Cells(3).Attributes.Add("onclick", "javascript:window.open('NewApp2New2.aspx?TYPE=" & Trim(e.Item.Cells(7).Text) & "')")

            'e.Item.Cells(4).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            'e.Item.Cells(4).Attributes.Add("onclick", "javascript:window.open('NewApp2New3.aspx?TYPE=" & Trim(e.Item.Cells(7).Text) & "')")

            'e.Item.Cells(5).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            'e.Item.Cells(5).Attributes.Add("onclick", "javascript:window.open('NewApp2New4.aspx?TYPE=" & Trim(e.Item.Cells(7).Text) & "')")

            'e.Item.Cells(6).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            'e.Item.Cells(6).Attributes.Add("onclick", "javascript:window.open('NewApp2New5.aspx?TYPE=" & Trim(e.Item.Cells(7).Text) & "')")

            ''e.Item.Cells(7).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            ''e.Item.Cells(7).Attributes.Add("onclick", "javascript:window.open('NewApp2New6.aspx?TYPE=" & Trim(e.Item.Cells(23).Text) & "')")

            ''e.Item.Cells(8).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            ''e.Item.Cells(8).Attributes.Add("onclick", "javascript:window.open('NewApp2New7.aspx?TYPE=" & Trim(e.Item.Cells(23).Text) & "')")

            ''e.Item.Cells(9).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            ''e.Item.Cells(9).Attributes.Add("onclick", "javascript:window.open('NewApp2New7.aspx?TYPE=" & Trim(e.Item.Cells(23).Text) & "')")

            ''e.Item.Cells(10).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            ''e.Item.Cells(10).Attributes.Add("onclick", "javascript:window.open('NewApp2New7.aspx?TYPE=" & Trim(e.Item.Cells(23).Text) & "')")

            ''e.Item.Cells(11).Attributes.Add("onmouseover", "this.style.cursor='hand'")
            '''  e.Item.Cells(11).Attributes.Add("onclick", "javascript:window.open('NewApp2New7.aspx?TYPE=" & Trim(e.Item.Cells(23).Text) & "')")
            ''e.Item.Cells(11).Attributes.Add("onclick", "javascript:window.open('NewApp2New9M.aspx?TYPE=" & Mid(Trim(e.Item.Cells(0).Text), 1, 7) & "')")


            'If IsNumeric(e.Item.Cells(22).Text) Then
            '    Total11 = Total11 + Val(e.Item.Cells(22).Text)
            'End If

            'For Each gridrow In Datagrid2.Items
            '    ss = e.Item.Cells(13).Text
            '    Total1 = Total1 + Val(e.Item.Cells(13).Text)
            '    ss = e.Item.Cells(14).Text
            '    Total2 = Total2 + Val(e.Item.Cells(14).Text)
            '    ss = e.Item.Cells(15).Text
            '    Total3 = Total3 + Val(e.Item.Cells(15).Text)
            '    ss = e.Item.Cells(16).Text
            '    Total4 = Total4 + Val(e.Item.Cells(16).Text)
            '    ss = e.Item.Cells(17).Text
            '    Total5 = Total5 + Val(e.Item.Cells(17).Text)
            '    ss = e.Item.Cells(18).Text
            '    Total6 = Total6 + Val(e.Item.Cells(18).Text)
            '    ss = e.Item.Cells(19).Text
            '    Total7 = Total7 + Val(e.Item.Cells(19).Text)
            '    ss = e.Item.Cells(20).Text
            '    Total8 = Total8 + Val(e.Item.Cells(20).Text)
            'Next

        ElseIf e.Item.ItemType = ListItemType.Footer Then
                '' e.Item.Cells(0).Text = TxtYear.Text & "/" & Val(Mid(LstMth.SelectedValue, 1, 2))

                e.Item.Cells(1).Text = Format(Total1, "########.00")
                e.Item.Cells(1).Attributes.Add("onmouseover", "this.style.cursor='hand'")
                ' e.Item.Cells(1).Attributes.Add("onclick", "javascript:window.open('NewApp2New1.aspx?TYPE=" & Total1 & "')")
                e.Item.Cells(1).Attributes.Add("onclick", "javascript:window.open('NewApp2New1M.aspx?TYPE=" & Mid(Trim(e.Item.Cells(0).Text), 6, 2) & "')")
                e.Item.Cells(2).Text = Format(Total2, "######")

                e.Item.Cells(2).Attributes.Add("onmouseover", "this.style.cursor='hand'")
                e.Item.Cells(2).Attributes.Add("onclick", "javascript:window.open('NewApp2New0M.aspx?TYPE=" & Mid(Trim(e.Item.Cells(0).Text), 6, 2) & "')")

                e.Item.Cells(3).Text = Format(Total3, "######.00")

                e.Item.Cells(3).Attributes.Add("onmouseover", "this.style.cursor='hand'")
                e.Item.Cells(3).Attributes.Add("onclick", "javascript:window.open('NewApp2New2M.aspx?TYPE=" & Mid(Trim(e.Item.Cells(0).Text), 6, 2) & "')")

                e.Item.Cells(4).Text = Format(Total4, "######.00")
                e.Item.Cells(4).Attributes.Add("onmouseover", "this.style.cursor='hand'")
                e.Item.Cells(4).Attributes.Add("onclick", "javascript:window.open('NewApp2New3M.aspx?TYPE=" & Mid(Trim(e.Item.Cells(0).Text), 6, 2) & "')")

                e.Item.Cells(5).Text = Format(Total5, "######.00")
                e.Item.Cells(5).Attributes.Add("onmouseover", "this.style.cursor='hand'")
                e.Item.Cells(5).Attributes.Add("onclick", "javascript:window.open('NewApp2New4M.aspx?TYPE=" & Mid(Trim(e.Item.Cells(0).Text), 6, 2) & "')")

                e.Item.Cells(6).Text = Format(Total6, "######")
                e.Item.Cells(6).Attributes.Add("onmouseover", "this.style.cursor='hand'")
                e.Item.Cells(6).Attributes.Add("onclick", "javascript:window.open('NewApp2New5M.aspx?TYPE=" & Mid(Trim(e.Item.Cells(0).Text), 6, 2) & "')")


                'e.Item.Cells(7).Text = Format(Total7, "######")
                'e.Item.Cells(7).Attributes.Add("onmouseover", "this.style.cursor='hand'")
                'e.Item.Cells(7).Attributes.Add("onclick", "javascript:window.open('NewApp2New6M.aspx?TYPE=" & Mid(Trim(e.Item.Cells(0).Text), 6, 2) & "')")



                'e.Item.Cells(8).Text = Format(Total8, "######")
                'e.Item.Cells(8).Attributes.Add("onmouseover", "this.style.cursor='hand'")
                'e.Item.Cells(8).Attributes.Add("onclick", "javascript:window.open('NewApp2New7M.aspx?TYPE=" & Mid(Trim(e.Item.Cells(0).Text), 6, 2) & "')")


                'e.Item.Cells(9).Text = Format(Total9, "######.00")

                'e.Item.Cells(11).Attributes.Add("onmouseover", "this.style.cursor='hand'")
                'e.Item.Cells(11).Attributes.Add("onclick", "javascript:window.open('NewApp2New9M.aspx?TYPE=" & Mid(Trim(e.Item.Cells(0).Text), 1, 10) & "')")


            End If


    End Sub

    Private Sub Datagrid2_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
        'If e.Item.ItemType = ListItemType.Footer Then
        '    Response.Redirect("frmResoV.aspx?epf=" & Global.Uname & "&dept=55")
        'End If
    End Sub

    Private Sub ImageButton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        Dim myExportFile As String
        'Dim myReport As New MonthlyReport

        'stryr = Trim(TxtYear.Text)
        'strmt = Trim(Mid(LstMth.SelectedValue, 1, 2))
        ' strsec = Trim(Mid(LstSec.SelectedValue, 1, 4))
        'strmt1 = Trim(Mid(LstMth.SelectedValue, 3, 15))

        'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
        'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

        myExportFile = Server.MapPath(".") & "/Data/MonthlyReport.PDF"
        myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
        myDiskFileDestinationOptions.DiskFileName = myExportFile
        ' myExportOptions = myReport.ExportOptions
        With myExportOptions
            .DestinationOptions = myDiskFileDestinationOptions
            .ExportDestinationType = .ExportDestinationType.DiskFile
            .ExportFormatType = .ExportFormatType.PortableDocFormat

        End With
        '  myReport.SetDatabaseLogon("sa", "tstc123")

        '  myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

        '  myReport.SetParameterValue("Sec", "" & strsec & "")
        '  myReport.SetParameterValue("yr", "" & stryr & "")
        '  myReport.SetParameterValue("MT", "" & strmt & "")
        '  myReport.SetParameterValue("mnam", "" & strmt1 & "")


        '  myReport.Export()
        '  myReport.Close()
        '
        Response.Redirect("Data/MonthlyReport.PDF")

    End Sub

    Private Sub LstLender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindTheGrid()
    End Sub


    Private Sub Datagrid2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datagrid2.SelectedIndexChanged

    End Sub

    Private Sub LstBorrower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstBorrower.SelectedIndexChanged

    End Sub
End Class
