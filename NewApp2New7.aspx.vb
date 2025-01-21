Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Configuration

Public Class NewApp2New7
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1 As SqlDataReader
    Dim DS, ds1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim Dtr, Dtr1, dtr2 As DataRow
    Dim pay1 As Integer
    Dim pay2 As String
    Dim pay3 As String
    Dim pay4 As String
    Dim pay5 As String
    Dim pay6 As String
    Dim idno As String
    'Dim pos1 As String
    Public pos1 As String
    Dim Invno1, InvCom1, Invdt1, InvFlag11, InvPono1, InvItmNo1, InvQty1, InvVal1, InvPri1, Invvat1, Invdis1, Invflag31, invper1, invtt1 As String
    Dim Intstk As Integer
    Dim Typ, BODY, Ssec As String
    Dim AAA As String
    Dim InvVat As String
    Dim tradate As String
    Dim customerId As String

    Dim Count As Integer
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Textbox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents CrystalReportViewer2 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents TxtInvNo As System.Web.UI.WebControls.TextBox

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents LstId As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button

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
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=TreasuryDb; user id=sa;password=tstc123")

        CON.Open()

        ' If Not IsPostBack Then
        tradate = HttpContext.Current.Request.QueryString("Type").ToString()

        '  tradate = Mid(tradate, 4, 2) + "/" + Mid(tradate, 1, 2) + "/" + Mid(tradate, 7, 4)
        ' tradate = Format(CDate(tradate), "yyyy,MM,dd")
        'customerId = Val(InvNo11)
        ' InvNo11 = "T-00507"
        'TxtInvNo.Text = InvNo11
        '-------------------
        Dim DSS As CrdInvoice = New CrdInvoice

        'BtnUpdate.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        ' Button3.Visible = False
        Button4.Visible = False
        'Button5.Visible = False
        'Button6.Visible = False
        'Label4.Visible = False
        'LstSec.Visible = False
        ImageButton1.Visible = False
        ' LstMth.Visible = False
        ' TxtYear.Visible = False
        'Panel5.Visible = False
        ' Label1.Visible = False
        ' Button7.Visible = False
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True

        Dim vehno1 As String

        'Ssec = Global.PSec1




        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        ' DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Invno", "" & tradate & "")
        CrystalReportViewer2.SeparatePages = True
        CrystalReportViewer2.ReportSource = DSS
        CrystalReportViewer2.HasRefreshButton = True
        CrystalReportViewer2.HasZoomFactorList = True
        CrystalReportViewer2.HasPageNavigationButtons = True
        CrystalReportViewer2.HasDrillUpButton = True
        'CrystalReportViewer1.RefreshReport()
        CrystalReportViewer2.DataBind()





        ' End If




    End Sub


    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        Dim myExportFile As String
        Dim myReport As New CrdInvoice
        myExportFile = Server.MapPath(".") & "/Data/FReport7new.PDF"
        myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
        myDiskFileDestinationOptions.DiskFileName = myExportFile
        myExportOptions = myReport.ExportOptions
        With myExportOptions
            .DestinationOptions = myDiskFileDestinationOptions
            .ExportDestinationType = .ExportDestinationType.DiskFile
            .ExportFormatType = .ExportFormatType.PortableDocFormat

        End With
        myReport.SetDatabaseLogon("sa", "tstc123")

        myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

        myReport.SetParameterValue("Sec", "" & Ssec & "")
        myReport.SetParameterValue("Dt", "" & tradate & "")

        myReport.Export()
        myReport.Close()

        Response.Redirect("Data/FReport7new.PDF")
    End Sub
End Class

