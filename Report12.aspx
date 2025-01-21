<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Report12.aspx.vb" Inherits="TreasuryLoan.Report12" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
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
			<asp:label id="Label19" style="Z-INDEX: 102; LEFT: 48px; POSITION: absolute; TOP: 96px" runat="server"
				Height="16px" Width="168px">Indent No(s) -LC</asp:label>
			<asp:panel id="Panel1" style="Z-INDEX: 119; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Height="64px" Width="736px" ForeColor="White" BackImageUrl="Menu/banner.jpg" BackColor="Desktop"
				Font-Bold="True" HorizontalAlign="Left" Enabled="False" BorderColor="Transparent">
				<FONT style="BACKGROUND-COLOR: #000066"></FONT>
			</asp:panel>
			<asp:panel id="Panel3" style="Z-INDEX: 118; LEFT: 736px; POSITION: absolute; TOP: 0px" runat="server"
				Height="530px" Width="152px" BackImageUrl="Menu/EmpMaster4.jpg" BackColor="Desktop"></asp:panel><asp:dropdownlist id="LsNF" style="Z-INDEX: 117; LEFT: 232px; POSITION: absolute; TOP: 264px" runat="server"
				Height="24px" Width="336px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LsTT" style="Z-INDEX: 116; LEFT: 232px; POSITION: absolute; TOP: 232px" runat="server"
				Height="24px" Width="336px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LSDA" style="Z-INDEX: 115; LEFT: 232px; POSITION: absolute; TOP: 192px" runat="server"
				Height="24px" Width="336px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LsBD" style="Z-INDEX: 114; LEFT: 232px; POSITION: absolute; TOP: 160px" runat="server"
				Height="24px" Width="336px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="lSDP" style="Z-INDEX: 113; LEFT: 232px; POSITION: absolute; TOP: 128px" runat="server"
				Height="24px" Width="336px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label5" style="Z-INDEX: 111; LEFT: 48px; POSITION: absolute; TOP: 192px" runat="server"
				Height="16px" Width="168px">Indent No(s) -DA</asp:label><asp:label id="Label4" style="Z-INDEX: 110; LEFT: 48px; POSITION: absolute; TOP: 264px" runat="server"
				Height="16px" Width="168px">Indent No(s) -NF</asp:label><asp:label id="Label3" style="Z-INDEX: 109; LEFT: 48px; POSITION: absolute; TOP: 232px" runat="server"
				Height="16px" Width="168px">Indent No(s) -TT</asp:label><asp:label id="Label2" style="Z-INDEX: 107; LEFT: 48px; POSITION: absolute; TOP: 160px" runat="server"
				Height="16px" Width="168px">Indent No(s) -BD</asp:label><asp:label id="Label1" style="Z-INDEX: 106; LEFT: 48px; POSITION: absolute; TOP: 128px" runat="server"
				Height="16px" Width="168px">Indent No(s) -DP</asp:label><asp:textbox id="TxtIn" style="Z-INDEX: 100; LEFT: 584px; POSITION: absolute; TOP: 56px" runat="server"
				Width="280px" ForeColor="#0000C0" Visible="False"></asp:textbox><asp:imagebutton id="ImageButton2" style="Z-INDEX: 101; LEFT: 584px; POSITION: absolute; TOP: -8px"
				runat="server" Height="24px" Width="80px" ImageUrl="iCO\serch.gif" Visible="False"></asp:imagebutton><asp:textbox id="TxtRefno" style="Z-INDEX: 103; LEFT: 584px; POSITION: absolute; TOP: 80px" runat="server"
				Width="160px" Visible="False"></asp:textbox><asp:textbox id="TxtIndentNo" style="Z-INDEX: 104; LEFT: 592px; POSITION: absolute; TOP: 128px"
				runat="server" Width="168px" Visible="False"></asp:textbox><cr:crystalreportviewer id="CrystalReportViewer1" style="Z-INDEX: 105; LEFT: 48px; POSITION: absolute; TOP: 296px"
				runat="server" Height="50px" Width="350px" Visible="False"></cr:crystalreportviewer><asp:dropdownlist id="LsLC" style="Z-INDEX: 112; LEFT: 232px; POSITION: absolute; TOP: 96px" runat="server"
				Height="24px" Width="336px" AutoPostBack="True"></asp:dropdownlist>
			<asp:panel id="Panel8" style="Z-INDEX: 120; LEFT: 0px; POSITION: absolute; TOP: 64px" runat="server"
				Height="556px" Width="16px" BackColor="Desktop"></asp:panel>
			<asp:panel id="Panel2" style="Z-INDEX: 121; LEFT: 16px; POSITION: absolute; TOP: 472px" runat="server"
				Height="64px" Width="871px" BackImageUrl="Menu/EmpMaster3.jpg" BackColor="Desktop"></asp:panel></form>
	</body>
</HTML>
