<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Entry10.aspx.vb" Inherits="TreasuryLoan.Entry10" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Entry1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#dcefe3" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 100; LEFT: 32px; POSITION: absolute; TOP: 72px" runat="server"
				Width="96px" Height="16px">Ref No</asp:label><asp:textbox id="TxtAdv" style="Z-INDEX: 145; LEFT: 136px; POSITION: absolute; TOP: 400px" runat="server"
				Width="424px" Height="64px" TextMode="MultiLine"></asp:textbox><asp:label id="Label18" style="Z-INDEX: 144; LEFT: 32px; POSITION: absolute; TOP: 408px" runat="server"
				Width="88px" Height="24px">Advice Bank</asp:label><asp:calendar id="Calendar2" style="Z-INDEX: 143; LEFT: 576px; POSITION: absolute; TOP: 344px"
				runat="server" Width="160px" Height="88px" CellPadding="1" DayNameFormat="FirstLetter" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" ForeColor="#003399"
				BorderColor="#3366CC" BackColor="White">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:textbox id="TxtRecDate" style="Z-INDEX: 142; LEFT: 480px; POSITION: absolute; TOP: 344px"
				runat="server" Width="72px"></asp:textbox><asp:imagebutton id="Imagebutton1" style="Z-INDEX: 141; LEFT: 552px; POSITION: absolute; TOP: 344px"
				runat="server" Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:label id="Label17" style="Z-INDEX: 139; LEFT: 352px; POSITION: absolute; TOP: 344px" runat="server"
				Width="104px" Height="24px">Open Date</asp:label><asp:textbox id="TxtAppDate" style="Z-INDEX: 138; LEFT: 224px; POSITION: absolute; TOP: 344px"
				runat="server" Width="72px"></asp:textbox><asp:label id="Label16" style="Z-INDEX: 137; LEFT: 136px; POSITION: absolute; TOP: 344px" runat="server"
				Width="80px" Height="24px">Apply Date</asp:label><asp:label id="Label15" style="Z-INDEX: 136; LEFT: 32px; POSITION: absolute; TOP: 344px" runat="server"
				Width="96px" Height="24px" BackColor="Silver">L/c</asp:label><asp:textbox id="txtCncy" style="Z-INDEX: 135; LEFT: 440px; POSITION: absolute; TOP: 296px" runat="server"
				Width="48px" ReadOnly="True"></asp:textbox><asp:textbox id="txtInc" style="Z-INDEX: 134; LEFT: 304px; POSITION: absolute; TOP: 296px" runat="server"
				Width="40px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtPay" style="Z-INDEX: 133; LEFT: 136px; POSITION: absolute; TOP: 296px" runat="server"
				Width="88px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtSup" style="Z-INDEX: 132; LEFT: 136px; POSITION: absolute; TOP: 256px" runat="server"
				Width="424px" Height="24px" ReadOnly="True"></asp:textbox><asp:label id="Label14" style="Z-INDEX: 131; LEFT: 32px; POSITION: absolute; TOP: 256px" runat="server"
				Width="92px" Height="24px">Suplier</asp:label><asp:button id="BtnSave" style="Z-INDEX: 125; LEFT: 32px; POSITION: absolute; TOP: 504px" runat="server"
				Width="64px" Text="Save"></asp:button><asp:imagebutton id="btt1" style="Z-INDEX: 124; LEFT: 296px; POSITION: absolute; TOP: 344px" runat="server"
				Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar1" style="Z-INDEX: 123; LEFT: 320px; POSITION: absolute; TOP: 344px"
				runat="server" Width="160px" Height="88px" CellPadding="1" DayNameFormat="FirstLetter" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" ForeColor="#003399" BorderColor="#3366CC"
				BackColor="White">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:label id="Label12" style="Z-INDEX: 121; LEFT: 536px; POSITION: absolute; TOP: 96px" runat="server"
				Width="96px" Height="24px" Visible="False">Suplier code</asp:label><asp:label id="Label11" style="Z-INDEX: 119; LEFT: 32px; POSITION: absolute; TOP: 136px" runat="server"
				Width="96px" Height="24px">Recieved Date</asp:label><asp:label id="Label10" style="Z-INDEX: 116; LEFT: 504px; POSITION: absolute; TOP: 296px" runat="server"
				Width="64px" Height="24px">Value</asp:label><asp:label id="Label9" style="Z-INDEX: 115; LEFT: 368px; POSITION: absolute; TOP: 296px" runat="server"
				Width="96px" Height="24px">Currency</asp:label><asp:panel id="Panel2" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 536px" runat="server"
				Width="904px" Height="64px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster3.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 108; LEFT: 16px; POSITION: absolute; TOP: -8px" runat="server"
				Width="736px" Height="64px" ForeColor="White" BorderColor="Transparent" BackColor="Desktop" BackImageUrl="Menu/banner.jpg" Enabled="False" HorizontalAlign="Left" Font-Bold="True"></asp:panel><asp:label id="Label8" style="Z-INDEX: 107; LEFT: 232px; POSITION: absolute; TOP: 296px" runat="server"
				Width="64px" Height="24px">Inco Term</asp:label><asp:label id="Label7" style="Z-INDEX: 106; LEFT: 32px; POSITION: absolute; TOP: 296px" runat="server"
				Width="96px" Height="24px">Payment Term</asp:label><asp:label id="Label6" style="Z-INDEX: 105; LEFT: 32px; POSITION: absolute; TOP: 224px" runat="server"
				Width="92px" Height="24px">HS Code</asp:label><asp:label id="Label5" style="Z-INDEX: 104; LEFT: 32px; POSITION: absolute; TOP: 168px" runat="server"
				Width="96px" Height="24px">Description</asp:label><asp:label id="Label2" style="Z-INDEX: 101; LEFT: 32px; POSITION: absolute; TOP: 104px" runat="server"
				Width="96px" Height="24px">Indent No(s)</asp:label><asp:label id="Label3" style="Z-INDEX: 102; LEFT: 408px; POSITION: absolute; TOP: 224px" runat="server"
				Width="14px" Height="24px">Company</asp:label><asp:label id="Label4" style="Z-INDEX: 103; LEFT: 232px; POSITION: absolute; TOP: 136px" runat="server"
				Width="64px" Height="24px">Bank</asp:label><asp:textbox id="TxtRefno" style="Z-INDEX: 110; LEFT: 136px; POSITION: absolute; TOP: 72px" runat="server"
				Width="193px" Height="24px" ReadOnly="True" Visible="False"></asp:textbox><asp:textbox id="TxtIndentNo" style="Z-INDEX: 111; LEFT: 136px; POSITION: absolute; TOP: 104px"
				runat="server" Width="392px" Height="24px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtComNam" style="Z-INDEX: 112; LEFT: 488px; POSITION: absolute; TOP: 224px"
				runat="server" Width="246px" Height="24px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtDes" style="Z-INDEX: 113; LEFT: 136px; POSITION: absolute; TOP: 160px" runat="server"
				Width="596px" Height="64px" TextMode="MultiLine" ReadOnly="True"></asp:textbox><asp:textbox id="TxtHScd" style="Z-INDEX: 114; LEFT: 136px; POSITION: absolute; TOP: 224px" runat="server"
				Width="268px" Height="24px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtVal" style="Z-INDEX: 117; LEFT: 568px; POSITION: absolute; TOP: 296px" runat="server"
				Width="96px" ReadOnly="True"></asp:textbox><asp:panel id="Panel5" style="Z-INDEX: 118; LEFT: 104px; POSITION: absolute; TOP: 32px" runat="server"
				Width="184px" Height="27px" Font-Size="Medium" Font-Names="Tahoma" Font-Bold="True">Lc</asp:panel>
			<asp:textbox id="TxtRecDt" style="Z-INDEX: 120; LEFT: 136px; POSITION: absolute; TOP: 136px"
				runat="server" Width="88px" ReadOnly="True"></asp:textbox><asp:dropdownlist id="LstSup" style="Z-INDEX: 122; LEFT: 536px; POSITION: absolute; TOP: 104px" runat="server"
				Width="88px" Height="24px" Visible="False"></asp:dropdownlist><asp:textbox id="LstFlg1" style="Z-INDEX: 126; LEFT: 688px; POSITION: absolute; TOP: 272px" runat="server"
				Width="48px" ReadOnly="True" Visible="False"></asp:textbox><asp:textbox id="LstFlg2" style="Z-INDEX: 127; LEFT: 688px; POSITION: absolute; TOP: 304px" runat="server"
				Width="48px" Height="24px" ReadOnly="True" Visible="False"></asp:textbox><asp:textbox id="LstFlg3" style="Z-INDEX: 128; LEFT: 616px; POSITION: absolute; TOP: 264px" runat="server"
				Width="48px" Height="24px" ReadOnly="True" Visible="False"></asp:textbox><asp:label id="labelStatus" style="Z-INDEX: 129; LEFT: 104px; POSITION: absolute; TOP: 504px"
				runat="server" Width="208px" Height="16px"></asp:label><asp:textbox id="TxtBnk" style="Z-INDEX: 130; LEFT: 312px; POSITION: absolute; TOP: 136px" runat="server"
				Width="304px" ReadOnly="True"></asp:textbox><asp:panel id="Panel7" style="Z-INDEX: 146; LEFT: 16px; POSITION: absolute; TOP: 320px" runat="server"
				Width="768px" Height="16px" BackColor="Desktop"></asp:panel><asp:panel id="Panel8" style="Z-INDEX: 147; LEFT: 0px; POSITION: absolute; TOP: -16px" runat="server"
				Width="16px" Height="555px" BackColor="Desktop">
				<asp:textbox id="TxtExpDt" style="Z-INDEX: 139; LEFT: 136px; POSITION: absolute; TOP: 488px"
					runat="server" Width="72px"></asp:textbox>
				<asp:imagebutton id="Imagebutton3" style="Z-INDEX: 140; LEFT: 208px; POSITION: absolute; TOP: 488px"
					runat="server" Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton>
			</asp:panel><asp:dropdownlist id="LsRefno" style="Z-INDEX: 148; LEFT: 136px; POSITION: absolute; TOP: 72px" runat="server"
				Width="194px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:panel id="Panel3" style="Z-INDEX: 149; LEFT: 752px; POSITION: absolute; TOP: -64px" runat="server"
				Width="152px" Height="602px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster4.jpg"></asp:panel><asp:textbox id="TxtIn" style="Z-INDEX: 150; LEFT: 456px; POSITION: absolute; TOP: 72px" runat="server"
				Width="160px" ForeColor="#0000C0"></asp:textbox><asp:label id="Label19" style="Z-INDEX: 151; LEFT: 344px; POSITION: absolute; TOP: 72px" runat="server"
				Width="96px" Height="16px">Indent No(s)</asp:label><asp:imagebutton id="ImageButton2" style="Z-INDEX: 152; LEFT: 624px; POSITION: absolute; TOP: 72px"
				runat="server" Width="80px" Height="24px" ImageUrl="iCO\serch.gif"></asp:imagebutton><asp:label id="Label20" style="Z-INDEX: 153; LEFT: 32px; POSITION: absolute; TOP: 472px" runat="server"
				Width="88px" Height="24px">Expiry Date</asp:label><asp:dropdownlist id="LstDraft" style="Z-INDEX: 154; LEFT: 344px; POSITION: absolute; TOP: 472px"
				runat="server" Width="88px" Height="24px"></asp:dropdownlist><asp:label id="Label21" style="Z-INDEX: 155; LEFT: 240px; POSITION: absolute; TOP: 472px" runat="server"
				Width="96px" Height="24px">Draft At</asp:label><asp:label id="Label22" style="Z-INDEX: 156; LEFT: 32px; POSITION: absolute; TOP: 376px" runat="server"
				Width="96px" Height="24px">L/c No</asp:label><asp:textbox id="TxtLcNo" style="Z-INDEX: 157; LEFT: 136px; POSITION: absolute; TOP: 368px" runat="server"
				Width="248px"></asp:textbox>
			<asp:calendar id="Calendar3" style="Z-INDEX: 158; LEFT: 232px; POSITION: absolute; TOP: 472px"
				runat="server" Width="160px" Height="88px" CellPadding="1" DayNameFormat="FirstLetter" BorderWidth="1px"
				Font-Size="8pt" Font-Names="Verdana" ForeColor="#003399" BorderColor="#3366CC" BackColor="White">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar></form>
	</body>
</HTML>
