<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Entry4.aspx.vb" Inherits="TreasuryLoan.Entry4" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Entry1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="mistyrose" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 101; LEFT: 192px; POSITION: absolute; TOP: 80px" runat="server"
				Height="16px" Width="96px">Ref No</asp:label><asp:textbox id="Txtdes1" style="Z-INDEX: 147; LEFT: 296px; POSITION: absolute; TOP: 400px" runat="server"
				Height="64px" Width="424px" TextMode="MultiLine"></asp:textbox><asp:label id="Label18" style="Z-INDEX: 146; LEFT: 192px; POSITION: absolute; TOP: 408px" runat="server"
				Height="24px" Width="88px">Description</asp:label><asp:calendar id="Calendar2" style="Z-INDEX: 145; LEFT: 736px; POSITION: absolute; TOP: 376px"
				runat="server" Height="88px" Width="160px" BackColor="White" BorderColor="#3366CC" ForeColor="#003399" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"
				DayNameFormat="FirstLetter" CellPadding="1">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:textbox id="TxtRecDate" style="Z-INDEX: 144; LEFT: 640px; POSITION: absolute; TOP: 376px"
				runat="server" Width="72px"></asp:textbox><asp:imagebutton id="Imagebutton1" style="Z-INDEX: 143; LEFT: 712px; POSITION: absolute; TOP: 376px"
				runat="server" Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:label id="Label17" style="Z-INDEX: 142; LEFT: 512px; POSITION: absolute; TOP: 376px" runat="server"
				Height="24px" Width="104px">Receieved Date</asp:label><asp:textbox id="TxtAppDate" style="Z-INDEX: 141; LEFT: 384px; POSITION: absolute; TOP: 376px"
				runat="server" Width="72px"></asp:textbox><asp:label id="Label16" style="Z-INDEX: 140; LEFT: 296px; POSITION: absolute; TOP: 376px" runat="server"
				Height="24px" Width="80px">Apply Date</asp:label><asp:label id="Label15" style="Z-INDEX: 139; LEFT: 192px; POSITION: absolute; TOP: 376px" runat="server"
				Height="24px" Width="96px" BackColor="Silver">License</asp:label><asp:textbox id="txtCncy" style="Z-INDEX: 138; LEFT: 504px; POSITION: absolute; TOP: 296px" runat="server"
				Width="88px" ReadOnly="True"></asp:textbox><asp:textbox id="txtInc" style="Z-INDEX: 137; LEFT: 296px; POSITION: absolute; TOP: 328px" runat="server"
				Width="88px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtPay" style="Z-INDEX: 136; LEFT: 296px; POSITION: absolute; TOP: 296px" runat="server"
				Width="88px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtSup" style="Z-INDEX: 135; LEFT: 296px; POSITION: absolute; TOP: 256px" runat="server"
				Height="24px" Width="424px" ReadOnly="True"></asp:textbox><asp:label id="Label14" style="Z-INDEX: 134; LEFT: 192px; POSITION: absolute; TOP: 256px" runat="server"
				Height="24px" Width="92px">Suplier</asp:label><asp:button id="BtnSave" style="Z-INDEX: 128; LEFT: 192px; POSITION: absolute; TOP: 480px" runat="server"
				Width="64px" Text="Save"></asp:button><asp:imagebutton id="btt1" style="Z-INDEX: 127; LEFT: 456px; POSITION: absolute; TOP: 376px" runat="server"
				Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar1" style="Z-INDEX: 126; LEFT: 480px; POSITION: absolute; TOP: 376px"
				runat="server" Height="88px" Width="160px" BackColor="White" BorderColor="#3366CC" ForeColor="#003399" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px" DayNameFormat="FirstLetter"
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
			</asp:calendar><asp:label id="Label12" style="Z-INDEX: 124; LEFT: 696px; POSITION: absolute; TOP: 96px" runat="server"
				Height="24px" Width="96px" Visible="False">Suplier code</asp:label><asp:label id="Label11" style="Z-INDEX: 122; LEFT: 192px; POSITION: absolute; TOP: 136px" runat="server"
				Height="24px" Width="96px">Recieved Date</asp:label><asp:label id="Label10" style="Z-INDEX: 118; LEFT: 600px; POSITION: absolute; TOP: 296px" runat="server"
				Height="24px" Width="64px">Value</asp:label><asp:label id="Label9" style="Z-INDEX: 117; LEFT: 400px; POSITION: absolute; TOP: 296px" runat="server"
				Height="24px" Width="96px">Currency</asp:label><asp:panel id="Panel2" style="Z-INDEX: 111; LEFT: 136px; POSITION: absolute; TOP: 536px" runat="server"
				Height="64px" Width="912px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster3.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 110; LEFT: 160px; POSITION: absolute; TOP: 0px" runat="server"
				Height="64px" Width="752px" BackColor="Desktop" BorderColor="Transparent" ForeColor="White" BackImageUrl="Menu/banner.jpg" Font-Bold="True" HorizontalAlign="Left" Enabled="False"><FONT style="BACKGROUND-COLOR: #000066"></FONT></asp:panel><asp:panel id="Panel6" style="Z-INDEX: 109; LEFT: 912px; POSITION: absolute; TOP: -120px" runat="server"
				Height="720px" Width="137px" BackColor="Desktop"></asp:panel><asp:label id="Label8" style="Z-INDEX: 108; LEFT: 192px; POSITION: absolute; TOP: 328px" runat="server"
				Height="24px" Width="96px">Inco Term</asp:label><asp:label id="Label7" style="Z-INDEX: 107; LEFT: 192px; POSITION: absolute; TOP: 296px" runat="server"
				Height="24px" Width="96px">Payment Term</asp:label><asp:label id="Label6" style="Z-INDEX: 106; LEFT: 192px; POSITION: absolute; TOP: 224px" runat="server"
				Height="24px" Width="92px">HS Code</asp:label><asp:label id="Label5" style="Z-INDEX: 105; LEFT: 192px; POSITION: absolute; TOP: 168px" runat="server"
				Height="24px" Width="96px">Description</asp:label><asp:label id="Label2" style="Z-INDEX: 102; LEFT: 192px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="96px">Indent No(s)</asp:label><asp:label id="Label3" style="Z-INDEX: 103; LEFT: 512px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="64px">Company</asp:label><asp:label id="Label4" style="Z-INDEX: 104; LEFT: 440px; POSITION: absolute; TOP: 136px" runat="server"
				Height="24px" Width="64px">Bank</asp:label><asp:textbox id="TxtRefno" style="Z-INDEX: 112; LEFT: 296px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="200px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtIndentNo" style="Z-INDEX: 113; LEFT: 296px; POSITION: absolute; TOP: 104px"
				runat="server" Height="24px" Width="392px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtComNam" style="Z-INDEX: 114; LEFT: 592px; POSITION: absolute; TOP: 72px"
				runat="server" Height="24px" Width="302px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtDes" style="Z-INDEX: 115; LEFT: 296px; POSITION: absolute; TOP: 160px" runat="server"
				Height="64px" Width="596px" TextMode="MultiLine" ReadOnly="True"></asp:textbox><asp:textbox id="TxtHScd" style="Z-INDEX: 116; LEFT: 296px; POSITION: absolute; TOP: 224px" runat="server"
				Height="24px" Width="268px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtVal" style="Z-INDEX: 119; LEFT: 672px; POSITION: absolute; TOP: 296px" runat="server"
				Width="96px" ReadOnly="True"></asp:textbox><asp:panel id="Panel3" style="Z-INDEX: 120; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Height="602px" Width="152px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster4.jpg"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 121; LEFT: 248px; POSITION: absolute; TOP: 32px" runat="server"
				Height="27px" Width="184px" Font-Names="Tahoma" Font-Size="Medium" Font-Bold="True">LICENSE</asp:panel>
			<asp:textbox id="TxtRecDt" style="Z-INDEX: 123; LEFT: 296px; POSITION: absolute; TOP: 136px"
				runat="server" Width="88px" ReadOnly="True"></asp:textbox><asp:dropdownlist id="LstSup" style="Z-INDEX: 125; LEFT: 696px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="88px" Visible="False"></asp:dropdownlist><asp:textbox id="LstFlg1" style="Z-INDEX: 129; LEFT: 848px; POSITION: absolute; TOP: 272px" runat="server"
				Width="48px" ReadOnly="True" Visible="False"></asp:textbox><asp:textbox id="LstFlg2" style="Z-INDEX: 130; LEFT: 848px; POSITION: absolute; TOP: 304px" runat="server"
				Height="24px" Width="48px" ReadOnly="True" Visible="False"></asp:textbox><asp:textbox id="LstFlg3" style="Z-INDEX: 131; LEFT: 824px; POSITION: absolute; TOP: 336px" runat="server"
				Height="24px" Width="48px" ReadOnly="True" Visible="False"></asp:textbox><asp:label id="labelStatus" style="Z-INDEX: 132; LEFT: 264px; POSITION: absolute; TOP: 488px"
				runat="server" Height="16px" Width="208px"></asp:label><asp:textbox id="TxtBnk" style="Z-INDEX: 133; LEFT: 504px; POSITION: absolute; TOP: 136px" runat="server"
				Width="296px" ReadOnly="True"></asp:textbox><asp:panel id="Panel7" style="Z-INDEX: 148; LEFT: 152px; POSITION: absolute; TOP: 352px" runat="server"
				Height="16px" Width="768px" BackColor="Desktop"></asp:panel><asp:panel id="Panel8" style="Z-INDEX: 149; LEFT: 152px; POSITION: absolute; TOP: 0px" runat="server"
				Height="536px" Width="16px" BackColor="Desktop"></asp:panel></form>
	</body>
</HTML>
