Imports System.Data.SqlClient
Imports System.Data

Public Class PopView14
    Inherits System.Web.UI.Page
    Dim DSS As Report1 = New Report1
#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
   

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
        CrystalReportViewer1.Visible = True
        Dim aa As String

        'aa = Global.PCAT



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("cat1", "" & aa & "")


        CrystalReportViewer1.SeparatePages = False

        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = True
        CrystalReportViewer1.HasZoomFactorList = True
        CrystalReportViewer1.HasPageNavigationButtons = True
        CrystalReportViewer1.HasDrillUpButton = True

        CrystalReportViewer1.DataBind()
        CrystalReportViewer1.RefreshReport()
        DSS.Refresh()
    End Sub

End Class
