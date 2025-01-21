Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail


Public Class Dispaly1
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel9 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtId As System.Web.UI.WebControls.TextBox
    Protected WithEvents Datagrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Datagrid3 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Datagrid4 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Datagrid5 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Datagrid6 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Datagrid7 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
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
    Dim StrEmpno, StrEmpCom, StrEmpNam, strEmpIdno, strEmpAdd, StrEmpDoA As String
    Dim TT, body, ss1 As String
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        Dim USER1 As String
        ' USER1 = Request.QueryString("UID")

        ' Label2.Text = USER1
        ' TxtId.Text = USER1
        BindTheGrid()
        BindTheGrid1()
        BindTheGrid2()
        BindTheGrid3()
        BindTheGrid4()
        BindTheGrid5()

    End Sub


    Public Sub BindTheGrid()
        'Try
        ' CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()




        ss = "Select Id,Emp_ChqNo,Emp_Typ,format(Emp_DecAmt,'#,###.00') as Emp_DecAmt,format(Emp_Amt,'#,###.00') as Emp_Amt, Format(Emp_PayDt,'dd/MM/yyyy') as Emp_Paydt from HltMaster1 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'"""

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Mas_Refno,convert(varchar(10),Mas_IndRcDt,103) as Mas_IndRcDt,Mas_IndNos from MasterDocs where Mas_Entry1='Yes'", CON)
        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        Datagrid1.DataSource = cmdCustomers.ExecuteReader()
        Datagrid1.DataBind()

        Datagrid1.Visible = True
        CON.Close()

    End Sub


    Public Sub BindTheGrid1()
        'Try
        ' CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()




        ss = "Select Id,Emp_ChqNo,Emp_Typ,format(Emp_DecAmt,'#,###.00') as Emp_DecAmt,format(Emp_Amt,'#,###.00') as Emp_Amt, Format(Emp_PayDt,'dd/MM/yyyy') as Emp_Paydt from HltMaster1 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'"""

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Mas_Refno,convert(varchar(10),Mas_IndRcDt,103) as Mas_IndRcDt,Mas_IndNos from MasterDocs where Mas_Entry3='*' and Mas_Entry1='OK' and Mas_flAg1='Yes'", CON)
        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        Datagrid3.DataSource = cmdCustomers.ExecuteReader()
        Datagrid3.DataBind()

        Datagrid3.Visible = True
        CON.Close()

    End Sub

    Public Sub BindTheGrid2()
        'Try
        ' CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()




        ss = "Select Id,Emp_ChqNo,Emp_Typ,format(Emp_DecAmt,'#,###.00') as Emp_DecAmt,format(Emp_Amt,'#,###.00') as Emp_Amt, Format(Emp_PayDt,'dd/MM/yyyy') as Emp_Paydt from HltMaster1 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'"""

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Mas_Refno,convert(varchar(10),Mas_IndRcDt,103) as Mas_IndRcDt,Mas_IndNos from MasterDocs where Mas_Entry4='*' and Mas_Entry1='OK' and Mas_flAg2='Yes'", CON)
        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        Datagrid4.DataSource = cmdCustomers.ExecuteReader()
        Datagrid4.DataBind()

        Datagrid4.Visible = True
        CON.Close()

    End Sub
    Public Sub BindTheGrid3()
        'Try
        ' CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()




        ss = "Select Id,Emp_ChqNo,Emp_Typ,format(Emp_DecAmt,'#,###.00') as Emp_DecAmt,format(Emp_Amt,'#,###.00') as Emp_Amt, Format(Emp_PayDt,'dd/MM/yyyy') as Emp_Paydt from HltMaster1 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'"""

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Mas_Refno,convert(varchar(10),Mas_IndRcDt,103) as Mas_IndRcDt,Mas_IndNos from MasterDocs where Mas_Entry5='*' and Mas_Entry1='OK' and Mas_flAg3='Yes'", CON)
        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        Datagrid5.DataSource = cmdCustomers.ExecuteReader()
        Datagrid5.DataBind()

        Datagrid5.Visible = True
        CON.Close()

    End Sub
    Public Sub BindTheGrid4()
        'Try
        ' CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()




        ss = "Select Id,Emp_ChqNo,Emp_Typ,format(Emp_DecAmt,'#,###.00') as Emp_DecAmt,format(Emp_Amt,'#,###.00') as Emp_Amt, Format(Emp_PayDt,'dd/MM/yyyy') as Emp_Paydt from HltMaster1 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'"""

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select MasterDocs.Id as id,MasterDocs.Mas_Refno as Mas_Refno,convert(varchar(10),MasterDocs.Mas_IndRcDt,103) as Mas_IndRcDt,MasterDocs.Mas_IndNos as Mas_IndNos,Masmsg.Mas_Msg1 as Mas_Msg from MasterDocs,MasMsg where MasterDocs.Mas_Refno=Masmsg.Mas_Refno and  MasMsg.Mas_Flag='No'", CON)
        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        Datagrid6.DataSource = cmdCustomers.ExecuteReader()
        Datagrid6.DataBind()

        Datagrid6.Visible = True
        CON.Close()

    End Sub

    Public Sub BindTheGrid5()
        'Try
        ' CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()




        ss = "Select Id,Emp_ChqNo,Emp_Typ,format(Emp_DecAmt,'#,###.00') as Emp_DecAmt,format(Emp_Amt,'#,###.00') as Emp_Amt, Format(Emp_PayDt,'dd/MM/yyyy') as Emp_Paydt from HltMaster1 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'"""

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Mas_Refno,convert(varchar(10),Mas_IndRcDt,103) as Mas_IndRcDt,Mas_IndNos,Mas_InTrm from MasterDocs where (Mas_Entry6='*' AND Mas_EntryTT='*' AND Mas_EntryBD='*') AND (Mas_InTrm<>'*' AND Mas_InTrm<>'DP') order by Mas_InTrm", CON)
        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        Datagrid7.DataSource = cmdCustomers.ExecuteReader()
        Datagrid7.DataBind()

        Datagrid7.Visible = True
        CON.Close()

    End Sub
End Class
