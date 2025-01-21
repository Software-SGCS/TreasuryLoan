<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Report1.aspx.vb" Inherits="TreasuryLoan.Report11" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Report1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label19" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 0px" runat="server"
				Width="96px" Height="16px">Indent No(s)</asp:label><asp:textbox id="TxtIn" style="Z-INDEX: 101; LEFT: 120px; POSITION: absolute; TOP: -8px" runat="server"
				Width="280px" ForeColor="#0000C0"></asp:textbox><asp:imagebutton id="ImageButton2" style="Z-INDEX: 102; LEFT: 408px; POSITION: absolute; TOP: -8px"
				runat="server" Width="80px" Height="24px" ImageUrl="iCO\serch.gif"></asp:imagebutton><asp:textbox id="TxtRefno" style="Z-INDEX: 104; LEFT: 456px; POSITION: absolute; TOP: 136px"
				runat="server" Width="160px" Visible="False"></asp:textbox><asp:textbox id="TxtIndentNo" style="Z-INDEX: 105; LEFT: 456px; POSITION: absolute; TOP: 168px"
				runat="server" Width="312px" Visible="False"></asp:textbox><cr:crystalreportviewer id="CrystalReportViewer1" style="Z-INDEX: 106; LEFT: 8px; POSITION: absolute; TOP: 24px"
				runat="server" Width="350px" Height="50px" Visible="False"></cr:crystalreportviewer></form>
	</body>
</HTML>
