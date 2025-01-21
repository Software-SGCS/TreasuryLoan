Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.IO

Public Class Report11
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
    Dim oStream As New MemoryStream
    Protected WithEvents TxtRefno As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtIndentNo As System.Web.UI.WebControls.TextBox
    Protected CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

    Dim TT As String

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents ImageButton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents TxtIn As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label

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

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
        'Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        'Dim myExportFile As String
        'Dim myReport As New MonthlyReport

        ''stryr = Trim(TxtYear.Text)
        ''strmt = Trim(Mid(LstMth.SelectedValue, 1, 2))
        '' strsec = Trim(Mid(LstSec.SelectedValue, 1, 4))
        ''strmt1 = Trim(Mid(LstMth.SelectedValue, 3, 15))

        ''tradate = HttpContext.Current.Request.QueryString("Type").ToString()
        ''DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

        'myExportFile = Server.MapPath(".") & "/Data/MonthlyReport.PDF"
        'myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
        'myDiskFileDestinationOptions.DiskFileName = myExportFile
        'myExportOptions = myReport.ExportOptions
        'With myExportOptions
        '    .DestinationOptions = myDiskFileDestinationOptions
        '    .ExportDestinationType = .ExportDestinationType.DiskFile
        '    .ExportFormatType = .ExportFormatType.PortableDocFormat

        'End With
        'myReport.SetDatabaseLogon("sa", "tstc123")

        'myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

        'myReport.SetParameterValue("Sec", "" & strsec & "")
        'myReport.SetParameterValue("yr", "" & stryr & "")
        'myReport.SetParameterValue("MT", "" & strmt & "")
        'myReport.SetParameterValue("mnam", "" & strmt1 & "")


        'myReport.Export()
        'myReport.Close()

        'Response.Redirect("Data/MonthlyReport.PDF")
        Dim strReport As String = ""
        strReport = "PopView14.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=750,width=800,left=0,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)
        ' End If

    End Sub

    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        count1 = Len(Trim(TxtIn.Text))
        ss = Trim(TxtIn.Text)

        'ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where substring(Mas_IndNos,1," & count1 & ")='" & Trim(TxtIn.Text) & "' AND Mas_flag3='Yes' and Mas_Entry1='Ok'", CON)
        ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where substring(Mas_IndNos,1," & count1 & ")='" & Trim(TxtIn.Text) & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "MasterDocs")

        Count2 = DS.Tables("MasterDocs").Rows.Count

        If Count2 <> 0 Then
            For Each drt2 In DS.Tables("MasterDocs").Rows
                TxtRefno.Text = Trim(drt2("Mas_ReFno"))
                TxtIndentNo.Text = drt2("Mas_IndNos")
                ss = Trim(TxtRefno.Text)

            Next
        End If

        Dim DSS As Report2 = New Report2

        'BtnUpdate.Visible = False
        'Button1.Visible = False
        'Button2.Visible = False
        '' Button3.Visible = False
        'Button4.Visible = False
        'Button5.Visible = False
        'Button6.Visible = False
        'Label4.Visible = False
        'LstCat.Visible = False

        'LstMth.Visible = False
        'TxtYear.Visible = False
        'Panel5.Visible = False
        'Label1.Visible = False
        'Button7.Visible = False
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer1.Visible = True

        Dim vehno1 As String

        ' Ssec = Trim(Mid(LstCat.SelectedValue, 1, 4))


        '-----------------
        'Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
        'Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        'Dim myExportFile As String
        'Dim myReport As New Report2


        'myExportFile = Server.MapPath(".") & "/Data/REPORT2.PDF"
        'myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
        'myDiskFileDestinationOptions.DiskFileName = myExportFile
        'myExportOptions = myReport.ExportOptions
        'With myExportOptions
        '    .DestinationOptions = myDiskFileDestinationOptions
        '    .ExportDestinationType = .ExportDestinationType.DiskFile
        '    .ExportFormatType = .ExportFormatType.PortableDocFormat
        'End With
        'myReport.SetDatabaseLogon("sa", "tstc123")

        'myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

        'myReport.SetParameterValue("refno", "" & ss & "")


        'myReport.Export()
        'myReport.Close()
        '---------------



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("refno", "" & ss & "")

        ' TxtRefno.Text = ""

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
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()



    End Sub
End Class
