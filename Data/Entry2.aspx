<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Entry2.aspx.vb" Inherits="TreasuryLoan.Entry2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Entry1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="#dcefe3">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 101; LEFT: 176px; POSITION: absolute; TOP: 80px" runat="server"
				Height="16px" Width="96px">Ref No</asp:label>
			<asp:panel id="Panel7" style="Z-INDEX: 109; LEFT: 888px; POSITION: absolute; TOP: -88px" runat="server"
				Width="176px" Height="650px" BackColor="Desktop"></asp:panel><asp:button id="BtnSave" style="Z-INDEX: 132; LEFT: 592px; POSITION: absolute; TOP: 464px" runat="server"
				Width="64px" Text="Save"></asp:button><asp:imagebutton id="btt1" style="Z-INDEX: 131; LEFT: 368px; POSITION: absolute; TOP: 160px" runat="server"
				Height="24px" Width="24px" Visible="False" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar1" style="Z-INDEX: 130; LEFT: 392px; POSITION: absolute; TOP: 160px"
				runat="server" Height="128px" Width="152px" Visible="False" BackColor="White" BorderColor="#3366CC" ForeColor="#003399" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px" DayNameFormat="FirstLetter"
				CellPadding="1">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:label id="Label12" style="Z-INDEX: 128; LEFT: 176px; POSITION: absolute; TOP: 192px" runat="server"
				Height="24px" Width="96px">Suplier code</asp:label><asp:label id="Label11" style="Z-INDEX: 126; LEFT: 176px; POSITION: absolute; TOP: 160px" runat="server"
				Height="24px" Width="96px">Recieved Date</asp:label><asp:label id="Label10" style="Z-INDEX: 122; LEFT: 384px; POSITION: absolute; TOP: 464px" runat="server"
				Height="24px" Width="64px">Value</asp:label><asp:label id="Label9" style="Z-INDEX: 120; LEFT: 176px; POSITION: absolute; TOP: 464px" runat="server"
				Height="24px" Width="96px">Currency</asp:label><asp:panel id="Panel2" style="Z-INDEX: 111; LEFT: 144px; POSITION: absolute; TOP: 520px" runat="server"
				Height="74px" Width="920px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster3.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 110; LEFT: 152px; POSITION: absolute; TOP: -8px" runat="server"
				Height="64px" Width="736px" BackColor="Desktop" BorderColor="Transparent" ForeColor="White" BackImageUrl="Menu/banner.jpg" Font-Bold="True" HorizontalAlign="Left" Enabled="False"><FONT style="BACKGROUND-COLOR: #000066"></FONT></asp:panel><asp:label id="Label8" style="Z-INDEX: 108; LEFT: 176px; POSITION: absolute; TOP: 392px" runat="server"
				Height="24px" Width="96px">Inco Term</asp:label><asp:label id="Label7" style="Z-INDEX: 107; LEFT: 176px; POSITION: absolute; TOP: 424px" runat="server"
				Height="24px" Width="96px">Payment Term</asp:label><asp:label id="Label6" style="Z-INDEX: 106; LEFT: 176px; POSITION: absolute; TOP: 352px" runat="server"
				Height="24px" Width="92px">HS Code</asp:label><asp:label id="Label5" style="Z-INDEX: 105; LEFT: 176px; POSITION: absolute; TOP: 264px" runat="server"
				Height="24px" Width="96px">Description</asp:label><asp:label id="Label2" style="Z-INDEX: 102; LEFT: 176px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="96px">Indent No(s)</asp:label><asp:label id="Label3" style="Z-INDEX: 103; LEFT: 176px; POSITION: absolute; TOP: 136px" runat="server"
				Height="24px" Width="96px">Company</asp:label><asp:label id="Label4" style="Z-INDEX: 104; LEFT: 176px; POSITION: absolute; TOP: 224px" runat="server"
				Height="24px" Width="96px">Bank</asp:label><asp:textbox id="TxtRefno" style="Z-INDEX: 112; LEFT: 280px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="200px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtIndentNo" style="Z-INDEX: 113; LEFT: 280px; POSITION: absolute; TOP: 104px"
				runat="server" Height="24px" Width="392px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtComNam" style="Z-INDEX: 114; LEFT: 280px; POSITION: absolute; TOP: 128px"
				runat="server" Height="24px" Width="392px" ReadOnly="True"></asp:textbox><asp:dropdownlist id="LstBnk" style="Z-INDEX: 115; LEFT: 280px; POSITION: absolute; TOP: 224px" runat="server"
				Height="24px" Width="260px"></asp:dropdownlist><asp:textbox id="TxtDes" style="Z-INDEX: 116; LEFT: 280px; POSITION: absolute; TOP: 256px" runat="server"
				Height="92px" Width="596px" TextMode="MultiLine"></asp:textbox><asp:textbox id="TxtHScd" style="Z-INDEX: 117; LEFT: 280px; POSITION: absolute; TOP: 352px" runat="server"
				Height="24px" Width="268px"></asp:textbox><asp:dropdownlist id="LstPay" style="Z-INDEX: 118; LEFT: 280px; POSITION: absolute; TOP: 424px" runat="server"
				Height="24px" Width="268px"></asp:dropdownlist><asp:dropdownlist id="LstInc" style="Z-INDEX: 119; LEFT: 280px; POSITION: absolute; TOP: 392px" runat="server"
				Height="24px" Width="268px"></asp:dropdownlist><asp:dropdownlist id="LstCncy" style="Z-INDEX: 121; LEFT: 280px; POSITION: absolute; TOP: 464px" runat="server"
				Height="24px" Width="88px"></asp:dropdownlist><asp:textbox id="TxtVal" style="Z-INDEX: 123; LEFT: 456px; POSITION: absolute; TOP: 464px" runat="server"
				Width="112px"></asp:textbox>
			<asp:panel id="Panel3" style="Z-INDEX: 124; LEFT: -24px; POSITION: absolute; TOP: -16px" runat="server"
				Width="168px" Height="612px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster4.jpg"></asp:panel>
			<asp:panel id="Panel5" style="Z-INDEX: 125; LEFT: 248px; POSITION: absolute; TOP: 24px" runat="server"
				Width="184px" Height="27px" Font-Size="Medium" Font-Names="Tahoma" Font-Bold="True">Indent Documents</asp:panel>
			<asp:textbox id="TxtRecDt" style="Z-INDEX: 127; LEFT: 280px; POSITION: absolute; TOP: 160px"
				runat="server" Width="88px" ReadOnly="True"></asp:textbox><asp:dropdownlist id="LstSup" style="Z-INDEX: 129; LEFT: 280px; POSITION: absolute; TOP: 192px" runat="server"
				Height="24px" Width="400px"></asp:dropdownlist><asp:label id="Label14" style="Z-INDEX: 133; LEFT: 560px; POSITION: absolute; TOP: 352px" runat="server"
				Height="24px" Width="168px"> Insurance Apply</asp:label><asp:label id="Label15" style="Z-INDEX: 134; LEFT: 560px; POSITION: absolute; TOP: 376px" runat="server"
				Height="24px" Width="168px">Licenses Apply</asp:label><asp:label id="Label16" style="Z-INDEX: 135; LEFT: 560px; POSITION: absolute; TOP: 400px" runat="server"
				Height="16px" Width="168px"> Approval</asp:label><asp:textbox id="LstFlg1" style="Z-INDEX: 136; LEFT: 736px; POSITION: absolute; TOP: 352px" runat="server"
				Width="48px" ReadOnly="True"></asp:textbox><asp:textbox id="LstFlg2" style="Z-INDEX: 137; LEFT: 736px; POSITION: absolute; TOP: 376px" runat="server"
				Height="24px" Width="48px" ReadOnly="True"></asp:textbox><asp:textbox id="LstFlg3" style="Z-INDEX: 138; LEFT: 736px; POSITION: absolute; TOP: 400px" runat="server"
				Height="24px" Width="48px" ReadOnly="True"></asp:textbox><asp:label id="labelStatus" style="Z-INDEX: 139; LEFT: 672px; POSITION: absolute; TOP: 472px"
				runat="server" Height="16px" Width="208px"></asp:label>
			<asp:panel id="Panel9" style="Z-INDEX: 140; LEFT: 144px; POSITION: absolute; TOP: -24px" runat="server"
				Width="16px" Height="544px" BackColor="Desktop"></asp:panel></form>
	</body>
</HTML>
