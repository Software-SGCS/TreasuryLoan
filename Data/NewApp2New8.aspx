<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NewApp2New8.aspx.vb" Inherits="TreasuryLoan.NewApp2New8" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>NewApp1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 102; LEFT: 296px; POSITION: absolute; TOP: 656px" runat="server"
				Width="80px" Height="24px" Visible="False">Invoice No</asp:label>
			<asp:ImageButton id="ImageButton1" style="Z-INDEX: 113; LEFT: 832px; POSITION: absolute; TOP: 504px"
				runat="server" Height="32px" Width="78px" ImageUrl="iCO\print.jpg"></asp:ImageButton>
			<asp:Panel id="Panel2" style="Z-INDEX: 112; LEFT: 0px; POSITION: absolute; TOP: 72px" runat="server"
				Height="590px" Width="88px" BackImageUrl="Menu/EmpMaster4.jpg ">Panel</asp:Panel><asp:button id="Button4" style="Z-INDEX: 107; LEFT: 640px; POSITION: absolute; TOP: 656px" runat="server"
				Width="144px" Height="24px" Visible="False" Text="Tax Invoice-File Copy"></asp:button><asp:button id="Button3" style="Z-INDEX: 106; LEFT: 168px; POSITION: absolute; TOP: 664px" runat="server"
				Width="116px" Height="24px" Text="Not Approve" ForeColor="Black" BackColor="Desktop" Visible="False"></asp:button><asp:button id="Button2" style="Z-INDEX: 105; LEFT: 816px; POSITION: absolute; TOP: 656px" runat="server"
				Width="96px" Height="24px" Visible="False" Text="Print"></asp:button><asp:button id="Button1" style="Z-INDEX: 104; LEFT: 8px; POSITION: absolute; TOP: 664px" runat="server"
				Width="116px" Height="24px" Text="Approve" ForeColor="Black" BackColor="Desktop" Visible="False"></asp:button><asp:dropdownlist id="LstId" style="Z-INDEX: 101; LEFT: 456px; POSITION: absolute; TOP: 752px" runat="server"
				Width="64px" Height="10px" Visible="False"></asp:dropdownlist>
			<DIV id="Layer1" style="Z-INDEX: 103; LEFT: 88px; OVERFLOW: scroll; WIDTH: 877px; POSITION: absolute; TOP: 72px; HEIGHT: 594px"><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer2" style="Z-INDEX: 110; LEFT: -264px; POSITION: absolute; TOP: 0px"
					runat="server" Width="350px" Height="50px" Visible="False" SeparatePages="False" DisplayToolbar="False"></CR:CRYSTALREPORTVIEWER><asp:textbox id="TxtInvNo" runat="server" Width="104px" Height="26px" Visible="False"></asp:textbox></DIV>
			<asp:panel id="Panel1" style="Z-INDEX: 108; LEFT: 970px; POSITION: absolute; TOP: -8px" runat="server"
				Width="94px" Height="674px" BackColor="Desktop"></asp:panel>
			<asp:panel id="Panel7" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 48px" runat="server"
				Height="24px" Width="970px" BackColor="Navy"></asp:panel>
			<DIV style="Z-INDEX: 110; LEFT: 0px; WIDTH: 970px; POSITION: absolute; TOP: 24px; HEIGHT: 24px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4">Debit 
							Invoice </FONT></FONT></FONT>
			</DIV>
			<asp:panel id="Panel6" style="Z-INDEX: 111; LEFT: 0px; POSITION: absolute; TOP: 8px" runat="server"
				Height="16px" Width="970px" BackColor="Navy">Panel</asp:panel></FORM>
	</body>
</HTML>
